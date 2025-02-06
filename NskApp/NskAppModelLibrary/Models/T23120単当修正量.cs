using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_23120_PC³Ê
    /// </summary>
    [Serializable]
    [Table("t_23120_PC³Ê")]
    [PrimaryKey(nameof(gR[h), nameof(NY), nameof(¤ÏÚIR[h), nameof(¹¯ÊR[h), nameof(Þæª), nameof(øóû®), nameof(âR[h), nameof(]¿næR[h), nameof(Kwæª))]
    public class T23120PC³Ê : ModelBase
    {
        /// <summary>
        /// gR[h
        /// </summary>
        [Required]
        [Column("gR[h", Order = 1)]
        [StringLength(3)]
        public string gR[h { get; set; }

        /// <summary>
        /// NY
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("NY", Order = 2)]
        public short NY { get; set; }

        /// <summary>
        /// ¤ÏÚIR[h
        /// </summary>
        [Required]
        [Column("¤ÏÚIR[h", Order = 3)]
        [StringLength(2)]
        public string ¤ÏÚIR[h { get; set; }

        /// <summary>
        /// ¹¯ÊR[h
        /// </summary>
        [Required]
        [Column("¹¯ÊR[h", Order = 4)]
        [StringLength(3)]
        public string ¹¯ÊR[h { get; set; }

        /// <summary>
        /// Þæª
        /// </summary>
        [Required]
        [Column("Þæª", Order = 5)]
        [StringLength(2)]
        public string Þæª { get; set; }

        /// <summary>
        /// øóû®
        /// </summary>
        [Required]
        [Column("øóû®", Order = 6)]
        [StringLength(1)]
        public string øóû® { get; set; }

        /// <summary>
        /// âR[h
        /// </summary>
        [Required]
        [Column("âR[h", Order = 7)]
        [StringLength(2)]
        public string âR[h { get; set; }

        /// <summary>
        /// ]¿næR[h
        /// </summary>
        [Required]
        [Column("]¿næR[h", Order = 8)]
        [StringLength(4)]
        public string ]¿næR[h { get; set; }

        /// <summary>
        /// Kwæª
        /// </summary>
        [Required]
        [Column("Kwæª", Order = 9)]
        [StringLength(3)]
        public string Kwæª { get; set; }

        /// <summary>
        /// »F²¸ÊÏ
        /// </summary>
        [Column("»F²¸ÊÏ")]
        public Decimal? »F²¸ÊÏ { get; set; }

        /// <summary>
        /// ½ÏPû·
        /// </summary>
        [Column("½ÏPû·")]
        public Decimal? ½ÏPû· { get; set; }

        /// <summary>
        /// PC³Ê
        /// </summary>
        [Column("PC³Ê")]
        public Decimal? PC³Ê { get; set; }

        /// <summary>
        /// C³³µtO
        /// </summary>
        [Column("C³³µtO")]
        public Decimal? C³³µtO { get; set; }

        /// <summary>
        /// vZPÊÞæª
        /// </summary>
        [Column("vZPÊÞæª")]
        public Decimal? vZPÊÞæª { get; set; }

        /// <summary>
        /// vZPÊøóû®
        /// </summary>
        [Column("vZPÊøóû®")]
        public Decimal? vZPÊøóû® { get; set; }

        /// <summary>
        /// vZPÊâ
        /// </summary>
        [Column("vZPÊâ")]
        public Decimal? vZPÊâ { get; set; }

        /// <summary>
        /// ´ßíQÊÏ
        /// </summary>
        [Column("´ßíQÊÏ")]
        public Decimal? ´ßíQÊÏ { get; set; }

        /// <summary>
        /// »F]¿ÊÏ
        /// </summary>
        [Column("»F]¿ÊÏ")]
        public Decimal? »F]¿ÊÏ { get; set; }

        /// <summary>
        /// o^ú
        /// </summary>
        [Column("o^ú")]
        public DateTime? o^ú { get; set; }

        /// <summary>
        /// o^[Uid
        /// </summary>
        [Column("o^[Uid")]
        public string o^[Uid { get; set; }

        /// <summary>
        /// XVú
        /// </summary>
        [Column("XVú")]
        public DateTime? XVú { get; set; }

        /// <summary>
        /// XV[Uid
        /// </summary>
        [Column("XV[Uid")]
        public string XV[Uid { get; set; }
    }
}
