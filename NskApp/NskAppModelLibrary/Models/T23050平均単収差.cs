using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_23050_���ϒP����
    /// </summary>
    [Serializable]
    [Table("t_23050_���ϒP����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�x���R�[�h), nameof(�ދ敪), nameof(�������), nameof(�⏞�����R�[�h), nameof(�]���n��R�[�h), nameof(�K�w�敪))]
    public class T23050���ϒP���� : ModelBase
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
        /// �]���n��R�[�h
        /// </summary>
        [Required]
        [Column("�]���n��R�[�h", Order = 8)]
        [StringLength(4)]
        public string �]���n��R�[�h { get; set; }

        /// <summary>
        /// �K�w�敪
        /// </summary>
        [Required]
        [Column("�K�w�敪", Order = 9)]
        [StringLength(3)]
        public string �K�w�敪 { get; set; }

        /// <summary>
        /// ���F�����ʐ�
        /// </summary>
        [Column("���F�����ʐ�")]
        public Decimal? ���F�����ʐ� { get; set; }

        /// <summary>
        /// ����M��
        /// </summary>
        [Column("����M��")]
        public Decimal? ����M�� { get; set; }

        /// <summary>
        /// �����M��
        /// </summary>
        [Column("�����M��")]
        public Decimal? �����M�� { get; set; }

        /// <summary>
        /// �����P�����v
        /// </summary>
        [Column("�����P�����v")]
        public Decimal? �����P�����v { get; set; }

        /// <summary>
        /// ����M�̎��F�P�����v
        /// </summary>
        [Column("����M�̎��F�P�����v")]
        public Decimal? ����M�̎��F�P�����v { get; set; }

        /// <summary>
        /// �����P�����v
        /// </summary>
        [Column("�����P�����v")]
        public Decimal? �����P�����v { get; set; }

        /// <summary>
        /// �����M�̌����P�����v
        /// </summary>
        [Column("�����M�̌����P�����v")]
        public Decimal? �����M�̌����P�����v { get; set; }

        /// <summary>
        /// ���ϒP����
        /// </summary>
        [Column("���ϒP����")]
        public Decimal? ���ϒP���� { get; set; }

        /// <summary>
        /// �������ϒP����
        /// </summary>
        [Column("�������ϒP����")]
        public Decimal? �������ϒP���� { get; set; }

        /// <summary>
        /// ���蕽�ϒP����
        /// </summary>
        [Column("���蕽�ϒP����")]
        public Decimal? ���蕽�ϒP���� { get; set; }

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
