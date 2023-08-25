import { Component } from '@angular/core';
import { DepartmentResponse } from 'src/app/models/department-model';
import { DepartmentService } from 'src/app/services/department-service/department.service';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css']
})
export class DepartmentComponent {

  constructor(private departmentService : DepartmentService) { }
  
  departments! : DepartmentResponse[];

  ngOnInit(){
    this.getDepartmentList();
  }

  getDepartmentList(){
    this.departmentService.getDepartments().subscribe(
      (response : any) => {
        this.departments = response;
      }
    )
  }
}
