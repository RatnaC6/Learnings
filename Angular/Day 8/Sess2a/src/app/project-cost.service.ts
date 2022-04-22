import { Injectable } from '@angular/core';
import { ProjectType } from './project-type';

@Injectable({
  providedIn: 'root'
})
export class ProjectCostService {

  projectTypes : ProjectType[] = [
    {
      type:"Software Development",
      cost:50000000
    },
    {
      type:"Specialized Consulting",
      cost:3000000
    },
    {
      type:"IT Services Management",
      cost:10000000
    },
    {
      type:"Hospital Services Management",
      cost:45000000
    },
    {
      type:"Retail Service Management",
      cost:22000000
    }
  ];
  constructor() { }

  getProjectCosts() : ProjectType[]{
    return this.projectTypes;
  }

  getProjectCost(type : string) : number{
    let cost = 0;
    let i = 0;
    for(i = 0; i < this.projectTypes.length; i++){
      if(this.projectTypes[i].type.toLowerCase() === type.toLowerCase()){
        cost = this.projectTypes[i].cost;
      }
    }
    return cost;
  }

  getProjectsByBudget(budget : number) : ProjectType[]{
    let projectsInBudget : ProjectType[] = [];
    let i = 0;
    for(i = 0; i < this.projectTypes.length; i++){      
      if(this.projectTypes[i].cost <= budget){        
        projectsInBudget.push(this.projectTypes[i]);
      }      
    }    
    return projectsInBudget;
  }
}
