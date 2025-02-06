using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24175_“–‰•]‰¿‚î•ñWŒv
    /// </summary>
    [Serializable]
    [Table("t_24175_“–‰•]‰¿‚î•ñWŒv")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(­•{•ÛŒ¯”F’è‹æ•ª), nameof(¿‹‰ñ), nameof(•âŠ„‡), nameof(—Ş‹æ•ª), nameof(‰c”_’²®ƒtƒ‰ƒO))]
    public class T24175“–‰•]‰¿‚î•ñWŒv : ModelBase
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
        /// ­•{•ÛŒ¯”F’è‹æ•ª
        /// </summary>
        [Required]
        [Column("­•{•ÛŒ¯”F’è‹æ•ª", Order = 4)]
        [StringLength(4)]
        public string ­•{•ÛŒ¯”F’è‹æ•ª { get; set; }

        /// <summary>
        /// ¿‹‰ñ
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("¿‹‰ñ", Order = 5)]
        public short ¿‹‰ñ { get; set; }

        /// <summary>
        /// •âŠ„‡
        /// </summary>
        [Required]
        [Column("•âŠ„‡", Order = 6)]
        [StringLength(2)]
        public string •âŠ„‡ { get; set; }

        /// <summary>
        /// —Ş‹æ•ª
        /// </summary>
        [Required]
        [Column("—Ş‹æ•ª", Order = 7)]
        [StringLength(2)]
        public string —Ş‹æ•ª { get; set; }

        /// <summary>
        /// ‰c”_’²®ƒtƒ‰ƒO
        /// </summary>
        [Required]
        [Column("‰c”_’²®ƒtƒ‰ƒO", Order = 8)]
        [StringLength(1)]
        public string ‰c”_’²®ƒtƒ‰ƒO { get; set; }

        /// <summary>
        /// ˆøóŒË”
        /// </summary>
        [Column("ˆøóŒË”")]
        public Decimal? ˆøóŒË” { get; set; }

        /// <summary>
        /// ˆøó–ÊÏ
        /// </summary>
        [Column("ˆøó–ÊÏ")]
        public Decimal? ˆøó–ÊÏ { get; set; }

        /// <summary>
        /// ‹¤Ï‹àŠz
        /// </summary>
        [Column("‹¤Ï‹àŠz")]
        public Decimal? ‹¤Ï‹àŠz { get; set; }

        /// <summary>
        /// ”íŠQŒË”
        /// </summary>
        [Column("”íŠQŒË”")]
        public Decimal? ”íŠQŒË” { get; set; }

        /// <summary>
        /// x•¥‘ÎÛˆøó–ÊÏ
        /// </summary>
        [Column("x•¥‘ÎÛˆøó–ÊÏ")]
        public Decimal? x•¥‘ÎÛˆøó–ÊÏ { get; set; }

        /// <summary>
        /// Œ¸û—Ê
        /// </summary>
        [Column("Œ¸û—Ê")]
        public Decimal? Œ¸û—Ê { get; set; }

        /// <summary>
        /// ¶Y‹àŠz‚ÌŒ¸­Šz
        /// </summary>
        [Column("¶Y‹àŠz‚ÌŒ¸­Šz")]
        public Decimal? ¶Y‹àŠz‚ÌŒ¸­Šz { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹àŒ©Šz
        /// </summary>
        [Column("x•¥‹¤Ï‹àŒ©Šz")]
        public Decimal? x•¥‹¤Ï‹àŒ©Šz { get; set; }

        /// <summary>
        /// x•¥•ÛŒ¯‹àŒ©Šz
        /// </summary>
        [Column("x•¥•ÛŒ¯‹àŒ©Šz")]
        public Decimal? x•¥•ÛŒ¯‹àŒ©Šz { get; set; }

        /// <summary>
        /// ˆÙí•”•ª•ÛŒ¯‹àŒ©Šz
        /// </summary>
        [Column("ˆÙí•”•ª•ÛŒ¯‹àŒ©Šz")]
        public Decimal? ˆÙí•”•ª•ÛŒ¯‹àŒ©Šz { get; set; }

        /// <summary>
        /// x•¥Ä•ÛŒ¯‹àŒ©Šz
        /// </summary>
        [Column("x•¥Ä•ÛŒ¯‹àŒ©Šz")]
        public Decimal? x•¥Ä•ÛŒ¯‹àŒ©Šz { get; set; }

        /// <summary>
        /// Àˆøó‘g‡“™”
        /// </summary>
        [Column("Àˆøó‘g‡“™”")]
        public Decimal? Àˆøó‘g‡“™” { get; set; }

        /// <summary>
        /// ˆøó‘g‡“™”
        /// </summary>
        [Column("ˆøó‘g‡“™”")]
        public Decimal? ˆøó‘g‡“™” { get; set; }

        /// <summary>
        /// À”íŠQ‘g‡“™”
        /// </summary>
        [Column("À”íŠQ‘g‡“™”")]
        public Decimal? À”íŠQ‘g‡“™” { get; set; }

        /// <summary>
        /// ”íŠQ‘g‡“™”
        /// </summary>
        [Column("”íŠQ‘g‡“™”")]
        public Decimal? ”íŠQ‘g‡“™” { get; set; }

        /// <summary>
        /// ’ÊíĞŠQŒ©‘g‡“™”
        /// </summary>
        [Column("’ÊíĞŠQŒ©‘g‡“™”")]
        public Decimal? ’ÊíĞŠQŒ©‘g‡“™” { get; set; }

        /// <summary>
        /// ˆÙíĞŠQŒ©‘g‡“™”
        /// </summary>
        [Column("ˆÙíĞŠQŒ©‘g‡“™”")]
        public Decimal? ˆÙíĞŠQŒ©‘g‡“™” { get; set; }

        /// <summary>
        /// À–³”íŠQ‘g‡“™”
        /// </summary>
        [Column("À–³”íŠQ‘g‡“™”")]
        public Decimal? À–³”íŠQ‘g‡“™” { get; set; }

        /// <summary>
        /// –³”íŠQ‘g‡“™”
        /// </summary>
        [Column("–³”íŠQ‘g‡“™”")]
        public Decimal? –³”íŠQ‘g‡“™” { get; set; }

        /// <summary>
        /// ˜A‡‰ïˆÙíÓ”C•Û—L•ÛŒ¯‹àŠz
        /// </summary>
        [Column("˜A‡‰ïˆÙíÓ”C•Û—L•ÛŒ¯‹àŠz")]
        public Decimal? ˜A‡‰ïˆÙíÓ”C•Û—L•ÛŒ¯‹àŠz { get; set; }

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
