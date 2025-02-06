using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00040_�c������
    /// </summary>
    [Serializable]
    [Table("m_00040_�c������")]
    public class M00040�c������ : ModelBase
    {
        /// <summary>
        /// �c���敪
        /// </summary>
        [Required]
        [Key]
        [Column("�c���敪", Order = 1)]
        [StringLength(1)]
        public string �c���敪 { get; set; }

        /// <summary>
        /// �c������
        /// </summary>
        [Column("�c������")]
        public string �c������ { get; set; }

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
