
using System.Threading.Tasks;

namespace IDataAccess
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository();
        Task SaveAsync();
        ValueTask DisposeAsync();
    }
}
