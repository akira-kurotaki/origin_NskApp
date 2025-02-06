using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20100_�ЊQ���
    /// </summary>
    [Serializable]
    [Table("m_20100_�ЊQ���")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ώ��̃R�[�h), nameof(�ЊQ��ރR�[�h))]
    public class M20100�ЊQ��� : ModelBase
    {
        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("�g�����R�[�h", Order = 1)]
        [StringLength(3)]
        public string �g�����R�[�h { get; set; }

        /// <summary>
        /// �N�Y
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�N�Y", Order = 2)]
        public short �N�Y { get; set; }

        /// <summary>
        /// ���ώ��̃R�[�h
        /// </summary>
        [Required]
        [Column("���ώ��̃R�[�h", Order = 3)]
        [StringLength(2)]
        public string ���ώ��̃R�[�h { get; set; }

        /// <summary>
        /// �ЊQ��ރR�[�h
        /// </summary>
        [Required]
        [Column("�ЊQ��ރR�[�h", Order = 4)]
        [StringLength(2)]
        public string �ЊQ��ރR�[�h { get; set; }

        /// <summary>
        /// �ЊQ��ޖ�
        /// </summary>
        [Column("�ЊQ��ޖ�")]
        public string �ЊQ��ޖ� { get; set; }

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
