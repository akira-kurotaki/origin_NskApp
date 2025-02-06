using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_13020_�g��������_�댯�i�K�����ו�
    /// </summary>
    [Serializable]
    [Table("t_13020_�g��������_�댯�i�K�����ו�")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�񍐉�), nameof(�ދ敪), nameof(���������ʃR�[�h), nameof(�������), nameof(����敪), nameof(�⏞�����R�[�h), nameof(�n��P�ʋ敪), nameof(�댯�i�K�敪), nameof(�P�����ϋ��z))]
    public class T13020�g��������댯�i�K�����ו� : ModelBase
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
        [StringLength(2)]
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
        /// �n��P�ʋ敪
        /// </summary>
        [Required]
        [Column("�n��P�ʋ敪", Order = 10)]
        [StringLength(5)]
        public string �n��P�ʋ敪 { get; set; }

        /// <summary>
        /// �댯�i�K�敪
        /// </summary>
        [Required]
        [Column("�댯�i�K�敪", Order = 11)]
        [StringLength(3)]
        public string �댯�i�K�敪 { get; set; }

        /// <summary>
        /// �P�����ϋ��z
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�P�����ϋ��z", Order = 12)]
        public Decimal �P�����ϋ��z { get; set; }

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
        /// �������
        /// </summary>
        [Column("�������")]
        public Decimal? ������� { get; set; }

        /// <summary>
        /// ���ϋ��z
        /// </summary>
        [Column("���ϋ��z")]
        public Decimal? ���ϋ��z { get; set; }

        /// <summary>
        /// ����ϊ|��
        /// </summary>
        [Column("����ϊ|��")]
        public Decimal? ����ϊ|�� { get; set; }

        /// <summary>
        /// ���ϊ|��
        /// </summary>
        [Column("���ϊ|��")]
        public Decimal? ���ϊ|�� { get; set; }

        /// <summary>
        /// �ʏ�ӔC���ϋ��z
        /// </summary>
        [Column("�ʏ�ӔC���ϋ��z")]
        public Decimal? �ʏ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �ʏ�����ی����z
        /// </summary>
        [Column("�ʏ�����ی����z")]
        public Decimal? �ʏ�����ی����z { get; set; }

        /// <summary>
        /// �ُ�ӔC���ϋ��z
        /// </summary>
        [Column("�ُ�ӔC���ϋ��z")]
        public Decimal? �ُ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �ُ�ӔC���ϊ|��
        /// </summary>
        [Column("�ُ�ӔC���ϊ|��")]
        public Decimal? �ُ�ӔC���ϊ|�� { get; set; }

        /// <summary>
        /// �ĕی���
        /// </summary>
        [Column("�ĕی���")]
        public Decimal? �ĕی��� { get; set; }

        /// <summary>
        /// �g���ی����z
        /// </summary>
        [Column("�g���ی����z")]
        public Decimal? �g���ی����z { get; set; }

        /// <summary>
        /// �g���ی���
        /// </summary>
        [Column("�g���ی���")]
        public Decimal? �g���ی��� { get; set; }

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
        /// �댯�i�K�ʔ_�앨�ʏ�W����Q��
        /// </summary>
        [Column("�댯�i�K�ʔ_�앨�ʏ�W����Q��")]
        public Decimal? �댯�i�K�ʔ_�앨�ʏ�W����Q�� { get; set; }

        /// <summary>
        /// �댯�i�K�ʔ_�앨�ی�����b��
        /// </summary>
        [Column("�댯�i�K�ʔ_�앨�ی�����b��")]
        public Decimal? �댯�i�K�ʔ_�앨�ی�����b�� { get; set; }

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
