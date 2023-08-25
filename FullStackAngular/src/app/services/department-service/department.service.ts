import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddDepartmentRequest } from 'src/app/models/department-model';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  readonly departmentUrl = 'https://localhost:7247/api/department/';
    
  constructor(private http: HttpClient) { }

  addDepartment(model: AddDepartmentRequest): Observable<void> {
    return this.http.post<void>(this.departmentUrl + 'SaveDepartment', model);
  }

  getDepartments(): Observable<any> {
    return this.http.get(this.departmentUrl+'GetDepartments');
  }
}
