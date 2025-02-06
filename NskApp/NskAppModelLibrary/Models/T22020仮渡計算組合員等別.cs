using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_22020_���n�v�Z�g��������
    /// </summary>
    [Serializable]
    [Table("t_22020_���n�v�Z�g��������")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�g�������R�[�h), nameof(���v�P�ʒn��R�[�h), nameof(���n��))]
    public class T22020���n�v�Z�g�������� : ModelBase
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
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 5)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// ���v�P�ʒn��R�[�h
        /// </summary>
        [Required]
        [Column("���v�P�ʒn��R�[�h", Order = 6)]
        [StringLength(5)]
        public string ���v�P�ʒn��R�[�h { get; set; }

        /// <summary>
        /// ���n��
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("���n��", Order = 7)]
        public short ���n�� { get; set; }

        /// <summary>
        /// ���ϋ��z�P��
        /// </summary>
        [Column("���ϋ��z�P��")]
        public Decimal? ���ϋ��z�P�� { get; set; }

        /// <summary>
        /// ��M�S���F���M��
        /// </summary>
        [Column("��M�S���F���M��")]
        public Decimal? ��M�S���F���M�� { get; set; }

        /// <summary>
        /// ��M�S���F������n��
        /// </summary>
        [Column("��M�S���F������n��")]
        public Decimal? ��M�S���F������n�� { get; set; }

        /// <summary>
        /// ��M�S���F��������
        /// </summary>
        [Column("��M�S���F��������")]
        public Decimal? ��M�S���F�������� { get; set; }

        /// <summary>
        /// ��M�S���s�\�M��
        /// </summary>
        [Column("��M�S���s�\�M��")]
        public Decimal? ��M�S���s�\�M�� { get; set; }

        /// <summary>
        /// ��M�S���s�\����n��
        /// </summary>
        [Column("��M�S���s�\����n��")]
        public Decimal? ��M�S���s�\����n�� { get; set; }

        /// <summary>
        /// ��M�S���s�\������
        /// </summary>
        [Column("��M�S���s�\������")]
        public Decimal? ��M�S���s�\������ { get; set; }

        /// <summary>
        /// ��M�S���x���J�n������
        /// </summary>
        [Column("��M�S���x���J�n������")]
        public Decimal? ��M�S���x���J�n������ { get; set; }

        /// <summary>
        /// ��M�S�����ό�����
        /// </summary>
        [Column("��M�S�����ό�����")]
        public Decimal? ��M�S�����ό����� { get; set; }

        /// <summary>
        /// ��M�S�����n���ϋ������z
        /// </summary>
        [Column("��M�S�����n���ϋ������z")]
        public Decimal? ��M�S�����n���ϋ������z { get; set; }

        /// <summary>
        /// ��M������Q�M��
        /// </summary>
        [Column("��M������Q�M��")]
        public Decimal? ��M������Q�M�� { get; set; }

        /// <summary>
        /// ��M������Q����n��
        /// </summary>
        [Column("��M������Q����n��")]
        public Decimal? ��M������Q����n�� { get; set; }

        /// <summary>
        /// ��M������Q������
        /// </summary>
        [Column("��M������Q������")]
        public Decimal? ��M������Q������ { get; set; }

        /// <summary>
        /// ��M�����x���J�n������
        /// </summary>
        [Column("��M�����x���J�n������")]
        public Decimal? ��M�����x���J�n������ { get; set; }

        /// <summary>
        /// ��M�������ό�����
        /// </summary>
        [Column("��M�������ό�����")]
        public Decimal? ��M�������ό����� { get; set; }

        /// <summary>
        /// ��M�������n���ϋ������z
        /// </summary>
        [Column("��M�������n���ϋ������z")]
        public Decimal? ��M�������n���ϋ������z { get; set; }

        /// <summary>
        /// ���n���ϋ������z
        /// </summary>
        [Column("���n���ϋ������z")]
        public Decimal? ���n���ϋ������z { get; set; }

        /// <summary>
        /// �\�I���t���O
        /// </summary>
        [Column("�\�I���t���O")]
        [StringLength(1)]
        public string �\�I���t���O { get; set; }

        /// <summary>
        /// ���������ʃR�[�h
        /// </summary>
        [Column("���������ʃR�[�h")]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Column("��n��R�[�h")]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// ���n��R�[�h
        /// </summary>
        [Column("���n��R�[�h")]
        [StringLength(4)]
        public string ���n��R�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Column("����敪")]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Column("�⏞�����R�[�h")]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

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

        /// <summary>
        /// �X�V����
        /// </summary>
        [Column("�X�V����")]
        public DateTime? �X�V���� { get; set; }

        /// <summary>
        /// �X�V���[�Uid
        /// </summary>
        [Column("�X�V���[�Uid")]
        public string �X�V���[�Uid { get; set; }
    }
}
