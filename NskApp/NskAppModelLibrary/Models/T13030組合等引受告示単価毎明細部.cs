using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_13030_�g��������_�����P�������ו�
    /// </summary>
    [Serializable]
    [Table("t_13030_�g��������_�����P�������ו�")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�񍐉�), nameof(�ދ敪), nameof(���������ʃR�[�h), nameof(�������), nameof(����敪), nameof(�⏞�����R�[�h), nameof(��t����), nameof(�p�r�敪), nameof(�P�����ϋ��z����))]
    public class T13030�g�������󍐎��P�������ו� : ModelBase
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
        /// �񍐉�
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�񍐉�", Order = 4)]
        public short �񍐉� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���������ʃR�[�h
        /// </summary>
        [Required]
        [Column("���������ʃR�[�h", Order = 6)]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 7)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 8)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Column("�⏞�����R�[�h", Order = 9)]
        [StringLength(1)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// ��t����
        /// </summary>
        [Required]
        [Column("��t����", Order = 10)]
        [StringLength(1)]
        public string ��t���� { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Required]
        [Column("�p�r�敪", Order = 11)]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// �P�����ϋ��z����
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�P�����ϋ��z����", Order = 12)]
        public Decimal �P�����ϋ��z���� { get; set; }

        /// <summary>
        /// �P�����ϋ��z
        /// </summary>
        [Column("�P�����ϋ��z")]
        public Decimal? �P�����ϋ��z { get; set; }

        /// <summary>
        /// ����ː�
        /// </summary>
        [Column("����ː�")]
        public Decimal? ����ː� { get; set; }

        /// <summary>
        /// ����M��
        /// </summary>
        [Column("����M��")]
        public Decimal? ����M�� { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// ����n��
        /// </summary>
        [Column("����n��")]
        public Decimal? ����n�� { get; set; }

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
