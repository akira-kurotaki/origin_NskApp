using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24020_�����v�Z�o�ߕM
    /// </summary>
    [Serializable]
    [Table("t_24020_�����v�Z�o�ߕM")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�))]
    public class T24020�����v�Z�o�ߕM : ModelBase
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
        /// �k�n�ԍ�
        /// </summary>
        [Required]
        [Column("�k�n�ԍ�", Order = 5)]
        [StringLength(5)]
        public string �k�n�ԍ� { get; set; }

        /// <summary>
        /// ���M�ԍ�
        /// </summary>
        [Required]
        [Column("���M�ԍ�", Order = 6)]
        [StringLength(4)]
        public string ���M�ԍ� { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Column("�p�r�敪")]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// �c�_�Ώۗp�t���O
        /// </summary>
        [Column("�c�_�Ώۗp�t���O")]
        [StringLength(1)]
        public string �c�_�Ώۗp�t���O { get; set; }

        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Column("�c�_�ΏۊO�t���O")]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

        /// <summary>
        /// �c�_��t�Ώۃt���O
        /// </summary>
        [Column("�c�_��t�Ώۃt���O")]
        [StringLength(1)]
        public string �c�_��t�Ώۃt���O { get; set; }

        /// <summary>
        /// ��Q����R�[�h
        /// </summary>
        [Column("��Q����R�[�h")]
        [StringLength(1)]
        public string ��Q����R�[�h { get; set; }

        /// <summary>
        /// ��Q�ʐ�
        /// </summary>
        [Column("��Q�ʐ�")]
        public Decimal? ��Q�ʐ� { get; set; }

        /// <summary>
        /// ��P��
        /// </summary>
        [Column("��P��")]
        public Decimal? ��P�� { get; set; }

        /// <summary>
        /// ����n��
        /// </summary>
        [Column("����n��")]
        public Decimal? ����n�� { get; set; }

        /// <summary>
        /// ����P��
        /// </summary>
        [Column("����P��")]
        public Decimal? ����P�� { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        public Decimal? ������� { get; set; }

        /// <summary>
        /// ����P�����ϋ��z
        /// </summary>
        [Column("����P�����ϋ��z")]
        public Decimal? ����P�����ϋ��z { get; set; }

        /// <summary>
        /// �P���C����
        /// </summary>
        [Column("�P���C����")]
        public Decimal? �P���C���� { get; set; }

        /// <summary>
        /// ���F�P��
        /// </summary>
        [Column("���F�P��")]
        public Decimal? ���F�P�� { get; set; }

        /// <summary>
        /// ���F���n��
        /// </summary>
        [Column("���F���n��")]
        public Decimal? ���F���n�� { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column("��������")]
        public Decimal? �������� { get; set; }

        /// <summary>
        /// �g�����]���P��
        /// </summary>
        [Column("�g�����]���P��")]
        public Decimal? �g�����]���P�� { get; set; }

        /// <summary>
        /// �g�����]������
        /// </summary>
        [Column("�g�����]������")]
        public Decimal? �g�����]������ { get; set; }

        /// <summary>
        /// ��t�Ώۋ��ϒP��
        /// </summary>
        [Column("��t�Ώۋ��ϒP��")]
        public Decimal? ��t�Ώۋ��ϒP�� { get; set; }

        /// <summary>
        /// ��t�ΏۊO���ϒP��
        /// </summary>
        [Column("��t�ΏۊO���ϒP��")]
        public Decimal? ��t�ΏۊO���ϒP�� { get; set; }

        /// <summary>
        /// ���ʕ������z
        /// </summary>
        [Column("���ʕ������z")]
        public Decimal? ���ʕ������z { get; set; }

        /// <summary>
        /// �����P�����ō��z
        /// </summary>
        [Column("�����P�����ō��z")]
        public Decimal? �����P�����ō��z { get; set; }

        /// <summary>
        /// �����P�����ō��z
        /// </summary>
        [Column("�����P�����ō��z")]
        public Decimal? �����P�����ō��z { get; set; }

        /// <summary>
        /// ���ʕ��P��
        /// </summary>
        [Column("���ʕ��P��")]
        public Decimal? ���ʕ��P�� { get; set; }

        /// <summary>
        /// ����P��
        /// </summary>
        [Column("����P��")]
        public Decimal? ����P�� { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        public Decimal? ������� { get; set; }

        /// <summary>
        /// ���N���n��
        /// </summary>
        [Column("���N���n��")]
        public Decimal? ���N���n�� { get; set; }

        /// <summary>
        /// �s�\������
        /// </summary>
        [Column("�s�\������")]
        public Decimal? �s�\������ { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column("����")]
        public Decimal? ���� { get; set; }

        /// <summary>
        /// ����ȉ�
        /// </summary>
        [Column("����ȉ�")]
        public Decimal? ����ȉ� { get; set; }

        /// <summary>
        /// �����㓖�N���n��
        /// </summary>
        [Column("�����㓖�N���n��")]
        public Decimal? �����㓖�N���n�� { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Column("������")]
        public Decimal? ������ { get; set; }

        /// <summary>
        /// ���ό�����
        /// </summary>
        [Column("���ό�����")]
        public Decimal? ���ό����� { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [Column("����������")]
        public Decimal? ���������� { get; set; }

        /// <summary>
        /// ��M�S������
        /// </summary>
        [Column("��M�S������")]
        [StringLength(1)]
        public string ��M�S������ { get; set; }

        /// <summary>
        /// ��M�S��������
        /// </summary>
        [Column("��M�S��������")]
        public Decimal? ��M�S�������� { get; set; }

        /// <summary>
        /// ���ϋ�
        /// </summary>
        [Column("���ϋ�")]
        public Decimal? ���ϋ� { get; set; }

        /// <summary>
        /// ���������ʃR�[�h
        /// </summary>
        [Column("���������ʃR�[�h")]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

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
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �]���n��R�[�h
        /// </summary>
        [Column("�]���n��R�[�h")]
        [StringLength(4)]
        public string �]���n��R�[�h { get; set; }

        /// <summary>
        /// �K�w�敪
        /// </summary>
        [Column("�K�w�敪")]
        [StringLength(3)]
        public string �K�w�敪 { get; set; }

        /// <summary>
        /// �S���E�v�Z���@
        /// </summary>
        [Column("�S���E�v�Z���@")]
        [StringLength(1)]
        public string �S���E�v�Z���@ { get; set; }

        /// <summary>
        /// �����]������R�[�h
        /// </summary>
        [Column("�����]������R�[�h")]
        [StringLength(2)]
        public string �����]������R�[�h { get; set; }

        /// <summary>
        /// ���v�P�ʒn��R�[�h
        /// </summary>
        [Column("���v�P�ʒn��R�[�h")]
        [StringLength(5)]
        public string ���v�P�ʒn��R�[�h { get; set; }

        /// <summary>
        /// ��t����
        /// </summary>
        [Column("��t����")]
        [StringLength(1)]
        public string ��t���� { get; set; }

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
