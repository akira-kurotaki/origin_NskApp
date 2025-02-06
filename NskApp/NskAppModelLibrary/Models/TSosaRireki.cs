using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// ���엚��
    /// </summary>
    [Serializable]
    [Table("t_sosa_rireki")]
    [Keyless]
    public class TSosaRireki : ModelBase
    {
        /// <summary>
        /// �_�Ǝ�ID (FK)
        /// </summary>
        [Required]
        [Column("nogyosha_id")]
        public int NogyoshaId { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("sosa_date")]
        public DateTime SosaDate { get; set; }

        /// <summary>
        /// ���[�UID
        /// </summary>
        [Column("user_id")]
        [StringLength(11)]
        public string UserId { get; set; }

        /// <summary>
        /// ���ID
        /// </summary>
        [Column("screen_id")]
        [StringLength(9)]
        public string ScreenId { get; set; }

        /// <summary>
        /// �V�X�e�����p�ҋ敪
        /// </summary>
        [Column("system_riyo_kbn")]
        [StringLength(1)]
        public string SystemRiyoKbn { get; set; }

        /// <summary>
        /// �x���R�[�h
        /// </summary>
        [Column("shisho_cd")]
        [StringLength(2)]
        public string ShishoCd { get; set; }

        /// <summary>
        /// ������e
        /// </summary>
        [Column("sosa_naiyo")]
        [StringLength(100)]
        public string SosaNaiyo { get; set; }

        /// <summary>
        /// �\���F
        /// </summary>
        [Column("display_color")]
        [StringLength(1)]
        public string DisplayColor { get; set; }
    }
}
