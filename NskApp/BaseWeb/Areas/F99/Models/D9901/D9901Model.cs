using CoreLibrary.Core.DropDown;
using CoreLibrary.Core.Dto;
using System.ComponentModel.DataAnnotations;

namespace BaseWeb.Areas.F99.Models.D9901
{
    /// <summary>
    /// 都道府県ドロップダウンリスト
    /// </summary>
    [Serializable]
    public class D9901Model
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public D9901Model()
        {
            // 都道府県マルチドロップダウンリスト
            TodofukenDropDownList = new TodofukenDropDownList("");
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="syokuin">職員マスタ</param>
        public D9901Model(Syokuin syokuin, List<Shisho> shishoList)
        {
            // 都道府県マルチドロップダウンリスト
            TodofukenDropDownList = new TodofukenDropDownList("", syokuin, shishoList);
        }

        /// <summary>
        /// 都道府県マルチドロップダウンリスト
        /// </summary>
        [Display(Name = "都道府県マルチドロップダウンリスト")]
        public TodofukenDropDownList TodofukenDropDownList { get; set; }
    }
}
