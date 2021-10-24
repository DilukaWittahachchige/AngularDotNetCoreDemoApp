using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        Task<IEnumerable<StudentDto>> LoadAllActiveAsync();

        /// <summary>
        ///  Load studnet age category info
        /// </summary>
        /// <returns></returns>
        Task<StudentAgeCategoryDto> LoadAgeCategoryInfoAsync();
    }
}