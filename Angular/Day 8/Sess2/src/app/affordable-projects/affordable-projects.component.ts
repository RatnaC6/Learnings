import { Component, OnInit, Inject, Input } from '@angular/core';
import { ProjectCostService } from '../project-cost.service';
import { ProjectType } from '../project-type';

@Inject(ProjectCostService)
@Component({
  selector: 'app-affordable-projects',
  templateUrl: './affordable-projects.component.html',
  styleUrls: ['./affordable-projects.component.css']
})
export class AffordableProjectsComponent implements OnInit {

  projectsInBudget! : ProjectType[];
  @Input() budget!:number;

  constructor(private projectCostService : ProjectCostService) {
    
   }

  ngOnInit(): void {
    this.projectsInBudget = this.projectCostService.getProjectsByBudget(this.budget);
  }



}
