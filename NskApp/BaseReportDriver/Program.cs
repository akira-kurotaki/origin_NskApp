using BaseReportDriver.Common.Extensions;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using ReportService.Core;
using System.Text;

// SJIS(Shift_JIS)���g�p�\�ɂ���
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

builder.Services.AddSingleton<IValidationAttributeAdapterProvider, CustomValidationAttributeAdapterProvider>();
builder.Services.AddExceptionHandler<CustomExceptionHandler>();

// ���A�����[�o�̓T�[�r�X�Ăяo���N���C�A���g
builder.Services.AddHttpClient<ReportServiceClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
