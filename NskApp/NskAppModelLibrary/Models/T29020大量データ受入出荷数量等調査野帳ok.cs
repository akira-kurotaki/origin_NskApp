using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_29020_��ʃf�[�^���_�o�א��ʓ������쒠OK
    /// </summary>
    [Serializable]
    [Table("t_29020_��ʃf�[�^���_�o�א��ʓ������쒠OK")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�����敪), nameof(�g�������R�[�h), nameof(�o�ו]���n��R�[�h), nameof(�o�׊K�w�敪�R�[�h), nameof(�Y�n�ʖ����R�[�h))]
    public class T29020��ʃf�[�^����o�א��ʓ������쒠ok : ModelBase
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
        /// �����敪
        /// </summary>
        [Required]
        [Column("�����敪", Order = 4)]
        [StringLength(1)]
        public string �����敪 { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Required]
        [Column("�g�������R�[�h", Order = 5)]
        [StringLength(13)]
        public string �g�������R�[�h { get; set; }

        /// <summary>
        /// �o�ו]���n��R�[�h
        /// </summary>
        [Required]
        [Column("�o�ו]���n��R�[�h", Order = 6)]
        [StringLength(4)]
        public string �o�ו]���n��R�[�h { get; set; }

        /// <summary>
        /// �o�׊K�w�敪�R�[�h
        /// </summary>
        [Required]
        [Column("�o�׊K�w�敪�R�[�h", Order = 7)]
        [StringLength(3)]
        public string �o�׊K�w�敪�R�[�h { get; set; }

        /// <summary>
        /// �Y�n�ʖ����R�[�h
        /// </summary>
        [Required]
        [Column("�Y�n�ʖ����R�[�h", Order = 8)]
        [StringLength(5)]
        public string �Y�n�ʖ����R�[�h { get; set; }

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
        /// �o�׌�������
        /// </summary>
        [Column("�o�׌�������")]
        public Decimal? �o�׌������� { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P")]
        public Decimal? �o�א��ʓ�_�K�i�P { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q")]
        public Decimal? �o�א��ʓ�_�K�i�Q { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R")]
        public Decimal? �o�א��ʓ�_�K�i�R { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�S
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�S")]
        public Decimal? �o�א��ʓ�_�K�i�S { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�T
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�T")]
        public Decimal? �o�א��ʓ�_�K�i�T { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�U
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�U")]
        public Decimal? �o�א��ʓ�_�K�i�U { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�V
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�V")]
        public Decimal? �o�א��ʓ�_�K�i�V { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�W
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�W")]
        public Decimal? �o�א��ʓ�_�K�i�W { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�X
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�X")]
        public Decimal? �o�א��ʓ�_�K�i�X { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�O
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�O")]
        public Decimal? �o�א��ʓ�_�K�i�P�O { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�P
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�P")]
        public Decimal? �o�א��ʓ�_�K�i�P�P { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�Q
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�Q")]
        public Decimal? �o�א��ʓ�_�K�i�P�Q { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�R
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�R")]
        public Decimal? �o�א��ʓ�_�K�i�P�R { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�S
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�S")]
        public Decimal? �o�א��ʓ�_�K�i�P�S { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�T
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�T")]
        public Decimal? �o�א��ʓ�_�K�i�P�T { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�U
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�U")]
        public Decimal? �o�א��ʓ�_�K�i�P�U { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�V
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�V")]
        public Decimal? �o�א��ʓ�_�K�i�P�V { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�W
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�W")]
        public Decimal? �o�א��ʓ�_�K�i�P�W { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�P�X
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�P�X")]
        public Decimal? �o�א��ʓ�_�K�i�P�X { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�O
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�O")]
        public Decimal? �o�א��ʓ�_�K�i�Q�O { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�P
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�P")]
        public Decimal? �o�א��ʓ�_�K�i�Q�P { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�Q
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�Q")]
        public Decimal? �o�א��ʓ�_�K�i�Q�Q { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�R
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�R")]
        public Decimal? �o�א��ʓ�_�K�i�Q�R { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�S
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�S")]
        public Decimal? �o�א��ʓ�_�K�i�Q�S { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�T
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�T")]
        public Decimal? �o�א��ʓ�_�K�i�Q�T { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�U
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�U")]
        public Decimal? �o�א��ʓ�_�K�i�Q�U { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�V
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�V")]
        public Decimal? �o�א��ʓ�_�K�i�Q�V { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�W
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�W")]
        public Decimal? �o�א��ʓ�_�K�i�Q�W { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�Q�X
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�Q�X")]
        public Decimal? �o�א��ʓ�_�K�i�Q�X { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�O
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�O")]
        public Decimal? �o�א��ʓ�_�K�i�R�O { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�P
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�P")]
        public Decimal? �o�א��ʓ�_�K�i�R�P { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�Q
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�Q")]
        public Decimal? �o�א��ʓ�_�K�i�R�Q { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�R
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�R")]
        public Decimal? �o�א��ʓ�_�K�i�R�R { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�S
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�S")]
        public Decimal? �o�א��ʓ�_�K�i�R�S { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�T
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�T")]
        public Decimal? �o�א��ʓ�_�K�i�R�T { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�U
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�U")]
        public Decimal? �o�א��ʓ�_�K�i�R�U { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�V
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�V")]
        public Decimal? �o�א��ʓ�_�K�i�R�V { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�W
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�W")]
        public Decimal? �o�א��ʓ�_�K�i�R�W { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�R�X
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�R�X")]
        public Decimal? �o�א��ʓ�_�K�i�R�X { get; set; }

        /// <summary>
        /// �o�א��ʓ�_�K�i�S�O
        /// </summary>
        [Column("�o�א��ʓ�_�K�i�S�O")]
        public Decimal? �o�א��ʓ�_�K�i�S�O { get; set; }

        /// <summary>
        /// �K�i�ʔ���敪
        /// </summary>
        [Column("�K�i�ʔ���敪")]
        [StringLength(1)]
        public string �K�i�ʔ���敪 { get; set; }

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
