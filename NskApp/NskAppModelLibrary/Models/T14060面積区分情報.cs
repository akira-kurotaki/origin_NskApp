using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_14060_�ʐϋ敪���
    /// </summary>
    [Serializable]
    [Table("t_14060_�ʐϋ敪���")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(seqno))]
    public class T14060�ʐϋ敪��� : ModelBase
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
        /// seqno
        /// </summary>
        [Required]
        [Column("seqno", Order = 4)]
        [StringLength(3)]
        public string seqno { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P
        /// </summary>
        [Column("����ʐϋ敪�P")]
        [StringLength(5)]
        public string ����ʐϋ敪�P { get; set; }

        /// <summary>
        /// ����ʐϋ敪�Q
        /// </summary>
        [Column("����ʐϋ敪�Q")]
        [StringLength(5)]
        public string ����ʐϋ敪�Q { get; set; }

        /// <summary>
        /// ����ʐϋ敪�R
        /// </summary>
        [Column("����ʐϋ敪�R")]
        [StringLength(5)]
        public string ����ʐϋ敪�R { get; set; }

        /// <summary>
        /// ����ʐϋ敪�S
        /// </summary>
        [Column("����ʐϋ敪�S")]
        [StringLength(5)]
        public string ����ʐϋ敪�S { get; set; }

        /// <summary>
        /// ����ʐϋ敪�T
        /// </summary>
        [Column("����ʐϋ敪�T")]
        [StringLength(5)]
        public string ����ʐϋ敪�T { get; set; }

        /// <summary>
        /// ����ʐϋ敪�U
        /// </summary>
        [Column("����ʐϋ敪�U")]
        [StringLength(5)]
        public string ����ʐϋ敪�U { get; set; }

        /// <summary>
        /// ����ʐϋ敪�V
        /// </summary>
        [Column("����ʐϋ敪�V")]
        [StringLength(5)]
        public string ����ʐϋ敪�V { get; set; }

        /// <summary>
        /// ����ʐϋ敪�W
        /// </summary>
        [Column("����ʐϋ敪�W")]
        [StringLength(5)]
        public string ����ʐϋ敪�W { get; set; }

        /// <summary>
        /// ����ʐϋ敪�X
        /// </summary>
        [Column("����ʐϋ敪�X")]
        [StringLength(5)]
        public string ����ʐϋ敪�X { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�O
        /// </summary>
        [Column("����ʐϋ敪�P�O")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�O { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�P
        /// </summary>
        [Column("����ʐϋ敪�P�P")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�P { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�Q
        /// </summary>
        [Column("����ʐϋ敪�P�Q")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�Q { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�R
        /// </summary>
        [Column("����ʐϋ敪�P�R")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�R { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�S
        /// </summary>
        [Column("����ʐϋ敪�P�S")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�S { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�T
        /// </summary>
        [Column("����ʐϋ敪�P�T")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�T { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�U
        /// </summary>
        [Column("����ʐϋ敪�P�U")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�U { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�V
        /// </summary>
        [Column("����ʐϋ敪�P�V")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�V { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�W
        /// </summary>
        [Column("����ʐϋ敪�P�W")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�W { get; set; }

        /// <summary>
        /// ����ʐϋ敪�P�X
        /// </summary>
        [Column("����ʐϋ敪�P�X")]
        [StringLength(5)]
        public string ����ʐϋ敪�P�X { get; set; }

        /// <summary>
        /// ����ʐϋ敪�Q�O
        /// </summary>
        [Column("����ʐϋ敪�Q�O")]
        [StringLength(5)]
        public string ����ʐϋ敪�Q�O { get; set; }

        /// <summary>
        /// ����ʐϋ敪�Q�P
        /// </summary>
        [Column("����ʐϋ敪�Q�P")]
        [StringLength(5)]
        public string ����ʐϋ敪�Q�P { get; set; }

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
