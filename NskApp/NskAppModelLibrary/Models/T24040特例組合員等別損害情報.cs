using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24040_����g�������ʑ��Q���
    /// </summary>
    [Serializable]
    [Table("t_24040_����g�������ʑ��Q���")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�g�������R�[�h), nameof(���v�P�ʒn��R�[�h))]
    public class T24040����g�������ʑ��Q��� : ModelBase
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
        /// ���F�M��
        /// </summary>
        [Column("���F�M��")]
        public Decimal? ���F�M�� { get; set; }

        /// <summary>
        /// ���F�M�ʐ�
        /// </summary>
        [Column("���F�M�ʐ�")]
        public Decimal? ���F�M�ʐ� { get; set; }

        /// <summary>
        /// ��ʔ�Q�M��
        /// </summary>
        [Column("��ʔ�Q�M��")]
        public Decimal? ��ʔ�Q�M�� { get; set; }

        /// <summary>
        /// ��ʔ�Q�ʐ�
        /// </summary>
        [Column("��ʔ�Q�ʐ�")]
        public Decimal? ��ʔ�Q�ʐ� { get; set; }

        /// <summary>
        /// ��ʔ�Q���n��
        /// </summary>
        [Column("��ʔ�Q���n��")]
        public Decimal? ��ʔ�Q���n�� { get; set; }

        /// <summary>
        /// ��ʔ�Q������
        /// </summary>
        [Column("��ʔ�Q������")]
        public Decimal? ��ʔ�Q������ { get; set; }

        /// <summary>
        /// �F���M��
        /// </summary>
        [Column("�F���M��")]
        public Decimal? �F���M�� { get; set; }

        /// <summary>
        /// �F���ʐ�
        /// </summary>
        [Column("�F���ʐ�")]
        public Decimal? �F���ʐ� { get; set; }

        /// <summary>
        /// �F�����n��
        /// </summary>
        [Column("�F�����n��")]
        public Decimal? �F�����n�� { get; set; }

        /// <summary>
        /// �F��������
        /// </summary>
        [Column("�F��������")]
        public Decimal? �F�������� { get; set; }

        /// <summary>
        /// �s�\�M��
        /// </summary>
        [Column("�s�\�M��")]
        public Decimal? �s�\�M�� { get; set; }

        /// <summary>
        /// �s�\�ʐ�
        /// </summary>
        [Column("�s�\�ʐ�")]
        public Decimal? �s�\�ʐ� { get; set; }

        /// <summary>
        /// �s�\���n��
        /// </summary>
        [Column("�s�\���n��")]
        public Decimal? �s�\���n�� { get; set; }

        /// <summary>
        /// �s�\������
        /// </summary>
        [Column("�s�\������")]
        public Decimal? �s�\������ { get; set; }

        /// <summary>
        /// �]�쓙�M��
        /// </summary>
        [Column("�]�쓙�M��")]
        public Decimal? �]�쓙�M�� { get; set; }

        /// <summary>
        /// �]�쓙�ʐ�
        /// </summary>
        [Column("�]�쓙�ʐ�")]
        public Decimal? �]�쓙�ʐ� { get; set; }

        /// <summary>
        /// �]�쓙���n��
        /// </summary>
        [Column("�]�쓙���n��")]
        public Decimal? �]�쓙���n�� { get; set; }

        /// <summary>
        /// �]�쓙������
        /// </summary>
        [Column("�]�쓙������")]
        public Decimal? �]�쓙������ { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [Column("����������")]
        public Decimal? ���������� { get; set; }

        /// <summary>
        /// �����ʎZ�芄��
        /// </summary>
        [Column("�����ʎZ�芄��")]
        public Decimal? �����ʎZ�芄�� { get; set; }

        /// <summary>
        /// ���ጸ����
        /// </summary>
        [Column("���ጸ����")]
        public Decimal? ���ጸ���� { get; set; }

        /// <summary>
        /// ���ߔ�Q���ό�����
        /// </summary>
        [Column("���ߔ�Q���ό�����")]
        public Decimal? ���ߔ�Q���ό����� { get; set; }

        /// <summary>
        /// ��M�S���F���M��
        /// </summary>
        [Column("��M�S���F���M��")]
        public Decimal? ��M�S���F���M�� { get; set; }

        /// <summary>
        /// ��M�S���F���ʐ�
        /// </summary>
        [Column("��M�S���F���ʐ�")]
        public Decimal? ��M�S���F���ʐ� { get; set; }

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
        /// ��M�S���s�\�ʐ�
        /// </summary>
        [Column("��M�S���s�\�ʐ�")]
        public Decimal? ��M�S���s�\�ʐ� { get; set; }

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
        /// ������M�����k�n�M��
        /// </summary>
        [Column("������M�����k�n�M��")]
        public Decimal? ������M�����k�n�M�� { get; set; }

        /// <summary>
        /// ������M�����ʐ�
        /// </summary>
        [Column("������M�����ʐ�")]
        public Decimal? ������M�����ʐ� { get; set; }

        /// <summary>
        /// ������M�����k�n����n��
        /// </summary>
        [Column("������M�����k�n����n��")]
        public Decimal? ������M�����k�n����n�� { get; set; }

        /// <summary>
        /// ������M�����k�n������
        /// </summary>
        [Column("������M�����k�n������")]
        public Decimal? ������M�����k�n������ { get; set; }

        /// <summary>
        /// ������M�����x���J�n������
        /// </summary>
        [Column("������M�����x���J�n������")]
        public Decimal? ������M�����x���J�n������ { get; set; }

        /// <summary>
        /// ������M�������ό�����
        /// </summary>
        [Column("������M�������ό�����")]
        public Decimal? ������M�������ό����� { get; set; }

        /// <summary>
        /// ������M�O�����ό�����
        /// </summary>
        [Column("������M�O�����ό�����")]
        public Decimal? ������M�O�����ό����� { get; set; }

        /// <summary>
        /// ��Q�敪
        /// </summary>
        [Column("��Q�敪")]
        [StringLength(1)]
        public string ��Q�敪 { get; set; }

        /// <summary>
        /// ������Q�M��
        /// </summary>
        [Column("������Q�M��")]
        public Decimal? ������Q�M�� { get; set; }

        /// <summary>
        /// ������Q�ʐ�
        /// </summary>
        [Column("������Q�ʐ�")]
        public Decimal? ������Q�ʐ� { get; set; }

        /// <summary>
        /// �������ό�����
        /// </summary>
        [Column("�������ό�����")]
        public Decimal? �������ό����� { get; set; }

        /// <summary>
        /// �������ϋ������z
        /// </summary>
        [Column("�������ϋ������z")]
        public Decimal? �������ϋ������z { get; set; }

        /// <summary>
        /// ��������������
        /// </summary>
        [Column("��������������")]
        public Decimal? �������������� { get; set; }

        /// <summary>
        /// �x���Ώۋ敪
        /// </summary>
        [Column("�x���Ώۋ敪")]
        [StringLength(1)]
        public string �x���Ώۋ敪 { get; set; }

        /// <summary>
        /// ���苤�ό�����
        /// </summary>
        [Column("���苤�ό�����")]
        public Decimal? ���苤�ό����� { get; set; }

        /// <summary>
        /// �x������������
        /// </summary>
        [Column("�x������������")]
        public Decimal? �x������������ { get; set; }

        /// <summary>
        /// ���ϋ�
        /// </summary>
        [Column("���ϋ�")]
        public Decimal? ���ϋ� { get; set; }

        /// <summary>
        /// �ƐӃt���O
        /// </summary>
        [Column("�ƐӃt���O")]
        [StringLength(1)]
        public string �ƐӃt���O { get; set; }

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
        /// �x���Ώۖʐ�
        /// </summary>
        [Column("�x���Ώۖʐ�")]
        public Decimal? �x���Ώۖʐ� { get; set; }

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
        /// ����m����t
        /// </summary>
        [Column("����m����t")]
        public DateTime? ����m����t { get; set; }

        /// <summary>
        /// �����v�Z���t
        /// </summary>
        [Column("�����v�Z���t")]
        public DateTime? �����v�Z���t { get; set; }

        /// <summary>
        /// ����v�Z���t
        /// </summary>
        [Column("����v�Z���t")]
        public DateTime? ����v�Z���t { get; set; }

        /// <summary>
        /// ���{�ی��F��敪
        /// </summary>
        [Column("���{�ی��F��敪")]
        [StringLength(4)]
        public string ���{�ی��F��敪 { get; set; }

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
