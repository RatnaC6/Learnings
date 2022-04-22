import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AffordableProjectsComponent } from './affordable-projects.component';

describe('AffordableProjectsComponent', () => {
  let component: AffordableProjectsComponent;
  let fixture: ComponentFixture<AffordableProjectsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AffordableProjectsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AffordableProjectsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
