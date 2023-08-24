using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackDotNetAngular.Models
{
    [Table("Department")]
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
