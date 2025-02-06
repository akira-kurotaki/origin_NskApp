using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10080_ˆøó•û®–¼Ì
    /// </summary>
    [Serializable]
    [Table("m_10080_ˆøó•û®–¼Ì")]
    public class M10080ˆøó•û®–¼Ì : ModelBase
    {
        /// <summary>
        /// ˆøó•û®
        /// </summary>
        [Required]
        [Key]
        [Column("ˆøó•û®", Order = 1)]
        [StringLength(1)]
        public string ˆøó•û® { get; set; }

        /// <summary>
        /// ˆøó•û®–¼Ì
        /// </summary>
        [Column("ˆøó•û®–¼Ì")]
        public string ˆøó•û®–¼Ì { get; set; }

        /// <summary>
        /// ˆøó•û®’Zk–¼
        /// </summary>
        [Column("ˆøó•û®’Zk–¼")]
        public string ˆøó•û®’Zk–¼ { get; set; }

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
