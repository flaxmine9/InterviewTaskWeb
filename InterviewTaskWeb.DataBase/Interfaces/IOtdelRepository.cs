using InterviewTaskWeb.DataBase.Models;

namespace InterviewTaskWeb.DataBase.Interfaces
{
    public interface IOtdelRepository : IRepository<Otdel>
    {
        Task MoveOtdelAsync(int otdelId, int newDepartmentId);
    }
}