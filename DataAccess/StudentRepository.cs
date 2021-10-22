
#region Directives
using EF;
using EF.Models;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
#endregion

namespace DataAccess
{
    /// <summary>
    ///  Student Data access repository
    /// </summary>
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        /// <summary>
        ///  Constructer
        /// </summary>
        /// <param name="context"></param>
        public StudentRepository(MarkProcessingContext context)
           : base(context)
        {

        }

        /// <summary>
        ///  Return all active student information
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Student>> LoadAllByYearAsync()
        {
            throw new NotImplementedException();
        }
    }
}
