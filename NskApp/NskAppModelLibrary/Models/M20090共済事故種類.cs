using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20090_���ώ��̎��
    /// </summary>
    [Serializable]
    [Table("m_20090_���ώ��̎��")]
    public class M20090���ώ��̎�� : ModelBase
    {
        /// <summary>
        /// ���ώ��̃R�[�h
        /// </summary>
        [Required]
        [Key]
        [Column("���ώ��̃R�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ώ��̃R�[�h { get; set; }

        /// <summary>
        /// ���ώ��̖�
        /// </summary>
        [Column("���ώ��̖�")]
        public string ���ώ��̖� { get; set; }

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
