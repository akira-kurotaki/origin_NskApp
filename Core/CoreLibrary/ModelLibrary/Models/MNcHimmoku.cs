using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// _{iÚ}X^
    /// </summary>
    [Serializable]
    [Table("m_nc_himmoku")]
    [PrimaryKey(nameof(NcShuruiCd), nameof(NcHimmokuCd))]
    public class MNcHimmoku : ModelBase
    {
        /// <summary>
        /// _{íÞR[h (FK)
        /// </summary>
        [Required]
        //[Key]
        [Column("nc_shurui_cd", Order = 1)]
        [StringLength(2)]
        public string NcShuruiCd { get; set; }

        /// <summary>
        /// _{iÚR[h
        /// </summary>
        [Required]
        //[Key]
        [Column("nc_himmoku_cd", Order = 2)]
        [StringLength(3)]
        public string NcHimmokuCd { get; set; }

        /// <summary>
        /// _{iÚ¼
        /// </summary>
        [Column("nc_himmoku_nm")]
        [StringLength(18)]
        public string NcHimmokuNm { get; set; }

        /// <summary>
        /// ß\l®tO
        /// </summary>
        [Required]
        [Column("kakoshinkoku_yoshiki_flg")]
        [StringLength(1)]
        public string KakoshinkokuYoshikiFlg { get; set; }

        /// <summary>
        /// âtH[l®tO
        /// </summary>
        [Required]
        [Column("hojoform_yoshiki_flg")]
        [StringLength(1)]
        public string HojoformYoshikiFlg { get; set; }

        /// <summary>
        /// c_væl®tO
        /// </summary>
        [Required]
        [Column("einokeikaku_yoshiki_flg")]
        [StringLength(1)]
        public string EinokeikakuYoshikiFlg { get; set; }

        /// <summary>
        /// ûüZl®tO
        /// </summary>
        [Required]
        [Column("shunyushisan_yoshiki_flg")]
        [StringLength(1)]
        public string ShunyushisanYoshikiFlg { get; set; }

        /// <summary>
        /// ocÚWl®tO
        /// </summary>
        [Required]
        [Column("keieimokuhyo_yoshiki_flg")]
        [StringLength(1)]
        public string KeieimokuhyoYoshikiFlg { get; set; }

        /// <summary>
        /// ß\prK{tO
        /// </summary>
        [Required]
        [Column("kakoshinkoku_yoto_required_flg")]
        [StringLength(1)]
        public string KakoshinkokuYotoRequiredFlg { get; set; }

        /// <summary>
        /// âtH[prK{tO
        /// </summary>
        [Required]
        [Column("hojoform_yoto_required_flg")]
        [StringLength(1)]
        public string HojoformYotoRequiredFlg { get; set; }

        /// <summary>
        /// c_væprK{tO
        /// </summary>
        [Required]
        [Column("einokeikaku_yoto_required_flg")]
        [StringLength(1)]
        public string EinokeikakuYotoRequiredFlg { get; set; }

        /// <summary>
        /// ûüZprK{tO
        /// </summary>
        [Required]
        [Column("shunyushisan_yoto_required_flg")]
        [StringLength(1)]
        public string ShunyushisanYotoRequiredFlg { get; set; }

        /// <summary>
        /// ocÚWprK{tO
        /// </summary>
        [Required]
        [Column("keieimokuhyo_yoto_required_flg")]
        [StringLength(1)]
        public string KeieimokuhyoYotoRequiredFlg { get; set; }

        /// <summary>
        /// KÍgåOtO
        /// </summary>
        [Required]
        [Column("kibokakudai_jyogai_flg")]
        [StringLength(1)]
        public string KibokakudaiJyogaiFlg { get; set; }

        /// <summary>
        /// ítO
        /// </summary>
        [Required]
        [Column("delete_flg")]
        [StringLength(1)]
        public string DeleteFlg { get; set; }

        /// <summary>
        /// o^[UID
        /// </summary>
        [Column("insert_user_id")]
        [StringLength(11)]
        public string InsertUserId { get; set; }

        /// <summary>
        /// o^ú
        /// </summary>
        [Column("insert_date")]
        public DateTime? InsertDate { get; set; }

        /// <summary>
        /// XV[UID
        /// </summary>
        [Column("update_user_id")]
        [StringLength(11)]
        public string UpdateUserId { get; set; }

        /// <summary>
        /// XVú
        /// </summary>
        [Column("update_date")]
        public DateTime? UpdateDate { get; set; }
    }
}
