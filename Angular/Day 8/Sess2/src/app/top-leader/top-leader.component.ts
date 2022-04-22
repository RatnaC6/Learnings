import { Component, Input, OnInit } from '@angular/core';
import { TopLeader } from '../top-leader';

@Component({
  selector: 'app-top-leader',
  templateUrl: './top-leader.component.html',
  styleUrls: ['./top-leader.component.css']
})
export class TopLeaderComponent implements OnInit {

  @Input() topLeader! : TopLeader;
  constructor() { }

  ngOnInit(): void {
  }

}
