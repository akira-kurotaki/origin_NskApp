using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10230_�댯�i�K
    /// </summary>
    [Serializable]
    [Table("m_10230_�댯�i�K")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(���������ʃR�[�h), nameof(�ދ敪), nameof(�n��P�ʋ敪), nameof(�������), nameof(����敪), nameof(�⏞�����R�[�h), nameof(�댯�i�K�敪))]
    public class M10230�댯�i�K : ModelBase
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
        /// ���������ʃR�[�h
        /// </summary>
        [Required]
        [Column("���������ʃR�[�h", Order = 4)]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �n��P�ʋ敪
        /// </summary>
        [Required]
        [Column("�n��P�ʋ敪", Order = 6)]
        [StringLength(5)]
        public string �n��P�ʋ敪 { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 7)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 8)]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Column("�⏞�����R�[�h", Order = 9)]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// �댯�i�K�敪
        /// </summary>
        [Required]
        [Column("�댯�i�K�敪", Order = 10)]
        [StringLength(3)]
        public string �댯�i�K�敪 { get; set; }

        /// <summary>
        /// �댯�i�K����ϊ|����
        /// </summary>
        [Column("�댯�i�K����ϊ|����")]
        public Decimal? �댯�i�K����ϊ|���� { get; set; }

        /// <summary>
        /// �댯�i�K���ϊ|����
        /// </summary>
        [Column("�댯�i�K���ϊ|����")]
        public Decimal? �댯�i�K���ϊ|���� { get; set; }

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
