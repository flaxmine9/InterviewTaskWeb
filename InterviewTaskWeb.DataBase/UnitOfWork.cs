using InterviewTaskWeb.DataBase.Interfaces;
using InterviewTaskWeb.DataBase.Repositories;

namespace InterviewTaskWeb.DataBase
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CompanyContext _context;
        public ICompanyRepository Companies { get; }
        public IDepartmentRepository Departments { get; }
        public IOtdelRepository Otdels { get; }

        public UnitOfWork(CompanyContext context)
        {
            _context = context;

            Companies = new CompanyRepository(context);
            Departments = new DepartmentRepository(context);
            Otdels = new OtdelRepository(context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}