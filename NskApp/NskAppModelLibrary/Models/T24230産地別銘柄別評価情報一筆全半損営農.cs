using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24230_�Y�n�ʖ����ʕ]�����_��M�S����_�c�_
    /// </summary>
    [Serializable]
    [Table("t_24230_�Y�n�ʖ����ʕ]�����_��M�S����_�c�_")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�Y�n�ʖ����R�[�h), nameof(�c�_�ΏۊO�t���O), nameof(��M�S�����敪), nameof(�ދ敪), nameof(���Z�敪))]
    public class T24230�Y�n�ʖ����ʕ]������M�S�����c�_ : ModelBase
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
        /// ��M�S�����敪
        /// </summary>
        [Required]
        [Column("��M�S�����敪", Order = 7)]
        [StringLength(1)]
        public string ��M�S�����敪 { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 8)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���Z�敪
        /// </summary>
        [Required]
        [Column("���Z�敪", Order = 9)]
        [StringLength(1)]
        public string ���Z�敪 { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// ����ʐ�_�c�_�ΏۊO
        /// </summary>
        [Column("����ʐ�_�c�_�ΏۊO")]
        public Decimal? ����ʐ�_�c�_�ΏۊO { get; set; }

        /// <summary>
        /// ����ʐ�_�c�_�Ώ�
        /// </summary>
        [Column("����ʐ�_�c�_�Ώ�")]
        public Decimal? ����ʐ�_�c�_�Ώ� { get; set; }

        /// <summary>
        /// ��������n�ʍ��v
        /// </summary>
        [Column("��������n�ʍ��v")]
        public Decimal? ��������n�ʍ��v { get; set; }

        /// <summary>
        /// �̔����������z���v
        /// </summary>
        [Column("�̔����������z���v")]
        public Decimal? �̔����������z���v { get; set; }

        /// <summary>
        /// ���ʕ������z���v
        /// </summary>
        [Column("���ʕ������z���v")]
        public Decimal? ���ʕ������z���v { get; set; }

        /// <summary>
        /// �o�׎��тɑ΂��鐔�ʕ�_�����O_���v
        /// </summary>
        [Column("�o�׎��тɑ΂��鐔�ʕ�_�����O_���v")]
        public Decimal? �o�׎��тɑ΂��鐔�ʕ�_�����O_���v { get; set; }

        /// <summary>
        /// ���������Y���z
        /// </summary>
        [Column("���������Y���z")]
        public Decimal? ���������Y���z { get; set; }

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
