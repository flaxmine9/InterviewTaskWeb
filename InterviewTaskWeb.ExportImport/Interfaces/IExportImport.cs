namespace InterviewTaskWeb.ExportImport.Interfaces
{
    public interface IExportImport
    {
        Task<string> ExportToXmlAsync();
        Task ImportFromXmlAsync(string xml);
    }
}