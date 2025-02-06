using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10240_ë¯iKnæÊÝè
    /// </summary>
    [Serializable]
    [Table("m_10240_ë¯iKnæÊÝè")]
    [PrimaryKey(nameof(gR[h), nameof(NY), nameof(¤ÏÚIR[h), nameof(Þæª), nameof(ånæR[h), nameof(¬næR[h), nameof(øóû®), nameof(Áñæª), nameof(âR[h))]
    public class M10240ë¯iKnæÊÝè : ModelBase
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
        /// Þæª
        /// </summary>
        [Required]
        [Column("Þæª", Order = 4)]
        [StringLength(2)]
        public string Þæª { get; set; }

        /// <summary>
        /// ånæR[h
        /// </summary>
        [Required]
        [Column("ånæR[h", Order = 5)]
        [StringLength(2)]
        public string ånæR[h { get; set; }

        /// <summary>
        /// ¬næR[h
        /// </summary>
        [Required]
        [Column("¬næR[h", Order = 6)]
        [StringLength(4)]
        public string ¬næR[h { get; set; }

        /// <summary>
        /// øóû®
        /// </summary>
        [Required]
        [Column("øóû®", Order = 7)]
        [StringLength(3)]
        public string øóû® { get; set; }

        /// <summary>
        /// Áñæª
        /// </summary>
        [Required]
        [Column("Áñæª", Order = 8)]
        [StringLength(1)]
        public string Áñæª { get; set; }

        /// <summary>
        /// âR[h
        /// </summary>
        [Required]
        [Column("âR[h", Order = 9)]
        [StringLength(2)]
        public string âR[h { get; set; }

        /// <summary>
        /// ë¯iKnææª
        /// </summary>
        [Column("ë¯iKnææª")]
        [StringLength(2)]
        public string ë¯iKnææª { get; set; }

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
