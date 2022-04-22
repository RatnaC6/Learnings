import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { ServicesComponent } from './services/services.component';
import { TopLeadersComponent } from './top-leaders/top-leaders.component';
import { LeaderComponent } from './leader/leader.component';

var routeList : Routes = [
  { path:"about", component:AboutComponent },
  { path:"contact",component:ContactComponent},
  { path:"services",component:ServicesComponent},
  { path:"leaders",component:TopLeadersComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    ContactComponent,
    ServicesComponent,
    TopLeadersComponent,
    LeaderComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routeList),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
