using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12060_�Y�n�ʖ����ʈ�����
    /// </summary>
    [Serializable]
    [Table("t_12060_�Y�n�ʖ����ʈ�����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�����), nameof(�Y�n�ʖ����R�[�h), nameof(�c�_�ΏۊO�t���O))]
    public class T12060�Y�n�ʖ����ʈ����� : ModelBase
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
        /// ����������
        /// </summary>
        [Column("����������")]
        [StringLength(3)]
        public string ���������� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ����M��
        /// </summary>
        [Column("����M��")]
        public Decimal? ����M�� { get; set; }

        /// <summary>
        /// �����㕽�ώ��n�ʍ��v
        /// </summary>
        [Column("�����㕽�ώ��n�ʍ��v")]
        public Decimal? �����㕽�ώ��n�ʍ��v { get; set; }

        /// <summary>
        /// �����㕽�ϒP��
        /// </summary>
        [Column("�����㕽�ϒP��")]
        public Decimal? �����㕽�ϒP�� { get; set; }

        /// <summary>
        /// �P�ʓ����苤�ϋ��z
        /// </summary>
        [Column("�P�ʓ����苤�ϋ��z")]
        public Decimal? �P�ʓ����苤�ϋ��z { get; set; }

        /// <summary>
        /// �d������_����
        /// </summary>
        [Column("�d������_����")]
        public Decimal? �d������_���� { get; set; }

        /// <summary>
        /// ����ʐ�_����
        /// </summary>
        [Column("����ʐ�_����")]
        public Decimal? ����ʐ�_���� { get; set; }

        /// <summary>
        /// ����ʐύ��v
        /// </summary>
        [Column("����ʐύ��v")]
        public Decimal? ����ʐύ��v { get; set; }

        /// <summary>
        /// �P�ʓ��������Y���z_����
        /// </summary>
        [Column("�P�ʓ��������Y���z_����")]
        public Decimal? �P�ʓ��������Y���z_���� { get; set; }

        /// <summary>
        /// ����Y���z_����
        /// </summary>
        [Column("����Y���z_����")]
        public Decimal? ����Y���z_���� { get; set; }

        /// <summary>
        /// ����Y���z���v
        /// </summary>
        [Column("����Y���z���v")]
        public Decimal? ����Y���z���v { get; set; }

        /// <summary>
        /// ��P��_����
        /// </summary>
        [Column("��P��_����")]
        public Decimal? ��P��_���� { get; set; }

        /// <summary>
        /// ����n��_����
        /// </summary>
        [Column("����n��_����")]
        public Decimal? ����n��_���� { get; set; }

        /// <summary>
        /// ����n�ʍ��v
        /// </summary>
        [Column("����n�ʍ��v")]
        public Decimal? ����n�ʍ��v { get; set; }

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
