using CoreLibrary.Core.Base;
using ModelLibrary.Models;

namespace BaseWeb.Areas.F00.Models.D0001
{
    /// <summary>
    /// ポータル
    /// </summary>
    /// <remarks>
    /// 作成日：2018/03/07
    /// 作成者：Gon Etuun
    /// </remarks>
    [Serializable]
    public class D0001Model : CoreViewModel
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public D0001Model()
        {
            this.VSyokuinRecords = new VSyokuin();
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
    }
}