using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00230_�c�_�Ώۖ���
    /// </summary>
    [Serializable]
    [Table("m_00230_�c�_�Ώۖ���")]
    public class M00230�c�_�Ώۖ��� : ModelBase
    {
        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Required]
        [Key]
        [Column("�c�_�ΏۊO�t���O", Order = 1)]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

        /// <summary>
        /// �c�_�Ώۃt���O����
        /// </summary>
        [Column("�c�_�Ώۃt���O����")]
        public string �c�_�Ώۃt���O���� { get; set; }

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
