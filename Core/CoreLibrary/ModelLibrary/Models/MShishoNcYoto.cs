using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �x���ʔ_�{�p�r�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_shisho_nc_yoto")]
    [PrimaryKey(nameof(TodofukenCd), nameof(KumiaitoCd), nameof(ShishoCd), nameof(NcShuruiCd), nameof(NcHimmokuCd), nameof(NcYotoCd))]
    public class MShishoNcYoto : ModelBase
    {
        /// <summary>
        /// �s���{���R�[�h
        /// </summary>
        [Required]
        //[Key]
        [Column("todofuken_cd", Order = 1)]
        [StringLength(2)]
        public string TodofukenCd { get; set; }

        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        //[Key]
        [Column("kumiaito_cd", Order = 2)]
        [StringLength(3)]
        public string KumiaitoCd { get; set; }

        /// <summary>
        /// �x���R�[�h
        /// </summary>
        [Required]
        //[Key]
        [Column("shisho_cd", Order = 3)]
        [StringLength(2)]
        public string ShishoCd { get; set; }

        /// <summary>
        /// �_�{��ރR�[�h
        /// </summary>
        [Required]
        //[Key]
        [Column("nc_shurui_cd", Order = 4)]
        [StringLength(2)]
        public string NcShuruiCd { get; set; }

        /// <summary>
        /// �_�{�i�ڃR�[�h
        /// </summary>
        [Required]
        //[Key]
        [Column("nc_himmoku_cd", Order = 5)]
        [StringLength(3)]
        public string NcHimmokuCd { get; set; }

        /// <summary>
        /// �_�{�p�r�R�[�h
        /// </summary>
        [Required]
        //[Key]
        [Column("nc_yoto_cd", Order = 6)]
        [StringLength(2)]
        public string NcYotoCd { get; set; }

        /// <summary>
        /// �x���ʔ_�{�p�r�R�[�h
        /// </summary>
        [Column("shisho_nc_yoto_cd")]
        [StringLength(2)]
        public string ShishoNcYotoCd { get; set; }

        /// <summary>
        /// ��\���t���O
        /// </summary>
        [Required]
        [Column("hidden_flg")]
        [StringLength(1)]
        public string HiddenFlg { get; set; }

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
