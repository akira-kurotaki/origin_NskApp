using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �o�b�N�A�b�v�Ώۏ��
    /// </summary>
    [Serializable]
    [Table("m_backup_info")]
    [PrimaryKey(nameof(TodofukenCd))]
    public class MBackupInfo
    {
        /// <summary>
        /// �s���{���R�[�h
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("todofuken_cd", Order = 1)]
        [StringLength(2)]
        public string TodofukenCd { get; set; }

        /// <summary>
        /// �o�b�N�A�b�v�Ώۏ��
        /// </summary>
        [Required]
        [Column("backup_info")]
        [StringLength(1024)]
        public string BackupInfo { get; set; }

        /// <summary>
        /// �_���v�o�͐�p�X
        /// </summary>
        [Required]
        [Column("dmp_output_path")]
        [StringLength(300)]
        public string DmpOutputPath { get; set; }

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