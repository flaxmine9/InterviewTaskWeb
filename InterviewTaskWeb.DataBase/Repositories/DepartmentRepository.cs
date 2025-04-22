using InterviewTaskWeb.DataBase.Interfaces;
using InterviewTaskWeb.DataBase.Models;

namespace InterviewTaskWeb.DataBase.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(CompanyContext context) : base(context)
        {
        }

        public Task<IEnumerable<Otdel>> GetDepartmentOtdelAsync(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task MoveDepartmentAsync(int departmentId, int newCompanyId)
        {
            throw new NotImplementedException();
        }
    }
}