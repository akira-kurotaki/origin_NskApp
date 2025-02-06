using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00020_�ޖ���
    /// </summary>
    [Serializable]
    [Table("m_00020_�ޖ���")]
    [PrimaryKey(nameof(���ϖړI�R�[�h), nameof(�ދ敪))]
    public class M00020�ޖ��� : ModelBase
    {
        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 1)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 2)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �ޖ���
        /// </summary>
        [Column("�ޖ���")]
        public string �ޖ��� { get; set; }

        /// <summary>
        /// �ޒZ�k����
        /// </summary>
        [Column("�ޒZ�k����")]
        public string �ޒZ�k���� { get; set; }

        /// <summary>
        /// �����敪
        /// </summary>
        [Column("�����敪")]
        [StringLength(1)]
        public string �����敪 { get; set; }

        /// <summary>
        /// �c���敪
        /// </summary>
        [Column("�c���敪")]
        [StringLength(1)]
        public string �c���敪 { get; set; }

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
        /// �����敪�C���f�b�N�X�ȊO�t���O
        /// </summary>
        [Column("�����敪�C���f�b�N�X�ȊO�t���O")]
        [StringLength(1)]
        public string �����敪�C���f�b�N�X�ȊO�t���O { get; set; }

        /// <summary>
        /// �����敪�C���f�b�N�X�t���O
        /// </summary>
        [Column("�����敪�C���f�b�N�X�t���O")]
        [StringLength(1)]
        public string �����敪�C���f�b�N�X�t���O { get; set; }

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
