using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24280_����x���ʓ����]���W�v
    /// </summary>
    [Serializable]
    [Table("t_24280_����x���ʓ����]���W�v")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�x���R�[�h), nameof(�������), nameof(�⏞�����R�[�h), nameof(���{�ی��F��敪))]
    public class T24280����x���ʓ����]���W�v : ModelBase
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
        /// �x���R�[�h
        /// </summary>
        [Required]
        [Column("�x���R�[�h", Order = 5)]
        [StringLength(2)]
        public string �x���R�[�h { get; set; }

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
        /// ���{�ی��F��敪
        /// </summary>
        [Required]
        [Column("���{�ی��F��敪", Order = 8)]
        [StringLength(4)]
        public string ���{�ی��F��敪 { get; set; }

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
        /// ���ϋ��z
        /// </summary>
        [Column("���ϋ��z")]
        public Decimal? ���ϋ��z { get; set; }

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
        /// �S�M�����k�n�ʐ�
        /// </summary>
        [Column("�S�M�����k�n�ʐ�")]
        public Decimal? �S�M�����k�n�ʐ� { get; set; }

        /// <summary>
        /// ��r�O���ߔ�Q�M��
        /// </summary>
        [Column("��r�O���ߔ�Q�M��")]
        public Decimal? ��r�O���ߔ�Q�M�� { get; set; }

        /// <summary>
        /// ��r�O���ߔ�Q�ː�
        /// </summary>
        [Column("��r�O���ߔ�Q�ː�")]
        public Decimal? ��r�O���ߔ�Q�ː� { get; set; }

        /// <summary>
        /// ��r�O���ߔ�Q�ʐ�
        /// </summary>
        [Column("��r�O���ߔ�Q�ʐ�")]
        public Decimal? ��r�O���ߔ�Q�ʐ� { get; set; }

        /// <summary>
        /// ��r�O���ߔ�Q���ό�����
        /// </summary>
        [Column("��r�O���ߔ�Q���ό�����")]
        public Decimal? ��r�O���ߔ�Q���ό����� { get; set; }

        /// <summary>
        /// ��r�O���ߔ�Q�x�����ϋ������z
        /// </summary>
        [Column("��r�O���ߔ�Q�x�����ϋ������z")]
        public Decimal? ��r�O���ߔ�Q�x�����ϋ������z { get; set; }

        /// <summary>
        /// ���ߔ�Q�M��
        /// </summary>
        [Column("���ߔ�Q�M��")]
        public Decimal? ���ߔ�Q�M�� { get; set; }

        /// <summary>
        /// ���ߔ�Q�ː�
        /// </summary>
        [Column("���ߔ�Q�ː�")]
        public Decimal? ���ߔ�Q�ː� { get; set; }

        /// <summary>
        /// ���ߔ�Q�ʐ�
        /// </summary>
        [Column("���ߔ�Q�ʐ�")]
        public Decimal? ���ߔ�Q�ʐ� { get; set; }

        /// <summary>
        /// ���ߔ�Q���ό�����
        /// </summary>
        [Column("���ߔ�Q���ό�����")]
        public Decimal? ���ߔ�Q���ό����� { get; set; }

        /// <summary>
        /// ���ߔ�Q�x�����ϋ������z
        /// </summary>
        [Column("���ߔ�Q�x�����ϋ������z")]
        public Decimal? ���ߔ�Q�x�����ϋ������z { get; set; }

        /// <summary>
        /// ��M�S���ː�
        /// </summary>
        [Column("��M�S���ː�")]
        public Decimal? ��M�S���ː� { get; set; }

        /// <summary>
        /// ��M�S����Q�ʐ�
        /// </summary>
        [Column("��M�S����Q�ʐ�")]
        public Decimal? ��M�S����Q�ʐ� { get; set; }

        /// <summary>
        /// ��M�S�����ό�����
        /// </summary>
        [Column("��M�S�����ό�����")]
        public Decimal? ��M�S�����ό����� { get; set; }

        /// <summary>
        /// ��M�S���x�����ϋ������z
        /// </summary>
        [Column("��M�S���x�����ϋ������z")]
        public Decimal? ��M�S���x�����ϋ������z { get; set; }

        /// <summary>
        /// ��M�����ː�
        /// </summary>
        [Column("��M�����ː�")]
        public Decimal? ��M�����ː� { get; set; }

        /// <summary>
        /// ��M������Q�ʐ�
        /// </summary>
        [Column("��M������Q�ʐ�")]
        public Decimal? ��M������Q�ʐ� { get; set; }

        /// <summary>
        /// ��M�������ό�����
        /// </summary>
        [Column("��M�������ό�����")]
        public Decimal? ��M�������ό����� { get; set; }

        /// <summary>
        /// ��M�����x�����ϋ������z
        /// </summary>
        [Column("��M�����x�����ϋ������z")]
        public Decimal? ��M�����x�����ϋ������z { get; set; }

        /// <summary>
        /// ��M����ː�
        /// </summary>
        [Column("��M����ː�")]
        public Decimal? ��M����ː� { get; set; }

        /// <summary>
        /// ��M�����Q�ʐ�
        /// </summary>
        [Column("��M�����Q�ʐ�")]
        public Decimal? ��M�����Q�ʐ� { get; set; }

        /// <summary>
        /// ��M���ዤ�ό�����
        /// </summary>
        [Column("��M���ዤ�ό�����")]
        public Decimal? ��M���ዤ�ό����� { get; set; }

        /// <summary>
        /// ��M����x�����ϋ������z
        /// </summary>
        [Column("��M����x�����ϋ������z")]
        public Decimal? ��M����x�����ϋ������z { get; set; }

        /// <summary>
        /// �x���Ώ۔�Q�ː�
        /// </summary>
        [Column("�x���Ώ۔�Q�ː�")]
        public Decimal? �x���Ώ۔�Q�ː� { get; set; }

        /// <summary>
        /// �x���Ώ۔�Q�ʐ�
        /// </summary>
        [Column("�x���Ώ۔�Q�ʐ�")]
        public Decimal? �x���Ώ۔�Q�ʐ� { get; set; }

        /// <summary>
        /// �x���Ώ۔�Q���ό�����
        /// </summary>
        [Column("�x���Ώ۔�Q���ό�����")]
        public Decimal? �x���Ώ۔�Q���ό����� { get; set; }

        /// <summary>
        /// �x���Ώێx�����ϋ������z
        /// </summary>
        [Column("�x���Ώێx�����ϋ������z")]
        public Decimal? �x���Ώێx�����ϋ������z { get; set; }

        /// <summary>
        /// �ʏ�ӔC���ϋ��z
        /// </summary>
        [Column("�ʏ�ӔC���ϋ��z")]
        public Decimal? �ʏ�ӔC���ϋ��z { get; set; }

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
