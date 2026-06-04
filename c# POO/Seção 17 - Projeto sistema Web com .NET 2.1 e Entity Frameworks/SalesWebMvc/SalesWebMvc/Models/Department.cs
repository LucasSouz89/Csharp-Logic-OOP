namespace SalesWebMvc.Models
{
    public class Department
    {
        public string Name { get;set; }

        public int ID { get;set; }

        public Department()
        {
            
        }
        public Department(string name, int iD)
        {
            Name = name;
            ID = iD;
        }
    }
}
