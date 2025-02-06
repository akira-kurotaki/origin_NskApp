using BaseApi.Core.Config;
using BaseApi.Filter;
using BaseApi.Middleware;
using CoreLibrary.Core.Consts;
using CoreLibrary.Core.Service;
using CoreLibrary.Core.Utility;
using NLog.Web;
using System.Text;

// SJIS(Shift_JIS)���g�p�\�ɂ���
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

var builder = WebApplication.CreateBuilder(args);

// ���O�o�͂�NLog�@�\�Ɏg���悤�ɐݒ肷��
builder.Logging.ClearProviders();
builder.Host.UseNLog();

builder.Services.AddControllers(options =>
    {
        // �V�X�e�����b�N���؃t�B���^�[
        options.Filters.Add<ValidateSystemLockFilter>();
    })
    .AddJsonOptions(options =>
    {
        // ����̃L�������P�[�X�����ݒ�̑���ɁA�p�X�J���P�[�X�����ݒ���\��
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    })
    .ConfigureApiBehaviorOptions(options =>
    {
        // �����I�� 400 �����𖳌��ɂ���
        options.SuppressModelStateInvalidFilter = true;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// �L���b�V���@�\�̒�`��ǉ�
CacheConfig.RegisterMasterTable();

// �Ď��@�\�̒�`��ǉ�
if (ConfigUtil.GetBool(CoreConst.SYS_DATE_TIME_FLAG))
{
    // �V�X�e�����ԃt�@�C���Ď��@�\
    builder.Services.AddHostedService<SysDateTimeFileMonitorService>();
}

// Web�A�v���N���E�I�����̃C�x���g����
builder.Services.AddHostedService<LifetimeEventsHostedService>();

var app = builder.Build();

// �G���[�n���h�����O�~�h���E�G�A
app.UseErrorHandlerMiddleware();

// �x�[�X�p�X�ݒ�
if (!string.IsNullOrEmpty(ConfigUtil.Get("PathBase")))
{
    app.UsePathBase(ConfigUtil.Get("PathBase"));
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

// ���M���O�~�h���E�G�A
app.UseLoggingMiddleware();

app.MapControllers();

app.Run();
