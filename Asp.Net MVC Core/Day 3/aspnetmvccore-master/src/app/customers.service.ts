import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Icustomers } from './icustomers';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomersService {

  constructor(private httpClient : HttpClient) { }

  getAllCustomers() : Observable<Icustomers>{
    return this.httpClient.get<Icustomers>("https://localhost:44379/Customers/GetAllCustomers",
    {
      headers : {"Access-Control-Allow-Origin":"*"}
    }
  );
}
}