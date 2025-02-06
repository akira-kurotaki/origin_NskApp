using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �����}�X�^
    /// </summary>
    [Serializable]
    [Table("m_gengo")]
    public class MGengo : ModelBase
    {
        /// <summary>
        /// ����
        /// </summary>
        [Required]
        [Key]
        [Column("gengo", Order = 1)]
        [StringLength(2)]
        public string Gengo { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column("ryakugo")]
        [StringLength(1)]
        public string Ryakugo { get; set; }

        /// <summary>
        /// �p����
        /// </summary>
        [Column("ryakugo_en")]
        [StringLength(1)]
        public string RyakugoEn { get; set; }

        /// <summary>
        /// �K�p�J�n�N����
        /// </summary>
        [Column("tekiyo_start_ymd")]
        public DateTime? TekiyoStartYmd { get; set; }

        /// <summary>
        /// �K�p�I���N����
        /// </summary>
        [Column("tekiyo_end_ymd")]
        public DateTime? TekiyoEndYmd { get; set; }

        /// <summary>
        /// �o�^���[�UID
        /// </summary>
        [Column("insert_user_id")]
        [StringLength(11)]
        public string InsertUserId { get; set; }

        /// <summary>
        /// �o�^����
        /// </summary>
        [Column("insert_date")]
        public DateTime? InsertDate { get; set; }

        /// <summary>
        /// �X�V���[�UID
        /// </summary>
        [Column("update_user_id")]
        [StringLength(11)]
        public string UpdateUserId { get; set; }

        /// <summary>
        /// �X�V����
        /// </summary>
        [Column("update_date")]
        public DateTime? UpdateDate { get; set; }
    }
}
