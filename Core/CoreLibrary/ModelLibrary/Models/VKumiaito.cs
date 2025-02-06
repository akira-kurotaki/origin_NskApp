using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �g�����}�X�^
    /// </summary>
    [Serializable]
    [Table("v_kumiaito")]
    [PrimaryKey(nameof(TodofukenCd), nameof(KumiaitoCd))]
    public class VKumiaito
    {
        /// <summary>
        /// �s���{���R�[�h
        /// </summary>
        [Required]
        [Column("todofuken_cd", Order = 1)]
        [StringLength(2)]
        public string TodofukenCd { get; set; }

        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("kumiaito_cd", Order = 2)]
        [StringLength(3)]
        public string KumiaitoCd { get; set; }

        /// <summary>
        /// �g������������
        /// </summary>
        [Required]
        [Column("kumiaito_nm")]
        [StringLength(25)]
        public string KumiaitoNm { get; set; }

        /// <summary>
        /// �g��������
        /// </summary>
        [Column("kumiaito_rnm")]
        [StringLength(12)]
        public string KumiaitoRnm { get; set; }

        /// <summary>
        /// �X�֔ԍ�
        /// </summary>
        [Column("postal_cd")]
        [StringLength(7)]
        public string PostalCd { get; set; }

        /// <summary>
        /// �Z��
        /// </summary>
        [Column("address")]
        [StringLength(40)]
        public string Address { get; set; }

        /// <summary>
        /// �d�b�ԍ�
        /// </summary>
        [Column("tel")]
        [StringLength(13)]
        public string Tel { get; set; }

        /// <summary>
        /// FAX�ԍ�
        /// </summary>
        [Column("fax")]
        [StringLength(12)]
        public string Fax { get; set; }

        /// <summary>
        /// �g��������
        /// </summary>
        [Column("kumiaitocho_nm")]
        [StringLength(12)]
        public string KumiaitochoNm { get; set; }

        /// <summary>
        /// ��\�Җ�E��
        /// </summary>
        [Column("daihyosha_yaku_nm")]
        [StringLength(12)]
        public string DaihyoshaYakuNm { get; set; }

        /// <summary>
        /// ��\�Ҏ���
        /// </summary>
        [Column("daihyosha_nm")]
        [StringLength(30)]
        public string DaihyoshaNm { get; set; }

        /// <summary>
        /// �C���{�C�X�o�^�ԍ�
        /// </summary>
        [Column("invoice_no")]
        [StringLength(14)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// �_�ѐ��Y��b��
        /// </summary>
        [Column("norinsuisan_daijin_nm")]
        [StringLength(12)]
        public string NorinsuisanDaijinNm { get; set; }

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
