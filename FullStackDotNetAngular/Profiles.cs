using AutoMapper;
using FullStackDotNetAngular.Models;
using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;

namespace FullStackDotNetAngular
{
    public class Profiles : Profile
    {
        public Profiles() 
        { 
            CreateMap<Employee, EmployeeRequestModel>().ReverseMap();
            CreateMap<Employee, EmployeeResponseModel>().ReverseMap();

            CreateMap<Department, DepartmentRequestModel>().ReverseMap();
            CreateMap<Department, DepartmentResponseModel>().ReverseMap();

            CreateMap<Company, CompanyRequestModel>().ReverseMap();
            CreateMap<Company, CompanyResponseModel>().ReverseMap();
        }
    }
}
