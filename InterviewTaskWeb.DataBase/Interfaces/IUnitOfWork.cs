namespace InterviewTaskWeb.DataBase.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companies { get; }
        IDepartmentRepository Departments { get; }
        IOtdelRepository Otdels { get; }
    }
}