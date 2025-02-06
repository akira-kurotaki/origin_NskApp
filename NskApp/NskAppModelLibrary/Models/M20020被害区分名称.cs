using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20020_��Q�敪����
    /// </summary>
    [Serializable]
    [Table("m_20020_��Q�敪����")]
    public class M20020��Q�敪���� : ModelBase
    {
        /// <summary>
        /// ��Q�敪
        /// </summary>
        [Required]
        [Key]
        [Column("��Q�敪", Order = 1)]
        [StringLength(1)]
        public string ��Q�敪 { get; set; }

        /// <summary>
        /// ��Q�敪����
        /// </summary>
        [Column("��Q�敪����")]
        public string ��Q�敪���� { get; set; }

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
