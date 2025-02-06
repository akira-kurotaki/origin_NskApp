using CoreLibrary.Core.Attributes;
using CoreLibrary.Core.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace SynMain.Areas.F90.Controllers
{
    /// <summary>
    /// 閉じる
    /// </summary>
    /// <remarks>
    /// 作成日：2020/02/10
    /// 作成者：Nakamura Koichi
    /// </remarks>
    [ExcludeAuthCheck]
    [AllowAnonymous]
    [ExcludeSystemLockCheck]
    [Area("F90")]
    public class D9006Controller : CoreController
    {
        public D9006Controller(ICompositeViewEngine viewEngine) : base(viewEngine)
        {
        }

        // GET: F90/D9006/Init
        public ActionResult Init()
        {
            return View("D9006");
        }
    }
}