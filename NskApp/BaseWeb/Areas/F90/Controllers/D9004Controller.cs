using CoreLibrary.Core.Attributes;
using CoreLibrary.Core.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace SynMain.Areas.F90.Controllers
{
    /// <summary>
    /// 無効URL指定エラー
    /// </summary>
    /// <remarks>
    /// 作成日：2018/01/15
    /// 作成者：MATSUBAYASHI Atsushi
    /// </remarks>
    [ExcludeAuthCheck]
    [AllowAnonymous]
    [ExcludeSystemLockCheck]
    [Area("F90")]
    public class D9004Controller : CoreController
    {
        public D9004Controller(ICompositeViewEngine viewEngine) : base(viewEngine)
        {
        }

        // GET: F90/D9004/Init
        public ActionResult Init()
        {
            return View("D9004");
        }
    }
}