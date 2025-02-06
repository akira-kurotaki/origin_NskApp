using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00050_�[����������
    /// </summary>
    [Serializable]
    [Table("m_00050_�[����������")]
    public class M00050�[���������� : ModelBase
    {
        /// <summary>
        /// �[�������R�[�h
        /// </summary>
        [Required]
        [Key]
        [Column("�[�������R�[�h", Order = 1)]
        [StringLength(1)]
        public string �[�������R�[�h { get; set; }

        /// <summary>
        /// �[����������
        /// </summary>
        [Column("�[����������")]
        public string �[���������� { get; set; }

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
