using BaseWeb.Areas.F99.Models.D9905;
using CoreLibrary.Core.Attributes;
using CoreLibrary.Core.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace BaseWeb.Areas.F99.Controllers
{
    [Authorize(Roles = "bas")]
    [Area("F99")]
    [ExcludeSystemLockCheck]
    public class D9905Controller : CoreController
    {
        public D9905Controller(ICompositeViewEngine viewEngine) : base(viewEngine)
        {
        }

        // GET: F00/CheckInput
        public ActionResult Init()
        {
            return View("D9905");
        }

        // POST: F00/CheckInput/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Numeric,NumberDec,NumberSign,NumberSignDec,HalfWidthAlphaNum,HalfWidthAlphaNumSymbol,Hiragana,FullWidthKatakana,HalfWidthKatakana,ExceptGaiji,WithinStringLength,WithinNumericLength,FullStringLength,FullNumericLength,NumberPositive,EmailAddress,DateGYMD")] D9905Model checkInputModel)
        {
            if (ModelState.IsValid)
            {

                ViewBag.Message = "CheckInput is OK!";
                return View("D9905", checkInputModel);
            }

            return View("D9905", checkInputModel);
        }
    }
}
