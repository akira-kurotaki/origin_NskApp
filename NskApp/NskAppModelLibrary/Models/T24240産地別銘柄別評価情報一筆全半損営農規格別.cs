using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24240_�Y�n�ʖ����ʕ]�����_��M�S����_�c�__�K�i��
    /// </summary>
    [Serializable]
    [Table("t_24240_�Y�n�ʖ����ʕ]�����_��M�S����_�c�__�K�i��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�Y�n�ʖ����R�[�h), nameof(�c�_�ΏۊO�t���O), nameof(��M�S�����敪), nameof(�ދ敪), nameof(�K�i), nameof(���Z�敪))]
    public class T24240�Y�n�ʖ����ʕ]������M�S�����c�_�K�i�� : ModelBase
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
        /// �K�i
        /// </summary>
        [Required]
        [Column("�K�i", Order = 9)]
        [StringLength(2)]
        public string �K�i { get; set; }

        /// <summary>
        /// ���Z�敪
        /// </summary>
        [Required]
        [Column("���Z�敪", Order = 10)]
        [StringLength(1)]
        public string ���Z�敪 { get; set; }

        /// <summary>
        /// ��������n��
        /// </summary>
        [Column("��������n��")]
        public Decimal? ��������n�� { get; set; }

        /// <summary>
        /// �̔����������z
        /// </summary>
        [Column("�̔����������z")]
        public Decimal? �̔����������z { get; set; }

        /// <summary>
        /// ���ʕ������z
        /// </summary>
        [Column("���ʕ������z")]
        public Decimal? ���ʕ������z { get; set; }

        /// <summary>
        /// �o�׎��тɑ΂��鐔�ʕ�_�����O
        /// </summary>
        [Column("�o�׎��тɑ΂��鐔�ʕ�_�����O")]
        public Decimal? �o�׎��тɑ΂��鐔�ʕ�_�����O { get; set; }

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
