import { Component, OnChanges, OnInit, ViewChild } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-enquiry-form',
  templateUrl: './enquiry-form.component.html',
  styleUrls: ['./enquiry-form.component.css']
})
export class EnquiryFormComponent implements OnInit {
  projectBudgetAmt! : number;

  personDetails = new FormGroup(
    {
       pName: new FormControl(""),
       pDesignation: new FormControl("")
    });

  companyDetails = new FormGroup({
    companyName: new FormControl(""),
    companySize: new FormControl("5000"),
    projectBudget: new FormControl("20000000")

  });

  constructor() {
    this.projectBudgetAmt = 50000000;
   }

   ngOnInit(): void {
    this.projectBudgetAmt = this.companyDetails.get("projectBudget")?.value;
   }
  

  showResponse() : void{    
    //alert(this.personDetails.get("pName")?.value + " thanks for getting in touch");    
    this.projectBudgetAmt = this.companyDetails.get("projectBudget")?.value;     
  }

}
