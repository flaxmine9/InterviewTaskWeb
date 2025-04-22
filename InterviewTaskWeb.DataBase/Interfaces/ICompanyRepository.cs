using InterviewTaskWeb.DataBase.Models;

namespace InterviewTaskWeb.DataBase.Interfaces
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<IEnumerable<Department>> GetCompanyDepartmentsAsync(int companyId);
    }
}