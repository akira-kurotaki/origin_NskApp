using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_25020_�g�������ʎx�����
    /// </summary>
    [Serializable]
    [Table("t_25020_�g�������ʎx�����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�x����))]
    public class T25020�g�������ʎx����� : ModelBase
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
        /// �x����
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�x����", Order = 5)]
        public short �x���� { get; set; }

        /// <summary>
        /// �x�����ϋ��z
        /// </summary>
        [Column("�x�����ϋ��z")]
        public Decimal? �x�����ϋ��z { get; set; }

        /// <summary>
        /// ���n�x���z
        /// </summary>
        [Column("���n�x���z")]
        public Decimal? ���n�x���z { get; set; }

        /// <summary>
        /// �Ɛӊz
        /// </summary>
        [Column("�Ɛӊz")]
        public Decimal? �Ɛӊz { get; set; }

        /// <summary>
        /// ���x�����z
        /// </summary>
        [Column("���x�����z")]
        public Decimal? ���x�����z { get; set; }

        /// <summary>
        /// ���l
        /// </summary>
        [Column("���l")]
        public string ���l { get; set; }

        /// <summary>
        /// ����v�Z���t
        /// </summary>
        [Column("����v�Z���t")]
        public DateTime? ����v�Z���t { get; set; }

        /// <summary>
        /// �x���N����
        /// </summary>
        [Column("�x���N����")]
        public DateTime? �x���N���� { get; set; }

        /// <summary>
        /// �x���ʒm�����s��
        /// </summary>
        [Column("�x���ʒm�����s��")]
        public DateTime? �x���ʒm�����s�� { get; set; }

        /// <summary>
        /// ����σt���O
        /// </summary>
        [Column("����σt���O")]
        [StringLength(1)]
        public string ����σt���O { get; set; }

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
