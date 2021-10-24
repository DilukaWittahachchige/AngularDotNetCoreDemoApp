import { Inject, Injectable } from '@angular/core'; 
import {
  HttpClient, HttpParams,
} from "@angular/common/http";
import { catchError } from "rxjs/operators";
import { Observable } from "rxjs";
import { ErrorService } from 'src/app/core/services/error.service';
import { IStudentModel } from "../models/student.model";
import { IStudentAgeCategoryModel } from '../models/student-category.model';

@Injectable({
  providedIn: 'root',
})
export class StudentInfoService {
  baseUrl = "https://localhost:44320/"
  studentUrl: string = "";
   
  constructor(
    private http: HttpClient,
    private errorService: ErrorService,
  ) {
    this.studentUrl = `${this.baseUrl}api/student`;
  }

  getStudentInfo(): Observable<IStudentModel[]> {
    this.errorService;
    return this.http
      .get<IStudentModel[]>(`${this.studentUrl}/all-available`)
      .pipe(catchError(this.errorService.handleError));
  }

  getStudentAgeCategoryInfo(): Observable<IStudentAgeCategoryModel> {
    this.errorService;
    return this.http
      .get<IStudentAgeCategoryModel>(`${this.studentUrl}/age-category`)
      .pipe(catchError(this.errorService.handleError));
  }

}
 

