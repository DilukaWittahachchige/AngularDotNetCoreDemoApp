import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ChartsModule } from "ng2-charts";
import { StudentInfoDashboardComponent } from "./pages/student-info-dashboard/student-info-dashboard.component";

const routes: Routes = [
  {
    path: "info",
    component: StudentInfoDashboardComponent
  },
 
];

@NgModule({
  imports: [
    RouterModule.forChild(routes),
    ChartsModule],
  exports: [RouterModule]
})
export class StudentDashboardRoutingModule {}