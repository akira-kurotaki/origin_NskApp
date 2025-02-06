using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00150_���[�Ǘ�
    /// </summary>
    [Serializable]
    [Table("m_00150_���[�Ǘ�")]
    public class M00150���[�Ǘ� : ModelBase
    {
        /// <summary>
        /// ���[�Ǘ�id
        /// </summary>
        [Required]
        [Key]
        [Column("���[�Ǘ�id", Order = 1)]
        public string ���[�Ǘ�id { get; set; }

        /// <summary>
        /// ���[�t�@�C���敪
        /// </summary>
        [Column("���[�t�@�C���敪")]
        [StringLength(1)]
        public string ���[�t�@�C���敪 { get; set; }

        /// <summary>
        /// �Ɩ��敪
        /// </summary>
        [Column("�Ɩ��敪")]
        [StringLength(1)]
        public string �Ɩ��敪 { get; set; }

        /// <summary>
        /// �Ɩ�����
        /// </summary>
        [Column("�Ɩ�����")]
        [StringLength(2)]
        public string �Ɩ����� { get; set; }

        /// <summary>
        /// ���[�t�@�C������
        /// </summary>
        [Column("���[�t�@�C������")]
        public string ���[�t�@�C������ { get; set; }

        /// <summary>
        /// �o�̓o�b�`id
        /// </summary>
        [Column("�o�̓o�b�`id")]
        public string �o�̓o�b�`id { get; set; }

        /// <summary>
        /// �o�͎w�����id
        /// </summary>
        [Column("�o�͎w�����id")]
        public string �o�͎w�����id { get; set; }

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
