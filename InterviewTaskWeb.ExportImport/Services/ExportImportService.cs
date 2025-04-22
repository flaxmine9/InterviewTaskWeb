using InterviewTaskWeb.DataBase.Interfaces;
using InterviewTaskWeb.ExportImport.Interfaces;

namespace InterviewTaskWeb.ExportImport.Services
{
    public class ExportImportService : IExportImport
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExportImportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<string> ExportToXmlAsync()
        {
            // Получем необходимые данные из базы данных
            // Записываем в xml формат

            throw new NotImplementedException();
        }

        public Task ImportFromXmlAsync(string xml)
        {
            // Считываем xml формат
            // записываем в базу данных

            throw new NotImplementedException();
        }
    }
}