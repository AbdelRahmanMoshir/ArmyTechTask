namespace ArmyTech.Data.Entities
{
    public class Branches
    {
        public int ID { get; set; }
        public string BranchName { get; set; }

        public Cities City { get; set; }

        public int CityID { get; set; }
    }
}
