using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_23130_���㎻�F�]��
    /// </summary>
    [Serializable]
    [Table("t_23130_���㎻�F�]��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�k�n�ԍ�), nameof(���M�ԍ�), nameof(�p�r�敪))]
    public class T23130���㎻�F�]�� : ModelBase
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
        /// �p�r�敪
        /// </summary>
        [Required]
        [Column("�p�r�敪", Order = 7)]
        [StringLength(3)]
        public string �p�r�敪 { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [Column("����������")]
        public Decimal? ���������� { get; set; }

        /// <summary>
        /// �P���C����
        /// </summary>
        [Column("�P���C����")]
        public Decimal? �P���C���� { get; set; }

        /// <summary>
        /// �g�����]���P��
        /// </summary>
        [Column("�g�����]���P��")]
        public Decimal? �g�����]���P�� { get; set; }

        /// <summary>
        /// �g�����]������
        /// </summary>
        [Column("�g�����]������")]
        public Decimal? �g�����]������ { get; set; }

        /// <summary>
        /// ���n��
        /// </summary>
        [Column("���n��")]
        public Decimal? ���n�� { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Column("������")]
        public Decimal? ������ { get; set; }

        /// <summary>
        /// ���ό�����
        /// </summary>
        [Column("���ό�����")]
        public Decimal? ���ό����� { get; set; }

        /// <summary>
        /// ������M�S��������
        /// </summary>
        [Column("������M�S��������")]
        public Decimal? ������M�S�������� { get; set; }

        /// <summary>
        /// �����v�Z���t
        /// </summary>
        [Column("�����v�Z���t")]
        public DateTime? �����v�Z���t { get; set; }

        /// <summary>
        /// �������ϋ�
        /// </summary>
        [Column("�������ϋ�")]
        public Decimal? �������ϋ� { get; set; }

        /// <summary>
        /// �x�����ϋ�
        /// </summary>
        [Column("�x�����ϋ�")]
        public Decimal? �x�����ϋ� { get; set; }

        /// <summary>
        /// �␳��
        /// </summary>
        [Column("�␳��")]
        public Decimal? �␳�� { get; set; }

        /// <summary>
        /// �K�p�P�����ϋ��z
        /// </summary>
        [Column("�K�p�P�����ϋ��z")]
        public Decimal? �K�p�P�����ϋ��z { get; set; }

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
