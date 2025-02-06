using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24140_’n‹æ•Ê•]‰¿î•ñ
    /// </summary>
    [Serializable]
    [Table("t_24140_’n‹æ•Ê•]‰¿î•ñ")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(‘å’n‹æƒR[ƒh), nameof(¬’n‹æƒR[ƒh), nameof(•âŠ„‡), nameof(—Ş‹æ•ª), nameof(‰c”_’²®ƒtƒ‰ƒO))]
    public class T24140’n‹æ•Ê•]‰¿î•ñ : ModelBase
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
        /// ‘å’n‹æƒR[ƒh
        /// </summary>
        [Required]
        [Column("‘å’n‹æƒR[ƒh", Order = 4)]
        [StringLength(2)]
        public string ‘å’n‹æƒR[ƒh { get; set; }

        /// <summary>
        /// ¬’n‹æƒR[ƒh
        /// </summary>
        [Required]
        [Column("¬’n‹æƒR[ƒh", Order = 5)]
        [StringLength(4)]
        public string ¬’n‹æƒR[ƒh { get; set; }

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
        /// Šî€¶Y‹àŠz
        /// </summary>
        [Column("Šî€¶Y‹àŠz")]
        public Decimal? Šî€¶Y‹àŠz { get; set; }

        /// <summary>
        /// ‹¤Ï‹àŠz
        /// </summary>
        [Column("‹¤Ï‹àŠz")]
        public Decimal? ‹¤Ï‹àŠz { get; set; }

        /// <summary>
        /// •]‰¿_ŒË”
        /// </summary>
        [Column("•]‰¿_ŒË”")]
        public Decimal? •]‰¿_ŒË” { get; set; }

        /// <summary>
        /// •]‰¿_ŒË”_ˆê•M‘S‘¹
        /// </summary>
        [Column("•]‰¿_ŒË”_ˆê•M‘S‘¹")]
        public Decimal? •]‰¿_ŒË”_ˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// •]‰¿_ŒË”_ˆê•M”¼‘¹
        /// </summary>
        [Column("•]‰¿_ŒË”_ˆê•M”¼‘¹")]
        public Decimal? •]‰¿_ŒË”_ˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// •]‰¿_ŒË”_‘Œv
        /// </summary>
        [Column("•]‰¿_ŒË”_‘Œv")]
        public Decimal? •]‰¿_ŒË”_‘Œv { get; set; }

        /// <summary>
        /// •]‰¿_–ÊÏ
        /// </summary>
        [Column("•]‰¿_–ÊÏ")]
        public Decimal? •]‰¿_–ÊÏ { get; set; }

        /// <summary>
        /// •]‰¿_–ÊÏ_ˆê•M‘S‘¹
        /// </summary>
        [Column("•]‰¿_–ÊÏ_ˆê•M‘S‘¹")]
        public Decimal? •]‰¿_–ÊÏ_ˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// •]‰¿_–ÊÏ_ˆê•M”¼‘¹
        /// </summary>
        [Column("•]‰¿_–ÊÏ_ˆê•M”¼‘¹")]
        public Decimal? •]‰¿_–ÊÏ_ˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// ¶Y‹àŠz‚ÌŒ¸­Šz
        /// </summary>
        [Column("¶Y‹àŠz‚ÌŒ¸­Šz")]
        public Decimal? ¶Y‹àŠz‚ÌŒ¸­Šz { get; set; }

        /// <summary>
        /// ¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M‘S‘¹
        /// </summary>
        [Column("¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M‘S‘¹")]
        public Decimal? ¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// ¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M”¼‘¹
        /// </summary>
        [Column("¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M”¼‘¹")]
        public Decimal? ¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_x•¥—¦’²®‘O
        /// </summary>
        [Column("x•¥‹¤Ï‹à_x•¥—¦’²®‘O")]
        public Decimal? x•¥‹¤Ï‹à_x•¥—¦’²®‘O { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_x•¥—¦’²®‘O_“à’´‰ß”íŠQ
        /// </summary>
        [Column("x•¥‹¤Ï‹à_x•¥—¦’²®‘O_“à’´‰ß”íŠQ")]
        public Decimal? x•¥‹¤Ï‹à_x•¥—¦’²®‘O_“à’´‰ß”íŠQ { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_x•¥—¦’²®‘O_“àˆê•M‘S‘¹
        /// </summary>
        [Column("x•¥‹¤Ï‹à_x•¥—¦’²®‘O_“àˆê•M‘S‘¹")]
        public Decimal? x•¥‹¤Ï‹à_x•¥—¦’²®‘O_“àˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_x•¥—¦’²®‘O_“àˆê•M”¼‘¹
        /// </summary>
        [Column("x•¥‹¤Ï‹à_x•¥—¦’²®‘O_“àˆê•M”¼‘¹")]
        public Decimal? x•¥‹¤Ï‹à_x•¥—¦’²®‘O_“àˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// •]‰¿_x•¥‹¤Ï‹à
        /// </summary>
        [Column("•]‰¿_x•¥‹¤Ï‹à")]
        public Decimal? •]‰¿_x•¥‹¤Ï‹à { get; set; }

        /// <summary>
        /// •]‰¿_x•¥‹¤Ï‹à_“à’´‰ß”íŠQ
        /// </summary>
        [Column("•]‰¿_x•¥‹¤Ï‹à_“à’´‰ß”íŠQ")]
        public Decimal? •]‰¿_x•¥‹¤Ï‹à_“à’´‰ß”íŠQ { get; set; }

        /// <summary>
        /// •]‰¿_x•¥‹¤Ï‹à_“àˆê•M‘S‘¹
        /// </summary>
        [Column("•]‰¿_x•¥‹¤Ï‹à_“àˆê•M‘S‘¹")]
        public Decimal? •]‰¿_x•¥‹¤Ï‹à_“àˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// •]‰¿_x•¥‹¤Ï‹à_“àˆê•M”¼‘¹
        /// </summary>
        [Column("•]‰¿_x•¥‹¤Ï‹à_“àˆê•M”¼‘¹")]
        public Decimal? •]‰¿_x•¥‹¤Ï‹à_“àˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// •]‰¿_Àx•¥‹¤Ï‹à
        /// </summary>
        [Column("•]‰¿_Àx•¥‹¤Ï‹à")]
        public Decimal? •]‰¿_Àx•¥‹¤Ï‹à { get; set; }

        /// <summary>
        /// •]‰¿_‹àŠz”íŠQ—¦
        /// </summary>
        [Column("•]‰¿_‹àŠz”íŠQ—¦")]
        public Decimal? •]‰¿_‹àŠz”íŠQ—¦ { get; set; }

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
