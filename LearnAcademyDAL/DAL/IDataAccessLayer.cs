
namespace LearnAcademy.DAL
{
    public interface IDataAccessLayer
    {
        void CloseConnection();
        void OpenConnection();
        Task OpenConnectionAsync();
    }
}