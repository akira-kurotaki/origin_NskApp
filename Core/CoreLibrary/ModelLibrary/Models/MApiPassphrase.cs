using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// API�p�X�t���[�Y�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_api_passphrase")]
    [PrimaryKey(nameof(SystemKbn), nameof(ShoriNm), nameof(TodofukenCd))]
    public class MApiPassphrase : ModelBase
    {
        /// <summary>
        /// �V�X�e���敪
        /// </summary>
        [Required]
        [Column("system_kbn", Order = 1)]
        [StringLength(2)]
        public string SystemKbn { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Required]
        [Column("shori_nm", Order = 2)]
        [StringLength(30)]
        public string ShoriNm { get; set; }

        /// <summary>
        /// �s���{���R�[�h
        /// </summary>
        [Required]
        [Column("todofuken_cd", Order = 3)]
        [StringLength(2)]
        public string TodofukenCd { get; set; }

        /// <summary>
        /// �p�X�t���[�Y
        /// </summary>
        [Required]
        [Column("passphrase")]
        [StringLength(100)]
        public string Passphrase { get; set; }

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
