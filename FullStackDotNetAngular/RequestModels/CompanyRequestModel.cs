using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackDotNetAngular.RequestModels
{
    public class CompanyRequestModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
    }
}
