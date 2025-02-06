using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// ��ʋ@�\�����}�X�^
    /// </summary>
    [Serializable]
    [Table("m_screen_kino_kengen")]
    [PrimaryKey(nameof(ScreenSosaKengenId), nameof(ScreenKinoCd))]
    public class MScreenKinoKengen : ModelBase
    {
        /// <summary>
        /// ��ʑ��쌠��ID (FK)
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("screen_sosa_kengen_id", Order = 1)]
        public int ScreenSosaKengenId { get; set; }

        /// <summary>
        /// ��ʋ@�\�R�[�h
        /// </summary>
        [Required]
        [Column("screen_kino_cd", Order = 2)]
        [StringLength(20)]
        public string ScreenKinoCd { get; set; }

        /// <summary>
        /// �Q�ƕs�t���O
        /// </summary>
        [Column("no_refer_flg")]
        [StringLength(1)]
        public string NoReferFlg { get; set; }

        /// <summary>
        /// �X�V�s�t���O
        /// </summary>
        [Column("no_update_flg")]
        [StringLength(1)]
        public string NoUpdateFlg { get; set; }

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
