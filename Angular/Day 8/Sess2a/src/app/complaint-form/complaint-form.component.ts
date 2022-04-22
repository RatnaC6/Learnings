import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-complaint-form',
  templateUrl: './complaint-form.component.html',
  styleUrls: ['./complaint-form.component.css']
})
export class ComplaintFormComponent implements OnInit {

  public pName = new FormControl("");
  public pMessage = new FormControl("");

  constructor() { }

  ngOnInit(): void {
  }

  showResponse():void{
    alert(this.pName.value + " thanks for sharing your issue with us. \r\n"+
                        "We will get back to you within 2 working days");
  }

}
