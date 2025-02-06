using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10100_“Á–ñ‹æ•ª–¼Ì
    /// </summary>
    [Serializable]
    [Table("m_10100_“Á–ñ‹æ•ª–¼Ì")]
    public class M10100“Á–ñ‹æ•ª–¼Ì : ModelBase
    {
        /// <summary>
        /// “Á–ñ‹æ•ª
        /// </summary>
        [Required]
        [Key]
        [Column("“Á–ñ‹æ•ª", Order = 1)]
        [StringLength(1)]
        public string “Á–ñ‹æ•ª { get; set; }

        /// <summary>
        /// “Á–ñ‹æ•ª–¼Ì
        /// </summary>
        [Column("“Á–ñ‹æ•ª–¼Ì")]
        public string “Á–ñ‹æ•ª–¼Ì { get; set; }

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
