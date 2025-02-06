using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_00140_����
    /// </summary>
    [Serializable]
    [Table("m_00140_����")]
    [PrimaryKey(nameof(���̃O���[�v�R�[�h), nameof(���̃R�[�h))]
    public class M00140���� : ModelBase
    {
        /// <summary>
        /// ���̃O���[�v�R�[�h
        /// </summary>
        [Required]
        [Column("���̃O���[�v�R�[�h", Order = 1)]
        public string ���̃O���[�v�R�[�h { get; set; }

        /// <summary>
        /// ���̃R�[�h
        /// </summary>
        [Required]
        [Column("���̃R�[�h", Order = 2)]
        public string ���̃R�[�h { get; set; }

        /// <summary>
        /// ���̃O���[�v����
        /// </summary>
        [Column("���̃O���[�v����")]
        [StringLength(10)]
        public string ���̃O���[�v���� { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column("��������")]
        public string �������� { get; set; }

        /// <summary>
        /// ���̖���
        /// </summary>
        [Column("���̖���")]
        public string ���̖��� { get; set; }

        /// <summary>
        /// �L��
        /// </summary>
        [Column("�L��")]
        public string �L�� { get; set; }

        /// <summary>
        /// ���p�\�t���O
        /// </summary>
        [Column("���p�\�t���O")]
        [StringLength(1)]
        public string ���p�\�t���O { get; set; }

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
