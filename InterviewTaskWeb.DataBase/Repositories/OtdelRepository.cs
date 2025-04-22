using InterviewTaskWeb.DataBase.Interfaces;
using InterviewTaskWeb.DataBase.Models;

namespace InterviewTaskWeb.DataBase.Repositories
{
    public class OtdelRepository : BaseRepository<Otdel>, IOtdelRepository
    {
        public OtdelRepository(CompanyContext context) : base(context)
        {
        }

        public Task MoveOtdelAsync(int otdelId, int newDepartmentId)
        {
            throw new NotImplementedException();
        }
    }
}