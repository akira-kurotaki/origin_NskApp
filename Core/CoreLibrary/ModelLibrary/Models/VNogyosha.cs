using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �_�Ǝҏ��
    /// </summary>
    [Serializable]
    [Table("v_nogyosha")]
    public class VNogyosha
    {
        /// <summary>
        /// �_�Ǝ�ID
        /// </summary>
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("nogyosha_id", Order = 1)]
        public int NogyoshaId { get; set; }

        /// <summary>
        /// �_�ƎҊǗ��R�[�h
        /// </summary>
        [Required]
        [Column("nogyosha_cd")]
        [StringLength(13)]
        public string NogyoshaCd { get; set; }

        /// <summary>
        /// �g�������R�[�h
        /// </summary>
        [Column("kumiaiinto_cd")]
        [StringLength(13)]
        public string KumiaiintoCd { get; set; }

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
        /// �s�����R�[�h
        /// </summary>
        [Column("shichoson_cd")]
        [StringLength(5)]
        public string ShichosonCd { get; set; }

        /// <summary>
        /// ��n��R�[�h
        /// </summary>
        [Column("daichiku_cd")]
        [StringLength(2)]
        public string DaichikuCd { get; set; }

        /// <summary>
        /// ���n��R�[�h
        /// </summary>
        [Column("shochiku_cd")]
        [StringLength(4)]
        public string ShochikuCd { get; set; }

        /// <summary>
        /// �o�c�`��
        /// </summary>
        [Column("keiei_keitai_cd")]
        [StringLength(1)]
        public string KeieiKeitaiCd { get; set; }

        /// <summary>
        /// �@�l���
        /// </summary>
        [Column("hojin_shurui_cd")]
        [StringLength(1)]
        public string HojinShuruiCd { get; set; }

        /// <summary>
        /// �������͖@�l��
        /// </summary>
        [Required]
        [Column("hojin_full_nm")]
        [StringLength(30)]
        public string HojinFullNm { get; set; }

        /// <summary>
        /// �������͖@�l���t���K�i
        /// </summary>
        [Column("hojin_full_kana")]
        [StringLength(30)]
        public string HojinFullKana { get; set; }

        /// <summary>
        /// ��\�Ҏ���
        /// </summary>
        [Column("daihyosha_nm")]
        [StringLength(30)]
        public string DaihyoshaNm { get; set; }

        /// <summary>
        /// ��\�Ҏ����t���K�i
        /// </summary>
        [Column("daihyosha_kana")]
        [StringLength(30)]
        public string DaihyoshaKana { get; set; }

        /// <summary>
        /// �X�֔ԍ�
        /// </summary>
        [Column("postal_cd")]
        [StringLength(7)]
        public string PostalCd { get; set; }

        /// <summary>
        /// �Z���J�i
        /// </summary>
        [Column("address_kana")]
        [StringLength(60)]
        public string AddressKana { get; set; }

        /// <summary>
        /// �Z��
        /// </summary>
        [Column("address")]
        [StringLength(40)]
        public string Address { get; set; }

        /// <summary>
        /// �k�n�{�ɓ��Z���J�i
        /// </summary>
        [Column("kochito_address_kana")]
        [StringLength(60)]
        public string KochitoAddressKana { get; set; }

        /// <summary>
        /// �k�n�{�ɓ��Z��
        /// </summary>
        [Column("kochito_address")]
        [StringLength(40)]
        public string KochitoAddress { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column("gender")]
        [StringLength(1)]
        public string Gender { get; set; }

        /// <summary>
        /// ���N����
        /// </summary>
        [Column("date_of_birth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// �d�b�ԍ�
        /// </summary>
        [Column("tel")]
        [StringLength(13)]
        public string Tel { get; set; }

        /// <summary>
        /// �g�ѓd�b�ԍ�
        /// </summary>
        [Column("cell")]
        [StringLength(14)]
        public string Cell { get; set; }

        /// <summary>
        /// FAX�ԍ�
        /// </summary>
        [Column("fax")]
        [StringLength(12)]
        public string Fax { get; set; }

        /// <summary>
        /// ���[���A�h���X
        /// </summary>
        [Column("mail")]
        [StringLength(50)]
        public string Mail { get; set; }

        /// <summary>
        /// �z�[���y�[�W
        /// </summary>
        [Column("website")]
        [StringLength(50)]
        public string Website { get; set; }

        /// <summary>
        /// ���ю�敪
        /// </summary>
        [Column("setai_nushi_kbn")]
        [StringLength(1)]
        public string SetaiNushiKbn { get; set; }

        /// <summary>
        /// �g���������i�敪
        /// </summary>
        [Column("kumiaiinto_shikaku_kbn")]
        [StringLength(1)]
        public string KumiaiintoShikakuKbn { get; set; }

        /// <summary>
        /// �g����������o�͋敪
        /// </summary>
        [Column("kumiaiinto_output_kbn")]
        [StringLength(1)]
        public string KumiaiintoOutputKbn { get; set; }

        /// <summary>
        /// �g���������ۋ����ώ��ƃR�[�h
        /// </summary>
        [Column("fukakin_kyosai_jigyo_cd")]
        [StringLength(2)]
        public string FukakinKyosaiJigyoCd { get; set; }

        /// <summary>
        /// �g���������ۋ����ϖړI���R�[�h
        /// </summary>
        [Column("fukakin_kyosai_mokutekito_cd")]
        [StringLength(2)]
        public string FukakinKyosaiMokutekitoCd { get; set; }

        /// <summary>
        /// JA�R�[�h
        /// </summary>
        [Column("ja_cd")]
        [StringLength(4)]
        public string JaCd { get; set; }

        /// <summary>
        /// �Đ����c��R�[�h
        /// </summary>
        [Column("saisei_kyogikai_cd")]
        [StringLength(3)]
        public string SaiseiKyogikaiCd { get; set; }

        /// <summary>
        /// ���ϐV���w�ǋ敪
        /// </summary>
        [Column("kyosai_shinbun_kbn")]
        [StringLength(1)]
        public string KyosaiShinbunKbn { get; set; }

        /// <summary>
        /// �k��BCP�敪
        /// </summary>
        [Column("koshu_bcp_kbn")]
        [StringLength(1)]
        public string KoshuBcpKbn { get; set; }

        /// <summary>
        /// ���|BCP�敪
        /// </summary>
        [Column("engei_bcp_kbn")]
        [StringLength(1)]
        public string EngeiBcpKbn { get; set; }

        /// <summary>
        /// �{�YBCP�敪
        /// </summary>
        [Column("chikusan_bcp_kbn")]
        [StringLength(1)]
        public string ChikusanBcpKbn { get; set; }

        /// <summary>
        /// �����N����
        /// </summary>
        [Column("kanyu_ymd")]
        public DateTime? KanyuYmd { get; set; }

        /// <summary>
        /// �E�ޔN����
        /// </summary>
        [Column("dattai_ymd")]
        public DateTime? DattaiYmd { get; set; }

        /// <summary>
        /// ���S�i���U�j�A����t�N����
        /// </summary>
        [Column("shibo_renraku_ymd")]
        public DateTime? ShiboRenrakuYmd { get; set; }

        /// <summary>
        /// ���S�i���U�j�N����
        /// </summary>
        [Column("shibo_ymd")]
        public DateTime? ShiboYmd { get; set; }

        /// <summary>
        /// �X����Z���t���O
        /// </summary>
        [Column("yusosaki_flg")]
        [StringLength(1)]
        public string YusosakiFlg { get; set; }

        /// <summary>
        /// �����z�z�E���Ή��t���O
        /// </summary>
        [Column("yuso_shokuin_taio_flg")]
        [StringLength(1)]
        public string YusoShokuinTaioFlg { get; set; }

        /// <summary>
        /// �X����X�֔ԍ�
        /// </summary>
        [Column("yuso_postal_cd")]
        [StringLength(7)]
        public string YusoPostalCd { get; set; }

        /// <summary>
        /// �X����Z��
        /// </summary>
        [Column("yuso_address")]
        [StringLength(40)]
        public string YusoAddress { get; set; }

        /// <summary>
        /// �X���掁�����͖@�l��
        /// </summary>
        [Column("yuso_hojin_full_nm")]
        [StringLength(30)]
        public string YusoHojinFullNm { get; set; }

        /// <summary>
        /// �X�����\�Ҏ���
        /// </summary>
        [Column("yuso_daihyosha_nm")]
        [StringLength(30)]
        public string YusoDaihyoshaNm { get; set; }

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
