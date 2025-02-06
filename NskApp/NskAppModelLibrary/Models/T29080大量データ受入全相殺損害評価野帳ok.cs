using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_29080_��ʃf�[�^���_�S���E���Q�]���쒠ok
    /// </summary>
    [Serializable]
    [Table("t_29080_��ʃf�[�^���_�S���E���Q�]���쒠ok")]
    [PrimaryKey(nameof(�������id), nameof(�s�ԍ�))]
    public class T29080��ʃf�[�^����S���E���Q�]���쒠ok : ModelBase
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
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h")]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

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
        /// ���F�P��
        /// </summary>
        [Column("���F�P��")]
        public Decimal? ���F�P�� { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column("��������")]
        public Decimal? �������� { get; set; }

        /// <summary>
        /// �������R
        /// </summary>
        [Column("�������R")]
        [StringLength(255)]
        public string �������R { get; set; }

        /// <summary>
        /// ���n�\���
        /// </summary>
        [Column("���n�\���")]
        public DateTime? ���n�\��� { get; set; }

        /// <summary>
        /// �����\���
        /// </summary>
        [Column("�����\���")]
        public DateTime? �����\��� { get; set; }

        /// <summary>
        /// ���ώ��̂P
        /// </summary>
        [Column("���ώ��̂P")]
        [StringLength(2)]
        public string ���ώ��̂P { get; set; }

        /// <summary>
        /// �ЊQ��ނP
        /// </summary>
        [Column("�ЊQ��ނP")]
        [StringLength(2)]
        public string �ЊQ��ނP { get; set; }

        /// <summary>
        /// �ЊQ�����N�����P
        /// </summary>
        [Column("�ЊQ�����N�����P")]
        public DateTime? �ЊQ�����N�����P { get; set; }

        /// <summary>
        /// ���ώ��̂Q
        /// </summary>
        [Column("���ώ��̂Q")]
        [StringLength(2)]
        public string ���ώ��̂Q { get; set; }

        /// <summary>
        /// �ЊQ��ނQ
        /// </summary>
        [Column("�ЊQ��ނQ")]
        [StringLength(2)]
        public string �ЊQ��ނQ { get; set; }

        /// <summary>
        /// �ЊQ�����N�����Q
        /// </summary>
        [Column("�ЊQ�����N�����Q")]
        public DateTime? �ЊQ�����N�����Q { get; set; }

        /// <summary>
        /// ���ώ��̂R
        /// </summary>
        [Column("���ώ��̂R")]
        [StringLength(2)]
        public string ���ώ��̂R { get; set; }

        /// <summary>
        /// �ЊQ��ނR
        /// </summary>
        [Column("�ЊQ��ނR")]
        [StringLength(2)]
        public string �ЊQ��ނR { get; set; }

        /// <summary>
        /// �ЊQ�����N�����R
        /// </summary>
        [Column("�ЊQ�����N�����R")]
        public DateTime? �ЊQ�����N�����R { get; set; }

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
