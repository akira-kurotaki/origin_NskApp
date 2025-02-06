using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// 名称マスタ
    /// </summary>
    [Serializable]
    [Table("m_meisho")]
    [PrimaryKey(nameof(NmSbt), nameof(TekiyoStartYmd))]
    public class MMeisho : ModelBase
    {
        /// <summary>
        /// 名称種別
        /// </summary>
        [Required]
        //[Key]
        [Column("nm_sbt", Order = 1)]
        [StringLength(3)]
        public string NmSbt { get; set; }

        /// <summary>
        /// 適用開始年月日
        /// </summary>
        [Required]
        //[Key]
        [Column("tekiyo_start_ymd", Order = 2)]
        public DateTime TekiyoStartYmd { get; set; }

        /// <summary>
        /// 適用終了年月日
        /// </summary>
        [Column("tekiyo_end_ymd")]
        public DateTime? TekiyoEndYmd { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Column("nm")]
        [StringLength(50)]
        public string Nm { get; set; }

        /// <summary>
        /// 登録ユーザID
        /// </summary>
        [Column("insert_user_id")]
        [StringLength(11)]
        public string InsertUserId { get; set; }

        /// <summary>
        /// 登録日時
        /// </summary>
        [Column("insert_date")]
        public DateTime? InsertDate { get; set; }

        /// <summary>
        /// 更新ユーザID
        /// </summary>
        [Column("update_user_id")]
        [StringLength(11)]
        public string UpdateUserId { get; set; }

        /// <summary>
        /// 更新日時
        /// </summary>
        [Column("update_date")]
        public DateTime? UpdateDate { get; set; }
    }
}
