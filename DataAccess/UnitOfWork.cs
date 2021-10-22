using EF;
using IDataAccess;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private MarkProcessingContext context = new MarkProcessingContext(new DbContextOptions<MarkProcessingContext>());
        private readonly IStudentRepository _studentRepository;
 
        public UnitOfWork(
            IStudentRepository studentRepository
            )
        {
            this._studentRepository = studentRepository;
        }

        public IStudentRepository StudentRepository()
        {
            return this._studentRepository;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        ///  Object management / Garbage collection 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
