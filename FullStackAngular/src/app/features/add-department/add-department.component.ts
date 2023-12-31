import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AddDepartmentRequest } from 'src/app/models/department-model';
import { DepartmentService } from 'src/app/services/department-service/department.service';

@Component({
  selector: 'app-add-department',
  templateUrl: './add-department.component.html',
  styleUrls: ['./add-department.component.css']
})
export class AddDepartmentComponent {

  departmentModel: AddDepartmentRequest;

  constructor(
    private departmentService : DepartmentService,
    private router : Router
    ){
    this.departmentModel = {
      id: 0,
      departmentName: ''
    };
  }

  departmentSubmit(){
    this.departmentService.addDepartment(this.departmentModel)
    .subscribe({
      next:(response)=>{
        console.log('This was successfull!');
        this.router.navigate(['/', 'department']);

      }
    })
  }
}
