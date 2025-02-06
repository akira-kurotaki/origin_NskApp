using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �V�X�e���ݒ�l�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_core_config")]
    public class MCoreConfig : ModelBase
    {
        /// <summary>
        /// �����L�[
        /// </summary>
        [Required]
        [Key]
        [Column("search_key", Order = 1)]
        [StringLength(10)]
        public string SearchKey { get; set; }

        /// <summary>
        /// �ݒ�l
        /// </summary>
        [Required]
        [Column("config_value")]
        [StringLength(100)]
        public string ConfigValue { get; set; }

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
