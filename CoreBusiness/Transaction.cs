using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        [Required]
        public int? ReceiptsId2 { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } // in case product name changes
        public double Price { get; set; }
        public int BeforeQty { get; set; }
        public int SoldQty { get; set; }
        public string CashierName { get; set; }
        public int CashierId { get; set; }
        public string Visa { get; set; }

        public Receipts Receipts { get; set; }
    }
}
