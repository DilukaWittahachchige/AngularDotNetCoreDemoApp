import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentInfoDashboardComponent } from './student-info-dashboard/student-info-dashboard.component';



@NgModule({
  declarations: [
    StudentInfoDashboardComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    StudentInfoDashboardComponent
  ]
})
export class StudentDashboardModule { }
