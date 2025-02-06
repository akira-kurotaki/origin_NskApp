using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24130_�g�������ʕ]�����
    /// </summary>
    [Serializable]
    [Table("t_24130_�g�������ʕ]�����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�c�_�����t���O), nameof(���Z�敪))]
    public class T24130�g�������ʕ]����� : ModelBase
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
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 4)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �c�_�����t���O
        /// </summary>
        [Required]
        [Column("�c�_�����t���O", Order = 5)]
        [StringLength(1)]
        public string �c�_�����t���O { get; set; }

        /// <summary>
        /// ���Z�敪
        /// </summary>
        [Required]
        [Column("���Z�敪", Order = 6)]
        [StringLength(1)]
        public string ���Z�敪 { get; set; }

        /// <summary>
        /// �⏞����
        /// </summary>
        [Column("�⏞����")]
        [StringLength(2)]
        public string �⏞���� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���ϊ|��
        /// </summary>
        [Column("���ϊ|��")]
        public Decimal? ���ϊ|�� { get; set; }

        /// <summary>
        /// ���ۋ����v
        /// </summary>
        [Column("���ۋ����v")]
        public Decimal? ���ۋ����v { get; set; }

        /// <summary>
        /// ����M��
        /// </summary>
        [Column("����M��")]
        public Decimal? ����M�� { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// ��Q�ʐ�_��M�S��
        /// </summary>
        [Column("��Q�ʐ�_��M�S��")]
        public Decimal? ��Q�ʐ�_��M�S�� { get; set; }

        /// <summary>
        /// ��Q�ʐ�_��M����
        /// </summary>
        [Column("��Q�ʐ�_��M����")]
        public Decimal? ��Q�ʐ�_��M���� { get; set; }

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
        /// ����Y���z_��M�S��
        /// </summary>
        [Column("����Y���z_��M�S��")]
        public Decimal? ����Y���z_��M�S�� { get; set; }

        /// <summary>
        /// ����Y���z_��M����
        /// </summary>
        [Column("����Y���z_��M����")]
        public Decimal? ����Y���z_��M���� { get; set; }

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
        /// �����z
        /// </summary>
        [Column("�����z")]
        public Decimal? �����z { get; set; }

        /// <summary>
        /// ���ƕۗL����
        /// </summary>
        [Column("���ƕۗL����")]
        public Decimal? ���ƕۗL���� { get; set; }

        /// <summary>
        /// �o�א��ʓ�
        /// </summary>
        [Column("�o�א��ʓ�")]
        public Decimal? �o�א��ʓ� { get; set; }

        /// <summary>
        /// ���n��
        /// </summary>
        [Column("���n��")]
        public Decimal? ���n�� { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [Column("����������")]
        public Decimal? ���������� { get; set; }

        /// <summary>
        /// ��������n��
        /// </summary>
        [Column("��������n��")]
        public Decimal? ��������n�� { get; set; }

        /// <summary>
        /// ��������n��
        /// </summary>
        [Column("��������n��")]
        public Decimal? ��������n�� { get; set; }

        /// <summary>
        /// ���Y���z
        /// </summary>
        [Column("���Y���z")]
        public Decimal? ���Y���z { get; set; }

        /// <summary>
        /// �ڐA�s�\�k�n�����z_��M�S��
        /// </summary>
        [Column("�ڐA�s�\�k�n�����z_��M�S��")]
        public Decimal? �ڐA�s�\�k�n�����z_��M�S�� { get; set; }

        /// <summary>
        /// ���Y���z_��M�S��
        /// </summary>
        [Column("���Y���z_��M�S��")]
        public Decimal? ���Y���z_��M�S�� { get; set; }

        /// <summary>
        /// ���Y���z_��M����
        /// </summary>
        [Column("���Y���z_��M����")]
        public Decimal? ���Y���z_��M���� { get; set; }

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
        /// ���Y���z�̌����z_����z
        /// </summary>
        [Column("���Y���z�̌����z_����z")]
        public Decimal? ���Y���z�̌����z_����z { get; set; }

        /// <summary>
        /// �g���x���Ώۃt���O
        /// </summary>
        [Column("�g���x���Ώۃt���O")]
        [StringLength(1)]
        public string �g���x���Ώۃt���O { get; set; }

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
        /// �Ɛӊz
        /// </summary>
        [Column("�Ɛӊz")]
        public Decimal? �Ɛӊz { get; set; }

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
        /// ����x�����ϋ�
        /// </summary>
        [Column("����x�����ϋ�")]
        public Decimal? ����x�����ϋ� { get; set; }

        /// <summary>
        /// ���z��Q��
        /// </summary>
        [Column("���z��Q��")]
        public Decimal? ���z��Q�� { get; set; }

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
