using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00180_�S��_�Ƌ敪����
    /// </summary>
    [Serializable]
    [Table("m_00180_�S��_�Ƌ敪����")]
    public class M00180�S��_�Ƌ敪���� : ModelBase
    {
        /// <summary>
        /// �S��_�Ƌ敪
        /// </summary>
        [Required]
        [Key]
        [Column("�S��_�Ƌ敪", Order = 1)]
        [StringLength(1)]
        public string �S��_�Ƌ敪 { get; set; }

        /// <summary>
        /// �S��_�Ƌ敪����
        /// </summary>
        [Column("�S��_�Ƌ敪����")]
        public string �S��_�Ƌ敪���� { get; set; }

        /// <summary>
        /// �S��_�Ƌ敪����
        /// </summary>
        [Column("�S��_�Ƌ敪����")]
        public string �S��_�Ƌ敪���� { get; set; }

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
