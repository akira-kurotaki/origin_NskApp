using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_21200_�o�ו]���n��ʐ��Y���ʓ���
    /// </summary>
    [Serializable]
    [Table("t_21200_�o�ו]���n��ʐ��Y���ʓ���")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�o�ו]���n��R�[�h), nameof(�ދ敪), nameof(�Y�n�ʖ����R�[�h), nameof(�c�_�ΏۊO�t���O), nameof(�K�i))]
    public class T21200�o�ו]���n��ʐ��Y���ʓ��� : ModelBase
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
        /// �o�ו]���n��R�[�h
        /// </summary>
        [Required]
        [Column("�o�ו]���n��R�[�h", Order = 4)]
        [StringLength(4)]
        public string �o�ו]���n��R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �Y�n�ʖ����R�[�h
        /// </summary>
        [Required]
        [Column("�Y�n�ʖ����R�[�h", Order = 6)]
        [StringLength(5)]
        public string �Y�n�ʖ����R�[�h { get; set; }

        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Required]
        [Column("�c�_�ΏۊO�t���O", Order = 7)]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

        /// <summary>
        /// �K�i
        /// </summary>
        [Required]
        [Column("�K�i", Order = 8)]
        [StringLength(2)]
        public string �K�i { get; set; }

        /// <summary>
        /// ���Y����
        /// </summary>
        [Column("���Y����")]
        public Decimal? ���Y���� { get; set; }

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
