using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10060_���ʓ���
    /// </summary>
    [Serializable]
    [Table("m_10060_���ʓ���")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�x���R�[�h), nameof(���ʓ����R�[�h))]
    public class M10060���ʓ��� : ModelBase
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
        /// ��ދ敪
        /// </summary>
        [Column("��ދ敪")]
        [StringLength(1)]
        public string ��ދ敪 { get; set; }

        /// <summary>
        /// ��t����
        /// </summary>
        [Column("��t����")]
        [StringLength(1)]
        public string ��t���� { get; set; }

        /// <summary>
        /// �x���R�[�h
        /// </summary>
        [Required]
        [Column("�x���R�[�h", Order = 5)]
        [StringLength(2)]
        public string �x���R�[�h { get; set; }

        /// <summary>
        /// ���ʓ����R�[�h
        /// </summary>
        [Required]
        [Column("���ʓ����R�[�h", Order = 6)]
        [StringLength(3)]
        public string ���ʓ����R�[�h { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column("����")]
        [StringLength(4)]
        public string ���� { get; set; }

        /// <summary>
        /// �v�Z�P��
        /// </summary>
        [Column("�v�Z�P��")]
        public Decimal? �v�Z�P�� { get; set; }

        /// <summary>
        /// �K�p�P��
        /// </summary>
        [Column("�K�p�P��")]
        public Decimal? �K�p�P�� { get; set; }

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
