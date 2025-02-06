using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10130_��ދ敪����
    /// </summary>
    [Serializable]
    [Table("m_10130_��ދ敪����")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(��ދ敪))]
    public class M10130��ދ敪���� : ModelBase
    {
        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// ��ދ敪
        /// </summary>
        [Required]
        [Column("��ދ敪", Order = 2)]
        [StringLength(1)]
        public string ��ދ敪 { get; set; }

        /// <summary>
        /// ��ދ敪����
        /// </summary>
        [Column("��ދ敪����")]
        public string ��ދ敪���� { get; set; }

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
