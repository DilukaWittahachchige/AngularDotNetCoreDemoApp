import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType } from 'chart.js';
import { Label,  monkeyPatchChartJsLegend,  monkeyPatchChartJsTooltip,  SingleDataSet } from 'ng2-charts';
import { IStudentModel } from '../../models/student.model';
import { StudentInfoService } from '../../services/student-info.service';

@Component({
  selector: 'app-student-info-dashboard',
  templateUrl: './student-info-dashboard.component.html',
  styleUrls: ['./student-info-dashboard.component.scss']
})
export class StudentInfoDashboardComponent implements OnInit {
 studentInfo: IStudentModel[] = [];
 
 public pieChartOptions: ChartOptions = {
  responsive: true,
};
pieChartLabels: Label[] = [['Download', 'Sales'], ['In', 'Store', 'Sales'], 'Mail Sales'];
pieChartData: SingleDataSet = [300, 500, 100];
pieChartType: ChartType = 'pie';
pieChartLegend = true;
pieChartPlugins = [];

  constructor(
    private courseService: StudentInfoService,
  ) { 
    monkeyPatchChartJsTooltip();
    monkeyPatchChartJsLegend();
  }

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
