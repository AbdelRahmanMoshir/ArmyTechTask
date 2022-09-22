namespace ArmyTech.Data.Entities
{
    public class InvoiceDetails
    {
        public Int64 ID { get; set; }
        public string ItemName { get; set; }
        public double ItemCount { get; set; }
        public double ItemPrice { get; set; }
        public InvoiceHeader invoiceHeader { get; set; }
        public Int64 InvoiceHeaderID { get; set; }
    }
}
