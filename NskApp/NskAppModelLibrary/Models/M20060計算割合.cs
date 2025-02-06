using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20060_�v�Z����
    /// </summary>
    [Serializable]
    [Table("m_20060_�v�Z����")]
    [PrimaryKey(nameof(�������), nameof(�⏞�����R�[�h))]
    public class M20060�v�Z���� : ModelBase
    {
        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 1)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Required]
        [Column("�⏞�����R�[�h", Order = 2)]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// �s�\�k�n���n����
        /// </summary>
        [Column("�s�\�k�n���n����")]
        public Decimal? �s�\�k�n���n���� { get; set; }

        /// <summary>
        /// �x���J�n���Q����
        /// </summary>
        [Column("�x���J�n���Q����")]
        public Decimal? �x���J�n���Q���� { get; set; }

        /// <summary>
        /// �x���J�n���Q��������
        /// </summary>
        [Column("�x���J�n���Q��������")]
        public string �x���J�n���Q�������� { get; set; }

        /// <summary>
        /// �x���J�n���Q�������̓���
        /// </summary>
        [Column("�x���J�n���Q�������̓���")]
        public string �x���J�n���Q�������̓��� { get; set; }

        /// <summary>
        /// �S���k�n�x���J�n����
        /// </summary>
        [Column("�S���k�n�x���J�n����")]
        public Decimal? �S���k�n�x���J�n���� { get; set; }

        /// <summary>
        /// �S���s�\��������
        /// </summary>
        [Column("�S���s�\��������")]
        public Decimal? �S���s�\�������� { get; set; }

        /// <summary>
        /// �����k�n�x���J�n����
        /// </summary>
        [Column("�����k�n�x���J�n����")]
        public Decimal? �����k�n�x���J�n���� { get; set; }

        /// <summary>
        /// ����x���J�n����
        /// </summary>
        [Column("����x���J�n����")]
        public Decimal? ����x���J�n���� { get; set; }

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
