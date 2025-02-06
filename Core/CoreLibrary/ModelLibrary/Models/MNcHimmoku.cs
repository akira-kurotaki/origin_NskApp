using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �_�{�i�ڃ}�X�^
    /// </summary>
    [Serializable]
    [Table("m_nc_himmoku")]
    [PrimaryKey(nameof(NcShuruiCd), nameof(NcHimmokuCd))]
    public class MNcHimmoku : ModelBase
    {
        /// <summary>
        /// �_�{��ރR�[�h (FK)
        /// </summary>
        [Required]
        //[Key]
        [Column("nc_shurui_cd", Order = 1)]
        [StringLength(2)]
        public string NcShuruiCd { get; set; }

        /// <summary>
        /// �_�{�i�ڃR�[�h
        /// </summary>
        [Required]
        //[Key]
        [Column("nc_himmoku_cd", Order = 2)]
        [StringLength(3)]
        public string NcHimmokuCd { get; set; }

        /// <summary>
        /// �_�{�i�ږ�
        /// </summary>
        [Column("nc_himmoku_nm")]
        [StringLength(18)]
        public string NcHimmokuNm { get; set; }

        /// <summary>
        /// �ߋ��\�����l���t���O
        /// </summary>
        [Required]
        [Column("kakoshinkoku_yoshiki_flg")]
        [StringLength(1)]
        public string KakoshinkokuYoshikiFlg { get; set; }

        /// <summary>
        /// �⏕�t�H�[���l���t���O
        /// </summary>
        [Required]
        [Column("hojoform_yoshiki_flg")]
        [StringLength(1)]
        public string HojoformYoshikiFlg { get; set; }

        /// <summary>
        /// �c�_�v��l���t���O
        /// </summary>
        [Required]
        [Column("einokeikaku_yoshiki_flg")]
        [StringLength(1)]
        public string EinokeikakuYoshikiFlg { get; set; }

        /// <summary>
        /// �������Z�l���t���O
        /// </summary>
        [Required]
        [Column("shunyushisan_yoshiki_flg")]
        [StringLength(1)]
        public string ShunyushisanYoshikiFlg { get; set; }

        /// <summary>
        /// �o�c�ڕW�l���t���O
        /// </summary>
        [Required]
        [Column("keieimokuhyo_yoshiki_flg")]
        [StringLength(1)]
        public string KeieimokuhyoYoshikiFlg { get; set; }

        /// <summary>
        /// �ߋ��\�����p�r�K�{�t���O
        /// </summary>
        [Required]
        [Column("kakoshinkoku_yoto_required_flg")]
        [StringLength(1)]
        public string KakoshinkokuYotoRequiredFlg { get; set; }

        /// <summary>
        /// �⏕�t�H�[���p�r�K�{�t���O
        /// </summary>
        [Required]
        [Column("hojoform_yoto_required_flg")]
        [StringLength(1)]
        public string HojoformYotoRequiredFlg { get; set; }

        /// <summary>
        /// �c�_�v��p�r�K�{�t���O
        /// </summary>
        [Required]
        [Column("einokeikaku_yoto_required_flg")]
        [StringLength(1)]
        public string EinokeikakuYotoRequiredFlg { get; set; }

        /// <summary>
        /// �������Z�p�r�K�{�t���O
        /// </summary>
        [Required]
        [Column("shunyushisan_yoto_required_flg")]
        [StringLength(1)]
        public string ShunyushisanYotoRequiredFlg { get; set; }

        /// <summary>
        /// �o�c�ڕW�p�r�K�{�t���O
        /// </summary>
        [Required]
        [Column("keieimokuhyo_yoto_required_flg")]
        [StringLength(1)]
        public string KeieimokuhyoYotoRequiredFlg { get; set; }

        /// <summary>
        /// �K�͊g�叜�O�t���O
        /// </summary>
        [Required]
        [Column("kibokakudai_jyogai_flg")]
        [StringLength(1)]
        public string KibokakudaiJyogaiFlg { get; set; }

        /// <summary>
        /// �폜�t���O
        /// </summary>
        [Required]
        [Column("delete_flg")]
        [StringLength(1)]
        public string DeleteFlg { get; set; }

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
