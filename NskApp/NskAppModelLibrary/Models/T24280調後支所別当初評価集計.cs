using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24280_’²ŒãxŠ•Ê“–‰•]‰¿WŒv
    /// </summary>
    [Serializable]
    [Table("t_24280_’²ŒãxŠ•Ê“–‰•]‰¿WŒv")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(—Ş‹æ•ª), nameof(xŠƒR[ƒh), nameof(ˆøó•û®), nameof(•âŠ„‡ƒR[ƒh), nameof(­•{•ÛŒ¯”F’è‹æ•ª))]
    public class T24280’²ŒãxŠ•Ê“–‰•]‰¿WŒv : ModelBase
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
        /// xŠƒR[ƒh
        /// </summary>
        [Required]
        [Column("xŠƒR[ƒh", Order = 5)]
        [StringLength(2)]
        public string xŠƒR[ƒh { get; set; }

        /// <summary>
        /// ˆøó•û®
        /// </summary>
        [Required]
        [Column("ˆøó•û®", Order = 6)]
        [StringLength(1)]
        public string ˆøó•û® { get; set; }

        /// <summary>
        /// •âŠ„‡ƒR[ƒh
        /// </summary>
        [Required]
        [Column("•âŠ„‡ƒR[ƒh", Order = 7)]
        [StringLength(2)]
        public string •âŠ„‡ƒR[ƒh { get; set; }

        /// <summary>
        /// ­•{•ÛŒ¯”F’è‹æ•ª
        /// </summary>
        [Required]
        [Column("­•{•ÛŒ¯”F’è‹æ•ª", Order = 8)]
        [StringLength(4)]
        public string ­•{•ÛŒ¯”F’è‹æ•ª { get; set; }

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
        /// ‘S•M’²¸k’n–ÊÏ
        /// </summary>
        [Column("‘S•M’²¸k’n–ÊÏ")]
        public Decimal? ‘S•M’²¸k’n–ÊÏ { get; set; }

        /// <summary>
        /// ”äŠr‘O’´‰ß”íŠQ•M”
        /// </summary>
        [Column("”äŠr‘O’´‰ß”íŠQ•M”")]
        public Decimal? ”äŠr‘O’´‰ß”íŠQ•M” { get; set; }

        /// <summary>
        /// ”äŠr‘O’´‰ß”íŠQŒË”
        /// </summary>
        [Column("”äŠr‘O’´‰ß”íŠQŒË”")]
        public Decimal? ”äŠr‘O’´‰ß”íŠQŒË” { get; set; }

        /// <summary>
        /// ”äŠr‘O’´‰ß”íŠQ–ÊÏ
        /// </summary>
        [Column("”äŠr‘O’´‰ß”íŠQ–ÊÏ")]
        public Decimal? ”äŠr‘O’´‰ß”íŠQ–ÊÏ { get; set; }

        /// <summary>
        /// ”äŠr‘O’´‰ß”íŠQ‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("”äŠr‘O’´‰ß”íŠQ‹¤ÏŒ¸û—Ê")]
        public Decimal? ”äŠr‘O’´‰ß”íŠQ‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// ”äŠr‘O’´‰ß”íŠQx•¥‹¤Ï‹àŒ©Šz
        /// </summary>
        [Column("”äŠr‘O’´‰ß”íŠQx•¥‹¤Ï‹àŒ©Šz")]
        public Decimal? ”äŠr‘O’´‰ß”íŠQx•¥‹¤Ï‹àŒ©Šz { get; set; }

        /// <summary>
        /// ’´‰ß”íŠQ•M”
        /// </summary>
        [Column("’´‰ß”íŠQ•M”")]
        public Decimal? ’´‰ß”íŠQ•M” { get; set; }

        /// <summary>
        /// ’´‰ß”íŠQŒË”
        /// </summary>
        [Column("’´‰ß”íŠQŒË”")]
        public Decimal? ’´‰ß”íŠQŒË” { get; set; }

        /// <summary>
        /// ’´‰ß”íŠQ–ÊÏ
        /// </summary>
        [Column("’´‰ß”íŠQ–ÊÏ")]
        public Decimal? ’´‰ß”íŠQ–ÊÏ { get; set; }

        /// <summary>
        /// ’´‰ß”íŠQ‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("’´‰ß”íŠQ‹¤ÏŒ¸û—Ê")]
        public Decimal? ’´‰ß”íŠQ‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// ’´‰ß”íŠQx•¥‹¤Ï‹àŒ©Šz
        /// </summary>
        [Column("’´‰ß”íŠQx•¥‹¤Ï‹àŒ©Šz")]
        public Decimal? ’´‰ß”íŠQx•¥‹¤Ï‹àŒ©Šz { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹ŒË”
        /// </summary>
        [Column("ˆê•M‘S‘¹ŒË”")]
        public Decimal? ˆê•M‘S‘¹ŒË” { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹”íŠQ–ÊÏ
        /// </summary>
        [Column("ˆê•M‘S‘¹”íŠQ–ÊÏ")]
        public Decimal? ˆê•M‘S‘¹”íŠQ–ÊÏ { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("ˆê•M‘S‘¹‹¤ÏŒ¸û—Ê")]
        public Decimal? ˆê•M‘S‘¹‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M‘S‘¹x•¥‹¤Ï‹àŒ©Šz
        /// </summary>
        [Column("ˆê•M‘S‘¹x•¥‹¤Ï‹àŒ©Šz")]
        public Decimal? ˆê•M‘S‘¹x•¥‹¤Ï‹àŒ©Šz { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹ŒË”
        /// </summary>
        [Column("ˆê•M”¼‘¹ŒË”")]
        public Decimal? ˆê•M”¼‘¹ŒË” { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹”íŠQ–ÊÏ
        /// </summary>
        [Column("ˆê•M”¼‘¹”íŠQ–ÊÏ")]
        public Decimal? ˆê•M”¼‘¹”íŠQ–ÊÏ { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("ˆê•M”¼‘¹‹¤ÏŒ¸û—Ê")]
        public Decimal? ˆê•M”¼‘¹‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M”¼‘¹x•¥‹¤Ï‹àŒ©Šz
        /// </summary>
        [Column("ˆê•M”¼‘¹x•¥‹¤Ï‹àŒ©Šz")]
        public Decimal? ˆê•M”¼‘¹x•¥‹¤Ï‹àŒ©Šz { get; set; }

        /// <summary>
        /// ˆê•M“Á—áŒË”
        /// </summary>
        [Column("ˆê•M“Á—áŒË”")]
        public Decimal? ˆê•M“Á—áŒË” { get; set; }

        /// <summary>
        /// ˆê•M“Á—á”íŠQ–ÊÏ
        /// </summary>
        [Column("ˆê•M“Á—á”íŠQ–ÊÏ")]
        public Decimal? ˆê•M“Á—á”íŠQ–ÊÏ { get; set; }

        /// <summary>
        /// ˆê•M“Á—á‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("ˆê•M“Á—á‹¤ÏŒ¸û—Ê")]
        public Decimal? ˆê•M“Á—á‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// ˆê•M“Á—áx•¥‹¤Ï‹àŒ©Šz
        /// </summary>
        [Column("ˆê•M“Á—áx•¥‹¤Ï‹àŒ©Šz")]
        public Decimal? ˆê•M“Á—áx•¥‹¤Ï‹àŒ©Šz { get; set; }

        /// <summary>
        /// x•¥‘ÎÛ”íŠQŒË”
        /// </summary>
        [Column("x•¥‘ÎÛ”íŠQŒË”")]
        public Decimal? x•¥‘ÎÛ”íŠQŒË” { get; set; }

        /// <summary>
        /// x•¥‘ÎÛ”íŠQ–ÊÏ
        /// </summary>
        [Column("x•¥‘ÎÛ”íŠQ–ÊÏ")]
        public Decimal? x•¥‘ÎÛ”íŠQ–ÊÏ { get; set; }

        /// <summary>
        /// x•¥‘ÎÛ”íŠQ‹¤ÏŒ¸û—Ê
        /// </summary>
        [Column("x•¥‘ÎÛ”íŠQ‹¤ÏŒ¸û—Ê")]
        public Decimal? x•¥‘ÎÛ”íŠQ‹¤ÏŒ¸û—Ê { get; set; }

        /// <summary>
        /// x•¥‘ÎÛx•¥‹¤Ï‹àŒ©Šz
        /// </summary>
        [Column("x•¥‘ÎÛx•¥‹¤Ï‹àŒ©Šz")]
        public Decimal? x•¥‘ÎÛx•¥‹¤Ï‹àŒ©Šz { get; set; }

        /// <summary>
        /// ’ÊíÓ”C‹¤Ï‹àŠz
        /// </summary>
        [Column("’ÊíÓ”C‹¤Ï‹àŠz")]
        public Decimal? ’ÊíÓ”C‹¤Ï‹àŠz { get; set; }

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
