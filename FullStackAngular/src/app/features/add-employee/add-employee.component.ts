import { Component } from '@angular/core';
import { CompanyResponse } from 'src/app/models/company-model';
import { DepartmentResponse } from 'src/app/models/department-model';
import { AddEmployeeRequest } from 'src/app/models/employee-model';
import { CompanyService } from 'src/app/services/company-service/company.service';
import { DepartmentService } from 'src/app/services/department-service/department.service';
import { EmployeeService } from 'src/app/services/employee-service/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent {

  employeemodel: AddEmployeeRequest;
  departmentModel: DepartmentResponse;
  companyModel: CompanyResponse;

  departments! : DepartmentResponse[];
  companies! : CompanyResponse[];

  ngOnInit(){
    this.getDepartmentList();
    this.getCompanyList();
  }

  constructor(private employeeService: EmployeeService,
    private departmentService: DepartmentService,
    private companyService: CompanyService)
    {
    this.employeemodel = {
      empCode: 0,
      name: '',
      phoneNo: '',
      address: '',
      departmentName: '',
      companyName: '',
      isApproved: 0
    };

    this.departmentModel = {
      id: 0,
      departmentName:''
    };

    this.companyModel = {
      id: 0,
      companyName:''
    };

  }
  
  changeDepartmentName(value : any){
    this.employeemodel.departmentName = value.target.value;
  }

  changeCompanyName(value : any){
    this.employeemodel.companyName = value.target.value;
  }

  getDepartmentList(){
    this.departmentService.getDepartments().subscribe(
      (response : any) => {
        this.departments = response;
      }
    )
  }

  getCompanyList(){
    this.companyService.getCompanies().subscribe(
      (response: any) => {
        this.companies = response;
      }
    )
  }

  employeeSubmit(){
    this.employeeService.addEmployee(this.employeemodel)
    .subscribe({
      next:(response)=>{
        console.log('This was successfull!')
      }
    })
  }
  
}
