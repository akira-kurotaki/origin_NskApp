using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00190_��ʃf�[�^�Ώۃf�[�^
    /// </summary>
    [Serializable]
    [Table("m_00190_��ʃf�[�^�Ώۃf�[�^")]
    public class M00190��ʃf�[�^�Ώۃf�[�^ : ModelBase
    {
        /// <summary>
        /// �Ώۃf�[�^�敪
        /// </summary>
        [Required]
        [Key]
        [Column("�Ώۃf�[�^�敪", Order = 1)]
        [StringLength(2)]
        public string �Ώۃf�[�^�敪 { get; set; }

        /// <summary>
        /// �Ɩ��敪
        /// </summary>
        [Column("�Ɩ��敪")]
        [StringLength(1)]
        public string �Ɩ��敪 { get; set; }

        /// <summary>
        /// ����Ώۃf�[�^����
        /// </summary>
        [Column("����Ώۃf�[�^����")]
        public string ����Ώۃf�[�^���� { get; set; }

        /// <summary>
        /// ����Ώۃf�[�^����
        /// </summary>
        [Column("����Ώۃf�[�^����")]
        public string ����Ώۃf�[�^���� { get; set; }

        /// <summary>
        /// ����o�b�`id
        /// </summary>
        [Column("����o�b�`id")]
        public string ����o�b�`id { get; set; }

        /// <summary>
        /// �捞�o�b�`id
        /// </summary>
        [Column("�捞�o�b�`id")]
        public string �捞�o�b�`id { get; set; }

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
