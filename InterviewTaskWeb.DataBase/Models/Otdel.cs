namespace InterviewTaskWeb.DataBase.Models
{
    public class Otdel
    {
        // Или можно использовать GUID, int просто для примера
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}