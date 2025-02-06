using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_21100_�{�݌v��
    /// </summary>
    [Serializable]
    [Table("t_21100_�{�݌v��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�g�������R�[�h), nameof(����ғ��R�[�h), nameof(�׌��ԍ�), nameof(�i��R�[�h))]
    public class T21100�{�݌v�� : ModelBase
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
        /// ����ғ��R�[�h
        /// </summary>
        [Required]
        [Column("����ғ��R�[�h", Order = 6)]
        [StringLength(2)]
        public string ����ғ��R�[�h { get; set; }

        /// <summary>
        /// �׌��ԍ�
        /// </summary>
        [Required]
        [Column("�׌��ԍ�", Order = 7)]
        [StringLength(6)]
        public string �׌��ԍ� { get; set; }

        /// <summary>
        /// �i��R�[�h
        /// </summary>
        [Required]
        [Column("�i��R�[�h", Order = 8)]
        [StringLength(3)]
        public string �i��R�[�h { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Column("�p�r�敪")]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// ���n�N����
        /// </summary>
        [Column("���n�N����")]
        public DateTime? ���n�N���� { get; set; }

        /// <summary>
        /// �]������
        /// </summary>
        [Column("�]������")]
        public DateTime? �]������ { get; set; }

        /// <summary>
        /// �{�ݔ������̐��d��
        /// </summary>
        [Column("�{�ݔ������̐��d��")]
        public Decimal? �{�ݔ������̐��d�� { get; set; }

        /// <summary>
        /// �e�I��̐��d��
        /// </summary>
        [Column("�e�I��̐��d��")]
        public Decimal? �e�I��̐��d�� { get; set; }

        /// <summary>
        /// �{�݌v�ʐ����ܗL��
        /// </summary>
        [Column("�{�݌v�ʐ����ܗL��")]
        public Decimal? �{�݌v�ʐ����ܗL�� { get; set; }

        /// <summary>
        /// ������̏d�ʕ���
        /// </summary>
        [Column("������̏d�ʕ���")]
        public Decimal? ������̏d�ʕ��� { get; set; }

        /// <summary>
        /// ���傤�G���̏d�ʕ���
        /// </summary>
        [Column("���傤�G���̏d�ʕ���")]
        public Decimal? ���傤�G���̏d�ʕ��� { get; set; }

        /// <summary>
        /// ���傤�G�����̍�����
        /// </summary>
        [Column("���傤�G�����̍�����")]
        public Decimal? ���傤�G�����̍����� { get; set; }

        /// <summary>
        /// ���݂������
        /// </summary>
        [Column("���݂������")]
        public Decimal? ���݂������ { get; set; }

        /// <summary>
        /// ���ďd����
        /// </summary>
        [Column("���ďd����")]
        public Decimal? ���ďd���� { get; set; }

        /// <summary>
        /// ���ďd��
        /// </summary>
        [Column("���ďd��")]
        public Decimal? ���ďd�� { get; set; }

        /// <summary>
        /// ⿖ڕ��ɂ��C����
        /// </summary>
        [Column("⿖ڕ��ɂ��C����")]
        public Decimal? ⿖ڕ��ɂ��C���� { get; set; }

        /// <summary>
        /// ���ړ��̓t���O
        /// </summary>
        [Column("���ړ��̓t���O")]
        [StringLength(1)]
        public string ���ړ��̓t���O { get; set; }

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
