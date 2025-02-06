using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �莞�o�b�`�N���Ǘ�
    /// </summary>
    [Serializable]
    [Table("t_sche_batch_run_manage")]
    [PrimaryKey(nameof(SystemKbn), nameof(BatchNm))]
    public class TScheBatchRunManage : ModelBase
    {
        /// <summary>
        /// �V�X�e���敪
        /// </summary>
        [Required]
        [Column("system_kbn", Order = 1)]
        [StringLength(2)]
        public string SystemKbn { get; set; }

        /// <summary>
        /// �o�b�`��
        /// </summary>
        [Required]
        [Column("batch_nm", Order = 2)]
        [StringLength(30)]
        public string BatchNm { get; set; }

        /// <summary>
        /// �o�b�`�N����
        /// </summary>
        [Column("batch_run_date")]
        public DateTime? BatchRunDate { get; set; }
    }
}
