using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ��ʃ}�X�^
    /// </summary>
    [Serializable]
    [Table("m_screen")]
    public class MScreen : ModelBase
    {
        /// <summary>
        /// ���ID
        /// </summary>
        [Required]
        [Key]
        [Column("screen_id", Order = 1)]
        [StringLength(9)]
        public string ScreenId { get; set; }

        /// <summary>
        /// ��ʖ�
        /// </summary>
        [Required]
        [Column("screen_nm")]
        [StringLength(30)]
        public string ScreenNm { get; set; }

        /// <summary>
        /// �G���AID
        /// </summary>
        [Column("area_id")]
        [StringLength(5)]
        public string AreaId { get; set; }

        /// <summary>
        /// ��1�K�w���j���[�O���[�v
        /// </summary>
        [Column("first_menu_group")]
        [StringLength(2)]
        public string FirstMenuGroup { get; set; }

        /// <summary>
        /// ��2�K�w���j���[�\���t���O
        /// </summary>
        [Column("second_menu_display_flg")]
        [StringLength(1)]
        public string SecondMenuDisplayFlg { get; set; }

        /// <summary>
        /// ��2�K�w���j���[�\����
        /// </summary>
        [Column("second_menu_display_order")]
        public short? SecondMenuDisplayOrder { get; set; }

        /// <summary>
        /// ��2�K�w���j���[�\����ʖ�
        /// </summary>
        [Column("second_menu_display_nm")]
        [StringLength(30)]
        public string SecondMenuDisplayNm { get; set; }

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
