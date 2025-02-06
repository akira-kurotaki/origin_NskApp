using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_24090_�K�i�ʎ��n�ʓ��z���v�Z_�K�i��
    /// </summary>
    [Serializable]
    [Table("t_24090_�K�i�ʎ��n�ʓ��z���v�Z_�K�i��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�g�������R�[�h), nameof(�Y�n�ʖ����R�[�h), nameof(�c�_�ΏۊO�t���O), nameof(�ދ敪), nameof(���Z�敪), nameof(�K�i))]
    public class T24090�K�i�ʎ��n�ʓ��z���v�Z�K�i�� : ModelBase
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
        /// �Y�n�ʖ����R�[�h
        /// </summary>
        [Required]
        [Column("�Y�n�ʖ����R�[�h", Order = 5)]
        [StringLength(5)]
        public string �Y�n�ʖ����R�[�h { get; set; }

        /// <summary>
        /// �c�_�ΏۊO�t���O
        /// </summary>
        [Required]
        [Column("�c�_�ΏۊO�t���O", Order = 6)]
        [StringLength(1)]
        public string �c�_�ΏۊO�t���O { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 7)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// ���Z�敪
        /// </summary>
        [Required]
        [Column("���Z�敪", Order = 8)]
        [StringLength(1)]
        public string ���Z�敪 { get; set; }

        /// <summary>
        /// �K�i
        /// </summary>
        [Required]
        [Column("�K�i", Order = 9)]
        [StringLength(2)]
        public string �K�i { get; set; }

        /// <summary>
        /// �␳��o�א��ʓ�
        /// </summary>
        [Column("�␳��o�א��ʓ�")]
        public Decimal? �␳��o�א��ʓ� { get; set; }

        /// <summary>
        /// �K�i�ʏo�׊���
        /// </summary>
        [Column("�K�i�ʏo�׊���")]
        public Decimal? �K�i�ʏo�׊��� { get; set; }

        /// <summary>
        /// �K�i�ʐ���
        /// </summary>
        [Column("�K�i�ʐ���")]
        public Decimal? �K�i�ʐ��� { get; set; }

        /// <summary>
        /// �␳�㕪��������
        /// </summary>
        [Column("�␳�㕪��������")]
        public Decimal? �␳�㕪�������� { get; set; }

        /// <summary>
        /// �K�i�ʊ���
        /// </summary>
        [Column("�K�i�ʊ���")]
        public Decimal? �K�i�ʊ��� { get; set; }

        /// <summary>
        /// �␳�㕪�������ʂQ
        /// </summary>
        [Column("�␳�㕪�������ʂQ")]
        public Decimal? �␳�㕪�������ʂQ { get; set; }

        /// <summary>
        /// �␳�㕪�������ʂR
        /// </summary>
        [Column("�␳�㕪�������ʂR")]
        public Decimal? �␳�㕪�������ʂR { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [Column("����������")]
        public Decimal? ���������� { get; set; }

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
