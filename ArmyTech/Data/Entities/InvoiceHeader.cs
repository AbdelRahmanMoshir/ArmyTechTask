using System;

namespace ArmyTech.Data.Entities
{
    public class InvoiceHeader
    {
        public Int64 ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime  Invoicedate { get; set; }
        public Cashier Cashier { get; set; }
        public int CashierID { get; set; }
        public Branches Branch { get; set; }
        public int BranchID { get; set; }
    }
}
