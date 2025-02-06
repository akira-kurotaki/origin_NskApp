using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12110_����n�ʏW�v�\
    /// </summary>
    [Serializable]
    [Table("t_12110_����n�ʏW�v�\")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�x���R�[�h), nameof(��n��R�[�h), nameof(���n��R�[�h), nameof(���ʓ����R�[�h), nameof(�i��R�[�h), nameof(�Q�ރR�[�h))]
    public class T12110����n�ʏW�v�\ : ModelBase
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
        /// ��n��R�[�h
        /// </summary>
        [Required]
        [Column("��n��R�[�h", Order = 6)]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// ���n��R�[�h
        /// </summary>
        [Required]
        [Column("���n��R�[�h", Order = 7)]
        [StringLength(4)]
        public string ���n��R�[�h { get; set; }

        /// <summary>
        /// ���ʓ����R�[�h
        /// </summary>
        [Required]
        [Column("���ʓ����R�[�h", Order = 8)]
        [StringLength(3)]
        public string ���ʓ����R�[�h { get; set; }

        /// <summary>
        /// �i��R�[�h
        /// </summary>
        [Required]
        [Column("�i��R�[�h", Order = 9)]
        [StringLength(3)]
        public string �i��R�[�h { get; set; }

        /// <summary>
        /// �Q�ރR�[�h
        /// </summary>
        [Required]
        [Column("�Q�ރR�[�h", Order = 10)]
        [StringLength(3)]
        public string �Q�ރR�[�h { get; set; }

        /// <summary>
        /// �M��
        /// </summary>
        [Column("�M��")]
        public Decimal? �M�� { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// ����n��_�C���O
        /// </summary>
        [Column("����n��_�C���O")]
        public Decimal? ����n��_�C���O { get; set; }

        /// <summary>
        /// ����n��_�P�O�O��
        /// </summary>
        [Column("����n��_�P�O�O��")]
        public Decimal? ����n��_�P�O�O�o { get; set; }

        /// <summary>
        /// ����n��_�C����
        /// </summary>
        [Column("����n��_�C����")]
        public Decimal? ����n��_�C���� { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column("����")]
        public Decimal? ���� { get; set; }

        /// <summary>
        /// �i�햼��
        /// </summary>
        [Column("�i�햼��")]
        public string �i�햼�� { get; set; }

        /// <summary>
        /// �i��W��
        /// </summary>
        [Column("�i��W��")]
        public Decimal? �i��W�� { get; set; }

        /// <summary>
        /// �Q�ތW��
        /// </summary>
        [Column("�Q�ތW��")]
        public Decimal? �Q�ތW�� { get; set; }

        /// <summary>
        /// ��C����
        /// </summary>
        [Column("��C����")]
        public Decimal? ��C���� { get; set; }

        /// <summary>
        /// �C����
        /// </summary>
        [Column("�C����")]
        public Decimal? �C���� { get; set; }

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
