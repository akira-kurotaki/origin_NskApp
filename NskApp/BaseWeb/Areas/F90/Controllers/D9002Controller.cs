using CoreLibrary.Core.Attributes;
using CoreLibrary.Core.Base;
using CoreLibrary.Core.Consts;
using CoreLibrary.Core.Exceptions;
using CoreLibrary.Core.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Npgsql;
using SynMain.Areas.F90.Models.D9002;
using SynMain.Areas.F90.Models.D9003;
using System.Dynamic;

namespace SynMain.Areas.F90.Controllers
{
    /// <summary>
    /// 業務エラー/システムエラー
    /// 
    /// このControllerでは、1Controller で2画面へ遷移する処理があるが、特例として許可する。
    /// </summary>
    /// <remarks>
    /// 作成日：2018/01/15
    /// 作成者：MATSUBAYASHI Atsushi
    /// </remarks>
    [ExcludeAuthCheck]
    [AllowAnonymous]
    [ExcludeSystemLockCheck]
    [Area("F90")]
    public class D9002Controller : CoreController
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="viewEngine"></param>
        public D9002Controller(ICompositeViewEngine viewEngine) : base(viewEngine)
        {
        }

        // GET: F90/D9002/Init
        public ActionResult Init()
        {
            Exception ex = TempData["_ERROR_EXCEPTION"] as Exception;
            dynamic document = null;

            if (ex == null)
            {
                // Exceptionのシリアライズはできないため、System.Dynamic.ExpandoObjectとして取得する。
                document = SessionUtil.Get<ExpandoObject>(CoreConst.SESS_COMMON_EXCEPTION, HttpContext);
                if (document != null)
                {
                    SessionUtil.Remove(CoreConst.SESS_COMMON_EXCEPTION, HttpContext);
                }
            }

            if (ex is AppException || document?.ClassName?.GetString().Contains("AppException") ?? false)
            {
                string Message = string.Empty;
                string HeaderPatternId = string.Empty;
                string ErrorCode = string.Empty;

                if (ex != null)
                {
                    AppException ae = ex as AppException;
                    Message = ae.Message;
                    HeaderPatternId = ae.HeaderPatternId;
                    ErrorCode = ae.ErrorCode;
                }
                else if (document != null)
                {
                    Message = document.Message?.GetString();
                    HeaderPatternId = document.HeaderPatternId?.GetString();
                    ErrorCode = document.ErrorCode?.GetString();
                }

                // 業務エラー
                D9002Model d9002Model = new D9002Model();

                if (TempData["_ERROR_TIME"] != null)
                {
                    d9002Model.ErrorTime = ((DateTime)TempData["_ERROR_TIME"]).ToString("yyyy/MM/dd HH:mm:ss");
                }
                else if (SessionUtil.Get<DateTime>("_D9000_SESS_COMMON_ERROR_TIME", HttpContext) != null)
                {
                    d9002Model.ErrorTime = SessionUtil.Get<DateTime>("_D9000_SESS_COMMON_ERROR_TIME", HttpContext).ToString("yyyy/MM/dd HH:mm:ss");
                    SessionUtil.Remove("_D9000_SESS_COMMON_ERROR_TIME", HttpContext);
                }
                else
                {
                    d9002Model.ErrorTime = DateUtil.GetSysDateTime().ToString("yyyy/MM/dd HH:mm:ss");
                }

                d9002Model.ErrorReason = Message;
                d9002Model.HeaderPatternId = HeaderPatternId;

                if ("MI00010".Equals(ErrorCode))
                {
                    d9002Model.HeaderPatternId = CoreConst.HEADER_PATTERN_ID_2;
                }

                return View("D9002", d9002Model);
            }

            // システムエラー
            D9003Model d9003Model = new D9003Model();
            if (TempData["_ERROR_TIME"] != null)
            {
                d9003Model.ErrorTime = ((DateTime)TempData["_ERROR_TIME"]).ToString("yyyy/MM/dd HH:mm:ss");
            }
            else
            {
                d9003Model.ErrorTime = DateUtil.GetSysDateTime().ToString("yyyy/MM/dd HH:mm:ss");
            }
            d9003Model.ErrorCode = "MF00001";

            d9003Model.HeaderPatternId = CoreConst.HEADER_PATTERN_ID_2;

            if (ex is NpgsqlException || (document?.ClassName?.GetString().Contains("Npgsql") ?? false))
            {
                // DBに繋がらない場合、メッセージを取得できないでの、メッセージを使用しないエラー画面を出力する
                d9003Model.NoDB = true;
            }

            return View("D9003", d9003Model);
        }
    }
}