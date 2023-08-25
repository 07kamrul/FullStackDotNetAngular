import { Component } from '@angular/core';
import { CompanyResponse } from 'src/app/models/company-model';
import { CompanyService } from 'src/app/services/company-service/company.service';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent {

  constructor(private companyService : CompanyService) { }
  
  companies! : CompanyResponse[];

  ngOnInit(){
    this.getCompanyList();
  }

  getCompanyList(){
    this.companyService.getCompanies().subscribe(
      (response : any) => {
        this.companies = response;
      }
    )
  }
}
