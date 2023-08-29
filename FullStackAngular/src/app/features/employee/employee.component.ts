import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { EmployeeRequest, EmployeeResponse } from 'src/app/models/employee-model';
import { EmployeeService } from 'src/app/services/employee-service/employee.service';
import { EmployeeModalComponent } from '../employee-modal/employee-modal.component';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent {

  constructor(private employeeService : EmployeeService,
    private modalService: NgbModal,
    private formbuilder: FormBuilder) { }
  
  employees! : EmployeeResponse[];
  employeeModal! : EmployeeResponse;
  formValue! : FormGroup;
  employeeCode!: number;

  ngOnInit(){
    this.getEmployeeList();
    this.formValue = this.formbuilder.group({
      empCode: ['']
    })
  }

  getEmployeeList(){
    this.employeeService.getEmployees().subscribe(
      (response : any) => {
        console.log(response);
        this.employees = response;
      }
    )
  }

  getEmployee(empCode: any){
    this.employeeService.getEmployee(empCode).subscribe(
      (response : any) => {
        this.employeeModal = response;
      }
    )
  }

  employeeDetails(_employeeCode: any){
    this.employeeCode = _employeeCode;
  }
  

  open(emp: EmployeeResponse) {
    const modalRef = this.modalService.open(EmployeeModalComponent);
    // console.log(emp);
    modalRef.componentInstance.employee = emp;

    modalRef.result.then((employee: EmployeeRequest) => {
      if (employee) {
       // console.log(employee);
      }
    });
  }
}
