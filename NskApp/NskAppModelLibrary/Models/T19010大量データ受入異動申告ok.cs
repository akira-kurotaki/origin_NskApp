using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_19010_��ʃf�[�^���_�ٓ��\��OK
    /// </summary>
    [Serializable]
    [Table("t_19010_��ʃf�[�^���_�ٓ��\��OK")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�����敪), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�))]
    public class T19010��ʃf�[�^����ٓ��\��ok : ModelBase
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
        /// �����敪
        /// </summary>
        [Required]
        [Column("�����敪", Order = 4)]
        [StringLength(1)]
        public string �����敪 { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 5)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �k�n�ԍ�
        /// </summary>
        [Required]
        [Column("�k�n�ԍ�", Order = 6)]
        [StringLength(5)]
        public string �k�n�ԍ� { get; set; }

        /// <summary>
        /// ���M�ԍ�
        /// </summary>
        [Required]
        [Column("���M�ԍ�", Order = 7)]
        [StringLength(4)]
        public string ���M�ԍ� { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Column("��n��R�[�h")]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// ���n��R�[�h
        /// </summary>
        [Column("���n��R�[�h")]
        [StringLength(4)]
        public string ���n��R�[�h { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// �Y�n�ʖ����R�[�h
        /// </summary>
        [Column("�Y�n�ʖ����R�[�h")]
        [StringLength(5)]
        public string �Y�n�ʖ����R�[�h { get; set; }

        /// <summary>
        /// �����W��
        /// </summary>
        [Column("�����W��")]
        public Decimal? �����W�� { get; set; }

        /// <summary>
        /// �n���n��
        /// </summary>
        [Column("�n���n��")]
        public string �n���n�� { get; set; }

        /// <summary>
        /// ����R�[�h
        /// </summary>
        [Column("����R�[�h")]
        [StringLength(1)]
        public string ����R�[�h { get; set; }

        /// <summary>
        /// ���l
        /// </summary>
        [Column("���l")]
        public string ���l { get; set; }

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
