namespace SalesWebMvc.Models
{
    public class Department
    {
        public string Name { get; private set; }

        public int ID { get;private set; }

        public Department(string name, int iD)
        {
            Name = name;
            ID = iD;
        }
    }
}
