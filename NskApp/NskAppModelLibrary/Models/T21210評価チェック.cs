using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_21210_�]���`�F�b�N
    /// </summary>
    [Serializable]
    [Table("t_21210_�]���`�F�b�N")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�))]
    public class T21210�]���`�F�b�N : ModelBase
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
        /// ERRCODE
        /// </summary>
        [Column("ERRCODE")]
        [StringLength(2)]
        public string ERRCODE { get; set; }

        /// <summary>
        /// �ދ敪CK
        /// </summary>
        [Column("�ދ敪CK")]
        [StringLength(1)]
        public string �ދ敪CK { get; set; }

        /// <summary>
        /// �]���ʐ�CK
        /// </summary>
        [Column("�]���ʐ�CK")]
        [StringLength(1)]
        public string �]���ʐ�CK { get; set; }

        /// <summary>
        /// �]���n��CK
        /// </summary>
        [Column("�]���n��CK")]
        [StringLength(1)]
        public string �]���n��CK { get; set; }

        /// <summary>
        /// �K�w�敪CK
        /// </summary>
        [Column("�K�w�敪CK")]
        [StringLength(1)]
        public string �K�w�敪CK { get; set; }

        /// <summary>
        /// ����CK
        /// </summary>
        [Column("����CK")]
        [StringLength(1)]
        public string ����CK { get; set; }

        /// <summary>
        /// ���F�P��CK
        /// </summary>
        [Column("���F�P��CK")]
        [StringLength(1)]
        public string ���F�P��CK { get; set; }

        /// <summary>
        /// ����CK
        /// </summary>
        [Column("����CK")]
        [StringLength(1)]
        public string ����CK { get; set; }

        /// <summary>
        /// ��M�S������CK
        /// </summary>
        [Column("��M�S������CK")]
        [StringLength(1)]
        public string ��M�S������CK { get; set; }

        /// <summary>
        /// ���͓��tCK
        /// </summary>
        [Column("���͓��tCK")]
        [StringLength(1)]
        public string ���͓��tCK { get; set; }

        /// <summary>
        /// ERR�t���O
        /// </summary>
        [Column("ERR�t���O")]
        [StringLength(1)]
        public string ERR�t���O { get; set; }

        /// <summary>
        /// WOR�t���O
        /// </summary>
        [Column("WOR�t���O")]
        [StringLength(1)]
        public string WOR�t���O { get; set; }

        /// <summary>
        /// �폜�t���O
        /// </summary>
        [Column("�폜�t���O")]
        [StringLength(1)]
        public string �폜�t���O { get; set; }

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
        /// �⏞�����R�[�h
        /// </summary>
        [Column("�⏞�����R�[�h")]
        [StringLength(1)]
        public string �⏞�����R�[�h { get; set; }

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
