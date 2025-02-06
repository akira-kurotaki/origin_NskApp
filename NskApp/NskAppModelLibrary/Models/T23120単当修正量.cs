using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_23120_�P���C����
    /// </summary>
    [Serializable]
    [Table("t_23120_�P���C����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(���������ʃR�[�h), nameof(�ދ敪), nameof(�������), nameof(�⏞�����R�[�h), nameof(�]���n��R�[�h), nameof(�K�w�敪))]
    public class T23120�P���C���� : ModelBase
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
        /// ���ϒP����
        /// </summary>
        [Column("���ϒP����")]
        public Decimal? ���ϒP���� { get; set; }

        /// <summary>
        /// �P���C����
        /// </summary>
        [Column("�P���C����")]
        public Decimal? �P���C���� { get; set; }

        /// <summary>
        /// �C�������t���O
        /// </summary>
        [Column("�C�������t���O")]
        public Decimal? �C�������t���O { get; set; }

        /// <summary>
        /// �v�Z�P�ʗދ敪
        /// </summary>
        [Column("�v�Z�P�ʗދ敪")]
        public Decimal? �v�Z�P�ʗދ敪 { get; set; }

        /// <summary>
        /// �v�Z�P�ʈ������
        /// </summary>
        [Column("�v�Z�P�ʈ������")]
        public Decimal? �v�Z�P�ʈ������ { get; set; }

        /// <summary>
        /// �v�Z�P�ʕ⏞����
        /// </summary>
        [Column("�v�Z�P�ʕ⏞����")]
        public Decimal? �v�Z�P�ʕ⏞���� { get; set; }

        /// <summary>
        /// ���ߔ�Q�ʐ�
        /// </summary>
        [Column("���ߔ�Q�ʐ�")]
        public Decimal? ���ߔ�Q�ʐ� { get; set; }

        /// <summary>
        /// ���F�]���ʐ�
        /// </summary>
        [Column("���F�]���ʐ�")]
        public Decimal? ���F�]���ʐ� { get; set; }

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
