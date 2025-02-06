using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �w���v���j���[�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_help_menu")]
    public class MHelpMenu : ModelBase
    {
        /// <summary>
        /// �w���v���j���[�\����
        /// </summary>
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("help_menu_display_order", Order = 1)]
        public short HelpMenuDisplayOrder { get; set; }

        /// <summary>
        /// �w���v���j���[�\���t���O
        /// </summary>
        [Column("help_menu_display_flg")]
        [StringLength(1)]
        public string HelpMenuDisplayFlg { get; set; }

        /// <summary>
        /// �w���v���j���[�\���@�\��
        /// </summary>
        [Column("help_menu_display_kino_nm")]
        [StringLength(30)]
        public string HelpMenuDisplayKinoNm { get; set; }

        /// <summary>
        /// �w���v�t�@�C���p�X
        /// </summary>
        [Required]
        [Column("help_file_path")]
        public string HelpFilePath { get; set; }

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
