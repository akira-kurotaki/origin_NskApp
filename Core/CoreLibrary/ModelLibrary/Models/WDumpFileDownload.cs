using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �ꎞ�_���v�t�@�C���擾�e�[�u���̃G���e�B�e�B�N���X�B
    /// </summary>
    [Serializable]
    [Table("w_dumpfile_download")]
    [PrimaryKey(nameof(Token), nameof(Renban))]
    public class WDumpFileDownload
    {
        /// <summary>
        /// �g�[�N�� 
        /// </summary>
        [Column("token")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [MaxLength(24)]
        public string Token { get; set; }

        /// <summary>
        /// �A�� 
        /// </summary>
        [Column("renban")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public short Renban { get; set; }

        /// <summary>
        /// �_���v�t�@�C���p�X
        /// </summary>
        [Column("dmpfile_path")]
        [Required]
        [StringLength(330)]
        public string DmpfilePath { get; set; }

        /// <summary>
        /// �_�E�����[�h�t���O
        /// </summary>
        [Column("download_flg")]
        [Required]
        [StringLength(1)]
        public string DownloadFlg { get; set; }

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