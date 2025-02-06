using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10260_���ۋ�_�����N����
    /// </summary>
    [Serializable]
    [Table("m_10260_���ۋ�_�����N����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�������), nameof(����敪), nameof(��n��R�[�h))]
    public class M10260���ۋ������N���� : ModelBase
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
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 4)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 5)]
        [StringLength(2)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 6)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Required]
        [Column("��n��R�[�h", Order = 7)]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// �ŏI�[�������R�[�h
        /// </summary>
        [Column("�ŏI�[�������R�[�h")]
        [StringLength(1)]
        public string �ŏI�[�������R�[�h { get; set; }

        /// <summary>
        /// ���ʒP��
        /// </summary>
        [Column("���ʒP��")]
        [StringLength(5)]
        public string ���ʒP�� { get; set; }

        /// <summary>
        /// �h�ВP��
        /// </summary>
        [Column("�h�ВP��")]
        [StringLength(5)]
        public string �h�ВP�� { get; set; }

        /// <summary>
        /// ���ۋ�����z
        /// </summary>
        [Column("���ۋ�����z")]
        public Decimal? ���ۋ�����z { get; set; }

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
