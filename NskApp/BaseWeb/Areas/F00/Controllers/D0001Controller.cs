using BaseAppModelLibrary.Context;
using BaseWeb.Areas.F00.Consts;
using BaseWeb.Areas.F00.Models.D0001;
using BaseWeb.Common.Consts;
using CoreLibrary.Core.Attributes;
using CoreLibrary.Core.Base;
using CoreLibrary.Core.Consts;
using CoreLibrary.Core.HelpMenu;
using CoreLibrary.Core.Menu;
using CoreLibrary.Core.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Text.RegularExpressions;

namespace BaseWeb.Areas.F00.Controllers
{
    /// <summary>
    /// ポータル
    /// </summary>
    /// <remarks>
    /// 作成日：2018/03/07
    /// 作成者：Gon Etuun
    /// </remarks>
    [SessionOutCheck]
    [ExcludeSystemLockCheck]
    [Area("F00")]
    public class D0001Controller : CoreController
    {
        #region メンバー定数
        /// <summary>
        /// 画面ID(D0001)
        /// </summary>
        private static readonly string SCREEN_ID_D0001 = "D0001";

        /// <summary>
        /// セッションキー(D0001)
        /// </summary>
        private static readonly string SESS_D0001 = "D0001_SCREEN";

        /// <summary>
        /// 180日(判断用)
        /// </summary>
        private static readonly int DAYS_180 = 180;

        /// <summary>
        /// システム選択画面ID(D8031)
        /// </summary>
        private static readonly string SCREEN_ID_D8031 = "D8031";

        public D0001Controller(ICompositeViewEngine viewEngine) : base(viewEngine)
        {
        }
        #endregion

        #region 初期表示イベント
        /// <summary>
        /// イベント：初期表示
        /// 画面を初期表示する
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpGet]
        public ActionResult Init()
        {
            // 画面表示モードを設定
            //SetScreenModeFromQueryString();
            //if (ScreenMode == CoreConst.ScreenMode.None)
            //{
            //    throw new AppException("MF00004", MessageUtil.Get("MF00004"));
            //}

            // 遷移元引数screenを取得する
            var pagefrom = HttpContext.Request.Query[CoreConst.SCREEN_PAGE_FROM];
            if (!string.IsNullOrEmpty(pagefrom) &&
                !Regex.IsMatch(pagefrom, CoreConst.SCREEN_PAGE_FROM_REGEX_MATCH))
            {
                throw new SystemException(MessageUtil.Get("MF00005", "遷移URLが不正です"));
            }

            // パンくずリストを修正する
            SessionUtil.Set(CoreConst.SESS_BREADCRUMB, new List<string>(), HttpContext);

            // 業務アプリ使用のセッションを削除
            SessionUtil.RemoveAll(HttpContext);

            // メニューを設定
            if (SessionUtil.Get<IEnumerable<MenuItem>>(InfraConst.SESS_MENU_LIST, HttpContext) == null)
            {
                SessionUtil.Set(InfraConst.SESS_MENU_LIST, MenuUtil.GetLeftMenuItems(HttpContext), HttpContext);
            }

            if (SessionUtil.Get<IEnumerable<HelpMenuItem>>(InfraConst.SESS_HELP_MENU_LIST, HttpContext) == null)
            {
                SessionUtil.Set(InfraConst.SESS_HELP_MENU_LIST, HelpMenuUtil.GetHelpMenuItems(HttpContext), HttpContext);
            }

            // モデル初期化
            D0001Model model = new D0001Model
            {
                // 「ログイン情報」を取得する
                VSyokuinRecords = getJigyoDb<BaseAppContext>().VSyokuins.Where(t => t.UserId == Syokuin.UserId).Single()
            };

            // ｢ログイン日時」をセッションに格納する
            if (model.VSyokuinRecords.LastLoginDate != null)
            {
                SessionUtil.Set(F00Const.SESS_LAST_LOGIN_DATETIME, model.VSyokuinRecords.LastLoginDate, HttpContext);
            }
            
            // 画面表示制御
            if (model.VSyokuinRecords.PwdLastUpdateYmd != null)
            {
                TimeSpan daySpan = DateUtil.GetSysDateTime().Subtract(model.VSyokuinRecords.PwdLastUpdateYmd.Value);
                if (daySpan.Days >= DAYS_180)
                {
                    model.PwdLabDisplay = true;
                }
            }

            // 初期表示情報をセッションに保存する
            SessionUtil.Set(SESS_D0001, model, HttpContext);

            // D0001 ポータルを表示する。
            return View(SCREEN_ID_D0001, model);
        }
        #endregion
    }
}