using InterviewTaskWeb.DataBase.Models;

namespace InterviewTaskWeb.DataBase.Interfaces
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Task<IEnumerable<Otdel>> GetDepartmentOtdelAsync(int departmentId);
        Task MoveDepartmentAsync(int departmentId, int newCompanyId);
    }
}