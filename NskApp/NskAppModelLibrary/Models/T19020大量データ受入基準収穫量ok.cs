using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_19020_��ʃf�[�^���_����n��OK
    /// </summary>
    [Serializable]
    [Table("t_19020_��ʃf�[�^���_����n��OK")]
    [PrimaryKey(nameof(�������id), nameof(�s�ԍ�))]
    public class T19020��ʃf�[�^�������n��ok : ModelBase
    {
        /// <summary>
        /// �������id
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�������id", Order = 1)]
        public long �������id { get; set; }

        /// <summary>
        /// �s�ԍ�
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�s�ԍ�", Order = 2)]
        public Decimal �s�ԍ� { get; set; }

        /// <summary>
        /// �����敪
        /// </summary>
        [Column("�����敪")]
        [StringLength(1)]
        public string �����敪 { get; set; }

        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Column("�g�����R�[�h")]
        [StringLength(3)]
        public string �g�����R�[�h { get; set; }

        /// <summary>
        /// �g������
        /// </summary>
        [Column("�g������")]
        public string �g������ { get; set; }

        /// <summary>
        /// �N�Y
        /// </summary>
        [Column("�N�Y")]
        public short? �N�Y { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Column("���ϖړI�R�[�h")]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// ���ϖړI��
        /// </summary>
        [Column("���ϖړI��")]
        public string ���ϖړI�� { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        [Column("�����������")]
        public string ����������� { get; set; }

        /// <summary>
        /// �x���R�[�h
        /// </summary>
        [Column("�x���R�[�h")]
        [StringLength(2)]
        public string �x���R�[�h { get; set; }

        /// <summary>
        /// �x����
        /// </summary>
        [Column("�x����")]
        public string �x���� { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Column("��n��R�[�h")]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// ��n�於
        /// </summary>
        [Column("��n�於")]
        public string ��n�於 { get; set; }

        /// <summary>
        /// ���n��R�[�h
        /// </summary>
        [Column("���n��R�[�h")]
        [StringLength(4)]
        public string ���n��R�[�h { get; set; }

        /// <summary>
        /// ���n�於
        /// </summary>
        [Column("���n�於")]
        public string ���n�於 { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Column("�g�������R�[�h")]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �g����������
        /// </summary>
        [Column("�g����������")]
        public string �g���������� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �ދ敪��
        /// </summary>
        [Column("�ދ敪��")]
        public string �ދ敪�� { get; set; }

        /// <summary>
        /// �Y�n�ʖ����R�[�h
        /// </summary>
        [Column("�Y�n�ʖ����R�[�h")]
        [StringLength(5)]
        public string �Y�n�ʖ����R�[�h { get; set; }

        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Column("�c�_�ΏۊO�t���O")]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

        /// <summary>
        /// �Y�n�ʖ���������
        /// </summary>
        [Column("�Y�n�ʖ���������")]
        public string �Y�n�ʖ��������� { get; set; }

        /// <summary>
        /// ���ϒP��
        /// </summary>
        [Column("���ϒP��")]
        public Decimal? ���ϒP�� { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P")]
        public Decimal? �K�i�ʊ���_�K�i�P { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q")]
        public Decimal? �K�i�ʊ���_�K�i�Q { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R")]
        public Decimal? �K�i�ʊ���_�K�i�R { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�S
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�S")]
        public Decimal? �K�i�ʊ���_�K�i�S { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�T
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�T")]
        public Decimal? �K�i�ʊ���_�K�i�T { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�U
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�U")]
        public Decimal? �K�i�ʊ���_�K�i�U { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�V
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�V")]
        public Decimal? �K�i�ʊ���_�K�i�V { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�W
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�W")]
        public Decimal? �K�i�ʊ���_�K�i�W { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�X
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�X")]
        public Decimal? �K�i�ʊ���_�K�i�X { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�O
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�O")]
        public Decimal? �K�i�ʊ���_�K�i�P�O { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�P
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�P")]
        public Decimal? �K�i�ʊ���_�K�i�P�P { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�Q
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�Q")]
        public Decimal? �K�i�ʊ���_�K�i�P�Q { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�R
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�R")]
        public Decimal? �K�i�ʊ���_�K�i�P�R { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�S
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�S")]
        public Decimal? �K�i�ʊ���_�K�i�P�S { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�T
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�T")]
        public Decimal? �K�i�ʊ���_�K�i�P�T { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�U
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�U")]
        public Decimal? �K�i�ʊ���_�K�i�P�U { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�V
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�V")]
        public Decimal? �K�i�ʊ���_�K�i�P�V { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�W
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�W")]
        public Decimal? �K�i�ʊ���_�K�i�P�W { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�P�X
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�P�X")]
        public Decimal? �K�i�ʊ���_�K�i�P�X { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�O
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�O")]
        public Decimal? �K�i�ʊ���_�K�i�Q�O { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�P
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�P")]
        public Decimal? �K�i�ʊ���_�K�i�Q�P { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�Q
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�Q")]
        public Decimal? �K�i�ʊ���_�K�i�Q�Q { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�R
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�R")]
        public Decimal? �K�i�ʊ���_�K�i�Q�R { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�S
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�S")]
        public Decimal? �K�i�ʊ���_�K�i�Q�S { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�T
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�T")]
        public Decimal? �K�i�ʊ���_�K�i�Q�T { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�U
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�U")]
        public Decimal? �K�i�ʊ���_�K�i�Q�U { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�V
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�V")]
        public Decimal? �K�i�ʊ���_�K�i�Q�V { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�W
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�W")]
        public Decimal? �K�i�ʊ���_�K�i�Q�W { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�Q�X
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�Q�X")]
        public Decimal? �K�i�ʊ���_�K�i�Q�X { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�O
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�O")]
        public Decimal? �K�i�ʊ���_�K�i�R�O { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�P
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�P")]
        public Decimal? �K�i�ʊ���_�K�i�R�P { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�Q
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�Q")]
        public Decimal? �K�i�ʊ���_�K�i�R�Q { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�R
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�R")]
        public Decimal? �K�i�ʊ���_�K�i�R�R { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�S
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�S")]
        public Decimal? �K�i�ʊ���_�K�i�R�S { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�T
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�T")]
        public Decimal? �K�i�ʊ���_�K�i�R�T { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�U
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�U")]
        public Decimal? �K�i�ʊ���_�K�i�R�U { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�V
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�V")]
        public Decimal? �K�i�ʊ���_�K�i�R�V { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�W
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�W")]
        public Decimal? �K�i�ʊ���_�K�i�R�W { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�R�X
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�R�X")]
        public Decimal? �K�i�ʊ���_�K�i�R�X { get; set; }

        /// <summary>
        /// �K�i�ʊ���_�K�i�S�O
        /// </summary>
        [Column("�K�i�ʊ���_�K�i�S�O")]
        public Decimal? �K�i�ʊ���_�K�i�S�O { get; set; }

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
