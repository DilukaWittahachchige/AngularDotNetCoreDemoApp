import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentInfoDashboardComponent } from './student-info-dashboard.component';

describe('StudentInfoDashboardComponent', () => {
  let component: StudentInfoDashboardComponent;
  let fixture: ComponentFixture<StudentInfoDashboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentInfoDashboardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentInfoDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
