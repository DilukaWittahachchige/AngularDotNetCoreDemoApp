export interface IStudentModel {
  studentId: number;
  givenName: string;
  surname: string;
  gender: string;
  studentPhoneNumber: string;
  studentEmailAddress: string;
  studentNRIC: string;
  studentDateOfBirth: Date;
  isActive: boolean;
  isDeleted: boolean;
  createdUserId: Date;
  updatedUserId: Date;
  createdDateTime: Date;
}
