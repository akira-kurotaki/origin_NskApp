using NskWeb.Common.Extensions;
using NskWeb.Core.Config;
using NskWeb.Core.Cookie;
using NskWeb.Core.Filter;
using NskWeb.Core.Middleware;
using Community.Microsoft.Extensions.Caching.PostgreSql;
using CoreLibrary.Core.Consts;
using CoreLibrary.Core.Filters;
using CoreLibrary.Core.ModelBinder;
using CoreLibrary.Core.Service;
using CoreLibrary.Core.Session;
using CoreLibrary.Core.Utility;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.WebEncoders;
using NLog;
using NLog.Web;
using ReportService.Core;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;

// SJIS(Shift_JIS)���g�p�\�ɂ���
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

// ���K�[
var logger = LogManager.GetCurrentClassLogger();
logger.Info("--- Application Start ---");

var builder = WebApplication.CreateBuilder(args);

// ���O�o�͂�NLog�@�\�Ɏg���悤�ɐݒ肷��
builder.Logging.ClearProviders();
builder.Host.UseNLog();

// View���g����Controller�ǉ�
// AddRazorRuntimeCompilation Razor�icshtml�j�̃����^�C���R���p�C���@�\�L����
// AddSessionStateTempDataProvider TempData�̊i�[����Z�b�V�����ɂ���
if (ConfigUtil.Get(CoreConst.APP_ENV) == "debug")
{
    builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation()
    .AddSessionStateTempDataProvider()
    .AddJsonOptions(options =>
    {
        // ����̃L�������P�[�X�����ݒ�̑���ɁA�p�X�J���P�[�X�����ݒ���\��
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });
}
else
{
    builder.Services.AddControllersWithViews(options =>
    {
        // �S�ẴR���g���[���[��[Authorize]��t�^����
        options.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build()));
    })
    .AddRazorRuntimeCompilation()
    .AddSessionStateTempDataProvider()
    .AddJsonOptions(options =>
    {
        // ����̃L�������P�[�X�����ݒ�̑���ɁA�p�X�J���P�[�X�����ݒ���\��
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });
}

// �F�؃G���[���Ƀ��O�C��URL�Ƀ��_�C���N�g����
builder.Services.AddScoped<CustomCookieAuthenticationEvents>();

// �F�؃~�h���E�F�A�T�[�r�X��ǉ�
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(ConfigUtil.GetInt(CoreConst.AUTHENTICATION_COOKIE_TIMEOUT));
    options.Cookie.SameSite = SameSiteMode.Lax;
    options.Cookie.Path = "/";
    options.Cookie.Domain = ConfigUtil.Get("HttpCookies_Domain");
    options.Cookie.HttpOnly = true;

    if (ConfigUtil.GetBool("HttpCookies_Use_Secure"))
    {
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    }

    // ���F�؁i401 Unauthorized�j���̃��_�C���N�g��
    options.EventsType = typeof(CustomCookieAuthenticationEvents);
    // �����Ȃ��i403 Forbidden�j���̃��_�C���N�g��
    options.AccessDeniedPath = new PathString("/F900/D900004/Init");
});

// HttpContextAccessor���e�N���X��DI�\�Ƃ���
builder.Services.AddHttpContextAccessor();

//IsNewSession��֋@�\�̑Ή�
builder.Services.AddTransient<ISessionStore, CustomDistributedSessionStore>();

// �Z�b�V�����Ǘ�
switch (ConfigUtil.Get("SessionState"))
{
    case "redis":
        // �Z�b�V�����Ǘ���Redis���g�p����ꍇ
        builder.Services.AddStackExchangeRedisCache(options =>
        {
            // �ڑ�������
            options.Configuration = ConfigUtil.Get("SessionState_Redis_Configuration");
            options.InstanceName = ConfigUtil.Get("SessionState_Redis_InstanceName");
        });
        break;
    case "postgresql":
        // �Z�b�V�����Ǘ���PostgreSql���g�p����ꍇ(Community.Microsoft.Extensions.Caching.PostgreSql)
        builder.Services.AddDistributedPostgreSqlCache(setup =>
        {
            // DB�ڑ�������
            setup.ConnectionString = builder.Configuration["PgCache:ConnectionString"];
            // �X�L�[�}��
            setup.SchemaName = builder.Configuration["PgCache:SchemaName"];
            // �e�[�u����
            setup.TableName = builder.Configuration["PgCache:TableName"];
            // �i�ȗ��j�����؂�A�C�e���̎����폜�itrue�F�폜���Ȃ��Afalse�F�폜����i�f�t�H���g�j�j
            setup.DisableRemoveExpired = bool.Parse(builder.Configuration["PgCache:DisableRemoveExpired"]);
            // �i�ȗ��j�K�v�ɉ����ăA�v���N�����ƂɃe�[�u���ƃf�[�^�x�[�X�֐����쐬�itrue�F�쐬����i�f�t�H���g�j�Afalse�F�쐬���Ȃ��j
            setup.CreateInfrastructure = bool.Parse(builder.Configuration["PgCache:CreateInfrastructure"]);
            // �i�ȗ��j�����؂�A�C�e���̎����폜�Ԋu�B�f�t�H���g��30���B�ŏ����e���Ԃ́A5���B
            setup.ExpiredItemsDeletionInterval = TimeSpan.FromMinutes(int.Parse(builder.Configuration["PgCache:ExpiredItemsDeletionInterval"]));
            // �i�ȗ��j�ǂݎ���p�f�[�^�x�[�X�A�܂��́A���[�U�[��write�������Ȃ��ꍇ��false��ݒ�B�f�t�H���g�Ftrue
            setup.UpdateOnGetCacheItem = bool.Parse(builder.Configuration["PgCache:UpdateOnGetCacheItem"]);
        });
        break;
    case "memory":
    default:
        // �Z�b�V�����Ǘ��ŃI�����������g�p����ꍇ
        builder.Services.AddDistributedMemoryCache();
        break;
}

// �Z�b�V�����Ǘ��ݒ�
builder.Services.AddSession(options =>
{
    // �Z�b�V�����^�C���A�E�g
    options.IdleTimeout = TimeSpan.FromMinutes(ConfigUtil.GetInt(CoreConst.SESSION_STATE_TIMEOUT));
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.Name = ConfigUtil.Get("HttpCookies_Session_Id");

    if (!string.IsNullOrEmpty(ConfigUtil.Get("PathBase")))
    {
        options.Cookie.Path = ConfigUtil.Get("PathBase");
    }

    if (!string.IsNullOrEmpty(ConfigUtil.Get("HttpCookies_Domain")))
    {
        options.Cookie.Domain = ConfigUtil.Get("HttpCookies_Domain");
    }
});

// �N�b�L�[�F�؃~�h���E�F�A�̐ݒ�
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    if (ConfigUtil.GetBool("HttpCookies_Use_Secure"))
    {
        options.Secure = CookieSecurePolicy.Always; // secure
    }
    options.HttpOnly = HttpOnlyPolicy.Always;   // httponly
});

// MVC�@�\
builder.Services.AddMvc(options =>
{
    // ��O�t�B���^�[
    options.Filters.Add<CoreExceptionFilter>();

    // ���O�C�����[�U���Z�b�V�����ɐݒ�
    options.Filters.Add<LoginUserSettingNskWebAttribute>();

    // ���M���O
    options.Filters.Add<LoggingFilter>();

    // ���N�G�X�g�̗L�����`�F�b�N
    options.Filters.Add<ValidRequestNskWebAttribute>();

    /// �V�X�e�����b�N�`�F�b�N
    options.Filters.Add<ValidSystemLockNskWebAttribute>();

    // �J�X�^�����f���o�C���h
    options.ModelBinderProviders.Insert(0, new DateTimeModelBinderProvider());

    // �֎~�������f���o�C���h
    options.ModelBinderProviders.Insert(0, new ProhibitWordModelBinderProvider());
});

// �L���b�V���@�\�̒�`��ǉ�
CacheConfig.RegisterMasterTable();

// �Ď��@�\�̒�`��ǉ�
if (ConfigUtil.GetBool(CoreConst.SYS_DATE_TIME_FLAG))
{
    // �V�X�e�����ԃt�@�C���Ď��@�\
    builder.Services.AddHostedService<SysDateTimeFileMonitorService>();
}

// �K�{�G���[���b�Z�[�W���J�X�^�}�C�Y���邽�߂̃A�_�v�^�[�N���X
builder.Services.AddSingleton<IValidationAttributeAdapterProvider, CustomValidationAttributeAdapterProvider>();

// Web�A�v���N���E�I�����̃C�x���g����
builder.Services.AddHostedService<LifetimeEventsHostedService>();

// �f�[�^�ی�̍\��
if (ConfigUtil.GetBool("DataProtection_Use_Certificate"))
{
    builder.Services.AddDataProtection()    // �f�[�^�ی��L���ɐݒ�
        .SetApplicationName(ConfigUtil.Get("DataProtection_SharedApplicationName"))       // ���ʃA�v������ݒ�
        .PersistKeysToFileSystem(new DirectoryInfo(ConfigUtil.Get("DataProtection_PersistKeysPath")))  // �L�[�̕ۑ��ꏊ�i���U���ł͋��L�t�H���_�j
        .ProtectKeysWithCertificate(new X509Certificate2(ConfigUtil.Get("DataProtection_CertificateFilePath"),
                                                            ConfigUtil.Get("DataProtection_CertificatePassword")));  // X.509�ؖ���
}
else
{
    builder.Services.AddDataProtection()    // �f�[�^�ی��L���ɐݒ�
        .SetApplicationName(ConfigUtil.Get("DataProtection_SharedApplicationName"))       // ���ʃA�v������ݒ�
        .PersistKeysToFileSystem(new DirectoryInfo(ConfigUtil.Get("DataProtection_PersistKeysPath")));  // �L�[�̕ۑ��ꏊ�i���U���ł͋��L�t�H���_�j
}

// �A�v����Cookie�ݒ�
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.SameSite = SameSiteMode.Lax;
    if (!string.IsNullOrEmpty(ConfigUtil.Get("PathBase")))
    {
        options.Cookie.Path = ConfigUtil.Get("PathBase");
    }

    if (!string.IsNullOrEmpty(ConfigUtil.Get("HttpCookies_Domain")))
    {
        options.Cookie.Domain = ConfigUtil.Get("HttpCookies_Domain");
    }

    options.Cookie.HttpOnly = true;

    if (ConfigUtil.GetBool("HttpCookies_Use_Secure"))
    {
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // secure
    }
});

// ASP.NET MVC�̓���Ɠ��l�Ƀ`�F�b�N�{�b�N�X�̉���hidden��\������B
builder.Services.Configure<MvcViewOptions>(options =>
{
    options.HtmlHelperOptions.CheckBoxHiddenInputRenderMode = CheckBoxHiddenInputRenderMode.Inline;
});

// �r���[�̃����_�����O���Ƀ}���`�o�C�g������HTML�G���R�[�h�����Ȃ�
builder.Services.Configure<WebEncoderOptions>(options =>
{
    options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
});

// ���A�����[�o�̓T�[�r�X�Ăяo���N���C�A���g�o�^
if (ConfigUtil.GetBool("ReportServiceCheckServerTrusted"))
{
    builder.Services.AddHttpClient<ReportServiceClient>();
}
else
{
    // �T�[�o�ؖ��������؂��Ȃ�
    builder.Services.AddHttpClient<ReportServiceClient>().ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
    {
        ServerCertificateCustomValidationCallback = delegate { return true; }
    });
}

// ���N�G�X�g�{�f�B��HTTP�t�H�[���Ƃ��ēǂݍ��ލۂ̃I�v�V����
//builder.Services.Configure<FormOptions>(options =>
//{
//    // �}���`�p�[�g�{���̃T�C�Y�i�f�t�H���g��128MB�i134,217,728�o�C�g�j�j
//    //options.MultipartBodyLengthLimit = long.MaxValue;
//    // ������t�H�[���G���g���̐��̐����i�f�t�H���g��1024�j
//    options.ValueCountLimit = 30000;
//});

// �f�t�H���g���b�Z�[�W����{��ɕϊ����鏈��
builder.Services.ConfigureModelBindingMessages();

var app = builder.Build();

// ���N�G�X�g�̓����E�o���̏���
app.UseCustomMiddlewareRequest();

// �x�[�X�p�X�ݒ�
if (!string.IsNullOrEmpty(ConfigUtil.Get("PathBase")))
{
    app.UsePathBase(ConfigUtil.Get("PathBase"));
}

//app.UseStatusCodePagesWithRedirects("~/F90/D9004");

// �ÓI�t�@�C�� �~�h���E�F�A
app.UseStaticFiles();

// Cookie�|���V�[ �~�h���E�F�A
app.UseCookiePolicy();

// ���[�e�B���O �~�h���E�F�A
app.UseRouting();

// �F�؃~�h���E�F�A
// UseAuthentication��UseAuthorization��MapRazorPages��MapDefaultControllerRoute�Ȃǂ�Map���\�b�h�̑O�ɌĂяo��
app.UseAuthentication();
// ���F�~�h���E�F�A
app.UseAuthorization();

// �Z�b�V�����L����
// UseSession�́AUseRouting�̌�A���AMapRazorPages��MapDefaultControllerRoute�̑O�ɌĂяo��
app.UseSession();

// �F�ؗv���̔�����
app.UseCustomMiddlewareAuthenticateRequest();

// �G���h�|�C���g ���[�e�B���O �~�h���E�F�A
app.UseEndpoints(endpoints =>
{
    // Area���g�����ݒ�
    _ = endpoints.MapControllerRoute(
        name: "Default",
        pattern: "{area:exists}/{controller}/{action}/{id?}",
        defaults: new { area = "F000", controller = "D000000", action = "Init" },
        dataTokens: new { area = "F000" }
    );
});

app.Run();
