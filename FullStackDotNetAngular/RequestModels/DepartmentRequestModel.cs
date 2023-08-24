using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackDotNetAngular.RequestModels
{
    public class DepartmentRequestModel
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
