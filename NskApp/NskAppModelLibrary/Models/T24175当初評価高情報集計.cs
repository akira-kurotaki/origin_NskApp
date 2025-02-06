using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24175_�����]�������W�v
    /// </summary>
    [Serializable]
    [Table("t_24175_�����]�������W�v")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(���{�ی��F��敪), nameof(������), nameof(�⏞����), nameof(�ދ敪), nameof(�c�_�����t���O))]
    public class T24175�����]�������W�v : ModelBase
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
        /// ���{�ی��F��敪
        /// </summary>
        [Required]
        [Column("���{�ی��F��敪", Order = 4)]
        [StringLength(4)]
        public string ���{�ی��F��敪 { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("������", Order = 5)]
        public short ������ { get; set; }

        /// <summary>
        /// �⏞����
        /// </summary>
        [Required]
        [Column("�⏞����", Order = 6)]
        [StringLength(2)]
        public string �⏞���� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 7)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �c�_�����t���O
        /// </summary>
        [Required]
        [Column("�c�_�����t���O", Order = 8)]
        [StringLength(1)]
        public string �c�_�����t���O { get; set; }

        /// <summary>
        /// ����ː�
        /// </summary>
        [Column("����ː�")]
        public Decimal? ����ː� { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// ���ϋ��z
        /// </summary>
        [Column("���ϋ��z")]
        public Decimal? ���ϋ��z { get; set; }

        /// <summary>
        /// ��Q�ː�
        /// </summary>
        [Column("��Q�ː�")]
        public Decimal? ��Q�ː� { get; set; }

        /// <summary>
        /// �x���Ώۈ���ʐ�
        /// </summary>
        [Column("�x���Ώۈ���ʐ�")]
        public Decimal? �x���Ώۈ���ʐ� { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Column("������")]
        public Decimal? ������ { get; set; }

        /// <summary>
        /// ���Y���z�̌����z
        /// </summary>
        [Column("���Y���z�̌����z")]
        public Decimal? ���Y���z�̌����z { get; set; }

        /// <summary>
        /// �x�����ϋ������z
        /// </summary>
        [Column("�x�����ϋ������z")]
        public Decimal? �x�����ϋ������z { get; set; }

        /// <summary>
        /// �x���ی��������z
        /// </summary>
        [Column("�x���ی��������z")]
        public Decimal? �x���ی��������z { get; set; }

        /// <summary>
        /// �ُ핔���ی��������z
        /// </summary>
        [Column("�ُ핔���ی��������z")]
        public Decimal? �ُ핔���ی��������z { get; set; }

        /// <summary>
        /// �x���ĕی��������z
        /// </summary>
        [Column("�x���ĕی��������z")]
        public Decimal? �x���ĕی��������z { get; set; }

        /// <summary>
        /// ������g������
        /// </summary>
        [Column("������g������")]
        public Decimal? ������g������ { get; set; }

        /// <summary>
        /// ����g������
        /// </summary>
        [Column("����g������")]
        public Decimal? ����g������ { get; set; }

        /// <summary>
        /// ����Q�g������
        /// </summary>
        [Column("����Q�g������")]
        public Decimal? ����Q�g������ { get; set; }

        /// <summary>
        /// ��Q�g������
        /// </summary>
        [Column("��Q�g������")]
        public Decimal? ��Q�g������ { get; set; }

        /// <summary>
        /// �ʏ�ЊQ�����g������
        /// </summary>
        [Column("�ʏ�ЊQ�����g������")]
        public Decimal? �ʏ�ЊQ�����g������ { get; set; }

        /// <summary>
        /// �ُ�ЊQ�����g������
        /// </summary>
        [Column("�ُ�ЊQ�����g������")]
        public Decimal? �ُ�ЊQ�����g������ { get; set; }

        /// <summary>
        /// ������Q�g������
        /// </summary>
        [Column("������Q�g������")]
        public Decimal? ������Q�g������ { get; set; }

        /// <summary>
        /// ����Q�g������
        /// </summary>
        [Column("����Q�g������")]
        public Decimal? ����Q�g������ { get; set; }

        /// <summary>
        /// �A����ُ�ӔC�ۗL�ی����z
        /// </summary>
        [Column("�A����ُ�ӔC�ۗL�ی����z")]
        public Decimal? �A����ُ�ӔC�ۗL�ی����z { get; set; }

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
