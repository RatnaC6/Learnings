import { Component, Input, OnInit } from '@angular/core';
import { TopLeader } from '../top-leader';

@Component({
  selector: 'app-leader',
  templateUrl: './leader.component.html',
  styleUrls: ['./leader.component.css']
})
export class LeaderComponent implements OnInit {

  @Input() topLeader! : TopLeader;
  constructor() { }

  ngOnInit(): void {
  }

}
