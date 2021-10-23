import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentInfoDashboardComponent } from './pages/student-info-dashboard/student-info-dashboard.component';
import { StudentMarksDashboardComponent } from './pages/student-marks-dashboard/student-marks-dashboard.component';
import { StudentDashboardRoutingModule } from './student-dashboard-routing.module';

@NgModule({
  declarations: [
    StudentInfoDashboardComponent,
    StudentMarksDashboardComponent
  ],
  imports: [
       CommonModule,
       StudentDashboardRoutingModule
      ]
  })
export class StudentDashboardModule { }
