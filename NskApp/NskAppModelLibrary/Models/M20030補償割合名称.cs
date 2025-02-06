using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20030_�⏞��������
    /// </summary>
    [Serializable]
    [Table("m_20030_�⏞��������")]
    public class M20030�⏞�������� : ModelBase
    {
        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Key]
        [Column("�⏞�����R�[�h", Order = 1)]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// �⏞��������
        /// </summary>
        [Column("�⏞��������")]
        public string �⏞�������� { get; set; }

        /// <summary>
        /// �⏞�����Z�k����
        /// </summary>
        [Column("�⏞�����Z�k����")]
        public string �⏞�����Z�k���� { get; set; }

        /// <summary>
        /// �⏞����
        /// </summary>
        [Column("�⏞����")]
        public Decimal? �⏞���� { get; set; }

        /// <summary>
        /// �x���J�n���Q����
        /// </summary>
        [Column("�x���J�n���Q����")]
        public Decimal? �x���J�n���Q���� { get; set; }

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
