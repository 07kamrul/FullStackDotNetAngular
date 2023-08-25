import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddEmployeeRequest } from 'src/app/models/employee-model';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  readonly employeeUrl = 'https://localhost:7247/api/employee/';
    
  constructor(private http: HttpClient) { }

  addEmployee(model: AddEmployeeRequest): Observable<void> {
    return this.http.post<void>(this.employeeUrl + 'SaveEmployee', model);
  }

  getEmployees(): Observable<any> {
    return this.http.get(this.employeeUrl + 'GetEmployees');
  }
}
