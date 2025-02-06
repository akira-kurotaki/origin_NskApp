using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ���͕��@PDF�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_nyuryokuhoho_pdf")]
    [PrimaryKey(nameof(ScreenId), nameof(TekiyoStartYmd))]
    public class MNyuryokuhohoPdf : ModelBase
    {
        /// <summary>
        /// ���ID
        /// </summary>
        [Required]
        [Column("screen_id", Order = 1)]
        [StringLength(9)]
        public string ScreenId { get; set; }

        /// <summary>
        /// �K�p�J�n�N����
        /// </summary>
        [Required]
        [Column("tekiyo_start_ymd", Order = 2)]
        public DateTime TekiyoStartYmd { get; set; }

        /// <summary>
        /// �K�p�I���N����
        /// </summary>
        [Column("tekiyo_end_ymd")]
        public DateTime? TekiyoEndYmd { get; set; }

        /// <summary>
        /// PDF�t�@�C���p�X
        /// </summary>
        [Column("pdf_file_path")]
        public string PdfFilePath { get; set; }

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
