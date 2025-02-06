using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20210_��������ʔ���
    /// </summary>
    [Serializable]
    [Table("m_20210_��������ʔ���")]
    [PrimaryKey(nameof(�������), nameof(�ޏ�t���O), nameof(��Q����R�[�h))]
    public class M20210��������ʔ��� : ModelBase
    {
        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 1)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �ޏ�t���O
        /// </summary>
        [Required]
        [Column("�ޏ�t���O", Order = 2)]
        [StringLength(1)]
        public string �ޏ�t���O { get; set; }

        /// <summary>
        /// ��Q����R�[�h
        /// </summary>
        [Required]
        [Column("��Q����R�[�h", Order = 3)]
        [StringLength(1)]
        public string ��Q����R�[�h { get; set; }

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
