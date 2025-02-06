using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00240_���j���[
    /// </summary>
    [Serializable]
    [Table("m_00240_���j���[")]
    public class M00240���j���[ : ModelBase
    {
        /// <summary>
        /// ���j���[id
        /// </summary>
        [Required]
        [Key]
        [Column("���j���[id", Order = 1)]
        public string ���j���[id { get; set; }

        /// <summary>
        /// ���j���[����
        /// </summary>
        [Column("���j���[����")]
        public string ���j���[���� { get; set; }

        /// <summary>
        /// �e���j���[id
        /// </summary>
        [Column("�e���j���[id")]
        public string �e���j���[id { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Column("���ϖړI�R�[�h")]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// ���id
        /// </summary>
        [Column("���id")]
        public string ���id { get; set; }

        /// <summary>
        /// ����id
        /// </summary>
        [Column("����id")]
        public string ����id { get; set; }

        /// <summary>
        /// ���я�
        /// </summary>
        [Column("���я�")]
        [StringLength(3)]
        public string ���я� { get; set; }

        /// <summary>
        /// ��1�K�w���j���[�O���[�v
        /// </summary>
        [Column("��1�K�w���j���[�O���[�v")]
        public string ��1�K�w���j���[�O���[�v { get; set; }

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
