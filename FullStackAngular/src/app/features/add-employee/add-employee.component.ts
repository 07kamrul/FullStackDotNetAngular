import { Component } from '@angular/core';
import { AddEmployeeRequest } from 'src/app/models/add-employee-request-model';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent {

  employeemodel: AddEmployeeRequest;

  constructor(){
    this.employeemodel = {
      name: '',
      phoneno: '',
      address: '',
      departmentname: '',
      companyname: ''
    };
  }
  onFormSubmit(){
    
  }
}
