using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_21060_���ώ��̓�������
    /// </summary>
    [Serializable]
    [Table("t_21060_���ώ��̓�������")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�))]
    public class T21060���ώ��̓������� : ModelBase
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
        /// �]���N����
        /// </summary>
        [Column("�]���N����")]
        public DateTime? �]���N���� { get; set; }

        /// <summary>
        /// �]����
        /// </summary>
        [Column("�]����")]
        public string �]���� { get; set; }

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
