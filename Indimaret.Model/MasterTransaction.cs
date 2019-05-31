using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{

    [Table("trx_mastertransaksi")]
        public class MasterTransaction
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ID { get; set; } //cara instant ketik prop kemudian tab 2x

            [Key]
            [Column(TypeName ="VARCHAR")]
            [StringLength(20)]
            [Required(AllowEmptyStrings = false)]
            public string NoFaktur { get; set; }

            [Column(TypeName = "Date")]
            [Required(AllowEmptyStrings = false)]
            public DateTime TransactionDate { get; set; }

            [Required(AllowEmptyStrings = false)]
            public int Total { get; set; }

            [Required(AllowEmptyStrings = false)]
            public int CashReturn { get; set; }

    }
}
