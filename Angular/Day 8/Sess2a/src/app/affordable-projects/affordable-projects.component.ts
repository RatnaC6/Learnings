import { Component, OnInit, Inject, Input, OnChanges, SimpleChanges } from '@angular/core';
import { ProjectCostService } from '../project-cost.service';
import { ProjectType } from '../project-type';
import { Observable } from 'rxjs';

@Inject(ProjectCostService)
@Component({
  selector: 'app-affordable-projects',
  templateUrl: './affordable-projects.component.html',
  styleUrls: ['./affordable-projects.component.css']
})
export class AffordableProjectsComponent implements OnChanges, OnInit {

  projectsInBudget! : ProjectType[];
  @Input() budget!:number;

  constructor(private projectCostService : ProjectCostService) {    
   }

   ngOnInit(): void {
     //Fetch data when the page is loaded
     this.loadProjects();                
   }

  ngOnChanges(changes: SimpleChanges): void {
    //Fetch data when the user input changes
    this.loadProjects();
  }

  loadProjects() : void{  
    //Get the data from the service  
    this.projectsInBudget = this.projectCostService.getProjectsByBudget(this.budget);       
  }
}
