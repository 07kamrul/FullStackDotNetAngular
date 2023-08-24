using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackDotNetAngular.Models
{
    [Table("Company")]
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
    }
}
