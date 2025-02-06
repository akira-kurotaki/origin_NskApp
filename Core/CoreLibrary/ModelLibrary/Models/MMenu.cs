using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ���j���[�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_menu")]
    public class MMenu : ModelBase
    {
        /// <summary>
        /// ��1�K�w���j���[�O���[�v
        /// </summary>
        [Required]
        [Key]
        [Column("first_menu_group", Order = 1)]
        [StringLength(2)]
        public string FirstMenuGroup { get; set; }

        /// <summary>
        /// ��1�K�w���j���[�\���t���O
        /// </summary>
        [Column("first_menu_display_flg")]
        [StringLength(1)]
        public string FirstMenuDisplayFlg { get; set; }

        /// <summary>
        /// ��1�K�w���j���[�\����
        /// </summary>
        [Column("first_menu_display_order")]
        public short? FirstMenuDisplayOrder { get; set; }

        /// <summary>
        /// ��1�K�w���j���[�\���@�\��
        /// </summary>
        [Column("first_menu_display_kino_nm")]
        [StringLength(15)]
        public string FirstMenuDisplayKinoNm { get; set; }

        /// <summary>
        /// �\���敪
        /// </summary>
        [Column("hyoji_kbn")]
        [StringLength(11)]
        public string HyojiKbn { get; set; }

        /// <summary>
        /// ���[�U�Ǘ�����
        /// </summary>
        [Column("user_kanri_kengen")]
        [StringLength(1)]
        public string UserKanriKengen { get; set; }

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
