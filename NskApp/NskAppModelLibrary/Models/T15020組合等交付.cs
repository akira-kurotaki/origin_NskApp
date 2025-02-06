using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_15020_�g������t
    /// </summary>
    [Serializable]
    [Table("t_15020_�g������t")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���S����t�敪), nameof(��t��))]
    public class T15020�g������t : ModelBase
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
        /// ���S����t�敪
        /// </summary>
        [Required]
        [Column("���S����t�敪", Order = 3)]
        [StringLength(2)]
        public string ���S����t�敪 { get; set; }

        /// <summary>
        /// ��t��
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("��t��", Order = 4)]
        public short ��t�� { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        public Decimal? ������� { get; set; }

        /// <summary>
        /// ���ϋ��z
        /// </summary>
        [Column("���ϋ��z")]
        public Decimal? ���ϋ��z { get; set; }

        /// <summary>
        /// �ی������z
        /// </summary>
        [Column("�ی������z")]
        public Decimal? �ی������z { get; set; }

        /// <summary>
        /// �g�����ʍ��ɕ��S��
        /// </summary>
        [Column("�g�����ʍ��ɕ��S��")]
        public Decimal? �g�����ʍ��ɕ��S�� { get; set; }

        /// <summary>
        /// �g���������S���ϊ|��
        /// </summary>
        [Column("�g���������S���ϊ|��")]
        public Decimal? �g���������S���ϊ|�� { get; set; }

        /// <summary>
        /// �g���������S���ϊ|�������ϊz
        /// </summary>
        [Column("�g���������S���ϊ|�������ϊz")]
        public Decimal? �g���������S���ϊ|�������ϊz { get; set; }

        /// <summary>
        /// ���ϊ|����������
        /// </summary>
        [Column("���ϊ|����������")]
        public Decimal? ���ϊ|���������� { get; set; }

        /// <summary>
        /// �g������t���̋��z
        /// </summary>
        [Column("�g������t���̋��z")]
        public Decimal? �g������t���̋��z { get; set; }

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
