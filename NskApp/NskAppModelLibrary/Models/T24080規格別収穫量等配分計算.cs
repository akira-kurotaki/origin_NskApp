using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24080_�K�i�ʎ��n�ʓ��z���v�Z
    /// </summary>
    [Serializable]
    [Table("t_24080_�K�i�ʎ��n�ʓ��z���v�Z")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�Y�n�ʖ����R�[�h), nameof(�c�_�ΏۊO�t���O), nameof(�ދ敪), nameof(���Z�敪))]
    public class T24080�K�i�ʎ��n�ʓ��z���v�Z : ModelBase
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
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 4)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �Y�n�ʖ����R�[�h
        /// </summary>
        [Required]
        [Column("�Y�n�ʖ����R�[�h", Order = 5)]
        [StringLength(5)]
        public string �Y�n�ʖ����R�[�h { get; set; }

        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Required]
        [Column("�c�_�ΏۊO�t���O", Order = 6)]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 7)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���Z�敪
        /// </summary>
        [Required]
        [Column("���Z�敪", Order = 8)]
        [StringLength(1)]
        public string ���Z�敪 { get; set; }

        /// <summary>
        /// �o�א��ʓ����v
        /// </summary>
        [Column("�o�א��ʓ����v")]
        public Decimal? �o�א��ʓ����v { get; set; }

        /// <summary>
        /// �K�i���ʏo�׊����v
        /// </summary>
        [Column("�K�i���ʏo�׊����v")]
        public Decimal? �K�i���ʏo�׊����v { get; set; }

        /// <summary>
        /// �K�i�ʐ��ʍ��v
        /// </summary>
        [Column("�K�i�ʐ��ʍ��v")]
        public Decimal? �K�i�ʐ��ʍ��v { get; set; }

        /// <summary>
        /// ���������ʍ��v
        /// </summary>
        [Column("���������ʍ��v")]
        public Decimal? ���������ʍ��v { get; set; }

        /// <summary>
        /// �K�i�ʊ����v
        /// </summary>
        [Column("�K�i�ʊ����v")]
        public Decimal? �K�i�ʊ����v { get; set; }

        /// <summary>
        /// ���������ʍ��v�Q
        /// </summary>
        [Column("���������ʍ��v�Q")]
        public Decimal? ���������ʍ��v�Q { get; set; }

        /// <summary>
        /// ���������ʍ��v�R
        /// </summary>
        [Column("���������ʍ��v�R")]
        public Decimal? ���������ʍ��v�R { get; set; }

        /// <summary>
        /// ���������ʍ��v�v
        /// </summary>
        [Column("���������ʍ��v�v")]
        public Decimal? ���������ʍ��v�v { get; set; }

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
