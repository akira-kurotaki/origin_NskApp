using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10210_�P�����ϋ��z�p�r
    /// </summary>
    [Serializable]
    [Table("m_10210_�P�����ϋ��z�p�r")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(��ދ敪), nameof(��t����), nameof(����敪), nameof(�p�r�敪), nameof(�ېŒP���敪), nameof(�P�����ϋ��z����))]
    public class M10210�P�����ϋ��z�p�r : ModelBase
    {
        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("�g�����R�[�h", Order = 1)]
        [StringLength(3)]
        public string �g�����R�[�h { get; set; }

        /// <summary>
        /// �N�Y
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�N�Y", Order = 2)]
        public short �N�Y { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 3)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// ��ދ敪
        /// </summary>
        [Required]
        [Column("��ދ敪", Order = 4)]
        [StringLength(1)]
        public string ��ދ敪 { get; set; }

        /// <summary>
        /// ��t����
        /// </summary>
        [Required]
        [Column("��t����", Order = 5)]
        [StringLength(1)]
        public string ��t���� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 6)]
        [StringLength(2)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Required]
        [Column("�p�r�敪", Order = 7)]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// �ېŒP���敪
        /// </summary>
        [Required]
        [Column("�ېŒP���敪", Order = 8)]
        [StringLength(1)]
        public string �ېŒP���敪 { get; set; }

        /// <summary>
        /// �P�����ϋ��z����
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�P�����ϋ��z����", Order = 9)]
        public Decimal �P�����ϋ��z���� { get; set; }

        /// <summary>
        /// �P�����ϋ��z
        /// </summary>
        [Column("�P�����ϋ��z")]
        public Decimal? �P�����ϋ��z { get; set; }

        /// <summary>
        /// �ܐ��ʕ��t���O
        /// </summary>
        [Column("�ܐ��ʕ��t���O")]
        [StringLength(1)]
        public string �ܐ��ʕ��t���O { get; set; }

        /// <summary>
        /// �����t���O
        /// </summary>
        [Column("�����t���O")]
        [StringLength(1)]
        public string �����t���O { get; set; }

        /// <summary>
        /// ���l
        /// </summary>
        [Column("���l")]
        public string ���l { get; set; }

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

        /// <summary>
        /// �X�V����
        /// </summary>
        [Column("�X�V����")]
        public DateTime? �X�V���� { get; set; }

        /// <summary>
        /// �X�V���[�Uid
        /// </summary>
        [Column("�X�V���[�Uid")]
        public string �X�V���[�Uid { get; set; }
    }
}
