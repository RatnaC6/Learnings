import { Component, OnInit, Inject } from '@angular/core';
import { ProjectCostService } from '../project-cost.service';
import { ProjectType } from '../project-type';
import { FormsModule } from '@angular/forms';

@Inject(ProjectCostService)
@Component({
  selector: 'app-cost-estimate',
  templateUrl: './cost-estimate.component.html',
  styleUrls: ['./cost-estimate.component.css']
})
export class CostEstimateComponent implements OnInit {

  projectTypes : ProjectType[] = [];
  selectedProjectCost! : number;

  constructor(private projectCostService : ProjectCostService) {
    this.projectTypes = projectCostService.getProjectCosts();
   }

  ngOnInit(): void {
  }

  getProjectCost(): void{

  }

}
