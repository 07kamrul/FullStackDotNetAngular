using AutoMapper;
using FullStackDotNetAngular.Models;
using FullStackDotNetAngular.Repositories;
using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;

namespace FullStackDotNetAngular.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IMapper mapper, IDepartmentRepository departmentRepository)
        {
            _mapper = mapper;
            _departmentRepository = departmentRepository;
        }

        public List<DepartmentResponseModel> GetDepartments()
        {
            var department = _departmentRepository.GetDepartments();
            return _mapper.Map<List<DepartmentResponseModel>>(department);
        }

        public DepartmentResponseModel SaveDepartment(DepartmentRequestModel departmentRequest)
        {
            var dept = _mapper.Map<Department>(departmentRequest);
            var department = _departmentRepository.SaveDepartment(dept);
            return _mapper.Map<DepartmentResponseModel>(department);
        }
    }
}
