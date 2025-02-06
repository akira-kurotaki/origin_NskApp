using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_22040_���n���ݒ�
    /// </summary>
    [Serializable]
    [Table("t_22040_���n���ݒ�")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�������), nameof(�⏞����), nameof(����敪))]
    public class T22040���n���ݒ� : ModelBase
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
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �⏞����
        /// </summary>
        [Required]
        [Column("�⏞����", Order = 6)]
        [StringLength(2)]
        public string �⏞���� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 7)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// ���n���{��Q����
        /// </summary>
        [Column("���n���{��Q����")]
        public Decimal? ���n���{��Q���� { get; set; }

        /// <summary>
        /// ���n�x����
        /// </summary>
        [Column("���n�x����")]
        public Decimal? ���n�x���� { get; set; }

        /// <summary>
        /// ���n�[�������R�[�h
        /// </summary>
        [Column("���n�[�������R�[�h")]
        [StringLength(1)]
        public string ���n�[�������R�[�h { get; set; }

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
    }
}
