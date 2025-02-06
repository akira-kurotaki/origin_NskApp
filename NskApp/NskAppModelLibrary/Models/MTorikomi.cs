using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// �捞�Ώۃ}�X�^
    /// </summary>
    [Serializable]
    [Table("m_torikomi")]
    public class MTorikomi : ModelBase
    {
        /// <summary>
        /// �捞�ΏۃR�[�h
        /// </summary>
        [Required]
        [Key]
        [Column("torikomi_cd", Order = 1)]
        [StringLength(2)]
        public string TorikomiCd { get; set; }

        /// <summary>
        /// �捞�Ώۖ�
        /// </summary>
        [Column("torikomi_nm")]
        [StringLength(30)]
        public string TorikomiNm { get; set; }

        /// <summary>
        /// ���b�N���
        /// </summary>
        [Column("lock_type")]
        [StringLength(1)]
        public string LockType { get; set; }

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
