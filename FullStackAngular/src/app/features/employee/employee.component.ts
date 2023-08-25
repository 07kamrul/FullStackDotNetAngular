import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { EmployeeResponse } from 'src/app/models/employee-model';
import { EmployeeService } from 'src/app/services/employee-service/employee.service';

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

  employeeDetails(_employeeCode: any){
    this.employeeCode = _employeeCode;
    //this.employeeModal.empCode = this.formValue.value.empCode;
  }

  open(content : any) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      console.log(result);
      console.log(content);
    }, (reason) => {

    });
  }
  
}
