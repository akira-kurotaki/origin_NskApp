using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_29120_��ʃf�[�^���_�S���E�Ŗ��\������ok
    /// </summary>
    [Serializable]
    [Table("t_29120_��ʃf�[�^���_�S���E�Ŗ��\������ok")]
    [PrimaryKey(nameof(�������id), nameof(�s�ԍ�))]
    public class T29120��ʃf�[�^����S���E�Ŗ��\������ok : ModelBase
    {
        /// <summary>
        /// �������ID
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�������id", Order = 1)]
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
        [Column("�����敪")]
        [StringLength(1)]
        public string �����敪 { get; set; }

        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Column("�g�����R�[�h")]
        [StringLength(3)]
        public string �g�����R�[�h { get; set; }

        /// <summary>
        /// �N�Y
        /// </summary>
        [Column("�N�Y")]
        public short? �N�Y { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Column("���ϖړI�R�[�h")]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Column("�g�������R�[�h")]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Column("�p�r�敪")]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// ���㐔��
        /// </summary>
        [Column("���㐔��")]
        public Decimal? ���㐔�� { get; set; }

        /// <summary>
        /// ���Ə����
        /// </summary>
        [Column("���Ə����")]
        public Decimal? ���Ə���� { get; set; }

        /// <summary>
        /// �p���S������
        /// </summary>
        [Column("�p���S������")]
        public Decimal? �p���S������ { get; set; }

        /// <summary>
        /// �����I������
        /// </summary>
        [Column("�����I������")]
        public Decimal? �����I������ { get; set; }

        /// <summary>
        /// ����I������
        /// </summary>
        [Column("����I������")]
        public Decimal? ����I������ { get; set; }

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
