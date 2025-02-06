using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24060_�k�n�ʕ����]�����
    /// </summary>
    [Serializable]
    [Table("t_24060_�k�n�ʕ����]�����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�), nameof(���Z�敪))]
    public class T24060�k�n�ʕ����]����� : ModelBase
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
        /// ��Q����R�[�h
        /// </summary>
        [Column("��Q����R�[�h")]
        [StringLength(1)]
        public string ��Q����R�[�h { get; set; }

        /// <summary>
        /// ���Z�敪
        /// </summary>
        [Required]
        [Column("���Z�敪", Order = 7)]
        [StringLength(1)]
        public string ���Z�敪 { get; set; }

        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Column("�c�_�ΏۊO�t���O")]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

        /// <summary>
        /// �Y�n�ʖ����R�[�h
        /// </summary>
        [Column("�Y�n�ʖ����R�[�h")]
        [StringLength(5)]
        public string �Y�n�ʖ����R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// �����㕽�ϒP��
        /// </summary>
        [Column("�����㕽�ϒP��")]
        public Decimal? �����㕽�ϒP�� { get; set; }

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
        /// �o�גP������_�v�Z
        /// </summary>
        [Column("�o�גP������_�v�Z")]
        public Decimal? �o�גP������_�v�Z { get; set; }

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
        /// ����������_�v�Z
        /// </summary>
        [Column("����������_�v�Z")]
        public Decimal? ����������_�v�Z { get; set; }

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
