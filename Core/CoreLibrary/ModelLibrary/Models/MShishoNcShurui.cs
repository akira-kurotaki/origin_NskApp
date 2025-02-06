using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �x���ʔ_�{��ރ}�X�^
    /// </summary>
    [Serializable]
    [Table("m_shisho_nc_shurui")]
    [PrimaryKey(nameof(TodofukenCd), nameof(KumiaitoCd), nameof(ShishoCd), nameof(NcShuruiCd))]
    public class MShishoNcShurui : ModelBase
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
        /// �x���ʔ_�{��ރR�[�h
        /// </summary>
        [Column("shisho_nc_shurui_cd")]
        [StringLength(2)]
        public string ShishoNcShuruiCd { get; set; }

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
