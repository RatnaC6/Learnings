import { TestBed } from '@angular/core/testing';

import { ProjectCostService } from './project-cost.service';

describe('ProjectCostService', () => {
  let service: ProjectCostService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProjectCostService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
