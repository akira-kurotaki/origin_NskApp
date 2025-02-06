using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ���̃}�X�^
    /// </summary>
    [Serializable]
    [Table("m_meisho")]
    [PrimaryKey(nameof(NmSbt), nameof(TekiyoStartYmd))]
    public class MMeisho : ModelBase
    {
        /// <summary>
        /// ���̎��
        /// </summary>
        [Required]
        //[Key]
        [Column("nm_sbt", Order = 1)]
        [StringLength(3)]
        public string NmSbt { get; set; }

        /// <summary>
        /// �K�p�J�n�N����
        /// </summary>
        [Required]
        //[Key]
        [Column("tekiyo_start_ymd", Order = 2)]
        public DateTime TekiyoStartYmd { get; set; }

        /// <summary>
        /// �K�p�I���N����
        /// </summary>
        [Column("tekiyo_end_ymd")]
        public DateTime? TekiyoEndYmd { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column("nm")]
        [StringLength(50)]
        public string Nm { get; set; }

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
