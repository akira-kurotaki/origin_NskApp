using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20050_x•¥‘ÎÛ‹æ•ª
    /// </summary>
    [Serializable]
    [Table("m_20050_x•¥‘ÎÛ‹æ•ª")]
    public class M20050x•¥‘ÎÛ‹æ•ª : ModelBase
    {
        /// <summary>
        /// x•¥‘ÎÛ‹æ•ª
        /// </summary>
        [Required]
        [Key]
        [Column("x•¥‘ÎÛ‹æ•ª", Order = 1)]
        [StringLength(1)]
        public string x•¥‘ÎÛ‹æ•ª { get; set; }

        /// <summary>
        /// x•¥‘ÎÛ‹æ•ª–¼Ì
        /// </summary>
        [Column("x•¥‘ÎÛ‹æ•ª–¼Ì")]
        public string x•¥‘ÎÛ‹æ•ª–¼Ì { get; set; }

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
