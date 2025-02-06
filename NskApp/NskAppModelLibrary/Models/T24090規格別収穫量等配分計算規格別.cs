using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24090_‹KŠi•ÊûŠn—Ê“™”z•ªŒvZ_‹KŠi•Ê
    /// </summary>
    [Serializable]
    [Table("t_24090_‹KŠi•ÊûŠn—Ê“™”z•ªŒvZ_‹KŠi•Ê")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(‘g‡ˆõ“™ƒR[ƒh), nameof(Y’n•Ê–Á•¿ƒR[ƒh), nameof(‰c”_‘ÎÛŠOƒtƒ‰ƒO), nameof(—Ş‹æ•ª), nameof(¸Z‹æ•ª), nameof(‹KŠi))]
    public class T24090‹KŠi•ÊûŠn—Ê“™”z•ªŒvZ‹KŠi•Ê : ModelBase
    {
        /// <summary>
        /// ‘g‡“™ƒR[ƒh
        /// </summary>
        [Required]
        [Column("‘g‡“™ƒR[ƒh", Order = 1)]
        [StringLength(3)]
        public string ‘g‡“™ƒR[ƒh { get; set; }

        /// <summary>
        /// ”NY
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("”NY", Order = 2)]
        public short ”NY { get; set; }

        /// <summary>
        /// ‹¤Ï–Ú“IƒR[ƒh
        /// </summary>
        [Required]
        [Column("‹¤Ï–Ú“IƒR[ƒh", Order = 3)]
        [StringLength(2)]
        public string ‹¤Ï–Ú“IƒR[ƒh { get; set; }

        /// <summary>
        /// ‘g‡ˆõ“™ƒR[ƒh
        /// </summary>
        [Required]
        [Column("‘g‡ˆõ“™ƒR[ƒh", Order = 4)]
        [StringLength(13)]
        public string ‘g‡ˆõ“™ƒR[ƒh { get; set; }

        /// <summary>
        /// Y’n•Ê–Á•¿ƒR[ƒh
        /// </summary>
        [Required]
        [Column("Y’n•Ê–Á•¿ƒR[ƒh", Order = 5)]
        [StringLength(5)]
        public string Y’n•Ê–Á•¿ƒR[ƒh { get; set; }

        /// <summary>
        /// ‰c”_‘ÎÛŠOƒtƒ‰ƒO
        /// </summary>
        [Required]
        [Column("‰c”_‘ÎÛŠOƒtƒ‰ƒO", Order = 6)]
        [StringLength(1)]
        public string ‰c”_‘ÎÛŠOƒtƒ‰ƒO { get; set; }

        /// <summary>
        /// —Ş‹æ•ª
        /// </summary>
        [Required]
        [Column("—Ş‹æ•ª", Order = 7)]
        [StringLength(2)]
        public string —Ş‹æ•ª { get; set; }

        /// <summary>
        /// ¸Z‹æ•ª
        /// </summary>
        [Required]
        [Column("¸Z‹æ•ª", Order = 8)]
        [StringLength(1)]
        public string ¸Z‹æ•ª { get; set; }

        /// <summary>
        /// ‹KŠi
        /// </summary>
        [Required]
        [Column("‹KŠi", Order = 9)]
        [StringLength(2)]
        public string ‹KŠi { get; set; }

        /// <summary>
        /// •â³Œão‰×”—Ê“™
        /// </summary>
        [Column("•â³Œão‰×”—Ê“™")]
        public Decimal? •â³Œão‰×”—Ê“™ { get; set; }

        /// <summary>
        /// ‹KŠi•Êo‰×Š„‡
        /// </summary>
        [Column("‹KŠi•Êo‰×Š„‡")]
        public Decimal? ‹KŠi•Êo‰×Š„‡ { get; set; }

        /// <summary>
        /// ‹KŠi•Ê”—Ê
        /// </summary>
        [Column("‹KŠi•Ê”—Ê")]
        public Decimal? ‹KŠi•Ê”—Ê { get; set; }

        /// <summary>
        /// •â³Œã•ªŠ„Œ¸û—Ê
        /// </summary>
        [Column("•â³Œã•ªŠ„Œ¸û—Ê")]
        public Decimal? •â³Œã•ªŠ„Œ¸û—Ê { get; set; }

        /// <summary>
        /// ‹KŠi•ÊŠ„‡
        /// </summary>
        [Column("‹KŠi•ÊŠ„‡")]
        public Decimal? ‹KŠi•ÊŠ„‡ { get; set; }

        /// <summary>
        /// •â³Œã•ªŠ„Œ¸û—Ê‚Q
        /// </summary>
        [Column("•â³Œã•ªŠ„Œ¸û—Ê‚Q")]
        public Decimal? •â³Œã•ªŠ„Œ¸û—Ê‚Q { get; set; }

        /// <summary>
        /// •â³Œã•ªŠ„Œ¸û—Ê‚R
        /// </summary>
        [Column("•â³Œã•ªŠ„Œ¸û—Ê‚R")]
        public Decimal? •â³Œã•ªŠ„Œ¸û—Ê‚R { get; set; }

        /// <summary>
        /// •ªŠ„Œ¸û—Ê
        /// </summary>
        [Column("•ªŠ„Œ¸û—Ê")]
        public Decimal? •ªŠ„Œ¸û—Ê { get; set; }

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
