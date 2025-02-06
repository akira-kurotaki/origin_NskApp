using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10140_��ޖ���
    /// </summary>
    [Serializable]
    [Table("m_10140_��ޖ���")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(��ރR�[�h))]
    public class M10140��ޖ��� : ModelBase
    {
        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// ��ރR�[�h
        /// </summary>
        [Required]
        [Column("��ރR�[�h", Order = 2)]
        [StringLength(2)]
        public string ��ރR�[�h { get; set; }

        /// <summary>
        /// ��ޖ���
        /// </summary>
        [Column("��ޖ���")]
        public string ��ޖ��� { get; set; }

        /// <summary>
        /// ��ދ敪
        /// </summary>
        [Column("��ދ敪")]
        [StringLength(1)]
        public string ��ދ敪 { get; set; }

        /// <summary>
        /// ��t����
        /// </summary>
        [Column("��t����")]
        [StringLength(1)]
        public string ��t���� { get; set; }

        /// <summary>
        /// ����\���p�t���O
        /// </summary>
        [Column("����\���p�t���O")]
        [StringLength(1)]
        public string ����\���p�t���O { get; set; }

        /// <summary>
        /// ����\���p�t���O
        /// </summary>
        [Column("����\���p�t���O")]
        [StringLength(1)]
        public string ����\���p�t���O { get; set; }

        /// <summary>
        /// ���\���p�t���O
        /// </summary>
        [Column("���\���p�t���O")]
        [StringLength(1)]
        public string ���\���p�t���O { get; set; }

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
