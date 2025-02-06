using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_29100_��ʃf�[�^���_�S���E�{�ݔ�������ok
    /// </summary>
    [Serializable]
    [Table("t_29100_��ʃf�[�^���_�S���E�{�ݔ�������ok")]
    [PrimaryKey(nameof(�������id), nameof(�s�ԍ�))]
    public class T29100��ʃf�[�^����S���E�{�ݔ�������ok : ModelBase
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
        /// ����ғ��R�[�h
        /// </summary>
        [Required]
        [Column("����ғ��R�[�h")]
        [StringLength(2)]
        public string ����ғ��R�[�h { get; set; }

        /// <summary>
        /// �׌��ԍ�
        /// </summary>
        [Required]
        [Column("�׌��ԍ�")]
        [StringLength(6)]
        public string �׌��ԍ� { get; set; }

        /// <summary>
        /// �i��R�[�h
        /// </summary>
        [Column("�i��R�[�h")]
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
