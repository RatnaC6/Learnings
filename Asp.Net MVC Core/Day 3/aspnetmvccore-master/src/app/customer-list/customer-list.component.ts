import { Component, Inject, OnInit } from '@angular/core';
import { CustomersService } from '../customers.service';
import { Icustomers } from '../icustomers';

@Inject(CustomersService)

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {

  customers : Icustomers[] = [];
  constructor(private customerService : CustomersService) { }

  ngOnInit(): void {
    this.customerService.getAllCustomers().subscribe((data : any) => {
      let i=0;
      for(;i<data.length;i++){
        this.customers.push({ Name:data[i].customerName, Title:data[i].customerTitle, CompanyName:data[i].company});
      }
    });
  }

}
