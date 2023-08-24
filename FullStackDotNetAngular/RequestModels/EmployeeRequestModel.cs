using FullStackDotNetAngular.RequestModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackDotNetAngular.RequestModels
{
    public class EmployeeRequestModel
    {
        public int EmpCode { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string DepartmentName { get; set; }
        public string CompanyName { get; set; }
        public int IsApproved { get; set; }
    }
}
