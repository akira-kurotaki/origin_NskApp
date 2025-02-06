using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace BaseWeb.Areas.F99.Models.D9902
{
    /// <summary>
    /// データロック
    /// </summary>
    [Serializable]
    public class D9902DataLocks
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public D9902DataLocks() {
            Locks = [];
        }

        /// <summary>
        /// データロック
        /// </summary>
        [Display(Name = "データロック")]
        public List<D9902DataLockRecord> Locks { get; set; }
    }
}
