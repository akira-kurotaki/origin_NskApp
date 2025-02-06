using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ���O�C�����J�ڐ�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_login_transition")]
    public class MLoginTransition : ModelBase
    {
        /// <summary>
        /// �J�ڐ�ԍ�
        /// </summary>
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("transition_no", Order = 1)]
        public int TransitionNo { get; set; }

        /// <summary>
        /// �L�[���[�h
        /// </summary>
        [Required]
        [Column("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// �f�t�H���g�J�ڐ�URL
        /// </summary>
        [Required]
        [Column("default_url")]
        public string DefaultUrl { get; set; }

        /// <summary>
        /// ��ʕ\�����[�hPC
        /// </summary>
        [Required]
        [Column("screen_pc")]
        public string ScreenPc { get; set; }

        /// <summary>
        /// ��ʕ\�����[�hTablet
        /// </summary>
        [Required]
        [Column("screen_tablet")]
        public string ScreenTablet { get; set; }
    }
}
