using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10080_�����������
    /// </summary>
    [Serializable]
    [Table("m_10080_�����������")]
    public class M10080����������� : ModelBase
    {
        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Key]
        [Column("�������", Order = 1)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        [Column("�����������")]
        public string ����������� { get; set; }

        /// <summary>
        /// ��������Z�k��
        /// </summary>
        [Column("��������Z�k��")]
        public string ��������Z�k�� { get; set; }

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
