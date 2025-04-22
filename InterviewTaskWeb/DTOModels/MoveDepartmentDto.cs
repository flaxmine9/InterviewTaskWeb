using System.ComponentModel.DataAnnotations;

namespace InterviewTaskWeb.DTOModels
{
    public class MoveDepartmentDto
    {
        [Required]
        public int NewCompanyId { get; set; }
    }
}