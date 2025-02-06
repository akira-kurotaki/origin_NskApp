using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24030_“–‰ŒvZŒo‰ß‘g‡ˆõ“™
    /// </summary>
    [Serializable]
    [Table("t_24030_“–‰ŒvZŒo‰ß‘g‡ˆõ“™")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(—Ş‹æ•ª), nameof(‘g‡ˆõ“™ƒR[ƒh), nameof(“Œv’PˆÊ’nˆæƒR[ƒh), nameof(—p“r‹æ•ª), nameof(ì•tŠú), nameof(’²®‘ÎÛ‹æ•ª))]
    public class T24030“–‰ŒvZŒo‰ß‘g‡ˆõ“™ : ModelBase
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
        /// —Ş‹æ•ª
        /// </summary>
        [Required]
        [Column("—Ş‹æ•ª", Order = 4)]
        [StringLength(2)]
        public string —Ş‹æ•ª { get; set; }

        /// <summary>
        /// ‘g‡ˆõ“™ƒR[ƒh
        /// </summary>
        [Required]
        [Column("‘g‡ˆõ“™ƒR[ƒh", Order = 5)]
        [StringLength(13)]
        public string ‘g‡ˆõ“™ƒR[ƒh { get; set; }

        /// <summary>
        /// “Œv’PˆÊ’nˆæƒR[ƒh
        /// </summary>
        [Required]
        [Column("“Œv’PˆÊ’nˆæƒR[ƒh", Order = 6)]
        [StringLength(5)]
        public string “Œv’PˆÊ’nˆæƒR[ƒh { get; set; }

        /// <summary>
        /// —p“r‹æ•ª
        /// </summary>
        [Required]
        [Column("—p“r‹æ•ª", Order = 7)]
        [StringLength(3)]
        public string —p“r‹æ•ª { get; set; }

        /// <summary>
        /// ì•tŠú
        /// </summary>
        [Required]
        [Column("ì•tŠú", Order = 8)]
        [StringLength(1)]
        public string ì•tŠú { get; set; }

        /// <summary>
        /// ’²®‘ÎÛ‹æ•ª
        /// </summary>
        [Required]
        [Column("’²®‘ÎÛ‹æ•ª", Order = 9)]
        [StringLength(1)]
        public string ’²®‘ÎÛ‹æ•ª { get; set; }

        /// <summary>
        /// ‘S‘ŠEŒvZ•û–@
        /// </summary>
        [Column("‘S‘ŠEŒvZ•û–@")]
        [StringLength(1)]
        public string ‘S‘ŠEŒvZ•û–@ { get; set; }

        /// <summary>
        /// ‰c”_‘ÎÛŠOƒtƒ‰ƒO
        /// </summary>
        [Column("‰c”_‘ÎÛŠOƒtƒ‰ƒO")]
        [StringLength(1)]
        public string ‰c”_‘ÎÛŠOƒtƒ‰ƒO { get; set; }

        /// <summary>
        /// ’Sè”_‰Æ‹æ•ª
        /// </summary>
        [Column("’Sè”_‰Æ‹æ•ª")]
        [StringLength(1)]
        public string ’Sè”_‰Æ‹æ•ª { get; set; }

        /// <summary>
        /// Šî€ûŠn—Ê
        /// </summary>
        [Column("Šî€ûŠn—Ê")]
        public Decimal? Šî€ûŠn—Ê { get; set; }

        /// <summary>
        /// ˆøóû—Ê
        /// </summary>
        [Column("ˆøóû—Ê")]
        public Decimal? ˆøóû—Ê { get; set; }

        /// <summary>
        /// “K—p’P“–‹¤Ï‹àŠz
        /// </summary>
        [Column("“K—p’P“–‹¤Ï‹àŠz")]
        public Decimal? “K—p’P“–‹¤Ï‹àŠz { get; set; }

        /// <summary>
        /// »ŠF•M”
        /// </summary>
        [Column("»ŠF•M”")]
        public Decimal? »ŠF•M” { get; set; }

        /// <summary>
        /// »ŠF•M–ÊÏ
        /// </summary>
        [Column("»ŠF•M–ÊÏ")]
        public Decimal? »ŠF•M–ÊÏ { get; set; }

        /// <summary>
        /// ˆê”Ê”íŠQ•M”
        /// </summary>
        [Column("ˆê”Ê”íŠQ•M”")]
        public Decimal? ˆê”Ê”íŠQ•M” { get; set; }

        /// <summary>
        /// ˆê”Ê”íŠQ–ÊÏ
        /// </summary>
        [Column("ˆê”Ê”íŠQ–ÊÏ")]
        public Decimal? ˆê”Ê”íŠQ–ÊÏ { get; set; }

        /// <summary>
        /// ˆê”Ê”íŠQûŠn—Ê
        /// </summary>
        [Column("ˆê”Ê”íŠQûŠn—Ê")]
        public Decimal? ˆê”Ê”íŠQûŠn—Ê { get; set; }

        /// <summary>
        /// ˆê”Ê”íŠQŒ¸û—Ê
        /// </summary>
        [Column("ˆê”Ê”íŠQŒ¸û—Ê")]
        public Decimal? ˆê”Ê”íŠQŒ¸û—Ê { get; set; }

        /// <summary>
        /// ŠF–³•M”
        /// </summary>
        [Column("ŠF–³•M”")]
        public Decimal? ŠF–³•M” { get; set; }

        /// <summary>
        /// ŠF–³–ÊÏ
        /// </summary>
        [Column("ŠF–³–ÊÏ")]
        public Decimal? ŠF–³–ÊÏ { get; set; }

        /// <summary>
        /// ŠF–³ûŠn—Ê
        /// </summary>
        [Column("ŠF–³ûŠn—Ê")]
        public Decimal? ŠF–³ûŠn—Ê { get; set; }

        /// <summary>
        /// ŠF–³Œ¸û—Ê
        /// </summary>
        [Column("ŠF–³Œ¸û—Ê")]
        public Decimal? ŠF–³Œ¸û—Ê { get; set; }

        /// <summary>
        /// •s”\•M”
        /// </summary>
        [Column("•s”\•M”")]
        public Decimal? •s”\•M” { get; set; }

        /// <summary>
        /// •s”\–ÊÏ
        /// </summary>
        [Column("•s”\–ÊÏ")]
        public Decimal? •s”\–ÊÏ { get; set; }

        /// <summary>
        /// •s”\ûŠn—Ê
        /// </summary>
        [Column("•s”\ûŠn—Ê")]
        public Decimal? •s”\ûŠn—Ê { get; set; }

        /// <summary>
        /// •s”\Œ¸û—Ê
        /// </summary>
        [Column("•s”\Œ¸û—Ê")]
        public Decimal? •s”\Œ¸û—Ê { get; set; }

        /// <summary>
        /// “]ì“™•M”
        /// </summary>
        [Column("“]ì“™•M”")]
        public Decimal? “]ì“™•M” { get; set; }

        /// <summary>
        /// “]ì“™–ÊÏ
        /// </summary>
        [Column("“]ì“™–ÊÏ")]
        public Decimal? “]ì“™–ÊÏ { get; set; }

        /// <summary>
        /// “]ì“™ûŠn—Ê
        /// </summary>
        [Column("“]ì“™ûŠn—Ê")]
        public Decimal? “]ì“™ûŠn—Ê { get; set; }

        /// <summary>
        /// “]ì“™Œ¸û—Ê
        /// </summary>
        [Column("“]ì“™Œ¸û—Ê")]
        public Decimal? “]ì“™Œ¸û—Ê { get; set; }

        /// <summary>
        /// •ªŠ„Œ¸û—Ê
        /// </summary>
        [Column("•ªŠ„Œ¸û—Ê")]
        public Decimal? •ªŠ„Œ¸û—Ê { get; set; }

        /// <summary>
        /// ‘S”’²¸ûŠn—Ê
        /// </summary>
        [Column("‘S”’²¸ûŠn—Ê")]
        public Decimal? ‘S”’²¸ûŠn—Ê { get; set; }

        /// <summary>
        /// •s”\k’n”À“üûŠn—Ê
        /// </summary>
        [Column("•s”\k’n”À“üûŠn—Ê")]
        public Decimal? •s”\k’n”À“üûŠn—Ê { get; set; }

        /// <summary>
        /// •s”\k’n”À“üûŠn—Ê•â³—Ê
        /// </summary>
        [Column("•s”\k’n”À“üûŠn—Ê•â³—Ê")]
        public Decimal? •s”\k’n”À“üûŠn—Ê•â³—Ê { get; set; }

        /// <summary>
        /// ‘g‡ˆõ“™ûŠn—Ê•â³—Ê
        /// </summary>
        [Column("‘g‡ˆõ“™ûŠn—Ê•â³—Ê")]
        public Decimal? ‘g‡ˆõ“™ûŠn—Ê•â³—Ê { get; set; }

        /// <summary>
        /// ’¼Ú{İ”À“üûŠn—Ê
        /// </summary>
        [Column("’¼Ú{İ”À“üûŠn—Ê")]
        public Decimal? ’¼Ú{İ”À“üûŠn—Ê { get; set; }

        /// <summary>
        /// ûŠn—Ê
        /// </summary>
        [Column("ûŠn—Ê")]
        public Decimal? ûŠn—Ê { get; set; }

        /// <summary>
        /// Œ¸û—Ê
        /// </summary>
        [Column("Œ¸û—Ê")]
        public Decimal? Œ¸û—Ê { get; set; }

        /// <summary>
        /// ’´‰ß”íŠQ‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("’´‰ß”íŠQ‹¤ÏŒ¸û—Ê")]
        public Decimal? ’´‰ß”íŠQ‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹ŠF–³•M”
        /// </summary>
        [Column("ˆê•M‘S‘¹ŠF–³•M”")]
        public Decimal? ˆê•M‘S‘¹ŠF–³•M” { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹ŠF–³–ÊÏ
        /// </summary>
        [Column("ˆê•M‘S‘¹ŠF–³–ÊÏ")]
        public Decimal? ˆê•M‘S‘¹ŠF–³–ÊÏ { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹ŠF–³Šî€ûŠn—Ê
        /// </summary>
        [Column("ˆê•M‘S‘¹ŠF–³Šî€ûŠn—Ê")]
        public Decimal? ˆê•M‘S‘¹ŠF–³Šî€ûŠn—Ê { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹ŠF–³Œ¸û—Ê
        /// </summary>
        [Column("ˆê•M‘S‘¹ŠF–³Œ¸û—Ê")]
        public Decimal? ˆê•M‘S‘¹ŠF–³Œ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹•s”\•M”
        /// </summary>
        [Column("ˆê•M‘S‘¹•s”\•M”")]
        public Decimal? ˆê•M‘S‘¹•s”\•M” { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹•s”\–ÊÏ
        /// </summary>
        [Column("ˆê•M‘S‘¹•s”\–ÊÏ")]
        public Decimal? ˆê•M‘S‘¹•s”\–ÊÏ { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹•s”\Šî€ûŠn—Ê
        /// </summary>
        [Column("ˆê•M‘S‘¹•s”\Šî€ûŠn—Ê")]
        public Decimal? ˆê•M‘S‘¹•s”\Šî€ûŠn—Ê { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹•s”\Œ¸û—Ê
        /// </summary>
        [Column("ˆê•M‘S‘¹•s”\Œ¸û—Ê")]
        public Decimal? ˆê•M‘S‘¹•s”\Œ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹x•¥ŠJnŒ¸û—Ê
        /// </summary>
        [Column("ˆê•M‘S‘¹x•¥ŠJnŒ¸û—Ê")]
        public Decimal? ˆê•M‘S‘¹x•¥ŠJnŒ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("ˆê•M‘S‘¹‹¤ÏŒ¸û—Ê")]
        public Decimal? ˆê•M‘S‘¹‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹‹¤Ï‹à
        /// </summary>
        [Column("ˆê•M‘S‘¹‹¤Ï‹à")]
        public Decimal? ˆê•M‘S‘¹‹¤Ï‹à { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹”íŠQ•M”
        /// </summary>
        [Column("ˆê•M”¼‘¹”íŠQ•M”")]
        public Decimal? ˆê•M”¼‘¹”íŠQ•M” { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹”íŠQ–ÊÏ
        /// </summary>
        [Column("ˆê•M”¼‘¹”íŠQ–ÊÏ")]
        public Decimal? ˆê•M”¼‘¹”íŠQ–ÊÏ { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹”íŠQŠî€ûŠn—Ê
        /// </summary>
        [Column("ˆê•M”¼‘¹”íŠQŠî€ûŠn—Ê")]
        public Decimal? ˆê•M”¼‘¹”íŠQŠî€ûŠn—Ê { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹”íŠQŒ¸û—Ê
        /// </summary>
        [Column("ˆê•M”¼‘¹”íŠQŒ¸û—Ê")]
        public Decimal? ˆê•M”¼‘¹”íŠQŒ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹x•¥ŠJnŒ¸û—Ê
        /// </summary>
        [Column("ˆê•M”¼‘¹x•¥ŠJnŒ¸û—Ê")]
        public Decimal? ˆê•M”¼‘¹x•¥ŠJnŒ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("ˆê•M”¼‘¹‹¤ÏŒ¸û—Ê")]
        public Decimal? ˆê•M”¼‘¹‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹‹¤Ï‹à
        /// </summary>
        [Column("ˆê•M”¼‘¹‹¤Ï‹à")]
        public Decimal? ˆê•M”¼‘¹‹¤Ï‹à { get; set; }

        /// <summary>
        /// ˆê•M‘S”¼‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("ˆê•M‘S”¼‹¤ÏŒ¸û—Ê")]
        public Decimal? ˆê•M‘S”¼‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// ”íŠQ‹æ•ª
        /// </summary>
        [Column("”íŠQ‹æ•ª")]
        [StringLength(1)]
        public string ”íŠQ‹æ•ª { get; set; }

        /// <summary>
        /// “–‰”íŠQ•M”
        /// </summary>
        [Column("“–‰”íŠQ•M”")]
        public Decimal? “–‰”íŠQ•M” { get; set; }

        /// <summary>
        /// “–‰”íŠQ–ÊÏ
        /// </summary>
        [Column("“–‰”íŠQ–ÊÏ")]
        public Decimal? “–‰”íŠQ–ÊÏ { get; set; }

        /// <summary>
        /// “–‰‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("“–‰‹¤ÏŒ¸û—Ê")]
        public Decimal? “–‰‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// “–‰‹¤Ï‹àŒ©Šz
        /// </summary>
        [Column("“–‰‹¤Ï‹àŒ©Šz")]
        public Decimal? “–‰‹¤Ï‹àŒ©Šz { get; set; }

        /// <summary>
        /// “–‰•ªŠ„Œ¸û—Ê
        /// </summary>
        [Column("“–‰•ªŠ„Œ¸û—Ê")]
        public Decimal? “–‰•ªŠ„Œ¸û—Ê { get; set; }

        /// <summary>
        /// ‘ÎÛˆøó–ÊÏ
        /// </summary>
        [Column("‘ÎÛˆøó–ÊÏ")]
        public Decimal? ‘ÎÛˆøó–ÊÏ { get; set; }

        /// <summary>
        /// “–”NûŠn—Ê
        /// </summary>
        [Column("“–”NûŠn—Ê")]
        public Decimal? “–”NûŠn—Ê { get; set; }

        /// <summary>
        /// ”íŠQŠOŠî€ûŠn—Ê
        /// </summary>
        [Column("”íŠQŠOŠî€ûŠn—Ê")]
        public Decimal? ”íŠQŠOŠî€ûŠn—Ê { get; set; }

        /// <summary>
        /// ‹¤Ï’P‰¿‡ˆÊ’´
        /// </summary>
        [Column("‹¤Ï’P‰¿‡ˆÊ’´")]
        public Decimal? ‹¤Ï’P‰¿‡ˆÊ’´ { get; set; }

        /// <summary>
        /// ‹¤Ï’P‰¿’´
        /// </summary>
        [Column("‹¤Ï’P‰¿’´")]
        public Decimal? ‹¤Ï’P‰¿’´ { get; set; }

        /// <summary>
        /// ”—Ê•¥‘Š“–Šz
        /// </summary>
        [Column("”—Ê•¥‘Š“–Šz")]
        public Decimal? ”—Ê•¥‘Š“–Šz { get; set; }

        /// <summary>
        /// ¦’P‰¿’´Å‚Šz
        /// </summary>
        [Column("¦’P‰¿’´Å‚Šz")]
        public Decimal? ¦’P‰¿’´Å‚Šz { get; set; }

        /// <summary>
        /// ¦’P‰¿‰ºÅ‚Šz
        /// </summary>
        [Column("¦’P‰¿‰ºÅ‚Šz")]
        public Decimal? ¦’P‰¿‰ºÅ‚Šz { get; set; }

        /// <summary>
        /// ”—Ê•¥’P‰¿
        /// </summary>
        [Column("”—Ê•¥’P‰¿")]
        public Decimal? ”—Ê•¥’P‰¿ { get; set; }

        /// <summary>
        /// •ªŠò’Pû
        /// </summary>
        [Column("•ªŠò’Pû")]
        public Decimal? •ªŠò’Pû { get; set; }

        /// <summary>
        /// •ªŠòû—Ê
        /// </summary>
        [Column("•ªŠòû—Ê")]
        public Decimal? •ªŠòû—Ê { get; set; }

        /// <summary>
        /// •ªŠò’´
        /// </summary>
        [Column("•ªŠò’´")]
        public Decimal? •ªŠò’´ { get; set; }

        /// <summary>
        /// •ªŠòˆÈ‰º
        /// </summary>
        [Column("•ªŠòˆÈ‰º")]
        public Decimal? •ªŠòˆÈ‰º { get; set; }

        /// <summary>
        /// ’²®‘ÎÛûŠn—Ê
        /// </summary>
        [Column("’²®‘ÎÛûŠn—Ê")]
        public Decimal? ’²®‘ÎÛûŠn—Ê { get; set; }

        /// <summary>
        /// ’²®‘ÎÛŠOûŠn—Ê
        /// </summary>
        [Column("’²®‘ÎÛŠOûŠn—Ê")]
        public Decimal? ’²®‘ÎÛŠOûŠn—Ê { get; set; }

        /// <summary>
        /// ’²®‘O“–”NûŠn—Ê
        /// </summary>
        [Column("’²®‘O“–”NûŠn—Ê")]
        public Decimal? ’²®‘O“–”NûŠn—Ê { get; set; }

        /// <summary>
        /// ’²®Œã“–”NûŠn—Ê
        /// </summary>
        [Column("’²®Œã“–”NûŠn—Ê")]
        public Decimal? ’²®Œã“–”NûŠn—Ê { get; set; }

        /// <summary>
        /// ‰c”_Œp‘±’P‰¿
        /// </summary>
        [Column("‰c”_Œp‘±’P‰¿")]
        public Decimal? ‰c”_Œp‘±’P‰¿ { get; set; }

        /// <summary>
        /// ˆøó•û®
        /// </summary>
        [Column("ˆøó•û®")]
        [StringLength(1)]
        public string ˆøó•û® { get; set; }

        /// <summary>
        /// “Á–ñ‹æ•ª
        /// </summary>
        [Column("“Á–ñ‹æ•ª")]
        [StringLength(1)]
        public string “Á–ñ‹æ•ª { get; set; }

        /// <summary>
        /// •âŠ„‡ƒR[ƒh
        /// </summary>
        [Column("•âŠ„‡ƒR[ƒh")]
        [StringLength(2)]
        public string •âŠ„‡ƒR[ƒh { get; set; }

        /// <summary>
        /// ‡•¹¯•ÊƒR[ƒh
        /// </summary>
        [Column("‡•¹¯•ÊƒR[ƒh")]
        [StringLength(3)]
        public string ‡•¹¯•ÊƒR[ƒh { get; set; }

        /// <summary>
        /// ûŠn—ÊŠm”F•û–@
        /// </summary>
        [Column("ûŠn—ÊŠm”F•û–@")]
        [StringLength(2)]
        public string ûŠn—ÊŠm”F•û–@ { get; set; }

        /// <summary>
        /// “Œv•]‰¿’Pû
        /// </summary>
        [Column("“Œv•]‰¿’Pû")]
        public Decimal? “Œv•]‰¿’Pû { get; set; }

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
