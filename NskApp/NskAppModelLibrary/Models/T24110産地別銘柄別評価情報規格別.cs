using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24110_�Y�n�ʖ����ʕ]�����_�K�i��
    /// </summary>
    [Serializable]
    [Table("t_24110_�Y�n�ʖ����ʕ]�����_�K�i��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�Y�n�ʖ����R�[�h), nameof(�c�_�ΏۊO�t���O), nameof(�ދ敪), nameof(���Z�敪), nameof(�K�i))]
    public class T24110�Y�n�ʖ����ʕ]�����K�i�� : ModelBase
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
        /// �K�i
        /// </summary>
        [Required]
        [Column("�K�i", Order = 9)]
        [StringLength(2)]
        public string �K�i { get; set; }

        /// <summary>
        /// ���n��
        /// </summary>
        [Column("���n��")]
        public Decimal? ���n�� { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [Column("����������")]
        public Decimal? ���������� { get; set; }

        /// <summary>
        /// ��������n��
        /// </summary>
        [Column("��������n��")]
        public Decimal? ��������n�� { get; set; }

        /// <summary>
        /// �i���w��
        /// </summary>
        [Column("�i���w��")]
        public Decimal? �i���w�� { get; set; }

        /// <summary>
        /// ��������n��
        /// </summary>
        [Column("��������n��")]
        public Decimal? ��������n�� { get; set; }

        /// <summary>
        /// ����������P��
        /// </summary>
        [Column("����������P��")]
        public Decimal? ����������P�� { get; set; }

        /// <summary>
        /// ���Y���z
        /// </summary>
        [Column("���Y���z")]
        public Decimal? ���Y���z { get; set; }

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
