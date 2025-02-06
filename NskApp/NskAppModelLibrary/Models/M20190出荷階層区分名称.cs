using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20190_�o�׊K�w�敪����
    /// </summary>
    [Serializable]
    [Table("m_20190_�o�׊K�w�敪����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�o�ו]���n��R�[�h), nameof(�o�׊K�w�敪))]
    public class M20190�o�׊K�w�敪���� : ModelBase
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
        /// �o�ו]���n��R�[�h
        /// </summary>
        [Required]
        [Column("�o�ו]���n��R�[�h", Order = 4)]
        [StringLength(4)]
        public string �o�ו]���n��R�[�h { get; set; }

        /// <summary>
        /// �o�׊K�w�敪
        /// </summary>
        [Required]
        [Column("�o�׊K�w�敪", Order = 5)]
        [StringLength(3)]
        public string �o�׊K�w�敪 { get; set; }

        /// <summary>
        /// �o�׊K�w�敪����
        /// </summary>
        [Column("�o�׊K�w�敪����")]
        public string �o�׊K�w�敪���� { get; set; }

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
