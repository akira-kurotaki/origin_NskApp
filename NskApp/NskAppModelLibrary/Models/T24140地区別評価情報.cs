using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24140_�n��ʕ]�����
    /// </summary>
    [Serializable]
    [Table("t_24140_�n��ʕ]�����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(��n��R�[�h), nameof(���n��R�[�h), nameof(�⏞����), nameof(�ދ敪), nameof(�c�_�����t���O))]
    public class T24140�n��ʕ]����� : ModelBase
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
        /// ��n��R�[�h
        /// </summary>
        [Required]
        [Column("��n��R�[�h", Order = 4)]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// ���n��R�[�h
        /// </summary>
        [Required]
        [Column("���n��R�[�h", Order = 5)]
        [StringLength(4)]
        public string ���n��R�[�h { get; set; }

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
        /// ����Y���z
        /// </summary>
        [Column("����Y���z")]
        public Decimal? ����Y���z { get; set; }

        /// <summary>
        /// ���ϋ��z
        /// </summary>
        [Column("���ϋ��z")]
        public Decimal? ���ϋ��z { get; set; }

        /// <summary>
        /// �]��_�ː�
        /// </summary>
        [Column("�]��_�ː�")]
        public Decimal? �]��_�ː� { get; set; }

        /// <summary>
        /// �]��_�ː�_��M�S��
        /// </summary>
        [Column("�]��_�ː�_��M�S��")]
        public Decimal? �]��_�ː�_��M�S�� { get; set; }

        /// <summary>
        /// �]��_�ː�_��M����
        /// </summary>
        [Column("�]��_�ː�_��M����")]
        public Decimal? �]��_�ː�_��M���� { get; set; }

        /// <summary>
        /// �]��_�ː�_���v
        /// </summary>
        [Column("�]��_�ː�_���v")]
        public Decimal? �]��_�ː�_���v { get; set; }

        /// <summary>
        /// �]��_�ʐ�
        /// </summary>
        [Column("�]��_�ʐ�")]
        public Decimal? �]��_�ʐ� { get; set; }

        /// <summary>
        /// �]��_�ʐ�_��M�S��
        /// </summary>
        [Column("�]��_�ʐ�_��M�S��")]
        public Decimal? �]��_�ʐ�_��M�S�� { get; set; }

        /// <summary>
        /// �]��_�ʐ�_��M����
        /// </summary>
        [Column("�]��_�ʐ�_��M����")]
        public Decimal? �]��_�ʐ�_��M���� { get; set; }

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
        /// �]��_�x�����ϋ�
        /// </summary>
        [Column("�]��_�x�����ϋ�")]
        public Decimal? �]��_�x�����ϋ� { get; set; }

        /// <summary>
        /// �]��_�x�����ϋ�_�����ߔ�Q
        /// </summary>
        [Column("�]��_�x�����ϋ�_�����ߔ�Q")]
        public Decimal? �]��_�x�����ϋ�_�����ߔ�Q { get; set; }

        /// <summary>
        /// �]��_�x�����ϋ�_����M�S��
        /// </summary>
        [Column("�]��_�x�����ϋ�_����M�S��")]
        public Decimal? �]��_�x�����ϋ�_����M�S�� { get; set; }

        /// <summary>
        /// �]��_�x�����ϋ�_����M����
        /// </summary>
        [Column("�]��_�x�����ϋ�_����M����")]
        public Decimal? �]��_�x�����ϋ�_����M���� { get; set; }

        /// <summary>
        /// �]��_���x�����ϋ�
        /// </summary>
        [Column("�]��_���x�����ϋ�")]
        public Decimal? �]��_���x�����ϋ� { get; set; }

        /// <summary>
        /// �]��_���z��Q��
        /// </summary>
        [Column("�]��_���z��Q��")]
        public Decimal? �]��_���z��Q�� { get; set; }

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
