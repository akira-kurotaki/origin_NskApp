using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24180_���{�ĕی��F��敪�ދ敪�ʑ��Q�]�������
    /// </summary>
    [Serializable]
    [Table("t_24180_���{�ĕی��F��敪�ދ敪�ʑ��Q�]�������")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(����������), nameof(������), nameof(���{�ی��F��敪), nameof(�⏞����), nameof(�ދ敪), nameof(�c�_�����t���O))]
    public class T24180���{�ĕی��F��敪�ދ敪�ʑ��Q�]������� : ModelBase
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
        /// ����������
        /// </summary>
        [Required]
        [Column("����������", Order = 4)]
        [StringLength(3)]
        public string ���������� { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("������", Order = 5)]
        public short ������ { get; set; }

        /// <summary>
        /// ���{�ی��F��敪
        /// </summary>
        [Required]
        [Column("���{�ی��F��敪", Order = 6)]
        [StringLength(4)]
        public string ���{�ی��F��敪 { get; set; }

        /// <summary>
        /// �⏞����
        /// </summary>
        [Required]
        [Column("�⏞����", Order = 7)]
        [StringLength(2)]
        public string �⏞���� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 8)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �c�_�����t���O
        /// </summary>
        [Required]
        [Column("�c�_�����t���O", Order = 9)]
        [StringLength(1)]
        public string �c�_�����t���O { get; set; }

        /// <summary>
        /// ����ː�
        /// </summary>
        [Column("����ː�")]
        public Decimal? ����ː� { get; set; }

        /// <summary>
        /// ������ː�
        /// </summary>
        [Column("������ː�")]
        public Decimal? ������ː� { get; set; }

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
        /// �x�����ϋ�_�x���������O
        /// </summary>
        [Column("�x�����ϋ�_�x���������O")]
        public Decimal? �x�����ϋ�_�x���������O { get; set; }

        /// <summary>
        /// �x�����ϋ�_�x���������O_�����ߔ�Q
        /// </summary>
        [Column("�x�����ϋ�_�x���������O_�����ߔ�Q")]
        public Decimal? �x�����ϋ�_�x���������O_�����ߔ�Q { get; set; }

        /// <summary>
        /// �x�����ϋ�_�x���������O_����M�S��
        /// </summary>
        [Column("�x�����ϋ�_�x���������O_����M�S��")]
        public Decimal? �x�����ϋ�_�x���������O_����M�S�� { get; set; }

        /// <summary>
        /// �x�����ϋ�_�x���������O_����M����
        /// </summary>
        [Column("�x�����ϋ�_�x���������O_����M����")]
        public Decimal? �x�����ϋ�_�x���������O_����M���� { get; set; }

        /// <summary>
        /// �x�����ϋ�
        /// </summary>
        [Column("�x�����ϋ�")]
        public Decimal? �x�����ϋ� { get; set; }

        /// <summary>
        /// �x�����ϋ�_�����ߔ�Q
        /// </summary>
        [Column("�x�����ϋ�_�����ߔ�Q")]
        public Decimal? �x�����ϋ�_�����ߔ�Q { get; set; }

        /// <summary>
        /// �x�����ϋ�_����M�S��
        /// </summary>
        [Column("�x�����ϋ�_����M�S��")]
        public Decimal? �x�����ϋ�_����M�S�� { get; set; }

        /// <summary>
        /// �x�����ϋ�_����M����
        /// </summary>
        [Column("�x�����ϋ�_����M����")]
        public Decimal? �x�����ϋ�_����M���� { get; set; }

        /// <summary>
        /// ���ϋ��z
        /// </summary>
        [Column("���ϋ��z")]
        public Decimal? ���ϋ��z { get; set; }

        /// <summary>
        /// �ʏ�ӔC���ϋ��z
        /// </summary>
        [Column("�ʏ�ӔC���ϋ��z")]
        public Decimal? �ʏ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �ʏ�ӔC�ی�����
        /// </summary>
        [Column("�ʏ�ӔC�ی�����")]
        public Decimal? �ʏ�ӔC�ی����� { get; set; }

        /// <summary>
        /// �_�앨�ʏ�W����Q��
        /// </summary>
        [Column("�_�앨�ʏ�W����Q��")]
        public Decimal? �_�앨�ʏ�W����Q�� { get; set; }

        /// <summary>
        /// �_�앨�ُ�ӔC�ی����z
        /// </summary>
        [Column("�_�앨�ُ�ӔC�ی����z")]
        public Decimal? �_�앨�ُ�ӔC�ی����z { get; set; }

        /// <summary>
        /// �x���ی���
        /// </summary>
        [Column("�x���ی���")]
        public Decimal? �x���ی��� { get; set; }

        /// <summary>
        /// ���x�����ϋ�
        /// </summary>
        [Column("���x�����ϋ�")]
        public Decimal? ���x�����ϋ� { get; set; }

        /// <summary>
        /// ���x�����ϋ�_�����ߔ�Q
        /// </summary>
        [Column("���x�����ϋ�_�����ߔ�Q")]
        public Decimal? ���x�����ϋ�_�����ߔ�Q { get; set; }

        /// <summary>
        /// ���x�����ϋ�_����M�S��
        /// </summary>
        [Column("���x�����ϋ�_����M�S��")]
        public Decimal? ���x�����ϋ�_����M�S�� { get; set; }

        /// <summary>
        /// ���x�����ϋ�_����M����
        /// </summary>
        [Column("���x�����ϋ�_����M����")]
        public Decimal? ���x�����ϋ�_����M���� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�g��������
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g�������� { get; set; }

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
        /// ���ϋ��x���Ώ�_���ό��x�z
        /// </summary>
        [Column("���ϋ��x���Ώ�_���ό��x�z")]
        public Decimal? ���ϋ��x���Ώ�_���ό��x�z { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_����Y���z
        /// </summary>
        [Column("���ϋ��x���Ώ�_����Y���z")]
        public Decimal? ���ϋ��x���Ώ�_����Y���z { get; set; }

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
        /// ���ϋ��x���Ώ�_��Q�g��������_��M�S��
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������_��M�S��")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g��������_��M�S�� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�ʐ�_��M�S��
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�ʐ�_��M�S��")]
        public Decimal? ���ϋ��x���Ώ�_��Q�ʐ�_��M�S�� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_���Y���z�̌����z_��M�S��
        /// </summary>
        [Column("���ϋ��x���Ώ�_���Y���z�̌����z_��M�S��")]
        public Decimal? ���ϋ��x���Ώ�_���Y���z�̌����z_��M�S�� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�g��������_��M����
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������_��M����")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g��������_��M���� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�ʐ�_��M����
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�ʐ�_��M����")]
        public Decimal? ���ϋ��x���Ώ�_��Q�ʐ�_��M���� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_���Y���z�̌����z_��M����
        /// </summary>
        [Column("���ϋ��x���Ώ�_���Y���z�̌����z_��M����")]
        public Decimal? ���ϋ��x���Ώ�_���Y���z�̌����z_��M���� { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�g��������_��M�S�����v
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������_��M�S�����v")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g��������_��M�S�����v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�ʐ�_��M�S�����v
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�ʐ�_��M�S�����v")]
        public Decimal? ���ϋ��x���Ώ�_��Q�ʐ�_��M�S�����v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_���Y���z�̌����z_��M�S�����v
        /// </summary>
        [Column("���ϋ��x���Ώ�_���Y���z�̌����z_��M�S�����v")]
        public Decimal? ���ϋ��x���Ώ�_���Y���z�̌����z_��M�S�����v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_��Q�g��������_���v
        /// </summary>
        [Column("���ϋ��x���Ώ�_��Q�g��������_���v")]
        public Decimal? ���ϋ��x���Ώ�_��Q�g��������_���v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_���Y���z�̌����z_���v
        /// </summary>
        [Column("���ϋ��x���Ώ�_���Y���z�̌����z_���v")]
        public Decimal? ���ϋ��x���Ώ�_���Y���z�̌����z_���v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_����ʐ�_���v
        /// </summary>
        [Column("���ϋ��x���Ώ�_����ʐ�_���v")]
        public Decimal? ���ϋ��x���Ώ�_����ʐ�_���v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_����n��_���v
        /// </summary>
        [Column("���ϋ��x���Ώ�_����n��_���v")]
        public Decimal? ���ϋ��x���Ώ�_����n��_���v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_����Y���z_���v
        /// </summary>
        [Column("���ϋ��x���Ώ�_����Y���z_���v")]
        public Decimal? ���ϋ��x���Ώ�_����Y���z_���v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_���ό��x�z_���v
        /// </summary>
        [Column("���ϋ��x���Ώ�_���ό��x�z_���v")]
        public Decimal? ���ϋ��x���Ώ�_���ό��x�z_���v { get; set; }

        /// <summary>
        /// ���ϋ��x���Ώ�_������_���v
        /// </summary>
        [Column("���ϋ��x���Ώ�_������_���v")]
        public Decimal? ���ϋ��x���Ώ�_������_���v { get; set; }

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
        /// �x���ĕی���
        /// </summary>
        [Column("�x���ĕی���")]
        public Decimal? �x���ĕی��� { get; set; }

        /// <summary>
        /// ���z��Q��
        /// </summary>
        [Column("���z��Q��")]
        public Decimal? ���z��Q�� { get; set; }

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
