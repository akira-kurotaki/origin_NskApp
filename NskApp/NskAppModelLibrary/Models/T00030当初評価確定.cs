using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_00030_�����]���m��
    /// </summary>
    [Serializable]
    [Table("t_00030_�����]���m��")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(�N�Y), nameof(�x���R�[�h), nameof(�������), nameof(���{�ی��F��敪))]
    public class T00030�����]���m�� : ModelBase
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
        /// �x���R�[�h
        /// </summary>
        [Required]
        [Column("�x���R�[�h", Order = 4)]
        [StringLength(2)]
        public string �x���R�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 5)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ���{�ی��F��敪
        /// </summary>
        [Required]
        [Column("���{�ی��F��敪", Order = 6)]
        [StringLength(4)]
        public string ���{�ی��F��敪 { get; set; }

        /// <summary>
        /// �����]�����v�Z���{��
        /// </summary>
        [Column("�����]�����v�Z���{��")]
        public DateTime? �����]�����v�Z���{�� { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column("����")]
        public int? ���� { get; set; }

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
