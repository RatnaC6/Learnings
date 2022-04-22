import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CostEstimateComponent } from './cost-estimate.component';

describe('CostEstimateComponent', () => {
  let component: CostEstimateComponent;
  let fixture: ComponentFixture<CostEstimateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CostEstimateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CostEstimateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
