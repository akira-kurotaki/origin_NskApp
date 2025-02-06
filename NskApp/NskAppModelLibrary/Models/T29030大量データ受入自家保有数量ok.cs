using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_29030_‘å—Êƒf[ƒ^ó“ü_©‰Æ•Û—L”—ÊOK
    /// </summary>
    [Serializable]
    [Table("t_29030_‘å—Êƒf[ƒ^ó“ü_©‰Æ•Û—L”—ÊOK")]
    [PrimaryKey(nameof(‘g‡“™ƒR[ƒh), nameof(”NY), nameof(‹¤Ï–Ú“IƒR[ƒh), nameof(ˆ—‹æ•ª), nameof(‘g‡ˆõ“™ƒR[ƒh), nameof(Y’n•Ê–Á•¿ƒR[ƒh))]
    public class T29030‘å—Êƒf[ƒ^ó“ü©‰Æ•Û—L”—Êok : ModelBase
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
        /// Y’n•Ê–Á•¿ƒR[ƒh
        /// </summary>
        [Required]
        [Column("Y’n•Ê–Á•¿ƒR[ƒh", Order = 6)]
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
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚S
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚S")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚S { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚T
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚T")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚T { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚U
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚U")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚U { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚V
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚V")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚V { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚W
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚W")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚W { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚X
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚X")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚X { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚O
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚O")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚O { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚P
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚P")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚P { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚Q
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚Q")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚Q { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚R
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚R")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚R { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚S
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚S")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚S { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚T
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚T")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚T { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚U
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚U")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚U { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚V
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚V")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚V { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚W
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚W")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚W { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚P‚X
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚P‚X")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚P‚X { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚O
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚O")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚O { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚P
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚P")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚P { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚Q
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚Q")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚Q { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚R
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚R")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚R { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚S
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚S")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚S { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚T
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚T")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚T { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚U
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚U")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚U { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚V
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚V")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚V { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚W
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚W")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚W { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚X
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚Q‚X")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚Q‚X { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚O
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚O")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚O { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚P
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚P")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚P { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚Q
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚Q")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚Q { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚R
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚R")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚R { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚S
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚S")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚S { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚T
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚T")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚T { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚U
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚U")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚U { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚V
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚V")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚V { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚W
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚W")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚W { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚R‚X
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚R‚X")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚R‚X { get; set; }

        /// <summary>
        /// ©‰Æ•Û—L”—Ê_‹KŠi‚S‚O
        /// </summary>
        [Column("©‰Æ•Û—L”—Ê_‹KŠi‚S‚O")]
        public Decimal? ©‰Æ•Û—L”—Ê_‹KŠi‚S‚O { get; set; }

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
