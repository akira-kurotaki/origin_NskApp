using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20230_��M�S�������薼��
    /// </summary>
    [Serializable]
    [Table("m_20230_��M�S�������薼��")]
    public class M20230��M�S�������薼�� : ModelBase
    {
        /// <summary>
        /// ��M�S������
        /// </summary>
        [Required]
        [Key]
        [Column("��M�S������", Order = 1)]
        [StringLength(1)]
        public string ��M�S������ { get; set; }

        /// <summary>
        /// ��M�S�������薼��
        /// </summary>
        [Column("��M�S�������薼��")]
        public string ��M�S�������薼�� { get; set; }

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
