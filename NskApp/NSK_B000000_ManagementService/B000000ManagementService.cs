using NSK_B000000_ManagementService.Common;
using CoreLibrary.Core.Utility;
using System.Diagnostics;

namespace NSK_B000000_ManagementService
{
    /// <summary>
    /// �o�b�`���s�Ǘ��v���O����
    /// </summary>
    public class B000000ManagementService : BackgroundService
    {
        /// <summary>
        /// ���K�[
        /// </summary>
        private readonly ILogger<B000000ManagementService> _logger;

        /// <summary>
        /// �o�b�`�Ǘ��v���O�������Ăяo���v���Z�X
        /// </summary>
        private Process process = null;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="logger"></param>
        public B000000ManagementService(ILogger<B000000ManagementService> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// �T�[�r�X�J�n�C�x���g
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation(Constants.SERVICE_START_MESSAGE);

            return base.StartAsync(cancellationToken);
        }

        /// <summary>
        /// �T�[�r�X�I���C�x���g
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation(Constants.SERVICE_STOP_MESSAGE);

                if (process != null)
                {
                    // �v���Z�X�������I������
                    process.Kill();

                    // �v���Z�X��j������ 
                    process.Close();
                    process.Dispose();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Message}", ex.Message);
            }

            return base.StopAsync(cancellationToken);
        }

        /// <summary>
        /// �o�b�`�Ǘ��v���O�����̌Ăяo��
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                // �v���Z�X�N�����I�u�W�F�N�g���쐬����
                ProcessStartInfo start_info = new ProcessStartInfo();

                // �o�b�`�Ǘ��v���O�����̊i�[�� 
                var batchManagementProPath = ConfigUtil.Get(Constants.BATCH_MANAGEMENT_PRO_PATH_TAG_NAME);
                _logger.LogInformation(Constants.BATCH_MANAGEMENT_PRO_LOCATION_MSG + batchManagementProPath);

                // ���s����t�@�C��
                start_info.FileName = batchManagementProPath;

                // �R���\�[�����J���Ȃ�
                start_info.CreateNoWindow = true;

                // �v���Z�X���N������
                process = Process.Start(start_info);

                // �v���Z�X���I�������Ƃ��� Exited �C�x���g�𔭐������Ȃ�
                process.EnableRaisingEvents = false;

                // ���O�o�͂���
                _logger.LogInformation(Constants.BATCH_MANAGEMENT_PRO_START_MESSAGE);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Message}", ex.Message);
                Environment.Exit(1);
            }
        }
    }
}
