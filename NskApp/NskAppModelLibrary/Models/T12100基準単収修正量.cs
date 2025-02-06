using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12100_��P���C����
    /// </summary>
    [Serializable]
    [Table("t_12100_��P���C����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�x���R�[�h))]
    public class T12100��P���C���� : ModelBase
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
        /// �K�p�����
        /// </summary>
        [Column("�K�p�����")]
        public short? �K�p����� { get; set; }

        /// <summary>
        /// ��C����
        /// </summary>
        [Column("��C����")]
        public Decimal? ��C���� { get; set; }

        /// <summary>
        /// �O��C����
        /// </summary>
        [Column("�O��C����")]
        public Decimal? �O��C���� { get; set; }

        /// <summary>
        /// �C����
        /// </summary>
        [Column("�C����")]
        public Decimal? �C���� { get; set; }

        /// <summary>
        /// ��P���C���ʌv�Z���{��
        /// </summary>
        [Column("��P���C���ʌv�Z���{��")]
        public DateTime? ��P���C���ʌv�Z���{�� { get; set; }

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
