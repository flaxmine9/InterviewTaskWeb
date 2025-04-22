namespace InterviewTaskWeb.DataBase.Models
{
    public class Company
    {
        // Или можно использовать GUID, int просто для примера
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty; // Уникальный код компании
        public IEnumerable<Department> Departments { get; set; } = [];
    }
}