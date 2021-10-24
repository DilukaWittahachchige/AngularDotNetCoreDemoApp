import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType } from 'chart.js';
import { Label,  monkeyPatchChartJsLegend,  monkeyPatchChartJsTooltip,  SingleDataSet } from 'ng2-charts';
import { IStudentAgeCategoryModel } from '../../models/student-category.model';
import { IStudentModel } from '../../models/student.model';
import { StudentInfoService } from '../../services/student-info.service';

@Component({
  selector: 'app-student-info-dashboard',
  templateUrl: './student-info-dashboard.component.html',
  styleUrls: ['./student-info-dashboard.component.scss']
})
export class StudentInfoDashboardComponent implements OnInit {
 studentInfo: IStudentModel[] = [];
 studentAgeCategoryInfo: IStudentAgeCategoryModel = {
   studentAgeCategoryCount: [],
   studentAgeCategory: []
 };
 
 public pieChartOptions: ChartOptions = {
  responsive: true,
};
pieChartLabels: Label[] = [];
pieChartData: SingleDataSet = [];
pieChartType: ChartType = 'pie';
pieChartLegend = true;
pieChartPlugins = [];

public pieChartColors: Array < any > = [{
  backgroundColor: ['rgba(255, 99, 132, 0.2)',
  'rgba(54, 162, 235, 0.2)',
  'rgba(255, 206, 86, 0.2)',
  'rgba(75, 192, 192, 0.2)',
  'rgba(153, 102, 255, 0.2)',
  'rgba(255, 159, 64, 0.2)'],
  borderColor: ['rgba(255, 99, 132, 0.2)',
  'rgba(54, 162, 235, 0.2)',
  'rgba(255, 206, 86, 0.2)',
  'rgba(75, 192, 192, 0.2)',
  'rgba(153, 102, 255, 0.2)',
  'rgba(255, 159, 64, 0.2)']
}];


  constructor(
    private studentService: StudentInfoService,
  ) { 
    monkeyPatchChartJsTooltip();
    monkeyPatchChartJsLegend();
   
  }

  ngOnInit(): void {
     this.getstudent();
     this.getStudentAgeCategoryInfo();
  }
  
  getstudent() {
    this.studentService.getStudentInfo().subscribe(
      studentInfo => {
        this.studentInfo = studentInfo;
      },
      error => {
        console.log(error);
      }
    );
  }

  getStudentAgeCategoryInfo()
  {
    this.studentService.getStudentAgeCategoryInfo().subscribe(
      studentAgeCategoryInfo => {
        this.studentAgeCategoryInfo = studentAgeCategoryInfo;
        this.pieChartLabels = this.studentAgeCategoryInfo.studentAgeCategory;
        this.pieChartData = this.studentAgeCategoryInfo.studentAgeCategoryCount;
      },
      error => {
        console.log(error);
      }
    );
  }

}
