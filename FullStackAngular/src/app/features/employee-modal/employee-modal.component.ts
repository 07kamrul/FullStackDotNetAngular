import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { CompanyResponse } from 'src/app/models/company-model';
import { DepartmentResponse } from 'src/app/models/department-model';
import { EmployeeRequest, EmployeeResponse } from 'src/app/models/employee-model';
import { CompanyService } from 'src/app/services/company-service/company.service';
import { DepartmentService } from 'src/app/services/department-service/department.service';
import { EmployeeService } from 'src/app/services/employee-service/employee.service';

@Component({
  selector: 'app-employee-modal',
  templateUrl: './employee-modal.component.html',
  styleUrls: ['./employee-modal.component.css']
})
export class EmployeeModalComponent implements OnInit {

  employee!: EmployeeResponse;
  
  empForm!: FormGroup;
  departmentList!: Array<DepartmentResponse>;
  companyList!: Array<CompanyResponse>;

  constructor(
    private formBuilder: FormBuilder,
    private activeModal: NgbActiveModal,
    private employeeService: EmployeeService,
    private departmentService: DepartmentService,
    private companyService: CompanyService
  ){

    
  }

  ngOnInit(): void {    
    this.empForm = this.formBuilder.group({
      empCode: [],
      name: [],
      phoneNo: [],
      address: [],
      departmentName: [],
      companyName: []
    });

    this.departmentService.getDepartments().subscribe(
      (response : any) => {
        this.departmentList = response;
      }
    );

    this.companyService.getCompanies().subscribe(
      (response : any) => {
        this.companyList = response;
      }
    );
  }

  ngAfterViewInit(){
    this.employeeService.getEmployee(this.employee.empCode)
      .subscribe( x => {
        this.employee = x;
        this.getEmpFC;
        this.empForm.get('empCode')?.setValue(this.employee.empCode);
        this.empForm.get('name')?.setValue(this.employee.name);
        this.empForm.get('phoneNo')?.setValue(this.employee.phoneNo);
//this.departmentList.filter(d => d.departmentName.includes(this.employee.departmentName))        
        this.empForm.get('departmentName')?.setValue('abc');
        this.empForm.get('companyName')?.setValue(this.employee.companyName);
      })
  }

  get getEmpFC() {
    console.log(this.empForm.controls);
    return this.empForm.controls;
  }

  changeDepartment(value: any){
    this.employee.departmentName = value.target.value;
  }

  changeCompany(value: any){
    this.employee.companyName = value.target.value;
  }

  closeModal() {
    this.activeModal.close();
  }
}
