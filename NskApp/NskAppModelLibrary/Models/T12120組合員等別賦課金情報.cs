using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12120_�g�������ʕ��ۋ����
    /// </summary>
    [Serializable]
    [Table("t_12120_�g�������ʕ��ۋ����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�����), nameof(�g�������R�[�h), nameof(�ދ敪), nameof(���ۋ��������), nameof(����敪))]
    public class T12120�g�������ʕ��ۋ���� : ModelBase
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
        /// ���ۋ��������
        /// </summary>
        [Required]
        [Column("���ۋ��������", Order = 7)]
        [StringLength(2)]
        public string ���ۋ�������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 8)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Column("��n��R�[�h")]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// ��ʕ��ۋ�
        /// </summary>
        [Column("��ʕ��ۋ�")]
        public Decimal? ��ʕ��ۋ� { get; set; }

        /// <summary>
        /// �h�Е��ۋ�
        /// </summary>
        [Column("�h�Е��ۋ�")]
        public Decimal? �h�Е��ۋ� { get; set; }

        /// <summary>
        /// ���ʕ��ۋ�
        /// </summary>
        [Column("���ʕ��ۋ�")]
        public Decimal? ���ʕ��ۋ� { get; set; }

        /// <summary>
        /// �h�ВP��
        /// </summary>
        [Column("�h�ВP��")]
        public Decimal? �h�ВP�� { get; set; }

        /// <summary>
        /// ���ʒP��
        /// </summary>
        [Column("���ʒP��")]
        public Decimal? ���ʒP�� { get; set; }

        /// <summary>
        /// ���ۋ�����z
        /// </summary>
        [Column("���ۋ�����z")]
        public Decimal? ���ۋ�����z { get; set; }

        /// <summary>
        /// �����ۋ����v
        /// </summary>
        [Column("�����ۋ����v")]
        public Decimal? �����ۋ����v { get; set; }

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
