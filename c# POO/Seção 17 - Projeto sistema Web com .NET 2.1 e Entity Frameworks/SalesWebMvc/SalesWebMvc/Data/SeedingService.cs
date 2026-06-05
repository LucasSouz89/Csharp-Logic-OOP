using SalesWebMvc.Models;
using SalesWebMvc.Models.Enuns;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return; // DB has been seeded
            }
            Department d1 = new Department("Computers",1);
            Department d2 = new Department("Eletronics", 2);
            Department d3 = new Department("Fashion",3);
            Department d4 = new Department("Books",4);

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), d1, 1000.0);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), d2, 3500.0);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15),d1, 2200.0);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30),d4, 3000.0);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9),d3, 4000.0);
            Seller s6 = new Seller(6, "Alex Pink", "alexpink@gmail.com", new DateTime(1997, 3, 4),d2, 3000.0);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2026, 05, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2026, 05, 26), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2026, 05, 25), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2026, 05, 28), 8000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4,s5,s6);
            _context.SalesRecords.AddRange(r1, r2, r3, r4);

            _context.SaveChanges();
        }
    }
}
