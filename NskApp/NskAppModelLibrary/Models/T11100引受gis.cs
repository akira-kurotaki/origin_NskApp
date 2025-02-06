using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_11100_����gis
    /// </summary>
    [Serializable]
    [Table("t_11100_����gis")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�))]
    public class T11100����gis : ModelBase
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
        /// �k�n�ԍ�
        /// </summary>
        [Required]
        [Column("�k�n�ԍ�", Order = 5)]
        [StringLength(5)]
        public string �k�n�ԍ� { get; set; }

        /// <summary>
        /// ���M�ԍ�
        /// </summary>
        [Required]
        [Column("���M�ԍ�", Order = 6)]
        [StringLength(4)]
        public string ���M�ԍ� { get; set; }

        /// <summary>
        /// RS�敪
        /// </summary>
        [Column("RS�敪")]
        [StringLength(2)]
        public string RS�敪 { get; set; }

        /// <summary>
        /// �Ǔs���{���R�[�h
        /// </summary>
        [Column("�Ǔs���{���R�[�h")]
        public string �Ǔs���{���R�[�h { get; set; }

        /// <summary>
        /// �s�撬���R�[�h
        /// </summary>
        [Column("�s�撬���R�[�h")]
        public string �s�撬���R�[�h { get; set; }

        /// <summary>
        /// �厚�R�[�h
        /// </summary>
        [Column("�厚�R�[�h")]
        public string �厚�R�[�h { get; set; }

        /// <summary>
        /// �����R�[�h
        /// </summary>
        [Column("�����R�[�h")]
        public string �����R�[�h { get; set; }

        /// <summary>
        /// �n��
        /// </summary>
        [Column("�n��")]
        public string �n�� { get; set; }

        /// <summary>
        /// �}��
        /// </summary>
        [Column("�}��")]
        public string �}�� { get; set; }

        /// <summary>
        /// �q��
        /// </summary>
        [Column("�q��")]
        public string �q�� { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column("����")]
        public string ���� { get; set; }

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
