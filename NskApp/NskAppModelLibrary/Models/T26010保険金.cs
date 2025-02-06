using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_26010_�ی���
    /// </summary>
    [Serializable]
    [Table("t_26010_�ی���")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(���������ʃR�[�h), nameof(�������), nameof(�⏞�����R�[�h), nameof(������))]
    public class T26010�ی��� : ModelBase
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
        /// ���������ʃR�[�h
        /// </summary>
        [Required]
        [Column("���������ʃR�[�h", Order = 4)]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 5)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Column("�⏞�����R�[�h", Order = 6)]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("������", Order = 7)]
        public short ������ { get; set; }

        /// <summary>
        /// �x���Ώیː�
        /// </summary>
        [Column("�x���Ώیː�")]
        public Decimal? �x���Ώیː� { get; set; }

        /// <summary>
        /// ���ό�����
        /// </summary>
        [Column("���ό�����")]
        public Decimal? ���ό����� { get; set; }

        /// <summary>
        /// ���ߔ�Q�x�����ϋ�
        /// </summary>
        [Column("���ߔ�Q�x�����ϋ�")]
        public Decimal? ���ߔ�Q�x�����ϋ� { get; set; }

        /// <summary>
        /// ��M�S���x�����ϋ�
        /// </summary>
        [Column("��M�S���x�����ϋ�")]
        public Decimal? ��M�S���x�����ϋ� { get; set; }

        /// <summary>
        /// ��M�����x�����ϋ�
        /// </summary>
        [Column("��M�����x�����ϋ�")]
        public Decimal? ��M�����x�����ϋ� { get; set; }

        /// <summary>
        /// �x�����ϋ�
        /// </summary>
        [Column("�x�����ϋ�")]
        public Decimal? �x�����ϋ� { get; set; }

        /// <summary>
        /// �x���ی���
        /// </summary>
        [Column("�x���ی���")]
        public Decimal? �x���ی��� { get; set; }

        /// <summary>
        /// �ʏ�ӔC���ϋ��z
        /// </summary>
        [Column("�ʏ�ӔC���ϋ��z")]
        public Decimal? �ʏ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �ӔC�ی�����
        /// </summary>
        [Column("�ӔC�ی�����")]
        public Decimal? �ӔC�ی����� { get; set; }

        /// <summary>
        /// ���z��Q��
        /// </summary>
        [Column("���z��Q��")]
        public Decimal? ���z��Q�� { get; set; }

        /// <summary>
        /// ���ϋ��z
        /// </summary>
        [Column("���ϋ��z")]
        public Decimal? ���ϋ��z { get; set; }

        /// <summary>
        /// �_�앨�ʏ핔���ی���
        /// </summary>
        [Column("�_�앨�ʏ핔���ی���")]
        public Decimal? �_�앨�ʏ핔���ی��� { get; set; }

        /// <summary>
        /// �_�앨�ُ핔���ی���
        /// </summary>
        [Column("�_�앨�ُ핔���ی���")]
        public Decimal? �_�앨�ُ핔���ی��� { get; set; }

        /// <summary>
        /// �x���ی�������̊z
        /// </summary>
        [Column("�x���ی�������̊z")]
        public Decimal? �x���ی�������̊z { get; set; }

        /// <summary>
        /// �x���ی������񐿋��z
        /// </summary>
        [Column("�x���ی������񐿋��z")]
        public Decimal? �x���ی������񐿋��z { get; set; }

        /// <summary>
        /// �Ɛӌː�
        /// </summary>
        [Column("�Ɛӌː�")]
        public Decimal? �Ɛӌː� { get; set; }

        /// <summary>
        /// �Ɛӊz
        /// </summary>
        [Column("�Ɛӊz")]
        public Decimal? �Ɛӊz { get; set; }

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
