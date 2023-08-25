import { Component } from '@angular/core';
import { AddDepartmentRequest } from 'src/app/models/add-department-request-model';
import { DepartmentService } from 'src/app/services/department-service/department.service';

@Component({
  selector: 'app-add-department',
  templateUrl: './add-department.component.html',
  styleUrls: ['./add-department.component.css']
})
export class AddDepartmentComponent {

  departmentModel: AddDepartmentRequest;

  constructor(private departmentService: DepartmentService){
    this.departmentModel = {
      id: 0,
      department_name: ''
    };
  }
  onFormSubmit(){
    this.departmentService.addDepartment(this.departmentModel)
    .subscribe({
      next:(response)=>{
        console.log('This was successfull!')
      }
    })
  }
}
