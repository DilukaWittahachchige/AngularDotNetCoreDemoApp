using Domain;
using EF.Models;
using IBusinessServices;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public IEnumerable<StudentDto> LoadAllActive()
        {
            try
            {
                // Filter active student records 
                var roomList = new List<StudentDto>();
                var data = this._unityOfWork.StudentRepository().Get()
                               .ToList().Where(x => x.IsActive == true);

                data.ToList().ForEach(x =>
                {
                    roomList.Add(ConvertToDomain(x));
                });

                return roomList;
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