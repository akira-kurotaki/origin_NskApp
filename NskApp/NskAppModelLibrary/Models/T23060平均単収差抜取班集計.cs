using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_23060_���ϒP����_����ǏW�v
    /// </summary>
    [Serializable]
    [Table("t_23060_���ϒP����_����ǏW�v")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�x���R�[�h), nameof(�ދ敪), nameof(�������), nameof(�⏞�����R�[�h), nameof(���撲���ǃR�[�h))]
    public class T23060���ϒP��������ǏW�v : ModelBase
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
        /// �x���R�[�h
        /// </summary>
        [Required]
        [Column("�x���R�[�h", Order = 4)]
        [StringLength(2)]
        public string �x���R�[�h { get; set; }

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
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Column("�⏞�����R�[�h", Order = 7)]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// ���撲���ǃR�[�h
        /// </summary>
        [Required]
        [Column("���撲���ǃR�[�h", Order = 8)]
        [StringLength(3)]
        public string ���撲���ǃR�[�h { get; set; }

        /// <summary>
        /// �����M��
        /// </summary>
        [Column("�����M��")]
        public Decimal? �����M�� { get; set; }

        /// <summary>
        /// ���撲�������P��
        /// </summary>
        [Column("���撲�������P��")]
        public Decimal? ���撲�������P�� { get; set; }

        /// <summary>
        /// �����P��
        /// </summary>
        [Column("�����P��")]
        public Decimal? �����P�� { get; set; }

        /// <summary>
        /// �����P���C���W��
        /// </summary>
        [Column("�����P���C���W��")]
        public Decimal? �����P���C���W�� { get; set; }

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
