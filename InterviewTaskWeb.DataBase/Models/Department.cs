namespace InterviewTaskWeb.DataBase.Models
{
    public class Department
    {
        // Или можно использовать GUID, int просто для примера
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        public int CompanyId { get; set; }
        public Company? Company { get; set; }

        public IEnumerable<Otdel> Otdels { get; set; } = [];
    }
}