using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10160_���ۋ������������
    /// </summary>
    [Serializable]
    [Table("m_10160_���ۋ������������")]
    public class M10160���ۋ������������ : ModelBase
    {
        /// <summary>
        /// ���ۋ��������
        /// </summary>
        [Required]
        [Key]
        [Column("���ۋ��������", Order = 1)]
        [StringLength(2)]
        public string ���ۋ�������� { get; set; }

        /// <summary>
        /// ���ۋ������������
        /// </summary>
        [Column("���ۋ������������")]
        public string ���ۋ������������ { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        [StringLength(1)]
        public string ������� { get; set; }

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
