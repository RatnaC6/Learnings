import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TopLeaderComponent } from './top-leader.component';

describe('TopLeaderComponent', () => {
  let component: TopLeaderComponent;
  let fixture: ComponentFixture<TopLeaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TopLeaderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TopLeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
