using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10110_—p“r‹æ•ª–¼Ì
    /// </summary>
    [Serializable]
    [Table("m_10110_—p“r‹æ•ª–¼Ì")]
    [PrimaryKey(nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(—p“r‹æ•ª))]
    public class M10110—p“r‹æ•ª–¼Ì : ModelBase
    {
        /// <summary>
        /// ‹¤Ï–Ú“IƒR[ƒh
        /// </summary>
        [Required]
        [Column("‹¤Ï–Ú“IƒR[ƒh", Order = 1)]
        [StringLength(2)]
        public string ‹¤Ï–Ú“IƒR[ƒh { get; set; }

        /// <summary>
        /// —p“r‹æ•ª
        /// </summary>
        [Required]
        [Column("—p“r‹æ•ª", Order = 2)]
        [StringLength(3)]
        public string —p“r‹æ•ª { get; set; }

        /// <summary>
        /// —p“r–¼Ì
        /// </summary>
        [Column("—p“r–¼Ì")]
        public string —p“r–¼Ì { get; set; }

        /// <summary>
        /// —p“r’Zk–¼Ì
        /// </summary>
        [Column("—p“r’Zk–¼Ì")]
        public string —p“r’Zk–¼Ì { get; set; }

        /// <summary>
        /// ‰c”_‘ÎÛŠOƒtƒ‰ƒO
        /// </summary>
        [Column("‰c”_‘ÎÛŠOƒtƒ‰ƒO")]
        [StringLength(1)]
        public string ‰c”_‘ÎÛŠOƒtƒ‰ƒO { get; set; }

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
