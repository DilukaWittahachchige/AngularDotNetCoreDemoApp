using EF;
using IDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork : IAsyncDisposable, IUnitOfWork
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

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual async Task DisposeAsync(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    await context.DisposeAsync();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        ///  Object management / Garbage collection 
        /// </summary>
        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);
            GC.SuppressFinalize(this);
        }
    }
}
