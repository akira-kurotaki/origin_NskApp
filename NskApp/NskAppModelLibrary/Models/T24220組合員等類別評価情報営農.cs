using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24220_�g�������ޕʕ]�����_�c�_
    /// </summary>
    [Serializable]
    [Table("t_24220_�g�������ޕʕ]�����_�c�_")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�ދ敪), nameof(���Z�敪))]
    public class T24220�g�������ޕʕ]�����c�_ : ModelBase
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
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

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
        /// ���{�ی��F��敪
        /// </summary>
        [Column("���{�ی��F��敪")]
        [StringLength(4)]
        public string ���{�ی��F��敪 { get; set; }

        /// <summary>
        /// ����ʐ�
        /// </summary>
        [Column("����ʐ�")]
        public Decimal? ����ʐ� { get; set; }

        /// <summary>
        /// ����ʐ�_�c�_�ΏۊO
        /// </summary>
        [Column("����ʐ�_�c�_�ΏۊO")]
        public Decimal? ����ʐ�_�c�_�ΏۊO { get; set; }

        /// <summary>
        /// ����ʐ�_�c�_�Ώ�
        /// </summary>
        [Column("����ʐ�_�c�_�Ώ�")]
        public Decimal? ����ʐ�_�c�_�Ώ� { get; set; }

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
        /// ���Y���z_�c�_�����O
        /// </summary>
        [Column("���Y���z_�c�_�����O")]
        public Decimal? ���Y���z_�c�_�����O { get; set; }

        /// <summary>
        /// �̔����������z���v
        /// </summary>
        [Column("�̔����������z���v")]
        public Decimal? �̔����������z���v { get; set; }

        /// <summary>
        /// �̔����������z���v_��M�S��
        /// </summary>
        [Column("�̔����������z���v_��M�S��")]
        public Decimal? �̔����������z���v_��M�S�� { get; set; }

        /// <summary>
        /// �̔����������z���v_��M����
        /// </summary>
        [Column("�̔����������z���v_��M����")]
        public Decimal? �̔����������z���v_��M���� { get; set; }

        /// <summary>
        /// �c�_�p���x�������z
        /// </summary>
        [Column("�c�_�p���x�������z")]
        public Decimal? �c�_�p���x�������z { get; set; }

        /// <summary>
        /// �c�_�p���x�������z�P_��M�S��
        /// </summary>
        [Column("�c�_�p���x�������z�P_��M�S��")]
        public Decimal? �c�_�p���x�������z�P_��M�S�� { get; set; }

        /// <summary>
        /// �c�_�p���x�������z�P_��M����
        /// </summary>
        [Column("�c�_�p���x�������z�P_��M����")]
        public Decimal? �c�_�p���x�������z�P_��M���� { get; set; }

        /// <summary>
        /// �c�_�p���x�������z�Q_��M�S��
        /// </summary>
        [Column("�c�_�p���x�������z�Q_��M�S��")]
        public Decimal? �c�_�p���x�������z�Q_��M�S�� { get; set; }

        /// <summary>
        /// �c�_�p���x�������z�Q_��M����
        /// </summary>
        [Column("�c�_�p���x�������z�Q_��M����")]
        public Decimal? �c�_�p���x�������z�Q_��M���� { get; set; }

        /// <summary>
        /// �c�_�p���x�������z_����z__��M�S��
        /// </summary>
        [Column("�c�_�p���x�������z_����z__��M�S��")]
        public Decimal? �c�_�p���x�������z_����z__��M�S�� { get; set; }

        /// <summary>
        /// �c�_�p���x�������z_����z_��M����
        /// </summary>
        [Column("�c�_�p���x�������z_����z_��M����")]
        public Decimal? �c�_�p���x�������z_����z_��M���� { get; set; }

        /// <summary>
        /// ���ʕ������z
        /// </summary>
        [Column("���ʕ������z")]
        public Decimal? ���ʕ������z { get; set; }

        /// <summary>
        /// �o�׎��тɑ΂��鐔�ʕ�_��M�S��
        /// </summary>
        [Column("�o�׎��тɑ΂��鐔�ʕ�_��M�S��")]
        public Decimal? �o�׎��тɑ΂��鐔�ʕ�_��M�S�� { get; set; }

        /// <summary>
        /// �o�׎��тɑ΂��鐔�ʕ�_��M����
        /// </summary>
        [Column("�o�׎��тɑ΂��鐔�ʕ�_��M����")]
        public Decimal? �o�׎��тɑ΂��鐔�ʕ�_��M���� { get; set; }

        /// <summary>
        /// ���������Y���z_��M�S��
        /// </summary>
        [Column("���������Y���z_��M�S��")]
        public Decimal? ���������Y���z_��M�S�� { get; set; }

        /// <summary>
        /// ���������Y���z_��M����
        /// </summary>
        [Column("���������Y���z_��M����")]
        public Decimal? ���������Y���z_��M���� { get; set; }

        /// <summary>
        /// ���Y���z
        /// </summary>
        [Column("���Y���z")]
        public Decimal? ���Y���z { get; set; }

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
        /// ���Y���z�̌����z_�I���敪
        /// </summary>
        [Column("���Y���z�̌����z_�I���敪")]
        public Decimal? ���Y���z�̌����z_�I���敪 { get; set; }

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
