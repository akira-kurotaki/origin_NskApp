using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20090_‹¤Ï–ŒÌí—Ş
    /// </summary>
    [Serializable]
    [Table("m_20090_‹¤Ï–ŒÌí—Ş")]
    public class M20090‹¤Ï–ŒÌí—Ş : ModelBase
    {
        /// <summary>
        /// ‹¤Ï–ŒÌƒR[ƒh
        /// </summary>
        [Required]
        [Key]
        [Column("‹¤Ï–ŒÌƒR[ƒh", Order = 1)]
        [StringLength(2)]
        public string ‹¤Ï–ŒÌƒR[ƒh { get; set; }

        /// <summary>
        /// ‹¤Ï–ŒÌ–¼
        /// </summary>
        [Column("‹¤Ï–ŒÌ–¼")]
        public string ‹¤Ï–ŒÌ–¼ { get; set; }

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
