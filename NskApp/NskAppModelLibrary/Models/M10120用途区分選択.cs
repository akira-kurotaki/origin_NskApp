using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10120_�p�r�敪�I��
    /// </summary>
    [Serializable]
    [Table("m_10120_�p�r�敪�I��")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(��t����), nameof(�p�r�敪))]
    public class M10120�p�r�敪�I�� : ModelBase
    {
        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 2)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ��ދ敪
        /// </summary>
        [Column("��ދ敪")]
        [StringLength(1)]
        public string ��ދ敪 { get; set; }

        /// <summary>
        /// ��t����
        /// </summary>
        [Required]
        [Column("��t����", Order = 3)]
        [StringLength(1)]
        public string ��t���� { get; set; }

        /// <summary>
        /// �c���敪
        /// </summary>
        [Column("�c���敪")]
        [StringLength(1)]
        public string �c���敪 { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Required]
        [Column("�p�r�敪", Order = 4)]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

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
