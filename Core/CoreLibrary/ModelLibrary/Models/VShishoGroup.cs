using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �x���O���[�v�}�X�^
    /// </summary>
    [Serializable]
    [Table("v_shisho_group")]
    public class VShishoGroup
    {
        /// <summary>
        /// �x���O���[�vID
        /// </summary>
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("shisho_group_id", Order = 1)]
        public int ShishoGroupId { get; set; }

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
        /// �x���O���[�v�R�[�h
        /// </summary>
        [Required]
        [Column("shisho_group_cd")]
        [StringLength(4)]
        public string ShishoGroupCd { get; set; }

        /// <summary>
        /// �x���O���[�v��
        /// </summary>
        [Column("shisho_group_nm")]
        [StringLength(20)]
        public string ShishoGroupNm { get; set; }

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
