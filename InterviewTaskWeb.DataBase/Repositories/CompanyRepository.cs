using InterviewTaskWeb.DataBase.Interfaces;
using InterviewTaskWeb.DataBase.Models;

namespace InterviewTaskWeb.DataBase.Repositories
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(CompanyContext context) : base(context)
        {
        }

        public Task<IEnumerable<Department>> GetCompanyDepartmentsAsync(int companyId)
        {
            throw new NotImplementedException();
        }
    }
}