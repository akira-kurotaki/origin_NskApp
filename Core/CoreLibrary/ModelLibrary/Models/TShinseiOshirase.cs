using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary.Models
{
    /// <summary>
    /// �\�����m�点
    /// </summary>
    [Serializable]
    [Table("t_shinsei_oshirase")]
    [PrimaryKey(nameof(NogyoshaId), nameof(OshiraseDate))]
    public class TShinseiOshirase : ModelBase
    {
        /// <summary>
        /// �_�Ǝ�ID
        /// </summary>
        [Required]
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("nogyosha_id", Order = 1)]
        public int NogyoshaId { get; set; }

        /// <summary>
        /// ���m�点���t
        /// </summary>
        [Required]
        //[Key]
        [Column("oshirase_date", Order = 2)]
        public DateTime OshiraseDate { get; set; }

        /// <summary>
        /// �\�����m�点���e
        /// </summary>
        [Column("shinsei_ohirase_naiyo")]
        [StringLength(1000)]
        public string ShinseiOhiraseNaiyo { get; set; }
    }
}
