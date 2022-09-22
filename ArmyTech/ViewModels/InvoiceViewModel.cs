using ArmyTech.Data.Entities;

namespace ArmyTech.ViewModels
{
    public class InvoiceViewModel
    {
        public InvoiceHeader invoiceHeader { get; set; }
        public List<InvoiceDetails> invoiceDetails { get; set; }

        public double TotalPrice { get; set; }


    }

}
