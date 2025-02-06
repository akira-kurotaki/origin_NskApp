using NSK_B000000_ManagementService;

var builder = Host.CreateApplicationBuilder(args);

// �A�v����Windows�T�[�r�X�Ƃ��ē��삳����
builder.Services.AddWindowsService(options =>
{
    // �T�[�r�X��
    options.ServiceName = "NSK_Batch_ManagementService";
});

// �T�[�r�X
builder.Services.AddHostedService<B000000ManagementService>();

// Windows EventLog�ݒ�
#pragma warning disable CA1416 // �v���b�g�t�H�[���̌݊���������
builder.Logging.AddEventLog(eventLogSettings =>
{
    eventLogSettings.SourceName = "NSK_Batch_ManagementService";
});
#pragma warning restore CA1416 // �v���b�g�t�H�[���̌݊���������

var host = builder.Build();
host.Run();
