using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10110_�p�r�敪����
    /// </summary>
    [Serializable]
    [Table("m_10110_�p�r�敪����")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(�p�r�敪))]
    public class M10110�p�r�敪���� : ModelBase
    {
        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Required]
        [Column("�p�r�敪", Order = 2)]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// �p�r����
        /// </summary>
        [Column("�p�r����")]
        public string �p�r���� { get; set; }

        /// <summary>
        /// �p�r�Z�k����
        /// </summary>
        [Column("�p�r�Z�k����")]
        public string �p�r�Z�k���� { get; set; }

        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Column("�c�_�ΏۊO�t���O")]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

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
