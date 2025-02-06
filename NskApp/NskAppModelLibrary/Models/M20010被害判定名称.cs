using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20010_”íŠQ”»’è–¼Ì
    /// </summary>
    [Serializable]
    [Table("m_20010_”íŠQ”»’è–¼Ì")]
    public class M20010”íŠQ”»’è–¼Ì : ModelBase
    {
        /// <summary>
        /// ”íŠQ”»’èƒR[ƒh
        /// </summary>
        [Required]
        [Key]
        [Column("”íŠQ”»’èƒR[ƒh", Order = 1)]
        [StringLength(1)]
        public string ”íŠQ”»’èƒR[ƒh { get; set; }

        /// <summary>
        /// ”íŠQ”»’è–¼Ì
        /// </summary>
        [Column("”íŠQ”»’è–¼Ì")]
        public string ”íŠQ”»’è–¼Ì { get; set; }

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
