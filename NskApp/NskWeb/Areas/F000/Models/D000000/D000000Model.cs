using CoreLibrary.Core.Base;
using ModelLibrary.Models;

namespace NskWeb.Areas.F000.Models.D000000
{
    /// <summary>
    /// ポータル
    /// </summary>
    /// <remarks>
    /// 作成日：2018/03/07
    /// 作成者：Gon Etuun
    /// </remarks>
    [Serializable]
    public class D000000Model : CoreViewModel
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public D000000Model()
        {
            this.VSyokuinRecords = new VSyokuin();
            this.D000000Info = new NSKPortalInfoModel();  // $$$$$$$$$$$$$$$$$$$
            this.D000000Info2 = new NSKPortalInfoModel();  // $$$$$$$$$$$$$$$$$$$
        }

        /// <summary>
        /// 職員マスタの検索結果
        /// </summary>
        public VSyokuin VSyokuinRecords { get; set; }

        /// <summary>
        ///最終パスワード更新メッセージ 表示/非表示
        /// </summary>
        public bool PwdLabDisplay { get; set; }

        /// <summary>
        ///前回ログイン日時
        /// </summary>
        public string LoginDate { get; set; }

        /// <summary>
        ///最終パスワード日時
        /// </summary>
        public string PwdLastUpdateYmd { get; set; }

        // $$$$$$$$$$$$$$$$$$$$$
        public NSKPortalInfoModel D000000Info { get; set; }
        public NSKPortalInfoModel D000000Info2 { get; set; }
        // $$$$$$$$$$$$$$$$$$$$$
        public string wtest { get; set; }
    }
}