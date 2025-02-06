using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20010_��Q���薼��
    /// </summary>
    [Serializable]
    [Table("m_20010_��Q���薼��")]
    public class M20010��Q���薼�� : ModelBase
    {
        /// <summary>
        /// ��Q����R�[�h
        /// </summary>
        [Required]
        [Key]
        [Column("��Q����R�[�h", Order = 1)]
        [StringLength(1)]
        public string ��Q����R�[�h { get; set; }

        /// <summary>
        /// ��Q���薼��
        /// </summary>
        [Column("��Q���薼��")]
        public string ��Q���薼�� { get; set; }

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
