using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_21070_���Ꮋ�F�]��
    /// </summary>
    [Serializable]
    [Table("t_21070_���Ꮋ�F�]��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�))]
    public class T21070���Ꮋ�F�]�� : ModelBase
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
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �]���n��R�[�h
        /// </summary>
        [Column("�]���n��R�[�h")]
        [StringLength(4)]
        public string �]���n��R�[�h { get; set; }

        /// <summary>
        /// �K�w�敪
        /// </summary>
        [Column("�K�w�敪")]
        [StringLength(3)]
        public string �K�w�敪 { get; set; }

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
        /// �����]������R�[�h
        /// </summary>
        [Column("�����]������R�[�h")]
        [StringLength(2)]
        public string �����]������R�[�h { get; set; }

        /// <summary>
        /// ���Q�]���ʐ�
        /// </summary>
        [Column("���Q�]���ʐ�")]
        public Decimal? ���Q�]���ʐ� { get; set; }

        /// <summary>
        /// ���F�P��
        /// </summary>
        [Column("���F�P��")]
        public Decimal? ���F�P�� { get; set; }

        /// <summary>
        /// ���F���n��
        /// </summary>
        [Column("���F���n��")]
        public Decimal? ���F���n�� { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column("��������")]
        public Decimal? �������� { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [Column("����������")]
        public Decimal? ���������� { get; set; }

        /// <summary>
        /// �P���C����
        /// </summary>
        [Column("�P���C����")]
        public Decimal? �P���C���� { get; set; }

        /// <summary>
        /// �g�����]���P��
        /// </summary>
        [Column("�g�����]���P��")]
        public Decimal? �g�����]���P�� { get; set; }

        /// <summary>
        /// �g�����]������
        /// </summary>
        [Column("�g�����]������")]
        public Decimal? �g�����]������ { get; set; }

        /// <summary>
        /// ���n��
        /// </summary>
        [Column("���n��")]
        public Decimal? ���n�� { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Column("������")]
        public Decimal? ������ { get; set; }

        /// <summary>
        /// �����ʎZ�芄��
        /// </summary>
        [Column("�����ʎZ�芄��")]
        public Decimal? �����ʎZ�芄�� { get; set; }

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
        /// ������M�S��������
        /// </summary>
        [Column("������M�S��������")]
        public Decimal? ������M�S�������� { get; set; }

        /// <summary>
        /// �����v�Z���t
        /// </summary>
        [Column("�����v�Z���t")]
        public DateTime? �����v�Z���t { get; set; }

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
