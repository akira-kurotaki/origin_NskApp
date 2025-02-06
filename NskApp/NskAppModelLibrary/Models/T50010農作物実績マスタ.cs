using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_50010_�_�앨���у}�X�^
    /// </summary>
    [Serializable]
    [Table("t_50010_�_�앨���у}�X�^")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ƃR�[�h), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�ދ敪), nameof(���v�P�ʒn��R�[�h))]
    public class T50010�_�앨���у}�X�^ : ModelBase
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
        /// ���ƃR�[�h
        /// </summary>
        [Required]
        [Column("���ƃR�[�h", Order = 3)]
        [StringLength(2)]
        public string ���ƃR�[�h { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 4)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 5)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 6)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���v�P�ʒn��R�[�h
        /// </summary>
        [Required]
        [Column("���v�P�ʒn��R�[�h", Order = 7)]
        [StringLength(5)]
        public string ���v�P�ʒn��R�[�h { get; set; }

        /// <summary>
        /// ���������ʃR�[�h
        /// </summary>
        [Column("���������ʃR�[�h")]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Column("����敪")]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Column("�⏞�����R�[�h")]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Column("��n��R�[�h")]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// ���n��R�[�h
        /// </summary>
        [Column("���n��R�[�h")]
        [StringLength(4)]
        public string ���n��R�[�h { get; set; }

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
        /// ���ϋ��z�P��
        /// </summary>
        [Column("���ϋ��z�P��")]
        public Decimal? ���ϋ��z�P�� { get; set; }

        /// <summary>
        /// ���ϋ��z
        /// </summary>
        [Column("���ϋ��z")]
        public Decimal? ���ϋ��z { get; set; }

        /// <summary>
        /// ���ό��x�z
        /// </summary>
        [Column("���ό��x�z")]
        public Decimal? ���ό��x�z { get; set; }

        /// <summary>
        /// �댯�i�K�敪
        /// </summary>
        [Column("�댯�i�K�敪")]
        public Decimal? �댯�i�K�敪 { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column("��������")]
        public Decimal? �������� { get; set; }

        /// <summary>
        /// ���ϊ|����
        /// </summary>
        [Column("���ϊ|����")]
        public Decimal? ���ϊ|���� { get; set; }

        /// <summary>
        /// ���ɕ��S���ϊ|��
        /// </summary>
        [Column("���ɕ��S���ϊ|��")]
        public Decimal? ���ɕ��S���ϊ|�� { get; set; }

        /// <summary>
        /// �_�ƕ��S���ϊ|��
        /// </summary>
        [Column("�_�ƕ��S���ϊ|��")]
        public Decimal? �_�ƕ��S���ϊ|�� { get; set; }

        /// <summary>
        /// ���ό�����
        /// </summary>
        [Column("���ό�����")]
        public Decimal? ���ό����� { get; set; }

        /// <summary>
        /// �x�����ϋ�
        /// </summary>
        [Column("�x�����ϋ�")]
        public Decimal? �x�����ϋ� { get; set; }

        /// <summary>
        /// ���x�����ϋ�
        /// </summary>
        [Column("���x�����ϋ�")]
        public Decimal? ���x�����ϋ� { get; set; }

        /// <summary>
        /// ���ዤ�ό�����
        /// </summary>
        [Column("���ዤ�ό�����")]
        public Decimal? ���ዤ�ό����� { get; set; }

        /// <summary>
        /// ����x�����ϋ�
        /// </summary>
        [Column("����x�����ϋ�")]
        public Decimal? ����x�����ϋ� { get; set; }

        /// <summary>
        /// ������x�����ϋ�
        /// </summary>
        [Column("������x�����ϋ�")]
        public Decimal? ������x�����ϋ� { get; set; }

        /// <summary>
        /// ���n�ʊm�F���@
        /// </summary>
        [Column("���n�ʊm�F���@")]
        [StringLength(2)]
        public string ���n�ʊm�F���@ { get; set; }

        /// <summary>
        /// �c�_�Ώۋ敪
        /// </summary>
        [Column("�c�_�Ώۋ敪")]
        [StringLength(1)]
        public string �c�_�Ώۋ敪 { get; set; }

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
