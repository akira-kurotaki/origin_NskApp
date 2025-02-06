using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24170_­•{Ä•ÛŒ¯”F’è‹æ•ª•Ê“–‰•]‰¿‚î•ñ
    /// </summary>
    [Serializable]
    [Table("t_24170_­•{Ä•ÛŒ¯”F’è‹æ•ª•Ê“–‰•]‰¿‚î•ñ")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(‡•¹¯•Ê), nameof(­•{•ÛŒ¯”F’è‹æ•ª), nameof(•âŠ„‡), nameof(‰c”_’²®ƒtƒ‰ƒO))]
    public class T24170­•{Ä•ÛŒ¯”F’è‹æ•ª•Ê“–‰•]‰¿‚î•ñ : ModelBase
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
        /// ‡•¹¯•Ê
        /// </summary>
        [Required]
        [Column("‡•¹¯•Ê", Order = 4)]
        [StringLength(3)]
        public string ‡•¹¯•Ê { get; set; }

        /// <summary>
        /// ­•{•ÛŒ¯”F’è‹æ•ª
        /// </summary>
        [Required]
        [Column("­•{•ÛŒ¯”F’è‹æ•ª", Order = 5)]
        [StringLength(4)]
        public string ­•{•ÛŒ¯”F’è‹æ•ª { get; set; }

        /// <summary>
        /// •âŠ„‡
        /// </summary>
        [Required]
        [Column("•âŠ„‡", Order = 6)]
        [StringLength(2)]
        public string •âŠ„‡ { get; set; }

        /// <summary>
        /// ‰c”_’²®ƒtƒ‰ƒO
        /// </summary>
        [Required]
        [Column("‰c”_’²®ƒtƒ‰ƒO", Order = 7)]
        [StringLength(1)]
        public string ‰c”_’²®ƒtƒ‰ƒO { get; set; }

        /// <summary>
        /// ˆøóÀŒË”
        /// </summary>
        [Column("ˆøóÀŒË”")]
        public Decimal? ˆøóÀŒË” { get; set; }

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
        /// ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™” { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_ˆøó–ÊÏ
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_ˆøó–ÊÏ")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_ˆøó–ÊÏ { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_Œ¸û—Ê
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_Œ¸û—Ê")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_Œ¸û—Ê { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_ˆê•M‘S‘¹
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_ˆê•M‘S‘¹")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_ˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ–ÊÏ_ˆê•M‘S‘¹
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_”íŠQ–ÊÏ_ˆê•M‘S‘¹")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ–ÊÏ_ˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M‘S‘¹
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M‘S‘¹")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_ˆê•M”¼‘¹
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_ˆê•M”¼‘¹")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_ˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ–ÊÏ_ˆê•M”¼‘¹
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_”íŠQ–ÊÏ_ˆê•M”¼‘¹")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ–ÊÏ_ˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M”¼‘¹
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M”¼‘¹")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_ˆê•M‘S”¼‘¹Œv
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_ˆê•M‘S”¼‘¹Œv")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_ˆê•M‘S”¼‘¹Œv { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ–ÊÏ_ˆê•M‘S”¼‘¹Œv
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_”íŠQ–ÊÏ_ˆê•M‘S”¼‘¹Œv")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ–ÊÏ_ˆê•M‘S”¼‘¹Œv { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M‘S”¼‘¹Œv
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M‘S”¼‘¹Œv")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_ˆê•M‘S”¼‘¹Œv { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_‡Œv
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_‡Œv")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_”íŠQ‘g‡ˆõ“™”_‡Œv { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_–ÊÏ_‡Œv
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_–ÊÏ_‡Œv")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_–ÊÏ_‡Œv { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_Œ¸û—Ê_‡Œv
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_Œ¸û—Ê_‡Œv")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_Œ¸û—Ê_‡Œv { get; set; }

        /// <summary>
        /// ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_‡Œv
        /// </summary>
        [Column("‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_‡Œv")]
        public Decimal? ‹¤Ï‹àx•¥‘ÎÛ_¶Y‹àŠz‚ÌŒ¸­Šz_‡Œv { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_x•¥—¦’²®‘O
        /// </summary>
        [Column("x•¥‹¤Ï‹à_x•¥—¦’²®‘O")]
        public Decimal? x•¥‹¤Ï‹à_x•¥—¦’²®‘O { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_x•¥—¦’²®‘O_ˆê•M‘S‘¹
        /// </summary>
        [Column("x•¥‹¤Ï‹à_x•¥—¦’²®‘O_ˆê•M‘S‘¹")]
        public Decimal? x•¥‹¤Ï‹à_x•¥—¦’²®‘O_ˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_x•¥—¦’²®‘O_ˆê•M”¼‘¹
        /// </summary>
        [Column("x•¥‹¤Ï‹à_x•¥—¦’²®‘O_ˆê•M”¼‘¹")]
        public Decimal? x•¥‹¤Ï‹à_x•¥—¦’²®‘O_ˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_x•¥—¦’²®‘O_‡Œv
        /// </summary>
        [Column("x•¥‹¤Ï‹à_x•¥—¦’²®‘O_‡Œv")]
        public Decimal? x•¥‹¤Ï‹à_x•¥—¦’²®‘O_‡Œv { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à
        /// </summary>
        [Column("x•¥‹¤Ï‹à")]
        public Decimal? x•¥‹¤Ï‹à { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_ˆê•M‘S‘¹
        /// </summary>
        [Column("x•¥‹¤Ï‹à_ˆê•M‘S‘¹")]
        public Decimal? x•¥‹¤Ï‹à_ˆê•M‘S‘¹ { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_ˆê•M”¼‘¹
        /// </summary>
        [Column("x•¥‹¤Ï‹à_ˆê•M”¼‘¹")]
        public Decimal? x•¥‹¤Ï‹à_ˆê•M”¼‘¹ { get; set; }

        /// <summary>
        /// x•¥‹¤Ï‹à_‡Œv
        /// </summary>
        [Column("x•¥‹¤Ï‹à_‡Œv")]
        public Decimal? x•¥‹¤Ï‹à_‡Œv { get; set; }

        /// <summary>
        /// ’ÊíÓ”C‹¤Ï‹àŠz
        /// </summary>
        [Column("’ÊíÓ”C‹¤Ï‹àŠz")]
        public Decimal? ’ÊíÓ”C‹¤Ï‹àŠz { get; set; }

        /// <summary>
        /// ”_ì•¨’ÊíÓ”C‹¤Ï‹àŠz_“Á’è
        /// </summary>
        [Column("”_ì•¨’ÊíÓ”C‹¤Ï‹àŠz_“Á’è")]
        public Decimal? ”_ì•¨’ÊíÓ”C‹¤Ï‹àŠz_“Á’è { get; set; }

        /// <summary>
        /// ˆÙí•”•ª•ÛŒ¯‹àŒ©Šz
        /// </summary>
        [Column("ˆÙí•”•ª•ÛŒ¯‹àŒ©Šz")]
        public Decimal? ˆÙí•”•ª•ÛŒ¯‹àŒ©Šz { get; set; }

        /// <summary>
        /// ˆÙí•”•ª•ÛŒ¯‹àŒ©Šz_“Á’è
        /// </summary>
        [Column("ˆÙí•”•ª•ÛŒ¯‹àŒ©Šz_“Á’è")]
        public Decimal? ˆÙí•”•ª•ÛŒ¯‹àŒ©Šz_“Á’è { get; set; }

        /// <summary>
        /// ”_ì•¨ˆÙíÓ”C•ÛŒ¯‹àŠz
        /// </summary>
        [Column("”_ì•¨ˆÙíÓ”C•ÛŒ¯‹àŠz")]
        public Decimal? ”_ì•¨ˆÙíÓ”C•ÛŒ¯‹àŠz { get; set; }

        /// <summary>
        /// ’Êí•”•ª•ÛŒ¯‹àŒ©Šz
        /// </summary>
        [Column("’Êí•”•ª•ÛŒ¯‹àŒ©Šz")]
        public Decimal? ’Êí•”•ª•ÛŒ¯‹àŒ©Šz { get; set; }

        /// <summary>
        /// x•¥•ÛŒ¯‹àŒ©Šz
        /// </summary>
        [Column("x•¥•ÛŒ¯‹àŒ©Šz")]
        public Decimal? x•¥•ÛŒ¯‹àŒ©Šz { get; set; }

        /// <summary>
        /// x•¥Ä•ÛŒ¯‹àŒ©Šz
        /// </summary>
        [Column("x•¥Ä•ÛŒ¯‹àŒ©Šz")]
        public Decimal? x•¥Ä•ÛŒ¯‹àŒ©Šz { get; set; }

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
