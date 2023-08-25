import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddDepartmentRequest } from 'src/app/models/add-department-request-model';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  constructor(private http: HttpClient) { }

  addDepartment(model: AddDepartmentRequest): Observable<void> {
    return this.http.post<void>('https://localhost:7247/api/department/SaveDepartment', model);
  }
}
