using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_13040_‘g‡“™ˆøó_ŠëŒ¯’iŠK–ˆ–¾×•”_pq
    /// </summary>
    [Serializable]
    [Table("t_13040_‘g‡“™ˆøó_ŠëŒ¯’iŠK–ˆ–¾×•”_pq")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(•ñ‰ñ), nameof(—Ş‹æ•ª), nameof(‡•¹¯•ÊƒR[ƒh), nameof(ˆøó•û®), nameof(“Á–ñ‹æ•ª), nameof(•âŠ„‡ƒR[ƒh), nameof(’nˆæ’PˆÊ‹æ•ª), nameof(ŠëŒ¯’iŠK‹æ•ª))]
    public class T13040‘g‡“™ˆøóŠëŒ¯’iŠK–ˆ–¾×•”Pq : ModelBase
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
        /// •ñ‰ñ
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("•ñ‰ñ", Order = 4)]
        public short •ñ‰ñ { get; set; }

        /// <summary>
        /// —Ş‹æ•ª
        /// </summary>
        [Required]
        [Column("—Ş‹æ•ª", Order = 5)]
        [StringLength(2)]
        public string —Ş‹æ•ª { get; set; }

        /// <summary>
        /// ‡•¹¯•ÊƒR[ƒh
        /// </summary>
        [Required]
        [Column("‡•¹¯•ÊƒR[ƒh", Order = 6)]
        [StringLength(3)]
        public string ‡•¹¯•ÊƒR[ƒh { get; set; }

        /// <summary>
        /// ˆøó•û®
        /// </summary>
        [Required]
        [Column("ˆøó•û®", Order = 7)]
        [StringLength(1)]
        public string ˆøó•û® { get; set; }

        /// <summary>
        /// “Á–ñ‹æ•ª
        /// </summary>
        [Required]
        [Column("“Á–ñ‹æ•ª", Order = 8)]
        [StringLength(1)]
        public string “Á–ñ‹æ•ª { get; set; }

        /// <summary>
        /// •âŠ„‡ƒR[ƒh
        /// </summary>
        [Required]
        [Column("•âŠ„‡ƒR[ƒh", Order = 9)]
        [StringLength(1)]
        public string •âŠ„‡ƒR[ƒh { get; set; }

        /// <summary>
        /// ’nˆæ’PˆÊ‹æ•ª
        /// </summary>
        [Required]
        [Column("’nˆæ’PˆÊ‹æ•ª", Order = 10)]
        [StringLength(5)]
        public string ’nˆæ’PˆÊ‹æ•ª { get; set; }

        /// <summary>
        /// ŠëŒ¯’iŠK‹æ•ª
        /// </summary>
        [Required]
        [Column("ŠëŒ¯’iŠK‹æ•ª", Order = 11)]
        [StringLength(3)]
        public string ŠëŒ¯’iŠK‹æ•ª { get; set; }

        /// <summary>
        /// ˆøóŒË”
        /// </summary>
        [Column("ˆøóŒË”")]
        public Decimal? ˆøóŒË” { get; set; }

        /// <summary>
        /// ˆøó•M”
        /// </summary>
        [Column("ˆøó•M”")]
        public Decimal? ˆøó•M” { get; set; }

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
        /// Šî€‹¤ÏŠ|‹à—¦
        /// </summary>
        [Column("Šî€‹¤ÏŠ|‹à—¦")]
        public Decimal? Šî€‹¤ÏŠ|‹à—¦ { get; set; }

        /// <summary>
        /// ‹¤ÏŠ|‹à—¦
        /// </summary>
        [Column("‹¤ÏŠ|‹à—¦")]
        public Decimal? ‹¤ÏŠ|‹à—¦ { get; set; }

        /// <summary>
        /// Šî€‹¤ÏŠ|‹à
        /// </summary>
        [Column("Šî€‹¤ÏŠ|‹à")]
        public Decimal? Šî€‹¤ÏŠ|‹à { get; set; }

        /// <summary>
        /// ‹¤ÏŠ|‹à
        /// </summary>
        [Column("‹¤ÏŠ|‹à")]
        public Decimal? ‹¤ÏŠ|‹à { get; set; }

        /// <summary>
        /// •ÛŒ¯—¿
        /// </summary>
        [Column("•ÛŒ¯—¿")]
        public Decimal? •ÛŒ¯—¿ { get; set; }

        /// <summary>
        /// •ÛŒ¯—¿_“Á’è
        /// </summary>
        [Column("•ÛŒ¯—¿_“Á’è")]
        public Decimal? •ÛŒ¯—¿_“Á’è { get; set; }

        /// <summary>
        /// •ÛŒ¯‹àŠz
        /// </summary>
        [Column("•ÛŒ¯‹àŠz")]
        public Decimal? •ÛŒ¯‹àŠz { get; set; }

        /// <summary>
        /// •ÛŒ¯‹àŠz_“Á’è
        /// </summary>
        [Column("•ÛŒ¯‹àŠz_“Á’è")]
        public Decimal? •ÛŒ¯‹àŠz_“Á’è { get; set; }

        /// <summary>
        /// ŠëŒ¯’iŠK•Ê”_ì•¨’Êí•W€”íŠQ—¦
        /// </summary>
        [Column("ŠëŒ¯’iŠK•Ê”_ì•¨’Êí•W€”íŠQ—¦")]
        public Decimal? ŠëŒ¯’iŠK•Ê”_ì•¨’Êí•W€”íŠQ—¦ { get; set; }

        /// <summary>
        /// ’ÊíÓ”C‹¤Ï‹àŠz
        /// </summary>
        [Column("’ÊíÓ”C‹¤Ï‹àŠz")]
        public Decimal? ’ÊíÓ”C‹¤Ï‹àŠz { get; set; }

        /// <summary>
        /// ’ÊíÓ”C•ÛŒ¯•à‡
        /// </summary>
        [Column("’ÊíÓ”C•ÛŒ¯•à‡")]
        public Decimal? ’ÊíÓ”C•ÛŒ¯•à‡ { get; set; }

        /// <summary>
        /// ’Êí•à‡•ÛŒ¯‹àŠz
        /// </summary>
        [Column("’Êí•à‡•ÛŒ¯‹àŠz")]
        public Decimal? ’Êí•à‡•ÛŒ¯‹àŠz { get; set; }

        /// <summary>
        /// ”_ì•¨ˆÙíÓ”C‹¤Ï‹àŠz
        /// </summary>
        [Column("”_ì•¨ˆÙíÓ”C‹¤Ï‹àŠz")]
        public Decimal? ”_ì•¨ˆÙíÓ”C‹¤Ï‹àŠz { get; set; }

        /// <summary>
        /// ŠëŒ¯’iŠK•Ê•ÛŒ¯—¿Šî‘b—¦
        /// </summary>
        [Column("ŠëŒ¯’iŠK•Ê•ÛŒ¯—¿Šî‘b—¦")]
        public Decimal? ŠëŒ¯’iŠK•Ê•ÛŒ¯—¿Šî‘b—¦ { get; set; }

        /// <summary>
        /// ”_ì•¨’ÊíÓ”C‹¤ÏŠ|‹à
        /// </summary>
        [Column("”_ì•¨’ÊíÓ”C‹¤ÏŠ|‹à")]
        public Decimal? ”_ì•¨’ÊíÓ”C‹¤ÏŠ|‹à { get; set; }

        /// <summary>
        /// ’Êí•à‡•ÛŒ¯—¿
        /// </summary>
        [Column("’Êí•à‡•ÛŒ¯—¿")]
        public Decimal? ’Êí•à‡•ÛŒ¯—¿ { get; set; }

        /// <summary>
        /// ”_ì•¨ˆÙíÓ”C‹¤ÏŠ|‹à
        /// </summary>
        [Column("”_ì•¨ˆÙíÓ”C‹¤ÏŠ|‹à")]
        public Decimal? ”_ì•¨ˆÙíÓ”C‹¤ÏŠ|‹à { get; set; }

        /// <summary>
        /// ŠëŒ¯’iŠK•Ê”_ì•¨ˆÙí•W€”íŠQ—¦
        /// </summary>
        [Column("ŠëŒ¯’iŠK•Ê”_ì•¨ˆÙí•W€”íŠQ—¦")]
        public Decimal? ŠëŒ¯’iŠK•Ê”_ì•¨ˆÙí•W€”íŠQ—¦ { get; set; }

        /// <summary>
        /// ”_ì•¨ˆÙíÓ”C•ÛŒ¯‹àŠz
        /// </summary>
        [Column("”_ì•¨ˆÙíÓ”C•ÛŒ¯‹àŠz")]
        public Decimal? ”_ì•¨ˆÙíÓ”C•ÛŒ¯‹àŠz { get; set; }

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

        /// <summary>
        /// XV“ú
        /// </summary>
        [Column("XV“ú")]
        public DateTime? XV“ú { get; set; }

        /// <summary>
        /// XVƒ†[ƒUid
        /// </summary>
        [Column("XVƒ†[ƒUid")]
        public string XVƒ†[ƒUid { get; set; }
    }
}
