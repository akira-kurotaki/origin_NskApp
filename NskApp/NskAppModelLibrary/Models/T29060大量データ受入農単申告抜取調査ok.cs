using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_29060_��ʃf�[�^���_�_�P�\�����撲��ok
    /// </summary>
    [Serializable]
    [Table("t_29060_��ʃf�[�^���_�_�P�\�����撲��ok")]
    [PrimaryKey(nameof(�������id), nameof(�s�ԍ�))]
    public class T29060��ʃf�[�^����_�P�\�����撲��ok : ModelBase
    {
        /// <summary>
        /// �������ID
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�������ID", Order = 1)]
        public long �������id { get; set; }

        /// <summary>
        /// �s�ԍ�
        /// </summary>
        [Required]
        [Column("�s�ԍ�", Order = 2)]
        [StringLength(6)]
        public string �s�ԍ� { get; set; }

        /// <summary>
        /// �����敪
        /// </summary>
        [Required]
        [Column("�����敪")]
        [StringLength(1)]
        public string �����敪 { get; set; }

        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("�g�����R�[�h")]
        [StringLength(3)]
        public string �g�����R�[�h { get; set; }

        /// <summary>
        /// �N�Y
        /// </summary>
        [Required]
        [Column("�N�Y")]
        public short �N�Y { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h")]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h")]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �k�n�ԍ�
        /// </summary>
        [Required]
        [Column("�k�n�ԍ�")]
        [StringLength(5)]
        public string �k�n�ԍ� { get; set; }

        /// <summary>
        /// ���M�ԍ�
        /// </summary>
        [Required]
        [Column("���M�ԍ�")]
        [StringLength(4)]
        public string ���M�ԍ� { get; set; }

        /// <summary>
        /// �K�w�敪
        /// </summary>
        [Column("�K�w�敪")]
        [StringLength(3)]
        public string �K�w�敪 { get; set; }

        /// <summary>
        /// �]���n��R�[�h
        /// </summary>
        [Column("�]���n��R�[�h")]
        [StringLength(4)]
        public string �]���n��R�[�h { get; set; }

        /// <summary>
        /// �\�����n��
        /// </summary>
        [Column("�\�����n��")]
        public Decimal? �\�����n�� { get; set; }

        /// <summary>
        /// ����P��
        /// </summary>
        [Column("����P��")]
        public Decimal? ����P�� { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column("��������")]
        public Decimal? �������� { get; set; }

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
        /// �������R
        /// </summary>
        [Column("�������R")]
        public string �������R { get; set; }

        /// <summary>
        /// ���ώ���
        /// </summary>
        [Column("���ώ���")]
        [StringLength(2)]
        public string ���ώ��� { get; set; }

        /// <summary>
        /// �ЊQ���
        /// </summary>
        [Column("�ЊQ���")]
        [StringLength(2)]
        public string �ЊQ��� { get; set; }

        /// <summary>
        /// �ЊQ�����N����
        /// </summary>
        [Column("�ЊQ�����N����")]
        public DateTime? �ЊQ�����N���� { get; set; }

        /// <summary>
        /// �]���N����
        /// </summary>
        [Column("�]���N����")]
        public DateTime? �]���N���� { get; set; }

        /// <summary>
        /// ���撲���ǃR�[�h
        /// </summary>
        [Column("���撲���ǃR�[�h")]
        [StringLength(3)]
        public string ���撲���ǃR�[�h { get; set; }

        /// <summary>
        /// �\���P��
        /// </summary>
        [Column("�\���P��")]
        public Decimal? �\���P�� { get; set; }

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
