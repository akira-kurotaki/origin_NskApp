using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �ėp�敪�}�X�^
    /// </summary>
    [Serializable]
    [Table("m_hanyokubun")]
    [PrimaryKey(nameof(KbnSbt), nameof(KbnCd))]
    public class MHanyokubun : ModelBase
    {
        /// <summary>
        /// �敪���
        /// </summary>
        [Required]
        [Column("kbn_sbt", Order = 1)]
        [StringLength(100)]
        public string KbnSbt { get; set; }

        /// <summary>
        /// �敪�R�[�h
        /// </summary>
        [Required]
        [Column("kbn_cd", Order = 2)]
        [StringLength(3)]
        public string KbnCd { get; set; }

        /// <summary>
        /// �敪����
        /// </summary>
        [Column("kbn_nm")]
        [StringLength(40)]
        public string KbnNm { get; set; }

        /// <summary>
        /// �敪����
        /// </summary>
        [Column("kbn_rnm")]
        [StringLength(20)]
        public string KbnRnm { get; set; }

        /// <summary>
        /// �\�[�g��
        /// </summary>
        [Column("sort")]
        public short? Sort { get; set; }

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
