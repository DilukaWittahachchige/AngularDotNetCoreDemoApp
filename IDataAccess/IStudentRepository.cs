using EF.Models;
using System.Collections.Generic;

namespace IDataAccess
{
    /// <summary>
    ///  Student interface 
    /// </summary>
    public interface IStudentRepository : IGenericRepository<Student>
    {
        IEnumerable<Student> LoadAllByYear();
    }
}