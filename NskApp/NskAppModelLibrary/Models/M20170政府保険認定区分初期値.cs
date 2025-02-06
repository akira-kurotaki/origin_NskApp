using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20170_���{�ی��F��敪�����l
    /// </summary>
    [Serializable]
    [Table("m_20170_���{�ی��F��敪�����l")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(�������), nameof(�ދ敪), nameof(�\�t���O), nameof(���̑��R�[�h), nameof(�敪�t���O))]
    public class M20170���{�ی��F��敪�����l : ModelBase
    {
        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 2)]
        [StringLength(4)]
        public string ������� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 3)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �\�t���O
        /// </summary>
        [Required]
        [Column("�\�t���O", Order = 4)]
        [StringLength(3)]
        public string �\�t���O { get; set; }

        /// <summary>
        /// ���̑��R�[�h
        /// </summary>
        [Required]
        [Column("���̑��R�[�h", Order = 5)]
        [StringLength(4)]
        public string ���̑��R�[�h { get; set; }

        /// <summary>
        /// �敪�t���O
        /// </summary>
        [Required]
        [Column("�敪�t���O", Order = 6)]
        [StringLength(3)]
        public string �敪�t���O { get; set; }

        /// <summary>
        /// ���{�ی��F��敪
        /// </summary>
        [Column("���{�ی��F��敪")]
        [StringLength(3)]
        public string ���{�ی��F��敪 { get; set; }

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
