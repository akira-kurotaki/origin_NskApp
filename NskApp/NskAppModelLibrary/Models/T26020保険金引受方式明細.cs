using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_26020_�ی���_�����������
    /// </summary>
    [Serializable]
    [Table("t_26020_�ی���_�����������")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(���������ʃR�[�h), nameof(�������), nameof(�⏞�����R�[�h), nameof(�P�����ϋ��z), nameof(������))]
    public class T26020�ی�������������� : ModelBase
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
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 4)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���������ʃR�[�h
        /// </summary>
        [Required]
        [Column("���������ʃR�[�h", Order = 5)]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 6)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Column("�⏞�����R�[�h", Order = 7)]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// �P�����ϋ��z
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�P�����ϋ��z", Order = 8)]
        public Decimal �P�����ϋ��z { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("������", Order = 9)]
        public short ������ { get; set; }

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
        /// ���ߎx���Ώۈ���ʐ�
        /// </summary>
        [Column("���ߎx���Ώۈ���ʐ�")]
        public Decimal? ���ߎx���Ώۈ���ʐ� { get; set; }

        /// <summary>
        /// ���ߎx���Ώیː�
        /// </summary>
        [Column("���ߎx���Ώیː�")]
        public Decimal? ���ߎx���Ώیː� { get; set; }

        /// <summary>
        /// ���ߎx���Ώۖʐ�
        /// </summary>
        [Column("���ߎx���Ώۖʐ�")]
        public Decimal? ���ߎx���Ώۖʐ� { get; set; }

        /// <summary>
        /// ���ߎx���Ώۈ������
        /// </summary>
        [Column("���ߎx���Ώۈ������")]
        public Decimal? ���ߎx���Ώۈ������ { get; set; }

        /// <summary>
        /// ���ߎx�����ό�����
        /// </summary>
        [Column("���ߎx�����ό�����")]
        public Decimal? ���ߎx�����ό����� { get; set; }

        /// <summary>
        /// ���ߔ�Q�x�����ϋ�
        /// </summary>
        [Column("���ߔ�Q�x�����ϋ�")]
        public Decimal? ���ߔ�Q�x�����ϋ� { get; set; }

        /// <summary>
        /// ��M�S���x���Ώیː�
        /// </summary>
        [Column("��M�S���x���Ώیː�")]
        public Decimal? ��M�S���x���Ώیː� { get; set; }

        /// <summary>
        /// ��M�S���x���Ώۖʐ�
        /// </summary>
        [Column("��M�S���x���Ώۖʐ�")]
        public Decimal? ��M�S���x���Ώۖʐ� { get; set; }

        /// <summary>
        /// ��M�S���x�����ό�����
        /// </summary>
        [Column("��M�S���x�����ό�����")]
        public Decimal? ��M�S���x�����ό����� { get; set; }

        /// <summary>
        /// ��M�S���x�����ϋ�
        /// </summary>
        [Column("��M�S���x�����ϋ�")]
        public Decimal? ��M�S���x�����ϋ� { get; set; }

        /// <summary>
        /// ��M�����x���Ώیː�
        /// </summary>
        [Column("��M�����x���Ώیː�")]
        public Decimal? ��M�����x���Ώیː� { get; set; }

        /// <summary>
        /// ��M�����x���Ώۖʐ�
        /// </summary>
        [Column("��M�����x���Ώۖʐ�")]
        public Decimal? ��M�����x���Ώۖʐ� { get; set; }

        /// <summary>
        /// ��M�����x�����ό�����
        /// </summary>
        [Column("��M�����x�����ό�����")]
        public Decimal? ��M�����x�����ό����� { get; set; }

        /// <summary>
        /// ��M�����x�����ϋ�
        /// </summary>
        [Column("��M�����x�����ϋ�")]
        public Decimal? ��M�����x�����ϋ� { get; set; }

        /// <summary>
        /// ��M����x���Ώیː�
        /// </summary>
        [Column("��M����x���Ώیː�")]
        public Decimal? ��M����x���Ώیː� { get; set; }

        /// <summary>
        /// ��M����x���Ώۖʐ�
        /// </summary>
        [Column("��M����x���Ώۖʐ�")]
        public Decimal? ��M����x���Ώۖʐ� { get; set; }

        /// <summary>
        /// ��M����x�����ό�����
        /// </summary>
        [Column("��M����x�����ό�����")]
        public Decimal? ��M����x�����ό����� { get; set; }

        /// <summary>
        /// ��M����x�����ϋ�
        /// </summary>
        [Column("��M����x�����ϋ�")]
        public Decimal? ��M����x�����ϋ� { get; set; }

        /// <summary>
        /// �x���Ώیː�
        /// </summary>
        [Column("�x���Ώیː�")]
        public Decimal? �x���Ώیː� { get; set; }

        /// <summary>
        /// �x���Ώۖʐ�
        /// </summary>
        [Column("�x���Ώۖʐ�")]
        public Decimal? �x���Ώۖʐ� { get; set; }

        /// <summary>
        /// �x���Ώۋ��ό�����
        /// </summary>
        [Column("�x���Ώۋ��ό�����")]
        public Decimal? �x���Ώۋ��ό����� { get; set; }

        /// <summary>
        /// �x�����ϋ�
        /// </summary>
        [Column("�x�����ϋ�")]
        public Decimal? �x�����ϋ� { get; set; }

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
