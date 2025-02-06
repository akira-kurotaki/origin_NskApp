using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10170_�I���������
    /// </summary>
    [Serializable]
    [Table("m_10170_�I���������")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(���ϖړI�R�[�h), nameof(�������), nameof(����敪), nameof(�⏞�����R�[�h), nameof(�ދ敪))]
    public class M10170�I��������� : ModelBase
    {
        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("�g�����R�[�h", Order = 1)]
        [StringLength(3)]
        public string �g�����R�[�h { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 2)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 3)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 4)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Column("�⏞�����R�[�h", Order = 5)]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 6)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �\����
        /// </summary>
        [Column("�\����")]
        public short? �\���� { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        [Column("�����������")]
        public string ����������� { get; set; }

        /// <summary>
        /// ����敪����
        /// </summary>
        [Column("����敪����")]
        public string ����敪���� { get; set; }

        /// <summary>
        /// �⏞��������
        /// </summary>
        [Column("�⏞��������")]
        public string �⏞�������� { get; set; }

        /// <summary>
        /// �ޒZ�k����
        /// </summary>
        [Column("�ޒZ�k����")]
        public string �ޒZ�k���� { get; set; }

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
