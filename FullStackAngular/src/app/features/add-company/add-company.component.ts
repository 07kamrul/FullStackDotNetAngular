import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AddCompanyRequest } from 'src/app/models/company-model';
import { CompanyService } from 'src/app/services/company-service/company.service';

@Component({
  selector: 'app-add-company',
  templateUrl: './add-company.component.html',
  styleUrls: ['./add-company.component.css']
})
export class AddCompanyComponent {

  companyModel: AddCompanyRequest;

  constructor(
    private companyService : CompanyService,
    private router: Router )
    {
    this.companyModel = {
      id: 0,
      companyName: ''
    };
  }

  companySubmit(){
    this.companyService.addCompany(this.companyModel)
    .subscribe({
      next:(response)=>{
        console.log('This was successfull!');
        this.router.navigate(['/', 'company']);
      }
    })
  }
}
