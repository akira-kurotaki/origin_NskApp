using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20220_�����k�n���薼��
    /// </summary>
    [Serializable]
    [Table("m_20220_�����k�n���薼��")]
    public class M20220�����k�n���薼�� : ModelBase
    {
        /// <summary>
        /// �����k�n����R�[�h
        /// </summary>
        [Required]
        [Key]
        [Column("�����k�n����R�[�h", Order = 1)]
        [StringLength(1)]
        public string �����k�n����R�[�h { get; set; }

        /// <summary>
        /// �����k�n���薼��
        /// </summary>
        [Column("�����k�n���薼��")]
        public string �����k�n���薼�� { get; set; }

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
