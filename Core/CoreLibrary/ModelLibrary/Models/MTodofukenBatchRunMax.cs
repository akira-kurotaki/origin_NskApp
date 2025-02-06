using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �s���{���ʃo�b�`���s������}�X�^
    /// </summary>
    [Serializable]
    [Table("m_todofuken_batch_run_max")]
    public class MTodofukenBatchRunMax : ModelBase
    {
        /// <summary>
        /// �s���{���R�[�h
        /// </summary>
        [Required]
        [Key]
        [Column("todofuken_cd", Order = 1)]
        [StringLength(2)]
        public string TodofukenCd { get; set; }

        /// <summary>
        /// �o�b�`���s�����
        /// </summary>
        [Required]
        [Column("batch_max_run")]
        public int BatchMaxRun { get; set; }

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
