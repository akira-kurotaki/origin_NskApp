using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10050_��P��
    /// </summary>
    [Serializable]
    [Table("m_10050_��P��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�x���R�[�h))]
    public class M10050��P�� : ModelBase
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
        /// �x���R�[�h
        /// </summary>
        [Required]
        [Column("�x���R�[�h", Order = 5)]
        [StringLength(2)]
        public string �x���R�[�h { get; set; }

        /// <summary>
        /// ���ʒm�w���P��
        /// </summary>
        [Column("���ʒm�w���P��")]
        public Decimal? ���ʒm�w���P�� { get; set; }

        /// <summary>
        /// �ڕW�l
        /// </summary>
        [Column("�ڕW�l")]
        public Decimal? �ڕW�l { get; set; }

        /// <summary>
        /// �ō�����
        /// </summary>
        [Column("�ō�����")]
        public Decimal? �ō����� { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Column("������")]
        public Decimal? ������ { get; set; }

        /// <summary>
        /// ��
        /// </summary>
        [Column("��")]
        public Decimal? �� { get; set; }

        /// <summary>
        /// ⿖ڏC���W��
        /// </summary>
        [Column("⿖ڏC���W��")]
        public Decimal? ⿖ڏC���W�� { get; set; }

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
