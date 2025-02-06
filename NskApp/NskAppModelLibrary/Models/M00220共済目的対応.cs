using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00220_���ϖړI�Ή�
    /// </summary>
    [Serializable]
    [Table("m_00220_���ϖړI�Ή�")]
    [PrimaryKey(nameof(���ώ��ƃR�[�h), nameof(���ϖړI�R�[�h_fim), nameof(�U���敪), nameof(���ϖړI�R�[�h_nsk))]
    public class M00220���ϖړI�Ή� : ModelBase
    {
        /// <summary>
        /// ���ώ��ƃR�[�h
        /// </summary>
        [Required]
        [Column("���ώ��ƃR�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ώ��ƃR�[�h { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h_fim
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h_fim", Order = 2)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h_fim { get; set; }

        /// <summary>
        /// �U���敪
        /// </summary>
        [Required]
        [Column("�U���敪", Order = 3)]
        [StringLength(1)]
        public string �U���敪 { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h_nsk
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h_nsk", Order = 4)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h_nsk { get; set; }

        /// <summary>
        /// �̗p����
        /// </summary>
        [Column("�̗p����")]
        [StringLength(2)]
        public string �̗p���� { get; set; }

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
