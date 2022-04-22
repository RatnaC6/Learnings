import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { Router, Routes, RouterModule} from '@angular/router';

import { AppComponent } from './app.component';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductsService } from './products.service';
import { EmployeeListComponent } from './employee-list/employee-list.component';
import { EmployeeService } from './employee.service';
import { CustomersService } from './customers.service';
import { CustomerListComponent } from './customer-list/customer-list.component';

const routes: Routes = [
{path:"products",component:ProductListComponent},
{path:"employees",component:EmployeeListComponent},
{path:"customers", component:CustomerListComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    ProductListComponent,
    EmployeeListComponent,
    CustomerListComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(routes)
  ],
  providers: [ProductsService,EmployeeService,CustomersService],
  bootstrap: [AppComponent]
})
export class AppModule { }
