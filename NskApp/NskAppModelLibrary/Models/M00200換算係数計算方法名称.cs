using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00200_���Z�W���v�Z���@����
    /// </summary>
    [Serializable]
    [Table("m_00200_���Z�W���v�Z���@����")]
    public class M00200���Z�W���v�Z���@���� : ModelBase
    {
        /// <summary>
        /// �P�����Z�W���v�Z���@
        /// </summary>
        [Required]
        [Key]
        [Column("�P�����Z�W���v�Z���@", Order = 1)]
        [StringLength(1)]
        public string �P�����Z�W���v�Z���@ { get; set; }

        /// <summary>
        /// �P�����Z�W���v�Z���@��
        /// </summary>
        [Column("�P�����Z�W���v�Z���@��")]
        [StringLength(20)]
        public string �P�����Z�W���v�Z���@�� { get; set; }

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
