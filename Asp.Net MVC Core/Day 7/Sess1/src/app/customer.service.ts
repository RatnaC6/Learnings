import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Customer } from './customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private httpClient : HttpClient) { }

  getCustomers() {
    return this.httpClient.get<Customer[]>("https://localhost:44315/api/customers",{
      headers:{"Access_Control-Allow-Origin":"*"}
    });
  }

  addCustomer(customer : Customer){
    this.httpClient.post("https://localhost:44315/api/customers",customer,{
      headers:{"Access_Control-Allow-Origin":"*"}
    }).subscribe((customer) => {
        //alert((<Customer>customer).name);
        console.log(<Customer>customer);
      });
  }
}
