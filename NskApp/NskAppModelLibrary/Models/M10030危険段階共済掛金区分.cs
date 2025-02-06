using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10030_�댯�i�K���ϊ|���敪
    /// </summary>
    [Serializable]
    [Table("m_10030_�댯�i�K���ϊ|���敪")]
    [PrimaryKey(nameof(���ώ��Ɗ댯�i�K), nameof(���ϖړI�댯�i�K), nameof(�댯�i�K���ϊ|���敪))]
    public class M10030�댯�i�K���ϊ|���敪 : ModelBase
    {
        /// <summary>
        /// ���ώ��Ɗ댯�i�K
        /// </summary>
        [Required]
        [Column("���ώ��Ɗ댯�i�K", Order = 1)]
        [StringLength(2)]
        public string ���ώ��Ɗ댯�i�K { get; set; }

        /// <summary>
        /// ���ϖړI�댯�i�K
        /// </summary>
        [Required]
        [Column("���ϖړI�댯�i�K", Order = 2)]
        [StringLength(2)]
        public string ���ϖړI�댯�i�K { get; set; }

        /// <summary>
        /// �댯�i�K���ϊ|���敪
        /// </summary>
        [Required]
        [Column("�댯�i�K���ϊ|���敪", Order = 3)]
        public string �댯�i�K���ϊ|���敪 { get; set; }

        /// <summary>
        /// �댯�i�K���ϊ|���敪����
        /// </summary>
        [Column("�댯�i�K���ϊ|���敪����")]
        public string �댯�i�K���ϊ|���敪���� { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Column("���ϖړI�R�[�h")]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

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
