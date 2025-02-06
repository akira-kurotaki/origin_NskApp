using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_01080_��ʃf�[�^���_�G���[���X�g
    /// </summary>
    [Serializable]
    [Table("t_01080_��ʃf�[�^���_�G���[���X�g")]
    [PrimaryKey(nameof(�����敪), nameof(����id), nameof(seq))]
    public class T01080��ʃf�[�^����G���[���X�g : ModelBase
    {
        /// <summary>
        /// �����敪
        /// </summary>
        [Required]
        [Column("�����敪", Order = 1)]
        [StringLength(1)]
        public string �����敪 { get; set; }

        /// <summary>
        /// ����id
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("����id", Order = 2)]
        public long ����id { get; set; }

        /// <summary>
        /// seq
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("seq", Order = 3)]
        public long seq { get; set; }

        /// <summary>
        /// �s�ԍ�
        /// </summary>
        [Column("�s�ԍ�")]
        [StringLength(7)]
        public string �s�ԍ� { get; set; }

        /// <summary>
        /// �G���[���e
        /// </summary>
        [Column("�G���[���e")]
        public string �G���[���e { get; set; }

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
