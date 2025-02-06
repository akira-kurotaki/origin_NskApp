using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_13050_�x���ʈ���W�v���
    /// </summary>
    [Serializable]
    [Table("t_13050_�x���ʈ���W�v���")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�����), nameof(�ދ敪), nameof(�x���R�[�h), nameof(���������ʃR�[�h), nameof(�������), nameof(����敪), nameof(�⏞�����R�[�h))]
    public class T13050�x���ʈ���W�v��� : ModelBase
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
        /// �����
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�����", Order = 4)]
        public short ����� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(3)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �x���R�[�h
        /// </summary>
        [Required]
        [Column("�x���R�[�h", Order = 6)]
        [StringLength(2)]
        public string �x���R�[�h { get; set; }

        /// <summary>
        /// ���������ʃR�[�h
        /// </summary>
        [Required]
        [Column("���������ʃR�[�h", Order = 7)]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 8)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 9)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Column("�⏞�����R�[�h", Order = 10)]
        [StringLength(1)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// �g�����v����ː�
        /// </summary>
        [Column("�g�����v����ː�")]
        public Decimal? �g�����v����ː� { get; set; }

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
        /// �g�����v�_�앨��t�Ώە��S���z
        /// </summary>
        [Column("�g�����v�_�앨��t�Ώە��S���z")]
        public Decimal? �g�����v�_�앨��t�Ώە��S���z { get; set; }

        /// <summary>
        /// �g�����v�g���������S���ϊ|��
        /// </summary>
        [Column("�g�����v�g���������S���ϊ|��")]
        public Decimal? �g�����v�g���������S���ϊ|�� { get; set; }

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
        /// �ُ�ӔC�ی����z
        /// </summary>
        [Column("�ُ�ӔC�ی����z")]
        public Decimal? �ُ�ӔC�ی����z { get; set; }

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
        /// �g�����v���ۋ�
        /// </summary>
        [Column("�g�����v���ۋ�")]
        public Decimal? �g�����v���ۋ� { get; set; }

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
