using Microsoft.AspNetCore.Mvc;
using ModelLibrary.Context;
using RealtimeReportDriver.Models;
using ReportService.Core;
using System.Diagnostics;

namespace RealtimeRBaseReportDrivereportDriver.Controllers
{
    public class HomeController : Controller
    {
        private readonly ReportServiceClient _serviceClient;

        private JigyoCommonContext db = new JigyoCommonContext();

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="serviceClient">���A�����[�o�̓T�[�r�X�Ăяo���N���C�A���g</param>
        public HomeController(ReportServiceClient serviceClient)
        {
            _serviceClient = serviceClient;
        }

        public IActionResult Index()
        {
            var indexModel = new IndexModel();
            indexModel.ReportControlIdOptions = GetReportControlIdOptions();

            var capacity = 10;
            indexModel.ShishoList = new List<string>(capacity);
            for (int i = 0; i < capacity; i++) { indexModel.ShishoList.Add(null); }

            return View(indexModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// ���A���^�C�����[�쐬
        /// </summary>
        /// <param name="reportControlId">���[����ID</param>
        /// <param name="userId">���[�UID</param>
        /// <param name="joukenId">����ID</param>
        /// <returns></returns>
        public async Task<ActionResult> CreatRealtimeReportAsync([Bind("ReportControlId, UserId, JoukenId, TodofukenCd, KumiaitoCd, ShishoCd, ShishoList")] IndexModel model)
        {
            // ����ID�͐��̐����ȊO�̏ꍇ�A�G���[�Ƃ���
            if (model.JoukenId <= 0)
            {
                throw new ApplicationException("����ID�͐��̐�������͂��Ă��������I");
            }

            var shishoList = new List<string>();
            if (model.ShishoList != null)
            {
                shishoList = model.ShishoList.Where(s => s != null).ToList();
            }

            // ���A�����[�o�̓T�[�r�X�̒��[�o�͏������Ăяo��
            var result = await _serviceClient.CreateReport(model.ReportControlId, model.UserId, (int)model.JoukenId, model.TodofukenCd, model.KumiaitoCd, model.ShishoCd, shishoList);

            // �G���[�̏ꍇ
            if (result.Result != 0)
            {
                throw new ApplicationException(result.ErrorMessage);
            }

            var fileName = db.MReportKanris.Where(t => t.ReportControlId == model.ReportControlId).FirstOrDefault().FileNm;
            var cd = new System.Net.Mime.ContentDisposition
            {
                // ERR_RESPONSE_HEADERS_MULTIPLE_CONTENT_DISPOSITION��Ή����邽�߁Acd.FileName�̐ݒ�s�v
                Inline = true,
            };

            Response.Headers.Append("Content-Disposition", cd.ToString());
            return File(result.ReportData, "application/pdf", cd.FileName);
        }

        /// <summary>
        /// ���[����ID�̑I�������擾����
        /// </summary>
        /// <returns></returns>
        private IEnumerable<ReportControlIdOptionModel> GetReportControlIdOptions()
        {
            // ���[�����Ǘ��}�X�^���璠�[��������擾
            var reportControlIdOptions =
                db.MReportKanris.OrderBy(p => p.ReportControlId).Select(p => new ReportControlIdOptionModel()
                {
                    ControlId = p.ReportControlId,
                    ControlName = p.ReportControlNm
                }).ToList();

            return reportControlIdOptions;
        }
    }
}
