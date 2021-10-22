using Domain;
using System.Collections.Generic;

namespace IBusinessServices
{
    /// <summary>
    ///   Student Service interface 
    /// </summary>
    public interface IStudentService
    {
        /// <summary>
        ///  Load All Active student information 
        /// </summary>
        /// <returns></returns>
        IEnumerable<StudentDto> LoadAllActive();
    }
}