using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_22030_���n�v�Z�k�n��
    /// </summary>
    [Serializable]
    [Table("t_22030_���n�v�Z�k�n��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�), nameof(���n��))]
    public class T22030���n�v�Z�k�n�� : ModelBase
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
        /// ���n��
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("���n��", Order = 8)]
        public short ���n�� { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Column("�p�r�敪")]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// ��Q����R�[�h
        /// </summary>
        [Column("��Q����R�[�h")]
        [StringLength(1)]
        public string ��Q����R�[�h { get; set; }

        /// <summary>
        /// ��M�S������
        /// </summary>
        [Column("��M�S������")]
        [StringLength(1)]
        public string ��M�S������ { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [Column("����������")]
        public Decimal? ���������� { get; set; }

        /// <summary>
        /// ���n��
        /// </summary>
        [Column("���n��")]
        public Decimal? ���n�� { get; set; }

        /// <summary>
        /// �x���J�n������
        /// </summary>
        [Column("�x���J�n������")]
        public Decimal? �x���J�n������ { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Column("������")]
        public Decimal? ������ { get; set; }

        /// <summary>
        /// ���ጸ����
        /// </summary>
        [Column("���ጸ����")]
        public Decimal? ���ጸ���� { get; set; }

        /// <summary>
        /// ���ό�����
        /// </summary>
        [Column("���ό�����")]
        public Decimal? ���ό����� { get; set; }

        /// <summary>
        /// ���ϋ�
        /// </summary>
        [Column("���ϋ�")]
        public Decimal? ���ϋ� { get; set; }

        /// <summary>
        /// ���v�P�ʒn��R�[�h
        /// </summary>
        [Column("���v�P�ʒn��R�[�h")]
        [StringLength(5)]
        public string ���v�P�ʒn��R�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Column("����敪")]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Column("�⏞�����R�[�h")]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

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
