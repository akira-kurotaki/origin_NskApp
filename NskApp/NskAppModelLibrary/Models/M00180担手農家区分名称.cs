using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00180_’Sè”_‰Æ‹æ•ª–¼Ì
    /// </summary>
    [Serializable]
    [Table("m_00180_’Sè”_‰Æ‹æ•ª–¼Ì")]
    public class M00180’Sè”_‰Æ‹æ•ª–¼Ì : ModelBase
    {
        /// <summary>
        /// ’Sè”_‰Æ‹æ•ª
        /// </summary>
        [Required]
        [Key]
        [Column("’Sè”_‰Æ‹æ•ª", Order = 1)]
        [StringLength(1)]
        public string ’Sè”_‰Æ‹æ•ª { get; set; }

        /// <summary>
        /// ’Sè”_‰Æ‹æ•ª–¼Ì
        /// </summary>
        [Column("’Sè”_‰Æ‹æ•ª–¼Ì")]
        public string ’Sè”_‰Æ‹æ•ª–¼Ì { get; set; }

        /// <summary>
        /// ’Sè”_‰Æ‹æ•ª—ªÌ
        /// </summary>
        [Column("’Sè”_‰Æ‹æ•ª—ªÌ")]
        public string ’Sè”_‰Æ‹æ•ª—ªÌ { get; set; }

        /// <summary>
        /// “o˜^“ú
        /// </summary>
        [Column("“o˜^“ú")]
        public DateTime? “o˜^“ú { get; set; }

        /// <summary>
        /// “o˜^ƒ†[ƒUid
        /// </summary>
        [Column("“o˜^ƒ†[ƒUid")]
        public string “o˜^ƒ†[ƒUid { get; set; }
    }
}
