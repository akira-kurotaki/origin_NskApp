using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �o�b�`���s�\���ԑ�
    /// </summary>
    [Serializable]
    [Table("m_batch_run_time")]
    public class MBatchRunTime : ModelBase
    {
        /// <summary>
        /// �o�b�`���
        /// </summary>
        [Required]
        [Key]
        [Column("batch_type", Order = 1)]
        [StringLength(1)]
        public string BatchType { get; set; }

        /// <summary>
        /// ���s�\�����J�n
        /// </summary>
        [Required]
        [Column("batch_run_start_time")]
        [StringLength(8)]
        public string BatchRunStartTime { get; set; }

        /// <summary>
        /// ���s�\�����I��
        /// </summary>
        [Required]
        [Column("batch_run_end_time")]
        [StringLength(8)]
        public string BatchRunEndTime { get; set; }

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
