using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00040_“c”¨–¼Ì
    /// </summary>
    [Serializable]
    [Table("m_00040_“c”¨–¼Ì")]
    public class M00040“c”¨–¼Ì : ModelBase
    {
        /// <summary>
        /// “c”¨‹æ•ª
        /// </summary>
        [Required]
        [Key]
        [Column("“c”¨‹æ•ª", Order = 1)]
        [StringLength(1)]
        public string “c”¨‹æ•ª { get; set; }

        /// <summary>
        /// “c”¨–¼Ì
        /// </summary>
        [Column("“c”¨–¼Ì")]
        public string “c”¨–¼Ì { get; set; }

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
