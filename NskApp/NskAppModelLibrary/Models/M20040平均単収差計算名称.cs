using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20040_���ϒP�����v�Z����
    /// </summary>
    [Serializable]
    [Table("m_20040_���ϒP�����v�Z����")]
    public class M20040���ϒP�����v�Z���� : ModelBase
    {
        /// <summary>
        /// ���ϒP�����v�Z���@
        /// </summary>
        [Required]
        [Key]
        [Column("���ϒP�����v�Z���@", Order = 1)]
        [StringLength(1)]
        public string ���ϒP�����v�Z���@ { get; set; }

        /// <summary>
        /// ���ϒP�����v�Z����
        /// </summary>
        [Column("���ϒP�����v�Z����")]
        public string ���ϒP�����v�Z���� { get; set; }

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
