import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddCompanyRequest } from 'src/app/models/company-model';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  readonly companyUrl = 'https://localhost:7247/api/company/';
    
  constructor(private http: HttpClient) { }

  addCompany(model: AddCompanyRequest): Observable<void> {
    return this.http.post<void>(this.companyUrl + 'SaveCompany', model);
  }

  getCompanies(): Observable<any> {
    return this.http.get(this.companyUrl + 'GetCompanies');
  }}
