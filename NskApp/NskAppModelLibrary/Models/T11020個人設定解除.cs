using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_11020_�l�ݒ����
    /// </summary>
    [Serializable]
    [Table("t_11020_�l�ݒ����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h))]
    public class T11020�l�ݒ���� : ModelBase
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
        /// ���������
        /// </summary>
        [Column("���������")]
        public short? ��������� { get; set; }

        /// <summary>
        /// �����\�o���t
        /// </summary>
        [Column("�����\�o���t")]
        public DateTime? �����\�o���t { get; set; }

        /// <summary>
        /// ����������t
        /// </summary>
        [Column("����������t")]
        public DateTime? ����������t { get; set; }

        /// <summary>
        /// ��������Ԋҕ��ۋ��z
        /// </summary>
        [Column("��������Ԋҕ��ۋ��z")]
        public Decimal? ��������Ԋҕ��ۋ��z { get; set; }

        /// <summary>
        /// �������R�R�[�h
        /// </summary>
        [Column("�������R�R�[�h")]
        [StringLength(2)]
        public string �������R�R�[�h { get; set; }

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
