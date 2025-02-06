using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace BaseWeb.Areas.F99.Models.D9902
{
    /// <summary>
    /// システムロック
    /// </summary>
    [Serializable]
    public class D9902SysLocks
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public D9902SysLocks() {
            Locks = [];
        }

        /// <summary>
        /// システムロック
        /// </summary>
        [Display(Name = "システムロック")]
        public List<D9902SysLockRecord> Locks { get; set; }
    }
}
