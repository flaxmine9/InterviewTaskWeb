using InterviewTaskWeb.DataBase.Interfaces;
using InterviewTaskWeb.DataBase.Models;

namespace InterviewTaskWeb.DataBase.Services
{
    public class CompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(IUnitOfWork unitOfWork)
        {
            // Во всех нижеописанных методах обращаемся через _unitOfWork
            _unitOfWork = unitOfWork;
        }

        #region Компании
        public Task<IEnumerable<Company>> GetAllCompaniesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompanyWithDepartmentsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddCompanyAsync(Company company)
        {
            throw new NotImplementedException();
        }

        // Удаление
        public Task DeleteCompanyAsync(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Департаменты
        public Task AddDepartmentAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public Task MoveDepartmentAsync(int departmentId, int newCompanyId)
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetDepartmentWithCompanyAsync(int departmentId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Отделы
        public Task AddOtdelAsync(Otdel otdel)
        {
            throw new NotImplementedException();
        }

        public Task MoveOtdelAsync(int otdelId, int newDepartmentId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}