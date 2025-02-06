using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24165_���Q�]�������W�v
    /// </summary>
    [Serializable]
    [Table("t_24165_���Q�]�������W�v")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(������), nameof(�⏞����), nameof(�ދ敪), nameof(�c�_�����t���O))]
    public class T24165���Q�]�������W�v : ModelBase
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
        /// ������
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("������", Order = 4)]
        public short ������ { get; set; }

        /// <summary>
        /// �⏞����
        /// </summary>
        [Required]
        [Column("�⏞����", Order = 5)]
        [StringLength(2)]
        public string �⏞���� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 6)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �c�_�����t���O
        /// </summary>
        [Required]
        [Column("�c�_�����t���O", Order = 7)]
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
        /// ����n��
        /// </summary>
        [Column("����n��")]
        public Decimal? ����n�� { get; set; }

        /// <summary>
        /// ����Y���z
        /// </summary>
        [Column("����Y���z")]
        public Decimal? ����Y���z { get; set; }

        /// <summary>
        /// ���ό��x�z
        /// </summary>
        [Column("���ό��x�z")]
        public Decimal? ���ό��x�z { get; set; }

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
        /// ���ϋ��x���Ώ�_����ʐ�
        /// </summary>
        [Column("���ϋ��x���Ώ�_����ʐ�")]
        public Decimal? ���ϋ��x���Ώ�_����ʐ� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_����n��
        /// </summary>
        [Column("���ϋ��x���Ώ�_����n��")]
        public Decimal? ���ϋ��x���Ώ�_����n�� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_����Y���z
        /// </summary>
        [Column("���ϋ��x���Ώ�_����Y���z")]
        public Decimal? ���ϋ��x���Ώ�_����Y���z { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_���ό��x�z
        /// </summary>
        [Column("���ϋ��x���Ώ�_���ό��x�z")]
        public Decimal? ���ϋ��x���Ώ�_���ό��x�z { get; set; }

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
        /// �x���ĕی���_�c�_�����O
        /// </summary>
        [Column("�x���ĕی���_�c�_�����O")]
        public Decimal? �x���ĕی���_�c�_�����O { get; set; }

        /// <summary>
        /// �x���ĕی���
        /// </summary>
        [Column("�x���ĕی���")]
        public Decimal? �x���ĕی��� { get; set; }

        /// <summary>
        /// �ʏ�ӔC���ϋ��z
        /// </summary>
        [Column("�ʏ�ӔC���ϋ��z")]
        public Decimal? �ʏ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �A����ُ�ӔC�ۗL�ی����z
        /// </summary>
        [Column("�A����ُ�ӔC�ۗL�ی����z")]
        public Decimal? �A����ُ�ӔC�ۗL�ی����z { get; set; }

        /// <summary>
        /// �A����莝�ی���
        /// </summary>
        [Column("�A����莝�ی���")]
        public Decimal? �A����莝�ی��� { get; set; }

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
        /// �A����ُ�ӔC�x���ی���
        /// </summary>
        [Column("�A����ُ�ӔC�x���ی���")]
        public Decimal? �A����ُ�ӔC�x���ی��� { get; set; }

        /// <summary>
        /// ���z��Q��
        /// </summary>
        [Column("���z��Q��")]
        public Decimal? ���z��Q�� { get; set; }

        /// <summary>
        /// �쐬�敪
        /// </summary>
        [Column("�쐬�敪")]
        [StringLength(1)]
        public string �쐬�敪 { get; set; }

        /// <summary>
        /// ����g������
        /// </summary>
        [Column("����g������")]
        public Decimal? ����g������ { get; set; }

        /// <summary>
        /// ������g������
        /// </summary>
        [Column("������g������")]
        public Decimal? ������g������ { get; set; }

        /// <summary>
        /// ��Q�g������
        /// </summary>
        [Column("��Q�g������")]
        public Decimal? ��Q�g������ { get; set; }

        /// <summary>
        /// ����Q�g������
        /// </summary>
        [Column("����Q�g������")]
        public Decimal? ����Q�g������ { get; set; }

        /// <summary>
        /// ����Q�g������
        /// </summary>
        [Column("����Q�g������")]
        public Decimal? ����Q�g������ { get; set; }

        /// <summary>
        /// ������Q�g������
        /// </summary>
        [Column("������Q�g������")]
        public Decimal? ������Q�g������ { get; set; }

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
        /// �x���ĕی�������̊z
        /// </summary>
        [Column("�x���ĕی�������̊z")]
        public Decimal? �x���ĕی�������̊z { get; set; }

        /// <summary>
        /// �x���ĕی������񐿋��z
        /// </summary>
        [Column("�x���ĕی������񐿋��z")]
        public Decimal? �x���ĕی������񐿋��z { get; set; }

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
