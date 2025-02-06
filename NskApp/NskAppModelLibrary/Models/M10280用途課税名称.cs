using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10280_�p�r�ېŖ���
    /// </summary>
    [Serializable]
    [Table("m_10280_�p�r�ېŖ���")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(�p�r�敪), nameof(�ېŒP���敪))]
    public class M10280�p�r�ېŖ��� : ModelBase
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
        /// �ېŒP���敪
        /// </summary>
        [Required]
        [Column("�ېŒP���敪", Order = 3)]
        [StringLength(1)]
        public string �ېŒP���敪 { get; set; }

        /// <summary>
        /// �p�r�ېŖ���
        /// </summary>
        [Column("�p�r�ېŖ���")]
        public string �p�r�ېŖ��� { get; set; }

        /// <summary>
        /// �p�r�ېŒZ�k����
        /// </summary>
        [Column("�p�r�ېŒZ�k����")]
        public string �p�r�ېŒZ�k���� { get; set; }

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
