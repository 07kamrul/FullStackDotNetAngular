import { Component } from '@angular/core';
import { EmployeeResponse } from 'src/app/models/employee-model';
import { EmployeeService } from 'src/app/services/employee-service/employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent {

  constructor(private employeeService : EmployeeService) { }
  
  employees! : EmployeeResponse[];

  ngOnInit(){
    this.getEmployeeList();
  }

  getEmployeeList(){
    this.employeeService.getEmployees().subscribe(
      (response : any) => {
        console.log(response);
        this.employees = response;
      }
    )
  }
}
