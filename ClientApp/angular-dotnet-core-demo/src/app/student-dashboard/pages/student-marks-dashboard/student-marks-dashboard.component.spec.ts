import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentMarksDashboardComponent } from './student-marks-dashboard.component';

describe('StudentMarksDashboardComponent', () => {
  let component: StudentMarksDashboardComponent;
  let fixture: ComponentFixture<StudentMarksDashboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentMarksDashboardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentMarksDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
