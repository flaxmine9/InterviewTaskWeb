namespace InterviewTaskWeb.DTOModels
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<DepartmentDto> Departments { get; set; } = [];
    }
}
