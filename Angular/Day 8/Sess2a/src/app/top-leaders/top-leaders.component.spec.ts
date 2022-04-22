import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TopLeadersComponent } from './top-leaders.component';

describe('TopLeadersComponent', () => {
  let component: TopLeadersComponent;
  let fixture: ComponentFixture<TopLeadersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TopLeadersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TopLeadersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
