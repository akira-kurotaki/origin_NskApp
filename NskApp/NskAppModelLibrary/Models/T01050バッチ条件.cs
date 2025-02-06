using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_01050_�o�b�`����
    /// </summary>
    [Serializable]
    [Table("t_01050_�o�b�`����")]
    [PrimaryKey(nameof(�o�b�`����id), nameof(�A��))]
    public class T01050�o�b�`���� : ModelBase
    {
        /// <summary>
        /// �o�b�`����id
        /// </summary>
        [Required]
        [Column("�o�b�`����id", Order = 1)]
        [StringLength(36)]
        public string �o�b�`����id { get; set; }

        /// <summary>
        /// �A��
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�A��", Order = 2)]
        public int �A�� { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column("��������")]
        public string �������� { get; set; }

        /// <summary>
        /// �\���p�����l
        /// </summary>
        [Column("�\���p�����l")]
        public string �\���p�����l { get; set; }

        /// <summary>
        /// �����l
        /// </summary>
        [Column("�����l")]
        public string �����l { get; set; }

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
