using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_00050_��t��
    /// </summary>
    [Serializable]
    [Table("t_00050_��t��")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(�N�Y), nameof(���S����t�敪), nameof(��t��))]
    public class T00050��t�� : ModelBase
    {
        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("�g�����R�[�h", Order = 3)]
        [StringLength(3)]
        public string �g�����R�[�h { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �N�Y
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�N�Y", Order = 2)]
        public short �N�Y { get; set; }

        /// <summary>
        /// ���S����t�敪
        /// </summary>
        [Required]
        [Column("���S����t�敪", Order = 4)]
        [StringLength(1)]
        public string ���S����t�敪 { get; set; }

        /// <summary>
        /// ��t��
        /// </summary>
        [Required]
        [Column("��t��", Order = 5)]
        [StringLength(2)]
        public string ��t�� { get; set; }

        /// <summary>
        /// �R�Â��񍐉�
        /// </summary>
        [Column("�R�Â��񍐉�")]
        [StringLength(2)]
        public string �R�Â��񍐉� { get; set; }

        /// <summary>
        /// ��t�v�Z���{��
        /// </summary>
        [Column("��t�v�Z���{��")]
        public DateTime? ��t�v�Z���{�� { get; set; }

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
