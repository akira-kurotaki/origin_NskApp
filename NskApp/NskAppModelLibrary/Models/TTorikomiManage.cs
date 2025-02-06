using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// �捞�Ǘ�
    /// </summary>
    [Serializable]
    [Table("t_torikomi_manage")]
    public class TTorikomiManage : ModelBase
    {
        /// <summary>
        /// �o�b�`ID
        /// </summary>
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("batch_id", Order = 1)]
        public long BatchId { get; set; }

        /// <summary>
        /// �捞�ΏۃR�[�h
        /// </summary>
        [Required]
        [Column("torikomi_cd")]
        [StringLength(2)]
        public string TorikomiCd { get; set; }

        /// <summary>
        /// �Ώ۔N�x
        /// </summary>
        [Required]
        [Column("nendo")]
        public short Nendo { get; set; }

        /// <summary>
        /// �s���{���R�[�h
        /// </summary>
        [Required]
        [Column("todofuken_cd")]
        [StringLength(2)]
        public string TodofukenCd { get; set; }

        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Column("kumiaito_cd")]
        [StringLength(3)]
        public string KumiaitoCd { get; set; }

        /// <summary>
        /// �x���R�[�h
        /// </summary>
        [Column("shisho_cd")]
        [StringLength(2)]
        public string ShishoCd { get; set; }

        /// <summary>
        /// �捞�t�@�C���p�X
        /// </summary>
        [Column("torikomi_file_path")]
        [StringLength(256)]
        public string TorikomiFilePath { get; set; }

        /// <summary>
        /// �捞�t�@�C����
        /// </summary>
        [Column("torikomi_file_nm")]
        [StringLength(100)]
        public string TorikomiFileNm { get; set; }

        /// <summary>
        /// �n�b�V���l
        /// </summary>
        [Column("hash")]
        [StringLength(64)]
        public string Hash { get; set; }

        /// <summary>
        /// �捞�X�e�[�^�X
        /// </summary>
        [Column("torikomi_sts")]
        [StringLength(2)]
        public string TorikomiSts { get; set; }

        /// <summary>
        /// �捞��������
        /// </summary>
        [Column("torikomi_date")]
        public DateTime? TorikomiDate { get; set; }

        /// <summary>
        /// ���b�N�J�n����
        /// </summary>
        [Column("lock_date")]
        public DateTime? LockDate { get; set; }

        /// <summary>
        /// ���f��������
        /// </summary>
        [Column("hanei_date")]
        public DateTime? HaneiDate { get; set; }

        /// <summary>
        /// �폜�t���O
        /// </summary>
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
