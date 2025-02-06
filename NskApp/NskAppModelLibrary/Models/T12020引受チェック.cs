using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_12020_����`�F�b�N
    /// </summary>
    [Serializable]
    [Table("t_12020_����`�F�b�N")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�))]
    public class T12020����`�F�b�N : ModelBase
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
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 4)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 5)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �k�n�ԍ�
        /// </summary>
        [Required]
        [Column("�k�n�ԍ�", Order = 6)]
        [StringLength(5)]
        public string �k�n�ԍ� { get; set; }

        /// <summary>
        /// ���M�ԍ�
        /// </summary>
        [Required]
        [Column("���M�ԍ�", Order = 7)]
        [StringLength(4)]
        public string ���M�ԍ� { get; set; }

        /// <summary>
        /// �k�n�ʐσ`�F�b�N
        /// </summary>
        [Column("�k�n�ʐσ`�F�b�N")]
        [StringLength(1)]
        public string �k�n�ʐσ`�F�b�N { get; set; }

        /// <summary>
        /// ����ʐσ`�F�b�N
        /// </summary>
        [Column("����ʐσ`�F�b�N")]
        [StringLength(1)]
        public string ����ʐσ`�F�b�N { get; set; }

        /// <summary>
        /// �]�쓙�ʐσ`�F�b�N
        /// </summary>
        [Column("�]�쓙�ʐσ`�F�b�N")]
        [StringLength(1)]
        public string �]�쓙�ʐσ`�F�b�N { get; set; }

        /// <summary>
        /// ��ϑ��敪�`�F�b�N
        /// </summary>
        [Column("��ϑ��敪�`�F�b�N")]
        [StringLength(1)]
        public string ��ϑ��敪�`�F�b�N { get; set; }

        /// <summary>
        /// ��ϑ��҃`�F�b�N
        /// </summary>
        [Column("��ϑ��҃`�F�b�N")]
        [StringLength(1)]
        public string ��ϑ��҃`�F�b�N { get; set; }

        /// <summary>
        /// �c���敪�`�F�b�N
        /// </summary>
        [Column("�c���敪�`�F�b�N")]
        [StringLength(1)]
        public string �c���敪�`�F�b�N { get; set; }

        /// <summary>
        /// �敪�`�F�b�N
        /// </summary>
        [Column("�敪�`�F�b�N")]
        [StringLength(1)]
        public string �敪�`�F�b�N { get; set; }

        /// <summary>
        /// ��ރ`�F�b�N
        /// </summary>
        [Column("��ރ`�F�b�N")]
        [StringLength(1)]
        public string ��ރ`�F�b�N { get; set; }

        /// <summary>
        /// �ދ敪�`�F�b�N
        /// </summary>
        [Column("�ދ敪�`�F�b�N")]
        [StringLength(1)]
        public string �ދ敪�`�F�b�N { get; set; }

        /// <summary>
        /// �i��`�F�b�N
        /// </summary>
        [Column("�i��`�F�b�N")]
        [StringLength(1)]
        public string �i��`�F�b�N { get; set; }

        /// <summary>
        /// ���ʓ����`�F�b�N
        /// </summary>
        [Column("���ʓ����`�F�b�N")]
        [StringLength(1)]
        public string ���ʓ����`�F�b�N { get; set; }

        /// <summary>
        /// ���ʒP���`�F�b�N
        /// </summary>
        [Column("���ʒP���`�F�b�N")]
        [StringLength(1)]
        public string ���ʒP���`�F�b�N { get; set; }

        /// <summary>
        /// ���v�P���`�F�b�N
        /// </summary>
        [Column("���v�P���`�F�b�N")]
        [StringLength(1)]
        public string ���v�P���`�F�b�N { get; set; }

        /// <summary>
        /// �Q�ރ`�F�b�N
        /// </summary>
        [Column("�Q�ރ`�F�b�N")]
        [StringLength(1)]
        public string �Q�ރ`�F�b�N { get; set; }

        /// <summary>
        /// �֘A�`�F�b�N
        /// </summary>
        [Column("�֘A�`�F�b�N")]
        [StringLength(1)]
        public string �֘A�`�F�b�N { get; set; }

        /// <summary>
        /// FIM�`�F�b�N
        /// </summary>
        [Column("FIM�`�F�b�N")]
        [StringLength(1)]
        public string FIM�`�F�b�N { get; set; }

        /// <summary>
        /// �e������`�F�b�N
        /// </summary>
        [Column("�e������`�F�b�N")]
        [StringLength(1)]
        public string �e������`�F�b�N { get; set; }

        /// <summary>
        /// ��������`�F�b�N
        /// </summary>
        [Column("��������`�F�b�N")]
        [StringLength(1)]
        public string ��������`�F�b�N { get; set; }

        /// <summary>
        /// �x���R�[�h�`�F�b�N
        /// </summary>
        [Column("�x���R�[�h�`�F�b�N")]
        [StringLength(1)]
        public string �x���R�[�h�`�F�b�N { get; set; }

        /// <summary>
        /// �p�r�敪�`�F�b�N
        /// </summary>
        [Column("�p�r�敪�`�F�b�N")]
        [StringLength(1)]
        public string �p�r�敪�`�F�b�N { get; set; }

        /// <summary>
        /// �Y�n�ʖ����`�F�b�N
        /// </summary>
        [Column("�Y�n�ʖ����`�F�b�N")]
        [StringLength(1)]
        public string �Y�n�ʖ����`�F�b�N { get; set; }

        /// <summary>
        /// �����W���`�F�b�N
        /// </summary>
        [Column("�����W���`�F�b�N")]
        [StringLength(1)]
        public string �����W���`�F�b�N { get; set; }

        /// <summary>
        /// �폜�t���O
        /// </summary>
        [Column("�폜�t���O")]
        [StringLength(1)]
        public string �폜�t���O { get; set; }

        /// <summary>
        /// ERR�t���O
        /// </summary>
        [Column("ERR�t���O")]
        [StringLength(1)]
        public string ERR�t���O { get; set; }

        /// <summary>
        /// WAR�t���O
        /// </summary>
        [Column("WAR�t���O")]
        [StringLength(1)]
        public string WAR�t���O { get; set; }

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
