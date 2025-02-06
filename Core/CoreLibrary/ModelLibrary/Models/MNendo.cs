using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �N�x�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_nendo")]
    public class MNendo : ModelBase
    {
        /// <summary>
        /// �N�x
        /// </summary>
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("nendo", Order = 1)]
        public short Nendo { get; set; }

        /// <summary>
        /// �N�x�\��1
        /// </summary>
        [Column("nendo_disp1")]
        [StringLength(30)]
        public string NendoDisp1 { get; set; }

        /// <summary>
        /// �N�x�\��2
        /// </summary>
        [Column("nendo_disp2")]
        [StringLength(30)]
        public string NendoDisp2 { get; set; }

        /// <summary>
        /// �N�x�\��3
        /// </summary>
        [Column("nendo_disp3")]
        [StringLength(30)]
        public string NendoDisp3 { get; set; }

        /// <summary>
        /// �o�^���[�UID
        /// </summary>
        [Column("insert_user_id")]
        [StringLength(11)]
        public string InsertUserId { get; set; }

        /// <summary>
        /// �o�^����
        /// </summary>
        [Column("insert_date")]
        public DateTime? InsertDate { get; set; }

        /// <summary>
        /// �X�V���[�UID
        /// </summary>
        [Column("update_user_id")]
        [StringLength(11)]
        public string UpdateUserId { get; set; }

        /// <summary>
        /// �X�V����
        /// </summary>
        [Column("update_date")]
        public DateTime? UpdateDate { get; set; }
    }
}
