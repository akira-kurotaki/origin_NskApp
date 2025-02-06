using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_11030_�l�ݒ��
    /// </summary>
    [Serializable]
    [Table("t_11030_�l�ݒ��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�ދ敪), nameof(����敪))]
    public class T11030�l�ݒ�� : ModelBase
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
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Required]
        [Column("����敪", Order = 6)]
        [StringLength(2)]
        public string ����敪 { get; set; }

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
        /// �t�ۊ���
        /// </summary>
        [Column("�t�ۊ���")]
        public Decimal? �t�ۊ��� { get; set; }

        /// <summary>
        /// ��ދ敪
        /// </summary>
        [Column("��ދ敪")]
        [StringLength(1)]
        public string ��ދ敪 { get; set; }

        /// <summary>
        /// ��t����
        /// </summary>
        [Column("��t����")]
        [StringLength(1)]
        public string ��t���� { get; set; }

        /// <summary>
        /// �c���敪
        /// </summary>
        [Column("�c���敪")]
        [StringLength(1)]
        public string �c���敪 { get; set; }

        /// <summary>
        /// ���ϋ��z�I������
        /// </summary>
        [Column("���ϋ��z�I������")]
        public Decimal? ���ϋ��z�I������ { get; set; }

        /// <summary>
        /// ���n�ʊm�F���@
        /// </summary>
        [Column("���n�ʊm�F���@")]
        [StringLength(2)]
        public string ���n�ʊm�F���@ { get; set; }

        /// <summary>
        /// �S���E��P��
        /// </summary>
        [Column("�S���E��P��")]
        [StringLength(4)]
        public string �S���E��P�� { get; set; }

        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Column("�c�_�ΏۊO�t���O")]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

        /// <summary>
        /// �S��_�Ƌ敪
        /// </summary>
        [Column("�S��_�Ƌ敪")]
        [StringLength(1)]
        public string �S��_�Ƌ敪 { get; set; }

        /// <summary>
        /// �S���E����ғ�����
        /// </summary>
        [Column("�S���E����ғ�����")]
        public string �S���E����ғ����� { get; set; }

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
