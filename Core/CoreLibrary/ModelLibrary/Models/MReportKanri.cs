using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ���[�����Ǘ��}�X�^
    /// </summary>
    [Serializable]
    [Table("m_report_kanri")]
    [PrimaryKey(nameof(ReportControlId), nameof(SerialNumber))]
    public class MReportKanri : ModelBase
    {
        /// <summary>
        /// ���[����ID
        /// </summary>
        [Required]
        [Column("report_control_id", Order = 2)]
        [StringLength(10)]
        public string ReportControlId { get; set; }

        /// <summary>
        /// �A��
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("serial_number", Order = 1)]
        public int SerialNumber { get; set; }

        /// <summary>
        /// �o�b�`�����Ώی���
        /// </summary>
        [Required]
        [Column("batch_shori_kensu")]
        public short BatchShoriKensu { get; set; }

        /// <summary>
        /// ���[���䖼
        /// </summary>
        [Required]
        [Column("report_control_nm")]
        [StringLength(100)]
        public string ReportControlNm { get; set; }

        /// <summary>
        /// �t�@�C����
        /// </summary>
        [Required]
        [Column("file_nm")]
        [StringLength(100)]
        public string FileNm { get; set; }

        /// <summary>
        /// �\�񏈗���
        /// </summary>
        [Required]
        [Column("yoyaku_nm")]
        [StringLength(100)]
        public string YoyakuNm { get; set; }

        /// <summary>
        /// �o�^���[�UID
        /// </summary>
        [Required]
        [Column("insert_user_id")]
        [StringLength(11)]
        public string InsertUserId { get; set; }

        /// <summary>
        /// �o�^����
        /// </summary>
        [Required]
        [Column("insert_date")]
        public DateTime InsertDate { get; set; }

        /// <summary>
        /// �X�V���[�UID
        /// </summary>
        [Required]
        [Column("update_user_id")]
        [StringLength(11)]
        public string UpdateUserId { get; set; }

        /// <summary>
        /// �X�V����
        /// </summary>
        [Required]
        [Column("update_date")]
        public DateTime UpdateDate { get; set; }
    }
}
