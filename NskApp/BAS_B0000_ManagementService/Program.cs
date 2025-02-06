using BAS_B0000_ManagementService;

var builder = Host.CreateApplicationBuilder(args);

// �A�v����Windows�T�[�r�X�Ƃ��ē��삳����
builder.Services.AddWindowsService(options =>
{
    // �T�[�r�X��
    options.ServiceName = "BAS_Batch_ManagementService";
});

// �T�[�r�X
builder.Services.AddHostedService<B0000ManagementService>();

// Windows EventLog�ݒ�
#pragma warning disable CA1416 // �v���b�g�t�H�[���̌݊���������
builder.Logging.AddEventLog(eventLogSettings =>
{
    eventLogSettings.SourceName = "BAS_Batch_ManagementService";
});
#pragma warning restore CA1416 // �v���b�g�t�H�[���̌݊���������

var host = builder.Build();
host.Run();
