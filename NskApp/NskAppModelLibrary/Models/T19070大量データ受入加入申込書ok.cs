using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_19070_��ʃf�[�^���_�����\����OK
    /// </summary>
    [Serializable]
    [Table("t_19070_��ʃf�[�^���_�����\����OK")]
    [PrimaryKey(nameof(�������id), nameof(�s�ԍ�))]
    public class T19070��ʃf�[�^��������\����ok : ModelBase
    {
        /// <summary>
        /// �������id
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�������id", Order = 1)]
        public long �������id { get; set; }

        /// <summary>
        /// �s�ԍ�
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�s�ԍ�", Order = 2)]
        public Decimal �s�ԍ� { get; set; }

        /// <summary>
        /// �͈�
        /// </summary>
        [Required]
        [Column("�͈�")]
        [StringLength(2)]
        public string �͈� { get; set; }

        /// <summary>
        /// �N�Y�͈�
        /// </summary>
        [Required]
        [Column("�N�Y�͈�")]
        public short �N�Y�͈� { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h�͈�
        /// </summary>
        [Column("���ϖړI�R�[�h�͈�")]
        [StringLength(2)]
        public string ���ϖړI�R�[�h�͈� { get; set; }

        /// <summary>
        /// ���o�敪
        /// </summary>
        [Column("���o�敪")]
        [StringLength(1)]
        public string ���o�敪 { get; set; }

        /// <summary>
        /// �͈̓p�����[�^�P
        /// </summary>
        [Column("�͈̓p�����[�^�P")]
        [StringLength(13)]
        public string �͈̓p�����[�^�P { get; set; }

        /// <summary>
        /// �͈̓p�����[�^�Q
        /// </summary>
        [Column("�͈̓p�����[�^�Q")]
        [StringLength(13)]
        public string �͈̓p�����[�^�Q { get; set; }

        /// <summary>
        /// �͈̓p�����[�^�R
        /// </summary>
        [Column("�͈̓p�����[�^�R")]
        [StringLength(4)]
        public string �͈̓p�����[�^�R { get; set; }

        /// <summary>
        /// ���t
        /// </summary>
        [Column("���t")]
        public DateTime? ���t { get; set; }

        /// <summary>
        /// GIS�f�[�^�o�͂̃^�C�v
        /// </summary>
        [Column("GIS�f�[�^�o�͂̃^�C�v")]
        [StringLength(1)]
        public string GIS�f�[�^�o�͂̃^�C�v { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Column("���ϖړI�R�[�h")]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Column("�g�������R�[�h")]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �k�n�ԍ�
        /// </summary>
        [Column("�k�n�ԍ�")]
        [StringLength(5)]
        public string �k�n�ԍ� { get; set; }

        /// <summary>
        /// ���M�ԍ�
        /// </summary>
        [Column("���M�ԍ�")]
        [StringLength(4)]
        public string ���M�ԍ� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �n���n��
        /// </summary>
        [Column("�n���n��")]
        [StringLength(40)]
        public string �n���n�� { get; set; }

        /// <summary>
        /// �k�n�ʐ�
        /// </summary>
        [Column("�k�n�ʐ�")]
        public Decimal? �k�n�ʐ� { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// �]�쓙�ʐ�
        /// </summary>
        [Column("�]�쓙�ʐ�")]
        public Decimal? �]�쓙�ʐ� { get; set; }

        /// <summary>
        /// ��ϑ��敪
        /// </summary>
        [Column("��ϑ��敪")]
        [StringLength(1)]
        public string ��ϑ��敪 { get; set; }

        /// <summary>
        /// ���l
        /// </summary>
        [Column("���l")]
        [StringLength(40)]
        public string ���l { get; set; }

        /// <summary>
        /// �c���敪
        /// </summary>
        [Column("�c���敪")]
        [StringLength(1)]
        public string �c���敪 { get; set; }

        /// <summary>
        /// �敪�R�[�h
        /// </summary>
        [Column("�敪�R�[�h")]
        [StringLength(2)]
        public string �敪�R�[�h { get; set; }

        /// <summary>
        /// ��ރR�[�h
        /// </summary>
        [Column("��ރR�[�h")]
        [StringLength(2)]
        public string ��ރR�[�h { get; set; }

        /// <summary>
        /// �i��R�[�h
        /// </summary>
        [Column("�i��R�[�h")]
        [StringLength(3)]
        public string �i��R�[�h { get; set; }

        /// <summary>
        /// ���ʓ����R�[�h
        /// </summary>
        [Column("���ʓ����R�[�h")]
        [StringLength(3)]
        public string ���ʓ����R�[�h { get; set; }

        /// <summary>
        /// �Q�ރR�[�h
        /// </summary>
        [Column("�Q�ރR�[�h")]
        [StringLength(3)]
        public string �Q�ރR�[�h { get; set; }

        /// <summary>
        /// ��P��
        /// </summary>
        [Column("��P��")]
        public Decimal? ��P�� { get; set; }

        /// <summary>
        /// ����n��
        /// </summary>
        [Column("����n��")]
        public Decimal? ����n�� { get; set; }

        /// <summary>
        /// �C�����t
        /// </summary>
        [Column("�C�����t")]
        public DateTime? �C�����t { get; set; }

        /// <summary>
        /// �v�Z���t
        /// </summary>
        [Column("�v�Z���t")]
        public DateTime? �v�Z���t { get; set; }

        /// <summary>
        /// �N�Y
        /// </summary>
        [Column("�N�Y")]
        public short? �N�Y { get; set; }

        /// <summary>
        /// ���ʊ�P��
        /// </summary>
        [Column("���ʊ�P��")]
        public Decimal? ���ʊ�P�� { get; set; }

        /// <summary>
        /// RS�敪
        /// </summary>
        [Column("RS�敪")]
        [StringLength(2)]
        public string RS�敪 { get; set; }

        /// <summary>
        /// �Ǔs���{���R�[�h
        /// </summary>
        [Column("�Ǔs���{���R�[�h")]
        [StringLength(4)]
        public string �Ǔs���{���R�[�h { get; set; }

        /// <summary>
        /// �s�撬���R�[�h
        /// </summary>
        [Column("�s�撬���R�[�h")]
        [StringLength(3)]
        public string �s�撬���R�[�h { get; set; }

        /// <summary>
        /// �厚�R�[�h
        /// </summary>
        [Column("�厚�R�[�h")]
        [StringLength(8)]
        public string �厚�R�[�h { get; set; }

        /// <summary>
        /// �����R�[�h
        /// </summary>
        [Column("�����R�[�h")]
        [StringLength(4)]
        public string �����R�[�h { get; set; }

        /// <summary>
        /// �n��
        /// </summary>
        [Column("�n��")]
        [StringLength(16)]
        public string �n�� { get; set; }

        /// <summary>
        /// �}��
        /// </summary>
        [Column("�}��")]
        [StringLength(14)]
        public string �}�� { get; set; }

        /// <summary>
        /// �q��
        /// </summary>
        [Column("�q��")]
        [StringLength(10)]
        public string �q�� { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column("����")]
        [StringLength(10)]
        public string ���� { get; set; }

        /// <summary>
        /// ���v�s�����R�[�h
        /// </summary>
        [Column("���v�s�����R�[�h")]
        [StringLength(5)]
        public string ���v�s�����R�[�h { get; set; }

        /// <summary>
        /// ���v�P�ʒn��R�[�h
        /// </summary>
        [Column("���v�P�ʒn��R�[�h")]
        [StringLength(5)]
        public string ���v�P�ʒn��R�[�h { get; set; }

        /// <summary>
        /// ���v�P��
        /// </summary>
        [Column("���v�P��")]
        public Decimal? ���v�P�� { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Column("�p�r�敪")]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// �Y�n�ʖ����R�[�h
        /// </summary>
        [Column("�Y�n�ʖ����R�[�h")]
        [StringLength(5)]
        public string �Y�n�ʖ����R�[�h { get; set; }

        /// <summary>
        /// ��ϑ��҃R�[�h
        /// </summary>
        [Column("��ϑ��҃R�[�h")]
        [StringLength(13)]
        public string ��ϑ��҃R�[�h { get; set; }

        /// <summary>
        /// �o�^����
        /// </summary>
        [Column("�o�^����")]
        public DateTime? �o�^���� { get; set; }

        /// <summary>
        /// �o�^���[�Uid
        /// </summary>
        [Column("�o�^���[�Uid")]
        [StringLength(11)]
        public string �o�^���[�Uid { get; set; }
    }
}
