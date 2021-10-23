import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: "student-dashboard",
    loadChildren: () =>
      import("./student-dashboard/student-dashboard.module").then(m => m.StudentDashboardModule)
  },
];

@NgModule({
  imports: [
   RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: []
})
export class AppRoutingModule { }
