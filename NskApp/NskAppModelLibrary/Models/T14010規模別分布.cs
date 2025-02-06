using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_14010_�K�͕ʕ��z
    /// </summary>
    [Serializable]
    [Table("t_14010_�K�͕ʕ��z")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�����), nameof(�ދ敪), nameof(���������ʃR�[�h), nameof(��n��R�[�h), nameof(����ʐϋ敪))]
    public class T14010�K�͕ʕ��z : ModelBase
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
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���������ʃR�[�h
        /// </summary>
        [Required]
        [Column("���������ʃR�[�h", Order = 6)]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Required]
        [Column("��n��R�[�h", Order = 7)]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// ����ʐϋ敪
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("����ʐϋ敪", Order = 8)]
        public Decimal ����ʐϋ敪 { get; set; }

        /// <summary>
        /// ��������L���t���O
        /// </summary>
        [Column("��������L���t���O")]
        [StringLength(1)]
        public string ��������L���t���O { get; set; }

        /// <summary>
        /// ����ː�
        /// </summary>
        [Column("����ː�")]
        public Decimal? ����ː� { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

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
