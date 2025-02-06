using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ��ʑ��쌠���}�X�^
    /// </summary>
    [Serializable]
    [Table("m_screen_sosa_kengen")]
    public class MScreenSosaKengen : ModelBase
    {
        /// <summary>
        /// ��ʑ��쌠��ID
        /// </summary>
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("screen_sosa_kengen_id", Order = 1)]
        public int ScreenSosaKengenId { get; set; }

        /// <summary>
        /// �s���{���R�[�h
        /// </summary>
        [Required]
        [Column("todofuken_cd")]
        [StringLength(2)]
        public string TodofukenCd { get; set; }

        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("kumiaito_cd")]
        [StringLength(3)]
        public string KumiaitoCd { get; set; }

        /// <summary>
        /// �V�X�e���敪
        /// </summary>
        [Required]
        [Column("system_kbn")]
        [StringLength(2)]
        public string SystemKbn { get; set; }

        /// <summary>
        /// ��ʑ��쌠���敪�R�[�h
        /// </summary>
        [Required]
        [Column("screen_sosa_kengen_cd")]
        [StringLength(4)]
        public string ScreenSosaKengenCd { get; set; }

        /// <summary>
        /// ��ʑ��쌠���敪��
        /// </summary>
        [Column("screen_sosa_kengen_nm")]
        [StringLength(20)]
        public string ScreenSosaKengenNm { get; set; }

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
