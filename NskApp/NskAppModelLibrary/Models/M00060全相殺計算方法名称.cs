using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00060_�S���E�v�Z���@����
    /// </summary>
    [Serializable]
    [Table("m_00060_�S���E�v�Z���@����")]
    public class M00060�S���E�v�Z���@���� : ModelBase
    {
        /// <summary>
        /// �S���E�v�Z���@
        /// </summary>
        [Required]
        [Key]
        [Column("�S���E�v�Z���@", Order = 1)]
        [StringLength(1)]
        public string �S���E�v�Z���@ { get; set; }

        /// <summary>
        /// �S���E�v�Z���@����
        /// </summary>
        [Column("�S���E�v�Z���@����")]
        public string �S���E�v�Z���@���� { get; set; }

        /// <summary>
        /// �ޏ�t���O
        /// </summary>
        [Column("�ޏ�t���O")]
        [StringLength(1)]
        public string �ޏ�t���O { get; set; }

        /// <summary>
        /// �{�݃t���O
        /// </summary>
        [Column("�{�݃t���O")]
        [StringLength(1)]
        public string �{�݃t���O { get; set; }

        /// <summary>
        /// ���n�t���O
        /// </summary>
        [Column("���n�t���O")]
        [StringLength(1)]
        public string ���n�t���O { get; set; }

        /// <summary>
        /// ���n���ʎ�
        /// </summary>
        [Column("���n���ʎ�")]
        [StringLength(1)]
        public string ���n���ʎ� { get; set; }

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
