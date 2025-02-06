using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00070_���n�ʊm�F���@����
    /// </summary>
    [Serializable]
    [Table("m_00070_���n�ʊm�F���@����")]
    public class M00070���n�ʊm�F���@���� : ModelBase
    {
        /// <summary>
        /// ���n�ʊm�F���@
        /// </summary>
        [Required]
        [Key]
        [Column("���n�ʊm�F���@", Order = 1)]
        [StringLength(2)]
        public string ���n�ʊm�F���@ { get; set; }

        /// <summary>
        /// ���n�ʊm�F���@����
        /// </summary>
        [Column("���n�ʊm�F���@����")]
        public string ���n�ʊm�F���@���� { get; set; }

        /// <summary>
        /// �\�敪
        /// </summary>
        [Column("�\�敪")]
        [StringLength(1)]
        public string �\�敪 { get; set; }

        /// <summary>
        /// �S���E����t���O
        /// </summary>
        [Column("�S���E����t���O")]
        [StringLength(1)]
        public string �S���E����t���O { get; set; }

        /// <summary>
        /// ���ۋ��������
        /// </summary>
        [Column("���ۋ��������")]
        [StringLength(2)]
        public string ���ۋ�������� { get; set; }

        /// <summary>
        /// �����\���敪
        /// </summary>
        [Column("�����\���敪")]
        [StringLength(1)]
        public string �����\���敪 { get; set; }

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
