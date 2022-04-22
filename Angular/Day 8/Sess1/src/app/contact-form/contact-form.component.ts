import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.component.html',
  styleUrls: ['./contact-form.component.css']
})
export class ContactFormComponent implements OnInit {

  public pName : string = "";
  public pPhone: string = "";
  public pLocation: string = "";
  public pMessage: string = "";

  constructor() {
    
   }

  ngOnInit(): void {
  }

  showResponse() : void{
    alert(this.pName + " thanks for your message!");
  }

}
