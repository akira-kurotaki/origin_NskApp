using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �\�񏈗��}�X�^
    /// </summary>
    [Serializable]
    [Table("m_yoyaku")]
    [PrimaryKey(nameof(SystemKbn), nameof(BatchNm))]
    public class MYoyaku : ModelBase
    {
        /// <summary>
        /// �V�X�e���敪
        /// </summary>
        [Required]
        [Column("system_kbn", Order = 1)]
        [StringLength(2)]
        public string SystemKbn { get; set; }

        /// <summary>
        /// �o�b�`��
        /// </summary>
        [Required]
        [Column("batch_nm", Order = 2)]
        [StringLength(30)]
        public string BatchNm { get; set; }

        /// <summary>
        /// ���s�Ώۃo�b�`�p�X
        /// </summary>
        [Required]
        [Column("batch_path")]
        [StringLength(300)]
        public string BatchPath { get; set; }

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
