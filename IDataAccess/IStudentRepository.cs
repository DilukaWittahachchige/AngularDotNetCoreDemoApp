using EF.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IDataAccess
{
    /// <summary>
    ///  Student interface 
    /// </summary>
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<IEnumerable<Student>> LoadAllByYearAsync();
    }
}