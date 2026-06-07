namespace SalesWebMvc.Models
{
    public class Department
    {
        public string Name { get;set; }

        public int Id { get;set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public Department()
        {
            
        }
        public Department(string name, int iD)
        {
            Name = name;
            Id = iD;
        }
        public void AddSeller(Seller seller) => Sellers.Add(seller);
        
        
        public double TotalSales(DateTime initial,DateTime final)
        {
            var sum = Sellers.Sum(x=> x.TotalSales(initial,final));
            return sum;
        }
    }
}
