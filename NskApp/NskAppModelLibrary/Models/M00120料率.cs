using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00120_����
    /// </summary>
    [Serializable]
    [Table("m_00120_����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(���������ʃR�[�h), nameof(�ދ敪), nameof(�������), nameof(����敪), nameof(�⏞�����R�[�h), nameof(���v�P�ʒn��R�[�h))]
    public class M00120���� : ModelBase
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
        /// ���������ʃR�[�h
        /// </summary>
        [Required]
        [Column("���������ʃR�[�h", Order = 4)]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 6)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 7)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Column("�⏞�����R�[�h", Order = 8)]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// ���v�P�ʒn��R�[�h
        /// </summary>
        [Required]
        [Column("���v�P�ʒn��R�[�h", Order = 9)]
        [StringLength(5)]
        public string ���v�P�ʒn��R�[�h { get; set; }

        /// <summary>
        /// �ӔC�ی�����
        /// </summary>
        [Column("�ӔC�ی�����")]
        public Decimal? �ӔC�ی����� { get; set; }

        /// <summary>
        /// ���ϊ|���W����
        /// </summary>
        [Column("���ϊ|���W����")]
        public Decimal? ���ϊ|���W���� { get; set; }

        /// <summary>
        /// �ʏ�W����Q��
        /// </summary>
        [Column("�ʏ�W����Q��")]
        public Decimal? �ʏ�W����Q�� { get; set; }

        /// <summary>
        /// �ی�����b��
        /// </summary>
        [Column("�ی�����b��")]
        public Decimal? �ی�����b�� { get; set; }

        /// <summary>
        /// �ُ�W����Q��
        /// </summary>
        [Column("�ُ�W����Q��")]
        public Decimal? �ُ�W����Q�� { get; set; }

        /// <summary>
        /// �ĕی�����b��
        /// </summary>
        [Column("�ĕی�����b��")]
        public Decimal? �ĕی�����b�� { get; set; }

        /// <summary>
        /// ���ɕ��S����
        /// </summary>
        [Column("���ɕ��S����")]
        public Decimal? ���ɕ��S���� { get; set; }

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
