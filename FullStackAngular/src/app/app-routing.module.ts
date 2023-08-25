import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeComponent } from './features/employee/employee.component';
import { AddEmployeeComponent } from './features/add-employee/add-employee.component';
import { DepartmentComponent } from './features/department/department.component';
import { AddDepartmentComponent } from './features/add-department/add-department.component';
import { CompanyComponent } from './features/company/company.component';
import { AddCompanyComponent } from './features/add-company/add-company.component';

const routes: Routes = [
  {
    path: 'employee',
    component:EmployeeComponent
  },
  {
    path: 'employee/add',
    component: AddEmployeeComponent
  },
  {
    path: 'department',
    component: DepartmentComponent
  },
  {
    path: 'department/add',
    component: AddDepartmentComponent
  },
  {
    path: 'company',
    component: CompanyComponent
  },
  {
    path: 'company/add',
    component: AddCompanyComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
