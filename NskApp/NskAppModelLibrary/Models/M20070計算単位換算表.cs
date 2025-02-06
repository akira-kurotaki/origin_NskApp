using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20070_�v�Z�P�ʊ��Z�\
    /// </summary>
    [Serializable]
    [Table("m_20070_�v�Z�P�ʊ��Z�\")]
    [Keyless]
    public class M20070�v�Z�P�ʊ��Z�\ : ModelBase
    {
        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Column("�⏞�����R�[�h")]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// �v�Z�P�ʈ������
        /// </summary>
        [Column("�v�Z�P�ʈ������")]
        [StringLength(1)]
        public string �v�Z�P�ʈ������ { get; set; }

        /// <summary>
        /// �v�Z�P�ʕ⏞����
        /// </summary>
        [Column("�v�Z�P�ʕ⏞����")]
        [StringLength(2)]
        public string �v�Z�P�ʕ⏞���� { get; set; }

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
