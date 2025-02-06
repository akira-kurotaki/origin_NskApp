using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �o�b�`�_�E�����[�h�t�@�C��
    /// </summary>
    [Serializable]
    [Table("t_batch_download_file")]
    [PrimaryKey(nameof(BatchId), nameof(Renban))]
    public class TBatchDownloadFile : ModelBase
    {
        /// <summary>
        /// �o�b�`ID
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("batch_id", Order = 1)]
        public long BatchId { get; set; }

        /// <summary>
        /// �A��
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("renban", Order = 2)]
        public short Renban { get; set; }

        /// <summary>
        /// �t�@�C���p�X
        /// </summary>
        [Required]
        [Column("file_path")]
        [StringLength(256)]
        public string FilePath { get; set; }

        /// <summary>
        /// �n�b�V���l
        /// </summary>
        [Required]
        [Column("hash")]
        [StringLength(64)]
        public string Hash { get; set; }

        /// <summary>
        /// �t�@�C����
        /// </summary>
        [Required]
        [Column("file_nm")]
        [StringLength(100)]
        public string FileNm { get; set; }

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
