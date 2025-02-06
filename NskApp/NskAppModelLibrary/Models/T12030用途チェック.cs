using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12030_�p�r�`�F�b�N
    /// </summary>
    [Serializable]
    [Table("t_12030_�p�r�`�F�b�N")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�ދ敪), nameof(���v�P�ʒn��R�[�h), nameof(�p�r�敪))]
    public class T12030�p�r�`�F�b�N : ModelBase
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
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 4)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 5)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���v�P�ʒn��R�[�h
        /// </summary>
        [Required]
        [Column("���v�P�ʒn��R�[�h", Order = 6)]
        [StringLength(5)]
        public string ���v�P�ʒn��R�[�h { get; set; }

        /// <summary>
        /// �p�r�敪
        /// </summary>
        [Required]
        [Column("�p�r�敪", Order = 7)]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// ����ERR�t���O
        /// </summary>
        [Column("����ERR�t���O")]
        [StringLength(1)]
        public string ����ERR�t���O { get; set; }

        /// <summary>
        /// ����WAR�t���O
        /// </summary>
        [Column("����WAR�t���O")]
        [StringLength(1)]
        public string ����WAR�t���O { get; set; }

        /// <summary>
        /// ����ERRNO
        /// </summary>
        [Column("����ERRNO")]
        public string ����ERRNO { get; set; }

        /// <summary>
        /// ����SUBJECT
        /// </summary>
        [Column("����SUBJECT")]
        public string ����SUBJECT { get; set; }

        /// <summary>
        /// ����ERR���b�Z�[�W
        /// </summary>
        [Column("����ERR���b�Z�[�W")]
        public string ����ERR���b�Z�[�W { get; set; }

        /// <summary>
        /// �]��ERR�t���O
        /// </summary>
        [Column("�]��ERR�t���O")]
        [StringLength(1)]
        public string �]��ERR�t���O { get; set; }

        /// <summary>
        /// �]��WAR�t���O
        /// </summary>
        [Column("�]��WAR�t���O")]
        [StringLength(1)]
        public string �]��WAR�t���O { get; set; }

        /// <summary>
        /// �]��ERRNO
        /// </summary>
        [Column("�]��ERRNO")]
        public string �]��ERRNO { get; set; }

        /// <summary>
        /// �]��SUBJECT
        /// </summary>
        [Column("�]��SUBJECT")]
        public string �]��SUBJECT { get; set; }

        /// <summary>
        /// �]��ERR���b�Z�[�W
        /// </summary>
        [Column("�]��ERR���b�Z�[�W")]
        public string �]��ERR���b�Z�[�W { get; set; }

        /// <summary>
        /// ���������ʃR�[�h
        /// </summary>
        [Column("���������ʃR�[�h")]
        [StringLength(3)]
        public string ���������ʃR�[�h { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Column("�������")]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// ����敪
        /// </summary>
        [Column("����敪")]
        [StringLength(1)]
        public string ����敪 { get; set; }

        /// <summary>
        /// �⏞�����R�[�h
        /// </summary>
        [Column("�⏞�����R�[�h")]
        [StringLength(2)]
        public string �⏞�����R�[�h { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Column("��n��R�[�h")]
        [StringLength(2)]
        public string ��n��R�[�h { get; set; }

        /// <summary>
        /// ���n��R�[�h
        /// </summary>
        [Column("���n��R�[�h")]
        [StringLength(4)]
        public string ���n��R�[�h { get; set; }

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
