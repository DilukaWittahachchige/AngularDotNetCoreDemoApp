
namespace IDataAccess
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository();
        void Save();
        void Dispose();
    }
}
