using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_23020_��������]��
    /// </summary>
    [Serializable]
    [Table("t_23020_��������]��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�����ǋ敪), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�))]
    public class T23020��������]�� : ModelBase
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
        /// �����ǋ敪
        /// </summary>
        [Required]
        [Column("�����ǋ敪", Order = 4)]
        [StringLength(1)]
        public string �����ǋ敪 { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 5)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �k�n�ԍ�
        /// </summary>
        [Required]
        [Column("�k�n�ԍ�", Order = 6)]
        [StringLength(5)]
        public string �k�n�ԍ� { get; set; }

        /// <summary>
        /// ���M�ԍ�
        /// </summary>
        [Required]
        [Column("���M�ԍ�", Order = 7)]
        [StringLength(4)]
        public string ���M�ԍ� { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �P�����Z�W���v�Z���@
        /// </summary>
        [Column("�P�����Z�W���v�Z���@")]
        [StringLength(1)]
        public string �P�����Z�W���v�Z���@ { get; set; }

        /// <summary>
        /// ������@
        /// </summary>
        [Column("������@")]
        [StringLength(1)]
        public string ������@ { get; set; }

        /// <summary>
        /// �I������
        /// </summary>
        [Column("�I������")]
        public Decimal? �I������ { get; set; }

        /// <summary>
        /// �����芔��
        /// </summary>
        [Column("�����芔��")]
        public Decimal? �����芔�� { get; set; }

        /// <summary>
        /// ������ӏ�����
        /// </summary>
        [Column("������ӏ�����")]
        public Decimal? ������ӏ����� { get; set; }

        /// <summary>
        /// ������ӏ����~
        /// </summary>
        [Column("������ӏ����~")]
        public Decimal? ������ӏ����~ { get; set; }

        /// <summary>
        /// ���a
        /// </summary>
        [Column("���a")]
        public Decimal? ���a { get; set; }

        /// <summary>
        /// �l�ЂP�ӏ���
        /// </summary>
        [Column("�l�ЂP�ӏ���")]
        public Decimal? �l�ЂP�ӏ��� { get; set; }

        /// <summary>
        /// �l�ЂQ�ӏ���
        /// </summary>
        [Column("�l�ЂQ�ӏ���")]
        public Decimal? �l�ЂQ�ӏ��� { get; set; }

        /// <summary>
        /// �l�ЂR�ӏ���
        /// </summary>
        [Column("�l�ЂR�ӏ���")]
        public Decimal? �l�ЂR�ӏ��� { get; set; }

        /// <summary>
        /// ���ԂP�ӏ���
        /// </summary>
        [Column("���ԂP�ӏ���")]
        public Decimal? ���ԂP�ӏ��� { get; set; }

        /// <summary>
        /// ���ԂQ�ӏ���
        /// </summary>
        [Column("���ԂQ�ӏ���")]
        public Decimal? ���ԂQ�ӏ��� { get; set; }

        /// <summary>
        /// ���ԂR�ӏ���
        /// </summary>
        [Column("���ԂR�ӏ���")]
        public Decimal? ���ԂR�ӏ��� { get; set; }

        /// <summary>
        /// �l�Е���
        /// </summary>
        [Column("�l�Е���")]
        public Decimal? �l�Е��� { get; set; }

        /// <summary>
        /// ���ԕ���
        /// </summary>
        [Column("���ԕ���")]
        public Decimal? ���ԕ��� { get; set; }

        /// <summary>
        /// �P�����Z�W��
        /// </summary>
        [Column("�P�����Z�W��")]
        public Decimal? �P�����Z�W�� { get; set; }

        /// <summary>
        /// �����������ݏd
        /// </summary>
        [Column("�����������ݏd")]
        public Decimal? �����������ݏd { get; set; }

        /// <summary>
        /// �������������ݏd
        /// </summary>
        [Column("�������������ݏd")]
        public Decimal? �������������ݏd { get; set; }

        /// <summary>
        /// ����P������
        /// </summary>
        [Column("����P������")]
        public Decimal? ����P������ { get; set; }

        /// <summary>
        /// �����C����
        /// </summary>
        [Column("�����C����")]
        public Decimal? �����C���� { get; set; }

        /// <summary>
        /// �C���������R
        /// </summary>
        [Column("�C���������R")]
        public string �C���������R { get; set; }

        /// <summary>
        /// �����ܗL��
        /// </summary>
        [Column("�����ܗL��")]
        public Decimal? �����ܗL�� { get; set; }

        /// <summary>
        /// �e���ďd
        /// </summary>
        [Column("�e���ďd")]
        public Decimal? �e���ďd { get; set; }

        /// <summary>
        /// �ӂ邢�ɂ������e���ďd
        /// </summary>
        [Column("�ӂ邢�ɂ������e���ďd")]
        public Decimal? �ӂ邢�ɂ������e���ďd { get; set; }

        /// <summary>
        /// ���ďd
        /// </summary>
        [Column("���ďd")]
        public Decimal? ���ďd { get; set; }

        /// <summary>
        /// �����ďd
        /// </summary>
        [Column("�����ďd")]
        public Decimal? �����ďd { get; set; }

        /// <summary>
        /// �����I�ʋ@�C����
        /// </summary>
        [Column("�����I�ʋ@�C����")]
        public Decimal? �����I�ʋ@�C���� { get; set; }

        /// <summary>
        /// �����P��
        /// </summary>
        [Column("�����P��")]
        public Decimal? �����P�� { get; set; }

        /// <summary>
        /// �����敪
        /// </summary>
        [Column("�����敪")]
        [StringLength(1)]
        public string �����敪 { get; set; }

        /// <summary>
        /// �K�w�敪
        /// </summary>
        [Column("�K�w�敪")]
        [StringLength(3)]
        public string �K�w�敪 { get; set; }

        /// <summary>
        /// �]���n��R�[�h
        /// </summary>
        [Column("�]���n��R�[�h")]
        [StringLength(4)]
        public string �]���n��R�[�h { get; set; }

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
