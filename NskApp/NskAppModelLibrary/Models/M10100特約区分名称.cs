using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10100_����敪����
    /// </summary>
    [Serializable]
    [Table("m_10100_����敪����")]
    public class M10100����敪���� : ModelBase
    {
        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Key]
        [Column("����敪", Order = 1)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// ����敪����
        /// </summary>
        [Column("����敪����")]
        public string ����敪���� { get; set; }

        /// <summary>
        /// �o�^����
        /// </summary>
        [Column("�o�^����")]
        public DateTime? �o�^���� { get; set; }

        /// <summary>
        /// �o�^���[�Uid
        /// </summary>
        [Column("�o�^���[�Uid")]
        public string �o�^���[�Uid { get; set; }
    }
}
