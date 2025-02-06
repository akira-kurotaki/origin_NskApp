using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12040_�g�������ʈ�����
    /// </summary>
    [Serializable]
    [Table("t_12040_�g�������ʈ�����")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�����), nameof(�g�������R�[�h), nameof(�ދ敪), nameof(���v�P�ʒn��R�[�h))]
    public class T12040�g�������ʈ����� : ModelBase
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
        /// �����
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�����", Order = 4)]
        public short ����� { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 5)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 6)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���v�P�ʒn��R�[�h
        /// </summary>
        [Required]
        [Column("���v�P�ʒn��R�[�h", Order = 7)]
        [StringLength(5)]
        public string ���v�P�ʒn��R�[�h { get; set; }

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
        /// �x���R�[�h
        /// </summary>
        [Column("�x���R�[�h")]
        [StringLength(2)]
        public string �x���R�[�h { get; set; }

        /// <summary>
        /// �k�n�M��
        /// </summary>
        [Column("�k�n�M��")]
        public Decimal? �k�n�M�� { get; set; }

        /// <summary>
        /// �k�n�ʐόv
        /// </summary>
        [Column("�k�n�ʐόv")]
        public Decimal? �k�n�ʐόv { get; set; }

        /// <summary>
        /// �k�n�ʐώ��v
        /// </summary>
        [Column("�k�n�ʐώ��v")]
        public Decimal? �k�n�ʐώ��v { get; set; }

        /// <summary>
        /// �S�ʓ]��t���O
        /// </summary>
        [Column("�S�ʓ]��t���O")]
        [StringLength(1)]
        public string �S�ʓ]��t���O { get; set; }

        /// <summary>
        /// ����M��
        /// </summary>
        [Column("����M��")]
        public Decimal? ����M�� { get; set; }

        /// <summary>
        /// ����ʐόv
        /// </summary>
        [Column("����ʐόv")]
        public Decimal? ����ʐόv { get; set; }

        /// <summary>
        /// ����n�ʌv
        /// </summary>
        [Column("����n�ʌv")]
        public Decimal? ����n�ʌv { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        public Decimal? ������� { get; set; }

        /// <summary>
        /// ���ϋ��z�I������
        /// </summary>
        [Column("���ϋ��z�I������")]
        public Decimal? ���ϋ��z�I������ { get; set; }

        /// <summary>
        /// ���ϋ��z�P��
        /// </summary>
        [Column("���ϋ��z�P��")]
        public Decimal? ���ϋ��z�P�� { get; set; }

        /// <summary>
        /// �댯�i�K�n��敪
        /// </summary>
        [Column("�댯�i�K�n��敪")]
        [StringLength(5)]
        public string �댯�i�K�n��敪 { get; set; }

        /// <summary>
        /// �댯�i�K�敪
        /// </summary>
        [Column("�댯�i�K�敪")]
        [StringLength(3)]
        public string �댯�i�K�敪 { get; set; }

        /// <summary>
        /// ���ϊ|���W����
        /// </summary>
        [Column("���ϊ|���W����")]
        public Decimal? ���ϊ|���W���� { get; set; }

        /// <summary>
        /// ����ϊ|����
        /// </summary>
        [Column("����ϊ|����")]
        public Decimal? ����ϊ|���� { get; set; }

        /// <summary>
        /// ���ϊ|����
        /// </summary>
        [Column("���ϊ|����")]
        public Decimal? ���ϊ|���� { get; set; }

        /// <summary>
        /// �t�ۊ���
        /// </summary>
        [Column("�t�ۊ���")]
        public Decimal? �t�ۊ��� { get; set; }

        /// <summary>
        /// ���ɕ��S����
        /// </summary>
        [Column("���ɕ��S����")]
        public Decimal? ���ɕ��S���� { get; set; }

        /// <summary>
        /// �ʏ�W����Q��
        /// </summary>
        [Column("�ʏ�W����Q��")]
        public Decimal? �ʏ�W����Q�� { get; set; }

        /// <summary>
        /// �댯�i�K�ʒʏ�W����Q��
        /// </summary>
        [Column("�댯�i�K�ʒʏ�W����Q��")]
        public Decimal? �댯�i�K�ʒʏ�W����Q�� { get; set; }

        /// <summary>
        /// �Œዤ�ϋ��z
        /// </summary>
        [Column("�Œዤ�ϋ��z")]
        public Decimal? �Œዤ�ϋ��z { get; set; }

        /// <summary>
        /// �ی�����b��
        /// </summary>
        [Column("�ی�����b��")]
        public Decimal? �ی�����b�� { get; set; }

        /// <summary>
        /// �댯�i�K�ʕی�����b��
        /// </summary>
        [Column("�댯�i�K�ʕی�����b��")]
        public Decimal? �댯�i�K�ʕی�����b�� { get; set; }

        /// <summary>
        /// �ĕی�����b��
        /// </summary>
        [Column("�ĕی�����b��")]
        public Decimal? �ĕی�����b�� { get; set; }

        /// <summary>
        /// �댯�i�K�ʍĕی�����b��
        /// </summary>
        [Column("�댯�i�K�ʍĕی�����b��")]
        public Decimal? �댯�i�K�ʍĕی�����b�� { get; set; }

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
        /// �댯�i�K����ϊ|����
        /// </summary>
        [Column("�댯�i�K����ϊ|����")]
        public Decimal? �댯�i�K����ϊ|���� { get; set; }

        /// <summary>
        /// �댯�i�K���ϊ|����
        /// </summary>
        [Column("�댯�i�K���ϊ|����")]
        public Decimal? �댯�i�K���ϊ|���� { get; set; }

        /// <summary>
        /// ����ϊ|��
        /// </summary>
        [Column("����ϊ|��")]
        public Decimal? ����ϊ|�� { get; set; }

        /// <summary>
        /// ���ϊ|��
        /// </summary>
        [Column("���ϊ|��")]
        public Decimal? ���ϊ|�� { get; set; }

        /// <summary>
        /// ��t�Ώە��S��
        /// </summary>
        [Column("��t�Ώە��S��")]
        public Decimal? ��t�Ώە��S�� { get; set; }

        /// <summary>
        /// �g���������S���ϊ|��
        /// </summary>
        [Column("�g���������S���ϊ|��")]
        public Decimal? �g���������S���ϊ|�� { get; set; }

        /// <summary>
        /// ��ʕ��ۋ�
        /// </summary>
        [Column("��ʕ��ۋ�")]
        public Decimal? ��ʕ��ۋ� { get; set; }

        /// <summary>
        /// �h�Е��ۋ�
        /// </summary>
        [Column("�h�Е��ۋ�")]
        public Decimal? �h�Е��ۋ� { get; set; }

        /// <summary>
        /// ���ʕ��ۋ�
        /// </summary>
        [Column("���ʕ��ۋ�")]
        public Decimal? ���ʕ��ۋ� { get; set; }

        /// <summary>
        /// �g��������
        /// </summary>
        [Column("�g��������")]
        public Decimal? �g�������� { get; set; }

        /// <summary>
        /// ���ۋ��v
        /// </summary>
        [Column("���ۋ��v")]
        public Decimal? ���ۋ��v { get; set; }

        /// <summary>
        /// �[���z
        /// </summary>
        [Column("�[���z")]
        public Decimal? �[���z { get; set; }

        /// <summary>
        /// �����z
        /// </summary>
        [Column("�����z")]
        public Decimal? �����z { get; set; }

        /// <summary>
        /// ���؋�
        /// </summary>
        [Column("���؋�")]
        public Decimal? ���؋� { get; set; }

        /// <summary>
        /// �_�앨�ʏ�W����Q��
        /// </summary>
        [Column("�_�앨�ʏ�W����Q��")]
        public Decimal? �_�앨�ʏ�W����Q�� { get; set; }

        /// <summary>
        /// �댯�i�K�ʔ_�앨�ʏ�W����Q��
        /// </summary>
        [Column("�댯�i�K�ʔ_�앨�ʏ�W����Q��")]
        public Decimal? �댯�i�K�ʔ_�앨�ʏ�W����Q�� { get; set; }

        /// <summary>
        /// �ʏ�ӔC���ϋ��z
        /// </summary>
        [Column("�ʏ�ӔC���ϋ��z")]
        public Decimal? �ʏ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �ُ�ӔC���ϋ��z
        /// </summary>
        [Column("�ُ�ӔC���ϋ��z")]
        public Decimal? �ُ�ӔC���ϋ��z { get; set; }

        /// <summary>
        /// �ُ�ӔC���ϊ|��
        /// </summary>
        [Column("�ُ�ӔC���ϊ|��")]
        public Decimal? �ُ�ӔC���ϊ|�� { get; set; }

        /// <summary>
        /// �ʏ�ӔC�ی�����
        /// </summary>
        [Column("�ʏ�ӔC�ی�����")]
        public Decimal? �ʏ�ӔC�ی����� { get; set; }

        /// <summary>
        /// �ĕی����z��b�z
        /// </summary>
        [Column("�ĕی����z��b�z")]
        public Decimal? �ĕی����z��b�z { get; set; }

        /// <summary>
        /// �ĕی����z
        /// </summary>
        [Column("�ĕی����z")]
        public Decimal? �ĕی����z { get; set; }

        /// <summary>
        /// �ĕی���
        /// </summary>
        [Column("�ĕی���")]
        public Decimal? �ĕی��� { get; set; }

        /// <summary>
        /// �ی����z
        /// </summary>
        [Column("�ی����z")]
        public Decimal? �ی����z { get; set; }

        /// <summary>
        /// �ی���
        /// </summary>
        [Column("�ی���")]
        public Decimal? �ی��� { get; set; }

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
        /// ���������ʃR�[�h
        /// </summary>
        [Column("���������ʃR�[�h")]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// �p������t���O
        /// </summary>
        [Column("�p������t���O")]
        [StringLength(1)]
        public string �p������t���O { get; set; }

        /// <summary>
        /// ����Ώۃt���O
        /// </summary>
        [Column("����Ώۃt���O")]
        [StringLength(1)]
        public string ����Ώۃt���O { get; set; }

        /// <summary>
        /// �������t���O
        /// </summary>
        [Column("�������t���O")]
        [StringLength(1)]
        public string �������t���O { get; set; }

        /// <summary>
        /// �����t���O
        /// </summary>
        [Column("�����t���O")]
        [StringLength(1)]
        public string �����t���O { get; set; }

        /// <summary>
        /// ����������t
        /// </summary>
        [Column("����������t")]
        public DateTime? ����������t { get; set; }

        /// <summary>
        /// ��������Ԋҕ��ۋ��z
        /// </summary>
        [Column("��������Ԋҕ��ۋ��z")]
        public Decimal? ��������Ԋҕ��ۋ��z { get; set; }

        /// <summary>
        /// �S���E����t���O
        /// </summary>
        [Column("�S���E����t���O")]
        [StringLength(1)]
        public string �S���E����t���O { get; set; }

        /// <summary>
        /// ���n�ʊm�F���@
        /// </summary>
        [Column("���n�ʊm�F���@")]
        [StringLength(2)]
        public string ���n�ʊm�F���@ { get; set; }

        /// <summary>
        /// �\�t���O
        /// </summary>
        [Column("�\�t���O")]
        [StringLength(1)]
        public string �\�t���O { get; set; }

        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Column("�c�_�ΏۊO�t���O")]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

        /// <summary>
        /// �S��_�Ƌ敪
        /// </summary>
        [Column("�S��_�Ƌ敪")]
        [StringLength(1)]
        public string �S��_�Ƌ敪 { get; set; }

        /// <summary>
        /// ���v�P��
        /// </summary>
        [Column("���v�P��")]
        public Decimal? ���v�P�� { get; set; }

        /// <summary>
        /// �v�Z���t
        /// </summary>
        [Column("�v�Z���t")]
        public DateTime? �v�Z���t { get; set; }

        /// <summary>
        /// ���������
        /// </summary>
        [Column("���������")]
        public short? ��������� { get; set; }

        /// <summary>
        /// �������R�R�[�h
        /// </summary>
        [Column("�������R�R�[�h")]
        [StringLength(1)]
        public string �������R�R�[�h { get; set; }

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
