using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_11090_����k�n
    /// </summary>
    [Serializable]
    [Table("t_11090_����k�n")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�))]
    public class T11090����k�n : ModelBase
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
        /// �n���n��
        /// </summary>
        [Column("�n���n��")]
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
        /// ��ϑ��҃R�[�h
        /// </summary>
        [Column("��ϑ��҃R�[�h")]
        [StringLength(13)]
        public string ��ϑ��҃R�[�h { get; set; }

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
        /// �p�r�敪
        /// </summary>
        [Column("�p�r�敪")]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// �i��R�[�h
        /// </summary>
        [Column("�i��R�[�h")]
        [StringLength(3)]
        public string �i��R�[�h { get; set; }

        /// <summary>
        /// �Y�n�ʖ����R�[�h
        /// </summary>
        [Column("�Y�n�ʖ����R�[�h")]
        [StringLength(5)]
        public string �Y�n�ʖ����R�[�h { get; set; }

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
        /// ���ʊ�P��
        /// </summary>
        [Column("���ʊ�P��")]
        public Decimal? ���ʊ�P�� { get; set; }

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
        /// ���ϋ��z�I���敪
        /// </summary>
        [Column("���ϋ��z�I���敪")]
        [StringLength(2)]
        public string ���ϋ��z�I���敪 { get; set; }

        /// <summary>
        /// �����W��
        /// </summary>
        [Column("�����W��")]
        public Decimal? �����W�� { get; set; }

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
