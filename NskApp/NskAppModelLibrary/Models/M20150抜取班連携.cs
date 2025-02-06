using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20150_����ǘA�g
    /// </summary>
    [Serializable]
    [Table("m_20150_����ǘA�g")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�K�w�敪), nameof(�]���n��R�[�h))]
    public class M20150����ǘA�g : ModelBase
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
        /// �K�w�敪
        /// </summary>
        [Required]
        [Column("�K�w�敪", Order = 4)]
        [StringLength(3)]
        public string �K�w�敪 { get; set; }

        /// <summary>
        /// �]���n��R�[�h
        /// </summary>
        [Required]
        [Column("�]���n��R�[�h", Order = 5)]
        [StringLength(4)]
        public string �]���n��R�[�h { get; set; }

        /// <summary>
        /// ���撲���ǃR�[�h
        /// </summary>
        [Column("���撲���ǃR�[�h")]
        [StringLength(3)]
        public string ���撲���ǃR�[�h { get; set; }

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
