using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12090_�g�������ʒ������
    /// </summary>
    [Serializable]
    [Table("t_12090_�g�������ʒ������")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�����), nameof(�g�������R�[�h))]
    public class T12090�g�������ʒ������ : ModelBase
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
        /// �����
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�����", Order = 4)]
        public short ����� { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 5)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �����敪�R�[�h
        /// </summary>
        [Column("�����敪�R�[�h")]
        [StringLength(1)]
        public string �����敪�R�[�h { get; set; }

        /// <summary>
        /// �����U�փt���O
        /// </summary>
        [Column("�����U�փt���O")]
        [StringLength(1)]
        public string �����U�փt���O { get; set; }

        /// <summary>
        /// �������R�R�[�h
        /// </summary>
        [Column("�������R�R�[�h")]
        [StringLength(2)]
        public string �������R�R�[�h { get; set; }

        /// <summary>
        /// �����N����
        /// </summary>
        [Column("�����N����")]
        public DateTime? �����N���� { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Column("������")]
        public string ������ { get; set; }

        /// <summary>
        /// �������z
        /// </summary>
        [Column("�������z")]
        public Decimal? �������z { get; set; }

        /// <summary>
        /// ���_�ƕ��S�|��
        /// </summary>
        [Column("���_�ƕ��S�|��")]
        public Decimal? ���_�ƕ��S�|�� { get; set; }

        /// <summary>
        /// �����ۋ�
        /// </summary>
        [Column("�����ۋ�")]
        public Decimal? �����ۋ� { get; set; }

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
