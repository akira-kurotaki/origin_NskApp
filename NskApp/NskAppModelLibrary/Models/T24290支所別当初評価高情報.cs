using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24290_�x���ʓ����]�������
    /// </summary>
    [Serializable]
    [Table("t_24290_�x���ʓ����]�������")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�x���R�[�h), nameof(�⏞����), nameof(�ދ敪), nameof(�c�_�����t���O))]
    public class T24290�x���ʓ����]������� : ModelBase
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
        /// �x���R�[�h
        /// </summary>
        [Required]
        [Column("�x���R�[�h", Order = 4)]
        [StringLength(2)]
        public string �x���R�[�h { get; set; }

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
        /// �x�����ϋ�_�x���������O
        /// </summary>
        [Column("�x�����ϋ�_�x���������O")]
        public Decimal? �x�����ϋ�_�x���������O { get; set; }

        /// <summary>
        /// �x�����ϋ�
        /// </summary>
        [Column("�x�����ϋ�")]
        public Decimal? �x�����ϋ� { get; set; }

        /// <summary>
        /// �ʏ�ӔC���ϋ��z
        /// </summary>
        [Column("�ʏ�ӔC���ϋ��z")]
        public Decimal? �ʏ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �_�앨�ʏ�ӔC���ϋ��z_����
        /// </summary>
        [Column("�_�앨�ʏ�ӔC���ϋ��z_����")]
        public Decimal? �_�앨�ʏ�ӔC���ϋ��z_���� { get; set; }

        /// <summary>
        /// �ʏ핔���ی��������z
        /// </summary>
        [Column("�ʏ핔���ی��������z")]
        public Decimal? �ʏ핔���ی��������z { get; set; }

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
        /// ���ϋ��x���Ώ�_��Q�g��������
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g�������� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�g��������_��M�S��
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������_��M�S��")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g��������_��M�S�� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�g��������_��M����
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������_��M����")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g��������_��M���� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�g��������_��M�S�������v
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������_��M�S�������v")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g��������_��M�S�������v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�g��������_���v
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������_���v")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g��������_���v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_����ʐ�
        /// </summary>
        [Column("���ϋ��x���Ώ�_����ʐ�")]
        public Decimal? ���ϋ��x���Ώ�_����ʐ� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�ʐ�_��M�S��
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�ʐ�_��M�S��")]
        public Decimal? ���ϋ��x���Ώ�_��Q�ʐ�_��M�S�� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�ʐ�_��M����
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�ʐ�_��M����")]
        public Decimal? ���ϋ��x���Ώ�_��Q�ʐ�_��M���� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_������
        /// </summary>
        [Column("���ϋ��x���Ώ�_������")]
        public Decimal? ���ϋ��x���Ώ�_������ { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_���Y���z�̌����z
        /// </summary>
        [Column("���ϋ��x���Ώ�_���Y���z�̌����z")]
        public Decimal? ���ϋ��x���Ώ�_���Y���z�̌����z { get; set; }

        /// <summary>
        /// ���Y���z�̌����z_��M�S��
        /// </summary>
        [Column("���Y���z�̌����z_��M�S��")]
        public Decimal? ���Y���z�̌����z_��M�S�� { get; set; }

        /// <summary>
        /// ���Y���z�̌����z_��M����
        /// </summary>
        [Column("���Y���z�̌����z_��M����")]
        public Decimal? ���Y���z�̌����z_��M���� { get; set; }

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
