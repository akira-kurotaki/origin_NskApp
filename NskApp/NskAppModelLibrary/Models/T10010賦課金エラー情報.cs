using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_10010_���ۋ��G���[���
    /// </summary>
    [Serializable]
    [Table("t_10010_���ۋ��G���[���")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�������), nameof(����敪), nameof(��n��R�[�h), nameof(�G���[�����N))]
    public class T10010���ۋ��G���[��� : ModelBase
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
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 6)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Required]
        [Column("��n��R�[�h", Order = 7)]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// �G���[�����N
        /// </summary>
        [Required]
        [Column("�G���[�����N", Order = 8)]
        [StringLength(1)]
        public string �G���[�����N { get; set; }

        /// <summary>
        /// �G���[���
        /// </summary>
        [Column("�G���[���")]
        [StringLength(5)]
        public string �G���[��� { get; set; }

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
