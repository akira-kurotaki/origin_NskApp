using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24100_�Y�n�ʖ����ʕ]�����
    /// </summary>
    [Serializable]
    [Table("t_24100_�Y�n�ʖ����ʕ]�����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�Y�n�ʖ����R�[�h), nameof(�c�_�ΏۊO�t���O), nameof(�ދ敪), nameof(���Z�敪))]
    public class T24100�Y�n�ʖ����ʕ]����� : ModelBase
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
        /// ���n�ʌv
        /// </summary>
        [Column("���n�ʌv")]
        public Decimal? ���n�ʌv { get; set; }

        /// <summary>
        /// ���������ʌv
        /// </summary>
        [Column("���������ʌv")]
        public Decimal? ���������ʌv { get; set; }

        /// <summary>
        /// ��������n�ʌv
        /// </summary>
        [Column("��������n�ʌv")]
        public Decimal? ��������n�ʌv { get; set; }

        /// <summary>
        /// ��������n�ʌv
        /// </summary>
        [Column("��������n�ʌv")]
        public Decimal? ��������n�ʌv { get; set; }

        /// <summary>
        /// ����n��
        /// </summary>
        [Column("����n��")]
        public Decimal? ����n�� { get; set; }

        /// <summary>
        /// ���Y���z�v
        /// </summary>
        [Column("���Y���z�v")]
        public Decimal? ���Y���z�v { get; set; }

        /// <summary>
        /// ����Y���z
        /// </summary>
        [Column("����Y���z")]
        public Decimal? ����Y���z { get; set; }

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
