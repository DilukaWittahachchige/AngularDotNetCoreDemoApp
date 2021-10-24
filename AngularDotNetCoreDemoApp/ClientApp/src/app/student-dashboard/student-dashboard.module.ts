import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentInfoDashboardComponent } from './pages/student-info-dashboard/student-info-dashboard.component';
import { StudentMarksDashboardComponent } from './pages/student-marks-dashboard/student-marks-dashboard.component';
import { StudentDashboardRoutingModule } from './student-dashboard-routing.module';
import { ChartsModule } from 'ng2-charts';

@NgModule({
  declarations: [
    StudentInfoDashboardComponent,
    StudentMarksDashboardComponent
  ],
  imports: [
       CommonModule,
       StudentDashboardRoutingModule,
       ChartsModule
      ]
  })
export class StudentDashboardModule { }
