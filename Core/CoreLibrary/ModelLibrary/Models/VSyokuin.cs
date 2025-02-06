using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �E���}�X�^
    /// </summary>
    [Serializable]
    [Table("v_syokuin")]
    [PrimaryKey(nameof(UserId), nameof(UserKanriNo))]
    public class VSyokuin : ISyokuin
    {
        /// <summary>
        /// ���[�UID
        /// </summary>
        [Required]
        [Column("user_id", Order = 1)]
        [StringLength(11)]
        public string UserId { get; set; }

        /// <summary>
        /// ���[�U�Ǘ��ԍ�
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("user_kanri_no", Order = 2)]
        public int UserKanriNo { get; set; }

        /// <summary>
        /// �s���{���R�[�h
        /// </summary>
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
        /// ���[�U�Ǘ�����
        /// </summary>
        [Required]
        [Column("user_kanri_kengen")]
        [StringLength(1)]
        public string UserKanriKengen { get; set; }

        /// <summary>
        /// �o�b�`�Ǘ�����
        /// </summary>
        [Required]
        [Column("batch_kanri_kengen")]
        [StringLength(1)]
        public string BatchKanriKengen { get; set; }

        /// <summary>
        /// ���[�U���L�����ԊJ�n��
        /// </summary>
        [Required]
        [Column("user_yuko_start_ymd")]
        public DateTime UserYukoStartYmd { get; set; }

        /// <summary>
        /// ���[�U���L�����ԏI����
        /// </summary>
        [Column("user_yuko_end_ymd")]
        public DateTime? UserYukoEndYmd { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required]
        [Column("full_nm")]
        [StringLength(30)]
        public string FullNm { get; set; }

        /// <summary>
        /// �t���K�i
        /// </summary>
        [Column("full_kana")]
        [StringLength(30)]
        public string FullKana { get; set; }

        /// <summary>
        /// �d�b�ԍ�
        /// </summary>
        [Column("tel")]
        [StringLength(13)]
        public string Tel { get; set; }

        /// <summary>
        /// ���[���A�h���X
        /// </summary>
        [Column("mail")]
        [StringLength(50)]
        public string Mail { get; set; }

        /// <summary>
        /// �V�X�e�����p�ҋ敪
        /// </summary>
        [Column("system_riyo_kbn")]
        [StringLength(1)]
        public string SystemRiyoKbn { get; set; }

        /// <summary>
        /// ���p����_�����󋵊Ǘ�
        /// </summary>
        [Column("kjk_kengen")]
        [StringLength(1)]
        public string KjkKengen { get; set; }

        /// <summary>
        /// ���p����_�_�Ǝҏ��Ǘ�
        /// </summary>
        [Column("fim_kengen")]
        [StringLength(1)]
        public string FimKengen { get; set; }

        /// <summary>
        /// ���p����_�_�앨����
        /// </summary>
        [Column("nsk_kengen")]
        [StringLength(1)]
        public string NskKengen { get; set; }

        /// <summary>
        /// ���p����_��������
        /// </summary>
        [Column("sml_kengen")]
        [StringLength(1)]
        public string SmlKengen { get; set; }

        /// <summary>
        /// ���p����_�����ی�
        /// </summary>
        [Column("syn_kengen")]
        [StringLength(1)]
        public string SynKengen { get; set; }

        /// <summary>
        /// ���p����_���|�{�݋��ρi���ʐ\���j
        /// </summary>
        [Column("kyotsu_eng_kengen")]
        [StringLength(1)]
        public string KyotsuEngKengen { get; set; }

        /// <summary>
        /// ���p����_�ƒ{���ρi���ʐ\���j
        /// </summary>
        [Column("kyotsu_ktk_kengen")]
        [StringLength(1)]
        public string KyotsuKtkKengen { get; set; }

        /// <summary>
        /// ���p����_�_�앨���ρi���ʐ\���A�g�j
        /// </summary>
        [Column("kyotsu_renkei_nsk_kengen")]
        [StringLength(1)]
        public string KyotsuRenkeiNskKengen { get; set; }

        /// <summary>
        /// ���p����_���앨���ρi���ʐ\���A�g�j
        /// </summary>
        [Column("kyotsu_renkei_hat_kengen")]
        [StringLength(1)]
        public string KyotsuRenkeiHatKengen { get; set; }

        /// <summary>
        /// ���p����_�ʎ����ρi���ʐ\���A�g�j
        /// </summary>
        [Column("kyotsu_renkei_kju_kengen")]
        [StringLength(1)]
        public string KyotsuRenkeiKjuKengen { get; set; }

        /// <summary>
        /// �V�X�e�����p�ҊǗ��敪_�����ی�
        /// </summary>
        [Column("syn_system_kanri_kbn")]
        [StringLength(1)]
        public string SynSystemKanriKbn { get; set; }

        /// <summary>
        /// �V�X�e�����p�ҊǗ��敪_�ƒ{����(���ʐ\��)
        /// </summary>
        [Column("kyotsu_ktk_system_kanri_kbn")]
        [StringLength(1)]
        public string KyotsuKtkSystemKanriKbn { get; set; }

        /// <summary>
        /// �V�X�e�����p�ҊǗ��敪_���|�{�݋��ρi���ʐ\���j
        /// </summary>
        [Column("kyotsu_eng_system_kanri_kbn")]
        [StringLength(1)]
        public string KyotsuEngSystemKanriKbn { get; set; }

        /// <summary>
        /// ��ʑ��쌠��ID_�����󋵊Ǘ�
        /// </summary>
        [Column("kjk_screen_sosa_kengen_id")]
        public int? KjkScreenSosaKengenId { get; set; }

        /// <summary>
        /// ��ʑ��쌠��ID_�_�Ǝҏ��Ǘ�
        /// </summary>
        [Column("fim_screen_sosa_kengen_id")]
        public int? FimScreenSosaKengenId { get; set; }

        /// <summary>
        /// ��ʑ��쌠��ID_�_�앨����
        /// </summary>
        [Column("nsk_screen_sosa_kengen_id")]
        public int? NskScreenSosaKengenId { get; set; }

        /// <summary>
        /// ��ʑ��쌠��ID_��������
        /// </summary>
        [Column("sml_screen_sosa_kengen_id")]
        public int? SmlScreenSosaKengenId { get; set; }

        /// <summary>
        /// �x���O���[�vID_�����󋵊Ǘ�
        /// </summary>
        [Column("kjk_shisho_group_id")]
        public int? KjkShishoGroupId { get; set; }

        /// <summary>
        /// �x���O���[�vID_�_�Ǝҏ��Ǘ�
        /// </summary>
        [Column("fim_shisho_group_id")]
        public int? FimShishoGroupId { get; set; }

        /// <summary>
        /// �x���O���[�vID_�_�앨����
        /// </summary>
        [Column("nsk_shisho_group_id")]
        public int? NskShishoGroupId { get; set; }

        /// <summary>
        /// �x���O���[�vID_��������
        /// </summary>
        [Column("sml_shisho_group_id")]
        public int? SmlShishoGroupId { get; set; }

        /// <summary>
        /// �x���O���[�vID_�����ی�
        /// </summary>
        [Column("syn_shisho_group_id")]
        public int? SynShishoGroupId { get; set; }

        /// <summary>
        /// �閧�ێ����񏑒�o
        /// </summary>
        [Column("himitsu_seiyaku_flg")]
        [StringLength(1)]
        public string HimitsuSeiyakuFlg { get; set; }

        /// <summary>
        /// �p�X���[�h
        /// </summary>
        [Column("pwd")]
        [StringLength(84)]
        public string Pwd { get; set; }

        /// <summary>
        /// �p�X���[�h�ŏI�X�V�N����
        /// </summary>
        [Column("pwd_last_update_ymd")]
        public DateTime? PwdLastUpdateYmd { get; set; }

        /// <summary>
        /// ���O�C������
        /// </summary>
        [Column("login_date")]
        public DateTime? LoginDate { get; set; }

        /// <summary>
        /// �ŏI���O�C������
        /// </summary>
        [Column("last_login_date")]
        public DateTime? LastLoginDate { get; set; }

        /// <summary>
        /// ���b�N�t���O
        /// </summary>
        [Required]
        [Column("lock_flg")]
        [StringLength(1)]
        public string LockFlg { get; set; }

        /// <summary>
        /// ���O�C�����s��
        /// </summary>
        [Column("login_fail_cnt")]
        public short? LoginFailCnt { get; set; }

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
