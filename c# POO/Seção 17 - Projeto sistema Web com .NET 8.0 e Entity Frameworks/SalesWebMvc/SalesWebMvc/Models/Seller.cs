using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} required")]
        [StringLength(60,MinimumLength = 3,ErrorMessage ="{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid {0}")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>(); 
        public Seller()
        {

        }

        public Seller(int id,string name,string email,DateTime birthDate,Department department,double baseSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Department = department;
            BaseSalary = baseSalary;
        }
        public void AddSales(SalesRecord sales) {
            Sales.Add(sales);
        }
        public void RemoveSales(SalesRecord sales)
        {
            Sales.Remove(sales);
        }
        public double TotalSales(DateTime initial,DateTime final)
        {
            var Total = Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(x=> x.Amount);
            return Total;
        }
    }
}
