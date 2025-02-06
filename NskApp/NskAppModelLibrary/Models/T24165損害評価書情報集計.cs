using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24165_‘¹ŠQ•]‰¿‘î•ñWŒv
    /// </summary>
    [Serializable]
    [Table("t_24165_‘¹ŠQ•]‰¿‘î•ñWŒv")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(¿‹‰ñ), nameof(•âŠ„‡), nameof(—Ş‹æ•ª), nameof(‰c”_’²®ƒtƒ‰ƒO))]
    public class T24165‘¹ŠQ•]‰¿‘î•ñWŒv : ModelBase
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
        /// ¿‹‰ñ
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("¿‹‰ñ", Order = 4)]
        public short ¿‹‰ñ { get; set; }

        /// <summary>
        /// •âŠ„‡
        /// </summary>
        [Required]
        [Column("•âŠ„‡", Order = 5)]
        [StringLength(2)]
        public string •âŠ„‡ { get; set; }

        /// <summary>
        /// —Ş‹æ•ª
        /// </summary>
        [Required]
        [Column("—Ş‹æ•ª", Order = 6)]
        [StringLength(2)]
        public string —Ş‹æ•ª { get; set; }

        /// <summary>
        /// ‰c”_’²®ƒtƒ‰ƒO
        /// </summary>
        [Required]
        [Column("‰c”_’²®ƒtƒ‰ƒO", Order = 7)]
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
        /// Šî€ûŠn—Ê
        /// </summary>
        [Column("Šî€ûŠn—Ê")]
        public Decimal? Šî€ûŠn—Ê { get; set; }

        /// <summary>
        /// Šî€¶Y‹àŠz
        /// </summary>
        [Column("Šî€¶Y‹àŠz")]
        public Decimal? Šî€¶Y‹àŠz { get; set; }

        /// <summary>
        /// ‹¤ÏŒÀ“xŠz
        /// </summary>
        [Column("‹¤ÏŒÀ“xŠz")]
        public Decimal? ‹¤ÏŒÀ“xŠz { get; set; }

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
        /// ‹¤Ï‹àx•¥‘ÎÛ_ˆøó–ÊÏ
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_ˆøó–ÊÏ")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_ˆøó–ÊÏ { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_Šî€ûŠn—Ê
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_Šî€ûŠn—Ê")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_Šî€ûŠn—Ê { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_Šî€¶Y‹àŠz
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_Šî€¶Y‹àŠz")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_Šî€¶Y‹àŠz { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_‹¤ÏŒÀ“xŠz
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_‹¤ÏŒÀ“xŠz")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_‹¤ÏŒÀ“xŠz { get; set; }

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
        /// x•¥‹¤Ï‹à
        /// </summary>
        [Column("x•¥‹¤Ï‹à")]
        public Decimal? x•¥‹¤Ï‹à { get; set; }

        /// <summary>
        /// x•¥•ÛŒ¯‹à
        /// </summary>
        [Column("x•¥•ÛŒ¯‹à")]
        public Decimal? x•¥•ÛŒ¯‹à { get; set; }

        /// <summary>
        /// x•¥Ä•ÛŒ¯‹à_‰c”_’²®‘O
        /// </summary>
        [Column("x•¥Ä•ÛŒ¯‹à_‰c”_’²®‘O")]
        public Decimal? x•¥Ä•ÛŒ¯‹à_‰c”_’²®‘O { get; set; }

        /// <summary>
        /// x•¥Ä•ÛŒ¯‹à
        /// </summary>
        [Column("x•¥Ä•ÛŒ¯‹à")]
        public Decimal? x•¥Ä•ÛŒ¯‹à { get; set; }

        /// <summary>
        /// ’ÊíÓ”C‹¤Ï‹àŠz
        /// </summary>
        [Column("’ÊíÓ”C‹¤Ï‹àŠz")]
        public Decimal? ’ÊíÓ”C‹¤Ï‹àŠz { get; set; }

        /// <summary>
        /// ˜A‡‰ïˆÙíÓ”C•Û—L•ÛŒ¯‹àŠz
        /// </summary>
        [Column("˜A‡‰ïˆÙíÓ”C•Û—L•ÛŒ¯‹àŠz")]
        public Decimal? ˜A‡‰ïˆÙíÓ”C•Û—L•ÛŒ¯‹àŠz { get; set; }

        /// <summary>
        /// ˜A‡‰ïè•ÛŒ¯—¿
        /// </summary>
        [Column("˜A‡‰ïè•ÛŒ¯—¿")]
        public Decimal? ˜A‡‰ïè•ÛŒ¯—¿ { get; set; }

        /// <summary>
        /// ”_ì•¨’Êí•”•ª•ÛŒ¯‹à
        /// </summary>
        [Column("”_ì•¨’Êí•”•ª•ÛŒ¯‹à")]
        public Decimal? ”_ì•¨’Êí•”•ª•ÛŒ¯‹à { get; set; }

        /// <summary>
        /// ”_ì•¨ˆÙí•”•ª•ÛŒ¯‹à
        /// </summary>
        [Column("”_ì•¨ˆÙí•”•ª•ÛŒ¯‹à")]
        public Decimal? ”_ì•¨ˆÙí•”•ª•ÛŒ¯‹à { get; set; }

        /// <summary>
        /// ˜A‡‰ïˆÙíÓ”Cx•¥•ÛŒ¯‹à
        /// </summary>
        [Column("˜A‡‰ïˆÙíÓ”Cx•¥•ÛŒ¯‹à")]
        public Decimal? ˜A‡‰ïˆÙíÓ”Cx•¥•ÛŒ¯‹à { get; set; }

        /// <summary>
        /// ‹àŠz”íŠQ—¦
        /// </summary>
        [Column("‹àŠz”íŠQ—¦")]
        public Decimal? ‹àŠz”íŠQ—¦ { get; set; }

        /// <summary>
        /// ì¬‹æ•ª
        /// </summary>
        [Column("ì¬‹æ•ª")]
        [StringLength(1)]
        public string ì¬‹æ•ª { get; set; }

        /// <summary>
        /// ˆøó‘g‡“™”
        /// </summary>
        [Column("ˆøó‘g‡“™”")]
        public Decimal? ˆøó‘g‡“™” { get; set; }

        /// <summary>
        /// Àˆøó‘g‡“™”
        /// </summary>
        [Column("Àˆøó‘g‡“™”")]
        public Decimal? Àˆøó‘g‡“™” { get; set; }

        /// <summary>
        /// ”íŠQ‘g‡“™”
        /// </summary>
        [Column("”íŠQ‘g‡“™”")]
        public Decimal? ”íŠQ‘g‡“™” { get; set; }

        /// <summary>
        /// À”íŠQ‘g‡“™”
        /// </summary>
        [Column("À”íŠQ‘g‡“™”")]
        public Decimal? À”íŠQ‘g‡“™” { get; set; }

        /// <summary>
        /// –³”íŠQ‘g‡“™”
        /// </summary>
        [Column("–³”íŠQ‘g‡“™”")]
        public Decimal? –³”íŠQ‘g‡“™” { get; set; }

        /// <summary>
        /// À–³”íŠQ‘g‡“™”
        /// </summary>
        [Column("À–³”íŠQ‘g‡“™”")]
        public Decimal? À–³”íŠQ‘g‡“™” { get; set; }

        /// <summary>
        /// –ÆÓŒË”
        /// </summary>
        [Column("–ÆÓŒË”")]
        public Decimal? –ÆÓŒË” { get; set; }

        /// <summary>
        /// –ÆÓŠz
        /// </summary>
        [Column("–ÆÓŠz")]
        public Decimal? –ÆÓŠz { get; set; }

        /// <summary>
        /// x•¥Ä•ÛŒ¯‹àŠùó—ÌŠz
        /// </summary>
        [Column("x•¥Ä•ÛŒ¯‹àŠùó—ÌŠz")]
        public Decimal? x•¥Ä•ÛŒ¯‹àŠùó—ÌŠz { get; set; }

        /// <summary>
        /// x•¥Ä•ÛŒ¯‹à¡‰ñ¿‹Šz
        /// </summary>
        [Column("x•¥Ä•ÛŒ¯‹à¡‰ñ¿‹Šz")]
        public Decimal? x•¥Ä•ÛŒ¯‹à¡‰ñ¿‹Šz { get; set; }

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
