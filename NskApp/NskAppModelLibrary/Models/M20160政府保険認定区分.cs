using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20160_���{�ی��F��敪
    /// </summary>
    [Serializable]
    [Table("m_20160_���{�ی��F��敪")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�������), nameof(�ދ敪), nameof(���ʃR�[�h))]
    public class M20160���{�ی��F��敪 : ModelBase
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
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 4)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���ʃR�[�h
        /// </summary>
        [Required]
        [Column("���ʃR�[�h", Order = 6)]
        [StringLength(2)]
        public string ���ʃR�[�h { get; set; }

        /// <summary>
        /// �\�t���O
        /// </summary>
        [Column("�\�t���O")]
        [StringLength(1)]
        public string �\�t���O { get; set; }

        /// <summary>
        /// ���{�ی��F��敪
        /// </summary>
        [Column("���{�ی��F��敪")]
        [StringLength(4)]
        public string ���{�ی��F��敪 { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column("��������")]
        public string �������� { get; set; }

        /// <summary>
        /// �Z�k����
        /// </summary>
        [Column("�Z�k����")]
        public string �Z�k���� { get; set; }

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
