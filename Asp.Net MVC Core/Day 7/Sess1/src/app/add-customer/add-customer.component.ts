import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { CustomerService } from '../customer.service';
import { Customer } from '../customer';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-add-customer',
  templateUrl: './add-customer.component.html',
  styleUrls: ['./add-customer.component.css']
})
export class AddCustomerComponent implements OnInit {

  customerForm = new FormGroup({
    customerName: new FormControl(""),
    customerAddress: new FormControl("")
  });


  constructor(private httpClient : HttpClient, private customerService : CustomerService) { }

  ngOnInit(): void {
  }

  saveChanges(){
    var customer:Customer = {     
      address : this.customerForm.get("customerAddress")?.value,
      name : this.customerForm.get("customerName")?.value,
    };
    //alert(customer.name +" being added");
    this.customerService.addCustomer(customer);
  }

}
