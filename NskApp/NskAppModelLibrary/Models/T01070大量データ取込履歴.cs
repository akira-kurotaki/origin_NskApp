using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_01070_��ʃf�[�^�捞����
    /// </summary>
    [Serializable]
    [Table("t_01070_��ʃf�[�^�捞����")]
    public class T01070��ʃf�[�^�捞���� : ModelBase
    {
        /// <summary>
        /// �捞����id
        /// </summary>
        [Required]
        [Key]
        [Column("�捞����id", Order = 1)]
        [StringLength(19)]
        public string �捞����id { get; set; }

        /// <summary>
        /// �������id
        /// </summary>
        [Required]
        [Column("�������id")]
        [StringLength(19)]
        public string �������id { get; set; }

        /// <summary>
        /// �f�[�^�o�^����
        /// </summary>
        [Required]
        [Column("�f�[�^�o�^����")]
        public DateTime �f�[�^�o�^���� { get; set; }

        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("�g�����R�[�h")]
        [StringLength(3)]
        public string �g�����R�[�h { get; set; }

        /// <summary>
        /// �X�e�[�^�X
        /// </summary>
        [Required]
        [Column("�X�e�[�^�X")]
        [StringLength(2)]
        public string �X�e�[�^�X { get; set; }

        /// <summary>
        /// �Ώۃf�[�^�敪
        /// </summary>
        [Column("�Ώۃf�[�^�敪")]
        [StringLength(2)]
        public string �Ώۃf�[�^�敪 { get; set; }

        /// <summary>
        /// �Ώی���
        /// </summary>
        [Column("�Ώی���")]
        public int? �Ώی��� { get; set; }

        /// <summary>
        /// �G���[����
        /// </summary>
        [Column("�G���[����")]
        public int? �G���[���� { get; set; }

        /// <summary>
        /// �G���[���X�g��
        /// </summary>
        [Column("�G���[���X�g��")]
        public string �G���[���X�g�� { get; set; }

        /// <summary>
        /// �G���[���X�g�p�X
        /// </summary>
        [Column("�G���[���X�g�p�X")]
        public string �G���[���X�g�p�X { get; set; }

        /// <summary>
        /// �G���[���X�g�n�b�V���l
        /// </summary>
        [Column("�G���[���X�g�n�b�V���l")]
        public string �G���[���X�g�n�b�V���l { get; set; }

        /// <summary>
        /// �R�����g
        /// </summary>
        [Column("�R�����g")]
        public string �R�����g { get; set; }

        /// <summary>
        /// �J�n����
        /// </summary>
        [Column("�J�n����")]
        public DateTime? �J�n���� { get; set; }

        /// <summary>
        /// �I������
        /// </summary>
        [Column("�I������")]
        public DateTime? �I������ { get; set; }

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
