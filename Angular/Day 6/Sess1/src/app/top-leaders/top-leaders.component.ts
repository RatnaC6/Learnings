import { Component, OnInit } from '@angular/core';
import { TopLeader } from '../top-leader';

@Component({
  selector: 'app-top-leaders',
  templateUrl: './top-leaders.component.html',
  styleUrls: ['./top-leaders.component.css']
})
export class TopLeadersComponent implements OnInit {

  topLeaders : TopLeader[] = [
    {
      id:1, name:"abc",designation:"ceo"
    },
    {
      id:2, name:"pqr", designation:"coo"
    }
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
