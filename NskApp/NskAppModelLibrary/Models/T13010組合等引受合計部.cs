using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_13010_�g��������_���v��
    /// </summary>
    [Serializable]
    [Table("t_13010_�g��������_���v��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�񍐉�), nameof(�ދ敪), nameof(���������ʃR�[�h), nameof(�������), nameof(����敪), nameof(�⏞�����R�[�h))]
    public class T13010�g�������󍇌v�� : ModelBase
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
        [StringLength(3)]
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
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// �g�����v������ː�
        /// </summary>
        [Column("�g�����v������ː�")]
        public Decimal? �g�����v������ː� { get; set; }

        /// <summary>
        /// �g�����v���󉄌ː�
        /// </summary>
        [Column("�g�����v���󉄌ː�")]
        public Decimal? �g�����v���󉄌ː� { get; set; }

        /// <summary>
        /// �g�����v����ʐ�
        /// </summary>
        [Column("�g�����v����ʐ�")]
        public Decimal? �g�����v����ʐ� { get; set; }

        /// <summary>
        /// �g�����v����n��
        /// </summary>
        [Column("�g�����v����n��")]
        public Decimal? �g�����v����n�� { get; set; }

        /// <summary>
        /// �g�����v�������
        /// </summary>
        [Column("�g�����v�������")]
        public Decimal? �g�����v������� { get; set; }

        /// <summary>
        /// �g�����v����Y���z
        /// </summary>
        [Column("�g�����v����Y���z")]
        public Decimal? �g�����v����Y���z { get; set; }

        /// <summary>
        /// �g�����v���ό��x�z
        /// </summary>
        [Column("�g�����v���ό��x�z")]
        public Decimal? �g�����v���ό��x�z { get; set; }

        /// <summary>
        /// �g�����v���ϋ��z
        /// </summary>
        [Column("�g�����v���ϋ��z")]
        public Decimal? �g�����v���ϋ��z { get; set; }

        /// <summary>
        /// �g�����v����ϊ|��
        /// </summary>
        [Column("�g�����v����ϊ|��")]
        public Decimal? �g�����v����ϊ|�� { get; set; }

        /// <summary>
        /// �g�����v���ϊ|��
        /// </summary>
        [Column("�g�����v���ϊ|��")]
        public Decimal? �g�����v���ϊ|�� { get; set; }

        /// <summary>
        /// ���ϊ|�����ɕ��S����
        /// </summary>
        [Column("���ϊ|�����ɕ��S����")]
        public Decimal? ���ϊ|�����ɕ��S���� { get; set; }

        /// <summary>
        /// �g�����v��t�Ώە��S���z
        /// </summary>
        [Column("�g�����v��t�Ώە��S���z")]
        public Decimal? �g�����v��t�Ώە��S���z { get; set; }

        /// <summary>
        /// �g�����v�g���������S���ϊ|��
        /// </summary>
        [Column("�g�����v�g���������S���ϊ|��")]
        public Decimal? �g�����v�g���������S���ϊ|�� { get; set; }

        /// <summary>
        /// �ʏ�W����Q��
        /// </summary>
        [Column("�ʏ�W����Q��")]
        public Decimal? �ʏ�W����Q�� { get; set; }

        /// <summary>
        /// �g�����v�_�앨�ʏ�ӔC���ϋ��z
        /// </summary>
        [Column("�g�����v�_�앨�ʏ�ӔC���ϋ��z")]
        public Decimal? �g�����v�_�앨�ʏ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �g�����v�_�앨�ُ�ӔC���ϋ��z
        /// </summary>
        [Column("�g�����v�_�앨�ُ�ӔC���ϋ��z")]
        public Decimal? �g�����v�_�앨�ُ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �g�����v�ُ�ӔC���ϊ|��
        /// </summary>
        [Column("�g�����v�ُ�ӔC���ϊ|��")]
        public Decimal? �g�����v�ُ�ӔC���ϊ|�� { get; set; }

        /// <summary>
        /// �g������t���z
        /// </summary>
        [Column("�g������t���z")]
        public Decimal? �g������t���z { get; set; }

        /// <summary>
        /// �g�����v�ی����z
        /// </summary>
        [Column("�g�����v�ی����z")]
        public Decimal? �g�����v�ی����z { get; set; }

        /// <summary>
        /// �g�����v�ی���
        /// </summary>
        [Column("�g�����v�ی���")]
        public Decimal? �g�����v�ی��� { get; set; }

        /// <summary>
        /// �g�����v���󑍕M��
        /// </summary>
        [Column("�g�����v���󑍕M��")]
        public Decimal? �g�����v���󑍕M�� { get; set; }

        /// <summary>
        /// �����P������ʐόv
        /// </summary>
        [Column("�����P������ʐόv")]
        public Decimal? �����P������ʐόv { get; set; }

        /// <summary>
        /// �����P������n�ʌv
        /// </summary>
        [Column("�����P������n�ʌv")]
        public Decimal? �����P������n�ʌv { get; set; }

        /// <summary>
        /// ���s��P��
        /// </summary>
        [Column("���s��P��")]
        public Decimal? ���s��P�� { get; set; }

        /// <summary>
        /// �ō���P��
        /// </summary>
        [Column("�ō���P��")]
        public Decimal? �ō���P�� { get; set; }

        /// <summary>
        /// �Œ��P��
        /// </summary>
        [Column("�Œ��P��")]
        public Decimal? �Œ��P�� { get; set; }

        /// <summary>
        /// �g�������ϒP�����ϋ��z
        /// </summary>
        [Column("�g�������ϒP�����ϋ��z")]
        public Decimal? �g�������ϒP�����ϋ��z { get; set; }

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
