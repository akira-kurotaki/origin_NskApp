using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12050_�g�������ʈ���p�r
    /// </summary>
    [Serializable]
    [Table("t_12050_�g�������ʈ���p�r")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�����), nameof(�g�������R�[�h), nameof(�ދ敪), nameof(���v�P�ʒn��R�[�h), nameof(��t����), nameof(�p�r�敪))]
    public class T12050�g�������ʈ���p�r : ModelBase
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
        /// ���v�P�ʒn��R�[�h
        /// </summary>
        [Required]
        [Column("���v�P�ʒn��R�[�h", Order = 7)]
        [StringLength(5)]
        public string ���v�P�ʒn��R�[�h { get; set; }

        /// <summary>
        /// ��t����
        /// </summary>
        [Required]
        [Column("��t����", Order = 8)]
        [StringLength(1)]
        public string ��t���� { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Required]
        [Column("�p�r�敪", Order = 9)]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// ��ދ敪
        /// </summary>
        [Column("��ދ敪")]
        [StringLength(1)]
        public string ��ދ敪 { get; set; }

        /// <summary>
        /// �c���敪
        /// </summary>
        [Column("�c���敪")]
        [StringLength(1)]
        public string �c���敪 { get; set; }

        /// <summary>
        /// ����M��
        /// </summary>
        [Column("����M��")]
        public Decimal? ����M�� { get; set; }

        /// <summary>
        /// ����ʐόv
        /// </summary>
        [Column("����ʐόv")]
        public Decimal? ����ʐόv { get; set; }

        /// <summary>
        /// ����n�ʌv
        /// </summary>
        [Column("����n�ʌv")]
        public Decimal? ����n�ʌv { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        public Decimal? ������� { get; set; }

        /// <summary>
        /// ���ϋ��z�I������
        /// </summary>
        [Column("���ϋ��z�I������")]
        public Decimal? ���ϋ��z�I������ { get; set; }

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
