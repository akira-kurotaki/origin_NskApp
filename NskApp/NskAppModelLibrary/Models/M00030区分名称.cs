using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00030_�敪����
    /// </summary>
    [Serializable]
    [Table("m_00030_�敪����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�敪�R�[�h))]
    public class M00030�敪���� : ModelBase
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
        /// �敪�R�[�h
        /// </summary>
        [Required]
        [Column("�敪�R�[�h", Order = 4)]
        [StringLength(2)]
        public string �敪�R�[�h { get; set; }

        /// <summary>
        /// �敪����
        /// </summary>
        [Column("�敪����")]
        public string �敪���� { get; set; }

        /// <summary>
        /// ����t���O
        /// </summary>
        [Column("����t���O")]
        [StringLength(1)]
        public string ����t���O { get; set; }

        /// <summary>
        /// �]��t���O
        /// </summary>
        [Column("�]��t���O")]
        [StringLength(1)]
        public string �]��t���O { get; set; }

        /// <summary>
        /// �Q�ރt���O
        /// </summary>
        [Column("�Q�ރt���O")]
        [StringLength(1)]
        public string �Q�ރt���O { get; set; }

        /// <summary>
        /// �G���[�^�C�v
        /// </summary>
        [Column("�G���[�^�C�v")]
        [StringLength(1)]
        public string �G���[�^�C�v { get; set; }

        /// <summary>
        /// ���l
        /// </summary>
        [Column("���l")]
        public string ���l { get; set; }

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
