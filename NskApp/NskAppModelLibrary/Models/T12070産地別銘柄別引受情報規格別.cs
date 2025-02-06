using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12070_�Y�n�ʖ����ʈ�����_�K�i��
    /// </summary>
    [Serializable]
    [Table("t_12070_�Y�n�ʖ����ʈ�����_�K�i��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�����), nameof(�Y�n�ʖ����R�[�h), nameof(�c�_�ΏۊO�t���O), nameof(�K�i))]
    public class T12070�Y�n�ʖ����ʈ�����K�i�� : ModelBase
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
        /// �����
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�����", Order = 5)]
        public short ����� { get; set; }

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
        /// �K�i�ʊ���
        /// </summary>
        [Column("�K�i�ʊ���")]
        public Decimal? �K�i�ʊ��� { get; set; }

        /// <summary>
        /// �_�񉿊i
        /// </summary>
        [Column("�_�񉿊i")]
        public Decimal? �_�񉿊i { get; set; }

        /// <summary>
        /// �K�i�ʊ���Y���z
        /// </summary>
        [Column("�K�i�ʊ���Y���z")]
        public Decimal? �K�i�ʊ���Y���z { get; set; }

        /// <summary>
        /// �i���w��
        /// </summary>
        [Column("�i���w��")]
        public Decimal? �i���w�� { get; set; }

        /// <summary>
        /// �K�i�ʊ�P��
        /// </summary>
        [Column("�K�i�ʊ�P��")]
        public Decimal? �K�i�ʊ�P�� { get; set; }

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
