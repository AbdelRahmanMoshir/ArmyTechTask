namespace ArmyTech.Data.Entities
{
    public class Cashier
    {
        public int ID { get; set; }
        public string CashierName { get; set; }
        public Branches Branch { get; set; }
        public int BranchID { get; set; }
    }
}
