using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_21110_�{�ݑS������
    /// </summary>
    [Serializable]
    [Table("t_21110_�{�ݑS������")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�p�r�敪), nameof(�g�������R�[�h))]
    public class T21110�{�ݑS������ : ModelBase
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
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 4)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Required]
        [Column("�p�r�敪", Order = 5)]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 6)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �{�ݔ������n��
        /// </summary>
        [Column("�{�ݔ������n��")]
        public Decimal? �{�ݔ������n�� { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [Column("����������")]
        public Decimal? ���������� { get; set; }

        /// <summary>
        /// �F���ʐ�
        /// </summary>
        [Column("�F���ʐ�")]
        public Decimal? �F���ʐ� { get; set; }

        /// <summary>
        /// �F������n��
        /// </summary>
        [Column("�F������n��")]
        public Decimal? �F������n�� { get; set; }

        /// <summary>
        /// �s�\�ʐ�
        /// </summary>
        [Column("�s�\�ʐ�")]
        public Decimal? �s�\�ʐ� { get; set; }

        /// <summary>
        /// �s�\����n��
        /// </summary>
        [Column("�s�\����n��")]
        public Decimal? �s�\����n�� { get; set; }

        /// <summary>
        /// �s�\���n��
        /// </summary>
        [Column("�s�\���n��")]
        public Decimal? �s�\���n�� { get; set; }

        /// <summary>
        /// �]�쓙�ʐ�
        /// </summary>
        [Column("�]�쓙�ʐ�")]
        public Decimal? �]�쓙�ʐ� { get; set; }

        /// <summary>
        /// �]�쓙����n��
        /// </summary>
        [Column("�]�쓙����n��")]
        public Decimal? �]�쓙����n�� { get; set; }

        /// <summary>
        /// �]�쓙���n��
        /// </summary>
        [Column("�]�쓙���n��")]
        public Decimal? �]�쓙���n�� { get; set; }

        /// <summary>
        /// �p�r�ʊ���n��
        /// </summary>
        [Column("�p�r�ʊ���n��")]
        public Decimal? �p�r�ʊ���n�� { get; set; }

        /// <summary>
        /// �s�\�k�n�������n��
        /// </summary>
        [Column("�s�\�k�n�������n��")]
        public Decimal? �s�\�k�n�������n�� { get; set; }

        /// <summary>
        /// �s�\�k�n�������n�ʕ␳��
        /// </summary>
        [Column("�s�\�k�n�������n�ʕ␳��")]
        public Decimal? �s�\�k�n�������n�ʕ␳�� { get; set; }

        /// <summary>
        /// �g���������n�ʕ␳��
        /// </summary>
        [Column("�g���������n�ʕ␳��")]
        public Decimal? �g���������n�ʕ␳�� { get; set; }

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
