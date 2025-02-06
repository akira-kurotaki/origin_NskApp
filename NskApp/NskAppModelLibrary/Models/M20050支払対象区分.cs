using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20050_�x���Ώۋ敪
    /// </summary>
    [Serializable]
    [Table("m_20050_�x���Ώۋ敪")]
    public class M20050�x���Ώۋ敪 : ModelBase
    {
        /// <summary>
        /// �x���Ώۋ敪
        /// </summary>
        [Required]
        [Key]
        [Column("�x���Ώۋ敪", Order = 1)]
        [StringLength(1)]
        public string �x���Ώۋ敪 { get; set; }

        /// <summary>
        /// �x���Ώۋ敪����
        /// </summary>
        [Column("�x���Ώۋ敪����")]
        public string �x���Ώۋ敪���� { get; set; }

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
