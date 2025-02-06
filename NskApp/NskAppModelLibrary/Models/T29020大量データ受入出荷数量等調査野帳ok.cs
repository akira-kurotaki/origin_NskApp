using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_29020_‘å—Êƒf[ƒ^ó“ü_o‰×”—Ê“™’²¸–ì’ OK
    /// </summary>
    [Serializable]
    [Table("t_29020_‘å—Êƒf[ƒ^ó“ü_o‰×”—Ê“™’²¸–ì’ OK")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(ˆ—‹æ•ª), nameof(‘g‡ˆõ“™ƒR[ƒh), nameof(o‰×•]‰¿’n‹æƒR[ƒh), nameof(o‰×ŠK‘w‹æ•ªƒR[ƒh), nameof(Y’n•Ê–Á•¿ƒR[ƒh))]
    public class T29020‘å—Êƒf[ƒ^ó“üo‰×”—Ê“™’²¸–ì’ ok : ModelBase
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
        /// ˆ—‹æ•ª
        /// </summary>
        [Required]
        [Column("ˆ—‹æ•ª", Order = 4)]
        [StringLength(1)]
        public string ˆ—‹æ•ª { get; set; }

        /// <summary>
        /// ‘g‡ˆõ“™ƒR[ƒh
        /// </summary>
        [Required]
        [Column("‘g‡ˆõ“™ƒR[ƒh", Order = 5)]
        [StringLength(13)]
        public string ‘g‡ˆõ“™ƒR[ƒh { get; set; }

        /// <summary>
        /// o‰×•]‰¿’n‹æƒR[ƒh
        /// </summary>
        [Required]
        [Column("o‰×•]‰¿’n‹æƒR[ƒh", Order = 6)]
        [StringLength(4)]
        public string o‰×•]‰¿’n‹æƒR[ƒh { get; set; }

        /// <summary>
        /// o‰×ŠK‘w‹æ•ªƒR[ƒh
        /// </summary>
        [Required]
        [Column("o‰×ŠK‘w‹æ•ªƒR[ƒh", Order = 7)]
        [StringLength(3)]
        public string o‰×ŠK‘w‹æ•ªƒR[ƒh { get; set; }

        /// <summary>
        /// Y’n•Ê–Á•¿ƒR[ƒh
        /// </summary>
        [Required]
        [Column("Y’n•Ê–Á•¿ƒR[ƒh", Order = 8)]
        [StringLength(5)]
        public string Y’n•Ê–Á•¿ƒR[ƒh { get; set; }

        /// <summary>
        /// ‘å’n‹æƒR[ƒh
        /// </summary>
        [Column("‘å’n‹æƒR[ƒh")]
        [StringLength(2)]
        public string ‘å’n‹æƒR[ƒh { get; set; }

        /// <summary>
        /// ¬’n‹æƒR[ƒh
        /// </summary>
        [Column("¬’n‹æƒR[ƒh")]
        [StringLength(4)]
        public string ¬’n‹æƒR[ƒh { get; set; }

        /// <summary>
        /// o‰×Œ©”—Ê
        /// </summary>
        [Column("o‰×Œ©”—Ê")]
        public Decimal? o‰×Œ©”—Ê { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚S
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚S")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚S { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚T
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚T")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚T { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚U
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚U")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚U { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚V
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚V")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚V { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚W
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚W")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚W { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚X
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚X")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚X { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚O
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚O")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚O { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚P
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚P")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚P { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚Q
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚Q")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚Q { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚R
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚R")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚R { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚S
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚S")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚S { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚T
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚T")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚T { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚U
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚U")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚U { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚V
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚V")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚V { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚W
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚W")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚W { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚P‚X
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚P‚X")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚P‚X { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚O
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚O")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚O { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚P
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚P")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚P { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚Q
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚Q")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚Q { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚R
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚R")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚R { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚S
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚S")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚S { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚T
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚T")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚T { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚U
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚U")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚U { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚V
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚V")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚V { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚W
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚W")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚W { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚Q‚X
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚Q‚X")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚Q‚X { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚O
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚O")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚O { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚P
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚P")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚P { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚Q
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚Q")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚Q { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚R
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚R")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚R { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚S
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚S")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚S { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚T
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚T")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚T { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚U
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚U")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚U { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚V
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚V")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚V { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚W
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚W")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚W { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚R‚X
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚R‚X")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚R‚X { get; set; }

        /// <summary>
        /// o‰×”—Ê“™_‹KŠi‚S‚O
        /// </summary>
        [Column("o‰×”—Ê“™_‹KŠi‚S‚O")]
        public Decimal? o‰×”—Ê“™_‹KŠi‚S‚O { get; set; }

        /// <summary>
        /// ‹KŠi•Ê”»’è‹æ•ª
        /// </summary>
        [Column("‹KŠi•Ê”»’è‹æ•ª")]
        [StringLength(1)]
        public string ‹KŠi•Ê”»’è‹æ•ª { get; set; }

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
