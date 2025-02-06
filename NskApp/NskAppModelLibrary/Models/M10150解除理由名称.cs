using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10150_�������R����
    /// </summary>
    [Serializable]
    [Table("m_10150_�������R����")]
    public class M10150�������R���� : ModelBase
    {
        /// <summary>
        /// �������R�R�[�h
        /// </summary>
        [Required]
        [Key]
        [Column("�������R�R�[�h", Order = 1)]
        [StringLength(2)]
        public string �������R�R�[�h { get; set; }

        /// <summary>
        /// �������R����
        /// </summary>
        [Column("�������R����")]
        public string �������R���� { get; set; }

        /// <summary>
        /// �����t���O
        /// </summary>
        [Column("�����t���O")]
        [StringLength(1)]
        public string �����t���O { get; set; }

        /// <summary>
        /// �I�𖢔[�t���O
        /// </summary>
        [Column("�I�𖢔[�t���O")]
        [StringLength(1)]
        public string �I�𖢔[�t���O { get; set; }

        /// <summary>
        /// �I�����[�t���O
        /// </summary>
        [Column("�I�����[�t���O")]
        [StringLength(1)]
        public string �I�����[�t���O { get; set; }

        /// <summary>
        /// �ԊҊ|���t���O
        /// </summary>
        [Column("�ԊҊ|���t���O")]
        [StringLength(1)]
        public string �ԊҊ|���t���O { get; set; }

        /// <summary>
        /// �Ԋҕ��ۋ��t���O
        /// </summary>
        [Column("�Ԋҕ��ۋ��t���O")]
        [StringLength(1)]
        public string �Ԋҕ��ۋ��t���O { get; set; }

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
