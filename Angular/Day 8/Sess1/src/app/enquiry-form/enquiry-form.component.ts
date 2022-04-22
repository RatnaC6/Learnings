import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-enquiry-form',
  templateUrl: './enquiry-form.component.html',
  styleUrls: ['./enquiry-form.component.css']
})
export class EnquiryFormComponent implements OnInit {

  personDetails = new FormGroup(
    {
       pName: new FormControl(""),
       pDesignation: new FormControl("")
    });

  companyDetails = new FormGroup({
    companyName: new FormControl(""),
    companySize: new FormControl("5000"),
    projectBudget: new FormControl("1000000")

  });

  constructor() { }

  ngOnInit(): void {
  }

  showResponse() : void{
    //Use the FormControl to get the value of 
    alert(this.personDetails.get("pName")?.value + " thanks for getting in touch");
  }

}
