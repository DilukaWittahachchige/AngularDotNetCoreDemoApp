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