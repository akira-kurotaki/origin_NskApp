using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10090_����敪����
    /// </summary>
    [Serializable]
    [Table("m_10090_����敪����")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(����敪))]
    public class M10090����敪���� : ModelBase
    {
        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 2)]
        [StringLength(2)]
        public string ����敪 { get; set; }

        /// <summary>
        /// ����敪����
        /// </summary>
        [Column("����敪����")]
        public string ����敪���� { get; set; }

        /// <summary>
        /// ��ދ敪
        /// </summary>
        [Column("��ދ敪")]
        [StringLength(1)]
        public string ��ދ敪 { get; set; }

        /// <summary>
        /// ��t����
        /// </summary>
        [Column("��t����")]
        [StringLength(1)]
        public string ��t���� { get; set; }

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
