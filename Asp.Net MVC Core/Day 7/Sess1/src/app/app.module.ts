import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import {HttpClientModule} from '@angular/common/http';
import {ReactiveFormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { CustomerListComponent } from './customer-list/customer-list.component';
import { CustomerService } from './customer.service';
import { AddCustomerComponent } from './add-customer/add-customer.component';

const routes:Routes = [
  {path:"customers",component:CustomerListComponent},
  {path:"addCustomer",component:AddCustomerComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    CustomerListComponent,
    AddCustomerComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [CustomerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
