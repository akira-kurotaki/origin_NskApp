using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_10010_�g�����ݒ�
    /// </summary>
    [Serializable]
    [Table("m_10010_�g�����ݒ�")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h))]
    public class M10010�g�����ݒ� : ModelBase
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
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 3)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// ��������t���O
        /// </summary>
        [Column("��������t���O")]
        [StringLength(1)]
        public string ��������t���O { get; set; }

        /// <summary>
        /// ���Q�J�n��������t���O
        /// </summary>
        [Column("���Q�J�n��������t���O")]
        [StringLength(1)]
        public string ���Q�J�n��������t���O { get; set; }

        /// <summary>
        /// ����v�Z�x�����s�P�ʋ敪
        /// </summary>
        [Column("����v�Z�x�����s�P�ʋ敪")]
        [StringLength(1)]
        public string ����v�Z�x�����s�P�ʋ敪 { get; set; }

        /// <summary>
        /// ���ۋ��̗p���ʋ敪
        /// </summary>
        [Column("���ۋ��̗p���ʋ敪")]
        [StringLength(1)]
        public string ���ۋ��̗p���ʋ敪 { get; set; }

        /// <summary>
        /// �F��敪�x�������ޕ����t���O
        /// </summary>
        [Column("�F��敪�x�������ޕ����t���O")]
        [StringLength(1)]
        public string �F��敪�x�������ޕ����t���O { get; set; }

        /// <summary>
        /// �����I�ʋ@�g�p�L���t���O
        /// </summary>
        [Column("�����I�ʋ@�g�p�L���t���O")]
        [StringLength(1)]
        public string �����I�ʋ@�g�p�L���t���O { get; set; }

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
