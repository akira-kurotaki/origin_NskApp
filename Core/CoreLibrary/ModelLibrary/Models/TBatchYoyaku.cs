using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �o�b�`�\��
    /// </summary>
    [Serializable]
    [Table("t_batch_yoyaku")]
    public class TBatchYoyaku : ModelBase
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
        /// �o�b�`����
        /// </summary>
        [Required]
        [Column("batch_bunrui")]
        [StringLength(2)]
        public string BatchBunrui { get; set; }

        /// <summary>
        /// �V�X�e���敪
        /// </summary>
        [Required]
        [Column("system_kbn")]
        [StringLength(2)]
        public string SystemKbn { get; set; }

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
        /// �\�����
        /// </summary>
        [Column("batch_yoyaku_date")]
        public DateTime? BatchYoyakuDate { get; set; }

        /// <summary>
        /// �\�񃆁[�UID
        /// </summary>
        [Column("batch_yoyaku_id")]
        [StringLength(11)]
        public string BatchYoyakuId { get; set; }

        /// <summary>
        /// �\������s����������
        /// </summary>
        [Column("batch_yoyaku_shori")]
        [StringLength(30)]
        public string BatchYoyakuShori { get; set; }

        /// <summary>
        /// �o�b�`��
        /// </summary>
        [Column("batch_nm")]
        [StringLength(30)]
        public string BatchNm { get; set; }

        /// <summary>
        /// �o�b�`����
        /// </summary>
        [Column("batch_joken")]
        [StringLength(100)]
        public string BatchJoken { get; set; }

        /// <summary>
        /// �o�b�`�����i��ʕ\���p�j
        /// </summary>
        [Column("batch_joken_disp")]
        public string BatchJokenDisp { get; set; }

        /// <summary>
        /// �������s�֎~�t���O
        /// </summary>
        [Column("multi_run_ng_flg")]
        [StringLength(1)]
        public string MultiRunNgFlg { get; set; }

        /// <summary>
        /// �������s�֎~ID
        /// </summary>
        [Column("multi_run_ng_id")]
        [StringLength(100)]
        public string MultiRunNgId { get; set; }

        /// <summary>
        /// �o�b�`���
        /// </summary>
        [Required]
        [Column("batch_type")]
        [StringLength(1)]
        public string BatchType { get; set; }

        /// <summary>
        /// �莞���s�o�b�`�\�����
        /// </summary>
        [Column("batch_sche_datetime")]
        public DateTime? BatchScheDatetime { get; set; }

        /// <summary>
        /// ���b�N�Ώۃt���O
        /// </summary>
        [Column("lock_target_flg")]
        [StringLength(1)]
        public string LockTargetFlg { get; set; }

        /// <summary>
        /// �o�b�`�X�e�[�^�X
        /// </summary>
        [Column("batch_status")]
        [StringLength(2)]
        public string BatchStatus { get; set; }

        /// <summary>
        /// �o�b�`�J�n����
        /// </summary>
        [Column("batch_start_date")]
        public DateTime? BatchStartDate { get; set; }

        /// <summary>
        /// �o�b�`��������
        /// </summary>
        [Column("batch_end_date")]
        public DateTime? BatchEndDate { get; set; }

        /// <summary>
        /// ���s�T�[�o
        /// </summary>
        [Column("batch_run_server")]
        [StringLength(30)]
        public string BatchRunServer { get; set; }

        /// <summary>
        /// �G���[���
        /// </summary>
        [Column("error_info")]
        [StringLength(500)]
        public string ErrorInfo { get; set; }

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
