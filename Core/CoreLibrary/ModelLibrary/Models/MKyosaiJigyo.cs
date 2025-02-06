using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ����M���ώ���
    /// </summary>
    [Serializable]
    [Table("m_kyosai_jigyo")]
    public class MKyosaiJigyo : ModelBase
    {
        /// <summary>
        /// ���ώ��ƃR�[�h
        /// </summary>
        [Required]
        [Key]
        [Column("kyosai_jigyo_cd", Order = 1)]
        [StringLength(2)]
        public string KyosaiJigyoCd { get; set; }

        /// <summary>
        /// ���ώ��Ɩ���
        /// </summary>
        [Column("kyosai_jigyo_nm")]
        [StringLength(30)]
        public string KyosaiJigyoNm { get; set; }

        /// <summary>
        /// ���ώ��ƕ\����
        /// </summary>
        [Required]
        [Column("kyosai_jigyo_display_order")]
        public short KyosaiJigyoDisplayOrder { get; set; }

        /// <summary>
        /// ���ώ��ƕ\���t���O
        /// </summary>
        [Column("kyosai_jigyo_display_flg")]
        [StringLength(1)]
        public string KyosaiJigyoDisplayFlg { get; set; }

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
