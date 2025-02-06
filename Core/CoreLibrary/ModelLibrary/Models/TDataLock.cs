using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �f�[�^���b�N
    /// </summary>
    [Serializable]
    [Table("t_data_lock")]
    [PrimaryKey(nameof(SystemKbn), nameof(TodofukenCd), nameof(KumiaitoCd), nameof(ShishoCd), nameof(LockDate))]
    public class TDataLock : ModelBase
    {
        /// <summary>
        /// �V�X�e���敪
        /// </summary>
        [Required]
        [Column("system_kbn", Order = 1)]
        [StringLength(2)]
        public string SystemKbn { get; set; }

        /// <summary>
        /// �s���{���R�[�h
        /// </summary>
        [Required]
        [Column("todofuken_cd", Order = 2)]
        [StringLength(2)]
        public string TodofukenCd { get; set; }

        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("kumiaito_cd", Order = 3)]
        [StringLength(3)]
        public string KumiaitoCd { get; set; }

        /// <summary>
        /// �x���R�[�h
        /// </summary>
        [Required]
        [Column("shisho_cd", Order = 4)]
        [StringLength(2)]
        public string ShishoCd { get; set; }

        /// <summary>
        /// ���b�N�J�n����
        /// </summary>
        [Required]
        [Column("lock_date", Order = 5)]
        public DateTime LockDate { get; set; }

        /// <summary>
        /// ���b�N�I������
        /// </summary>
        [Required]
        [Column("lock_end_date")]
        public DateTime LockEndDate { get; set; }

        /// <summary>
        /// ���b�N���s���[�U
        /// </summary>
        [Required]
        [Column("lock_user_id")]
        [StringLength(11)]
        public string LockUserId { get; set; }

        /// <summary>
        /// ���b�N���s����
        /// </summary>
        [Required]
        [Column("lock_shori")]
        [StringLength(30)]
        public string LockShori { get; set; }
    }
}
