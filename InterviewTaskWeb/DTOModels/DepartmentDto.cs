namespace InterviewTaskWeb.DTOModels
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CompanyId { get; set; }
        public List<OtdelDto> Otdels { get; set; } = [];
    }
}