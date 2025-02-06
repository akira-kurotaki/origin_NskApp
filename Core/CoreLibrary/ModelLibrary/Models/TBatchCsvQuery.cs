using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �o�b�`CSV�擾����
    /// </summary>
    [Serializable]
    [Table("t_batch_csv_query")]
    [PrimaryKey(nameof(BatchId), nameof(SerialNumber))]
    public class TBatchCsvQuery : ModelBase
    {
        /// <summary>
        /// �o�b�`ID
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("batch_id", Order = 1)]
        public long BatchId { get; set; }

        /// <summary>
        /// �A��
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("serial_number", Order = 2)]
        public int SerialNumber { get; set; }

        /// <summary>
        /// �����Ώ�
        /// </summary>
        [Required]
        [Column("target_entity")]
        [StringLength(100)]
        public string TargetEntity { get; set; }

        /// <summary>
        /// ���������iSQL�j
        /// </summary>
        [Required]
        [Column("query_condition")]
        public string QueryCondition { get; set; }

        /// <summary>
        /// ���������i�p�����[�^�j
        /// </summary>
        [Required]
        [Column("query_param")]
        public string QueryParam { get; set; }

        /// <summary>
        /// ���я�
        /// </summary>
        [Required]
        [Column("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// �����R�[�h
        /// </summary>
        [Required]
        [Column("character_cd")]
        [StringLength(1)]
        public string CharacterCd { get; set; }

        /// <summary>
        /// CSV�t�@�C����
        /// </summary>
        [Required]
        [Column("csv_file_name")]
        [StringLength(100)]
        public string CsvFileName { get; set; }

        /// <summary>
        /// �w�b�_�L��
        /// </summary>
        [Required]
        [Column("header_umu")]
        [StringLength(1)]
        public string HeaderUmu { get; set; }

        /// <summary>
        /// �w�b�_�����񃊃X�g
        /// </summary>
        [Column("header_list")]
        public string HeaderList { get; set; }

        /// <summary>
        /// �Z�p���[�^�[
        /// </summary>
        [Required]
        [Column("separator")]
        [StringLength(1)]
        public string Separator { get; set; }

        /// <summary>
        /// BOM�R�[�h�L��
        /// </summary>
        [Required]
        [Column("bom_cd_umu")]
        [StringLength(1)]
        public string BomCdUmu { get; set; }

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
