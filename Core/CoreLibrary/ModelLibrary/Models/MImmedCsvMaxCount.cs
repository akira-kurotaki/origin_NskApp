using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ����CSV�o�͏��������}�X�^
    /// </summary>
    [Serializable]
    [Table("m_immed_csv_max_count")]
    [PrimaryKey(nameof(SystemKbn), nameof(TableNm))]
    public class MImmedCsvMaxCount : ModelBase
    {
        /// <summary>
        /// �V�X�e���敪
        /// </summary>
        [Required]
        [Column("system_kbn", Order = 1)]
        [StringLength(2)]
        public string SystemKbn { get; set; }

        /// <summary>
        /// �e�[�u����
        /// </summary>
        [Required]
        [Column("table_nm", Order = 2)]
        [StringLength(100)]
        public string TableNm { get; set; }

        /// <summary>
        /// ����CSV�o�͏������
        /// </summary>
        [Required]
        [Column("immed_csv_max_count")]
        public int ImmedCsvMaxCount { get; set; }

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
