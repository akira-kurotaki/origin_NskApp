using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �w���v���b�Z�[�W�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_help_message")]
    [PrimaryKey(nameof(TekiyoStartYmd), nameof(ScreenId), nameof(ItemNo))]
    public class MHelpMessage : ModelBase
    {
        /// <summary>
        /// �K�p�J�n�N����
        /// </summary>
        [Required]
        [Column("tekiyo_start_ymd", Order = 1)]
        public DateTime TekiyoStartYmd { get; set; }

        /// <summary>
        /// �K�p�I���N����
        /// </summary>
        [Column("tekiyo_end_ymd")]
        public DateTime? TekiyoEndYmd { get; set; }

        /// <summary>
        /// ���ID
        /// </summary>
        [Required]
        [Column("screen_id", Order = 2)]
        [StringLength(9)]
        public string ScreenId { get; set; }

        /// <summary>
        /// ����NO.
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("item_no", Order = 3)]
        public short ItemNo { get; set; }

        /// <summary>
        /// ���ږ�
        /// </summary>
        [Column("item_nm")]
        [StringLength(100)]
        public string ItemNm { get; set; }

        /// <summary>
        /// ���b�Z�[�W
        /// </summary>
        [Column("message")]
        [StringLength(1000)]
        public string Message { get; set; }

        /// <summary>
        /// �\���t���O
        /// </summary>
        [Required]
        [Column("display_flg")]
        [StringLength(1)]
        public string DisplayFlg { get; set; }
    }
}
