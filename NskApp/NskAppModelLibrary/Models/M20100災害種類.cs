using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20100_ÐQíÞ
    /// </summary>
    [Serializable]
    [Table("m_20100_ÐQíÞ")]
    [PrimaryKey(nameof(gR[h), nameof(NY), nameof(¤ÏÌR[h), nameof(ÐQíÞR[h))]
    public class M20100ÐQíÞ : ModelBase
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
        /// ¤ÏÌR[h
        /// </summary>
        [Required]
        [Column("¤ÏÌR[h", Order = 3)]
        [StringLength(2)]
        public string ¤ÏÌR[h { get; set; }

        /// <summary>
        /// ÐQíÞR[h
        /// </summary>
        [Required]
        [Column("ÐQíÞR[h", Order = 4)]
        [StringLength(2)]
        public string ÐQíÞR[h { get; set; }

        /// <summary>
        /// ÐQíÞ¼
        /// </summary>
        [Column("ÐQíÞ¼")]
        public string ÐQíÞ¼ { get; set; }

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
