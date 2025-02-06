using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10250_���ۋ�_�g���ݒ�
    /// </summary>
    [Serializable]
    [Table("m_10250_���ۋ�_�g���ݒ�")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h))]
    public class M10250���ۋ��g���ݒ� : ModelBase
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
        /// �����P�ʌŒ蒥���z_�g�p�t���O
        /// </summary>
        [Column("�����P�ʌŒ蒥���z_�g�p�t���O")]
        [StringLength(1)]
        public string �����P�ʌŒ蒥���z_�g�p�t���O { get; set; }

        /// <summary>
        /// �����P�ʌŒ蒥���z
        /// </summary>
        [Column("�����P�ʌŒ蒥���z")]
        public Decimal? �����P�ʌŒ蒥���z { get; set; }

        /// <summary>
        /// �����P�ʕ��ۋ�����z_�g�p�t���O
        /// </summary>
        [Column("�����P�ʕ��ۋ�����z_�g�p�t���O")]
        [StringLength(1)]
        public string �����P�ʕ��ۋ�����z_�g�p�t���O { get; set; }

        /// <summary>
        /// �����P�ʕ��ۋ�����z
        /// </summary>
        [Column("�����P�ʕ��ۋ�����z")]
        public Decimal? �����P�ʕ��ۋ�����z { get; set; }

        /// <summary>
        /// �_�ƕ��S���ϊ|��_����t���O
        /// </summary>
        [Column("�_�ƕ��S���ϊ|��_����t���O")]
        [StringLength(1)]
        public string �_�ƕ��S���ϊ|��_����t���O { get; set; }

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
