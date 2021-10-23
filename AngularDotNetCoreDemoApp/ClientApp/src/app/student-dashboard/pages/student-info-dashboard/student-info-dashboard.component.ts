import { Component, OnInit } from '@angular/core';
import { IStudentModel } from '../../models/student.model';
import { StudentInfoService } from '../../services/student-info.service';

@Component({
  selector: 'app-student-info-dashboard',
  templateUrl: './student-info-dashboard.component.html',
  styleUrls: ['./student-info-dashboard.component.scss']
})
export class StudentInfoDashboardComponent implements OnInit {
 studentInfo: IStudentModel[] = [];

  constructor(
    private courseService: StudentInfoService,
  ) { }

  ngOnInit(): void {
     this.getCourse();
  }


  getCourse() {
    this.courseService.getStudentInfo().subscribe(
      studentInfo => {
        this.studentInfo = studentInfo;
      },
      error => {
        console.log(error);
      }
    );
  }

}
