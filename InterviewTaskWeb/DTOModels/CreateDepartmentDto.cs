using System.ComponentModel.DataAnnotations;

namespace InterviewTaskWeb.DTOModels
{
    public class CreateDepartmentDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int CompanyId { get; set; }
    }
}