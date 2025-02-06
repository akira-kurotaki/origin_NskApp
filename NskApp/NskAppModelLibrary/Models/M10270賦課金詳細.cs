using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10270_���ۋ��ڍ�
    /// </summary>
    [Serializable]
    [Table("m_10270_���ۋ��ڍ�")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�������), nameof(����敪), nameof(��n��R�[�h), nameof(�����N))]
    public class M10270���ۋ��ڍ� : ModelBase
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
        /// �����N
        /// </summary>
        [Required]
        [Column("�����N", Order = 8)]
        [StringLength(2)]
        public string �����N { get; set; }

        /// <summary>
        /// �ʐϊ����ےP��_���
        /// </summary>
        [Column("�ʐϊ����ےP��_���")]
        public Decimal? �ʐϊ����ےP��_��� { get; set; }

        /// <summary>
        /// �ʐϊ����ےP��_�h��
        /// </summary>
        [Column("�ʐϊ����ےP��_�h��")]
        public Decimal? �ʐϊ����ےP��_�h�� { get; set; }

        /// <summary>
        /// �ʐϊ����ےP��_����
        /// </summary>
        [Column("�ʐϊ����ےP��_����")]
        public Decimal? �ʐϊ����ےP��_���� { get; set; }

        /// <summary>
        /// ���ی��x�ʐ�
        /// </summary>
        [Column("���ی��x�ʐ�")]
        public Decimal? ���ی��x�ʐ� { get; set; }

        /// <summary>
        /// ���ʊ����ےP��_���
        /// </summary>
        [Column("���ʊ����ےP��_���")]
        public Decimal? ���ʊ����ےP��_��� { get; set; }

        /// <summary>
        /// ���ʊ����ےP��_�h��
        /// </summary>
        [Column("���ʊ����ےP��_�h��")]
        public Decimal? ���ʊ����ےP��_�h�� { get; set; }

        /// <summary>
        /// ���ʊ����ےP��_����
        /// </summary>
        [Column("���ʊ����ےP��_����")]
        public Decimal? ���ʊ����ےP��_���� { get; set; }

        /// <summary>
        /// ���ی��x����
        /// </summary>
        [Column("���ی��x����")]
        public Decimal? ���ی��x���� { get; set; }

        /// <summary>
        /// ����Y���z�����ےP��_���
        /// </summary>
        [Column("����Y���z�����ےP��_���")]
        public Decimal? ����Y���z�����ےP��_��� { get; set; }

        /// <summary>
        /// ����Y���z�����ےP��_�h��
        /// </summary>
        [Column("����Y���z�����ےP��_�h��")]
        public Decimal? ����Y���z�����ےP��_�h�� { get; set; }

        /// <summary>
        /// ����Y���z�����ےP��_����
        /// </summary>
        [Column("����Y���z�����ےP��_����")]
        public Decimal? ����Y���z�����ےP��_���� { get; set; }

        /// <summary>
        /// ���ی��x����Y���z
        /// </summary>
        [Column("���ی��x����Y���z")]
        public Decimal? ���ی��x����Y���z { get; set; }

        /// <summary>
        /// ���z�����ےP��_���
        /// </summary>
        [Column("���z�����ےP��_���")]
        public Decimal? ���z�����ےP��_��� { get; set; }

        /// <summary>
        /// ���z�����ےP��_�h��
        /// </summary>
        [Column("���z�����ےP��_�h��")]
        public Decimal? ���z�����ےP��_�h�� { get; set; }

        /// <summary>
        /// ���z�����ےP��_����
        /// </summary>
        [Column("���z�����ےP��_����")]
        public Decimal? ���z�����ےP��_���� { get; set; }

        /// <summary>
        /// ���ی��x���ϋ��z
        /// </summary>
        [Column("���ی��x���ϋ��z")]
        public Decimal? ���ی��x���ϋ��z { get; set; }

        /// <summary>
        /// �[�������R�[�h
        /// </summary>
        [Column("�[�������R�[�h")]
        [StringLength(1)]
        public string �[�������R�[�h { get; set; }

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
