import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './core/components/navbar/navbar.component';
import { DepartmentComponent } from './features/department/department.component';
import { CompanyComponent } from './features/company/company.component';
import { EmployeeComponent } from './features/employee/employee.component';
import { AddEmployeeComponent } from './features/add-employee/add-employee.component';
import { FormsModule } from '@angular/forms';
import { AddDepartmentComponent } from './features/add-department/add-department.component';
import { AddCompanyComponent } from './features/add-company/add-company.component';
import { HttpClientModule } from '@angular/common/http';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { EmployeeModalComponent } from './features/employee-modal/employee-modal.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    DepartmentComponent,
    CompanyComponent,
    EmployeeComponent,
    AddEmployeeComponent,
    AddDepartmentComponent,
    AddCompanyComponent,
    EmployeeModalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    NgbModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
