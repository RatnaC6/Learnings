import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { ServicesComponent } from './services/services.component';
import { TopLeadersComponent } from './top-leaders/top-leaders.component';
import { TopLeaderComponent } from './top-leader/top-leader.component';
import { ContactFormComponent } from './contact-form/contact-form.component';
import { ComplaintFormComponent } from './complaint-form/complaint-form.component';
import { EnquiryFormComponent } from './enquiry-form/enquiry-form.component';
import { CostEstimateComponent } from './cost-estimate/cost-estimate.component';
import { ProjectCostService } from './project-cost.service';

var routeList : Routes = [
  { path:"about", component:AboutComponent },
  { path:"contact",component:ContactComponent},
  { path:"services",component:ServicesComponent},
  { path:"leaders",component:TopLeadersComponent},
  { path:"complaint",component:ComplaintFormComponent},
  { path:"enquiry",component:EnquiryFormComponent},
];

@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    ContactComponent,
    ServicesComponent,
    TopLeadersComponent,
    TopLeaderComponent,
    ContactFormComponent,
    ComplaintFormComponent,
    EnquiryFormComponent,
    CostEstimateComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routeList),
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [ProjectCostService],
  bootstrap: [AppComponent]
})
export class AppModule { }
