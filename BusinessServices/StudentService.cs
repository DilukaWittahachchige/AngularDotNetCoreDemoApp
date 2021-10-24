using Domain;
using EF.Models;
using IBusinessServices;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class StudentService : IStudentService
    {
        /// <summary>
        ///   IUnitOfWork 
        /// </summary>
        private readonly IUnitOfWork _unityOfWork;

        /// <summary>
        ///  Student Service Constructer
        /// </summary>
        /// <param name="unityOfWork"></param>
        public StudentService(IUnitOfWork unityOfWork)
        {
            this._unityOfWork = unityOfWork;
        }

        /// <summary>
        ///  Load All Active studnets info
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<StudentDto>> LoadAllActiveAsync()
        {
            try
            {
                // Filter active student records 
                var studentList = new List<StudentDto>();
                var data = await this._unityOfWork.StudentRepository().GetAsync();
                var dataList = data.Where(x => x.IsActive == true).ToList();

                dataList.ForEach(x =>
                {
                    studentList.Add(ConvertToDomain(x));
                });

                return studentList;
            }
            catch (Exception ex)
            {
                //TODO: Global exception handling 
                throw ex.InnerException;
            }
        }

        public async Task<StudentAgeCategoryDto> LoadAgeCategoryInfoAsync()
        {
            try
            {
                // Filter active student records 
                var ageList =  new List<int>();
                var studentAgeCategoryInfo = new StudentAgeCategoryDto();
                var studentList = new List<StudentDto>();
                var data = await this._unityOfWork.StudentRepository().GetAsync();
                var dataList = data.Where(x => x.IsActive == true).ToList();

                dataList.ForEach(x =>
                {
                    // Save today's date.
                    var today = DateTime.Today;

                    // Calculate the age.
                    var age = today.Year - x.StudentDateOfBirth.Year;

                    // Go back to the year in which the person was born in case of a leap year
                    if (x.StudentDateOfBirth > today.AddYears(-age)) age--;

                    ageList.Add(age);
                });

                studentAgeCategoryInfo.StudentAgeCategoryCount = this.LoadStudentAgeCategoryCount(ageList);
                //TODO: Enum 
                studentAgeCategoryInfo.StudentAgeCategory =  new string[]
                {
                    "Age below 25", 
                    "Age between 25 to 30", 
                    "Age between 30 to 35", 
                    "Age between 35 to 40",
                    "Age above 40",
                };

                return studentAgeCategoryInfo;
            }
            catch (Exception ex)
            {
                //TODO: Global exception handling 
                throw ex.InnerException;
            }
        }

        private int[] LoadStudentAgeCategoryCount(List<int> ageList)
        {
            var studentAgeCategoryCount = new int[5];
            int ageBelow25 = 0, age25to30 = 0, age30to35 = 0, age35to40 = 0, ageAbove40 = 0;

            ageList.ToList().ForEach(x=>{
                switch (x)
                {
                    case < 25:
                           ageBelow25++; break;
                    case < 30:
                           age25to30++; break;
                    case < 35:
                           age30to35++; break;
                    case < 40:
                           age35to40++; break;
                    default:
                           ageAbove40++; break;
                }
            });

            studentAgeCategoryCount.SetValue(ageBelow25, 0);
            studentAgeCategoryCount.SetValue(age25to30, 1);
            studentAgeCategoryCount.SetValue(age30to35, 2);
            studentAgeCategoryCount.SetValue(age35to40, 3);
            studentAgeCategoryCount.SetValue(ageAbove40, 4);
            return studentAgeCategoryCount;
        }
        /// <summary>
        ///  Entity models to domain models convert 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static StudentDto ConvertToDomain(Student obj)
        {
            if (obj == null)
            {
                return new StudentDto();
            }

            return new StudentDto()
            {
                StudentId = obj.StudentId,
                GivenName = obj.GivenName,
                Surname = obj.Surname,
                Gender = obj.Gender,
                StudentPhoneNumber = obj.StudentPhoneNumber,
                StudentEmailAddress = obj.StudentEmailAddress,
                StudentNRIC = obj.StudentNRIC,
                StudentDateOfBirth = obj.StudentDateOfBirth,
                IsActive = obj.IsActive,
                IsDeleted = obj.IsDeleted,
                CreatedUserId = obj.CreatedUserId,
                UpdatedUserId = obj.UpdatedUserId,
                CreatedDateTime = obj.CreatedDateTime,
                UpdatedDateTime = obj.UpdatedDateTime,
            };
        }
    }
}