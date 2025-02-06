using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_21160_�k�n�ʐϕ����]�����
    /// </summary>
    [Serializable]
    [Table("t_21160_�k�n�ʐϕ����]�����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�), nameof(�s�ԍ�))]
    public class T21160�k�n�ʐϕ����]����� : ModelBase
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
        /// �k�n�ԍ�
        /// </summary>
        [Required]
        [Column("�k�n�ԍ�", Order = 5)]
        [StringLength(5)]
        public string �k�n�ԍ� { get; set; }

        /// <summary>
        /// ���M�ԍ�
        /// </summary>
        [Required]
        [Column("���M�ԍ�", Order = 6)]
        [StringLength(4)]
        public string ���M�ԍ� { get; set; }

        /// <summary>
        /// �s�ԍ�
        /// </summary>
        [Required]
        [Column("�s�ԍ�", Order = 7)]
        [StringLength(2)]
        public string �s�ԍ� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �����k�n����R�[�h
        /// </summary>
        [Column("�����k�n����R�[�h")]
        [StringLength(1)]
        public string �����k�n����R�[�h { get; set; }

        /// <summary>
        /// �����Ώۖʐϊ���
        /// </summary>
        [Column("�����Ώۖʐϊ���")]
        public Decimal? �����Ώۖʐϊ��� { get; set; }

        /// <summary>
        /// �����Ώۖʐ�
        /// </summary>
        [Column("�����Ώۖʐ�")]
        public Decimal? �����Ώۖʐ� { get; set; }

        /// <summary>
        /// �o�גP������_����
        /// </summary>
        [Column("�o�גP������_����")]
        public Decimal? �o�גP������_���� { get; set; }

        /// <summary>
        /// �o�גP������_����
        /// </summary>
        [Column("�o�גP������_����")]
        public Decimal? �o�גP������_���� { get; set; }

        /// <summary>
        /// ����������_����
        /// </summary>
        [Column("����������_����")]
        public Decimal? ����������_���� { get; set; }

        /// <summary>
        /// ����������_����
        /// </summary>
        [Column("����������_����")]
        public Decimal? ����������_���� { get; set; }

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
