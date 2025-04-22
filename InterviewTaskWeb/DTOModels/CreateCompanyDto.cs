using System.ComponentModel.DataAnnotations;

namespace InterviewTaskWeb.DTOModels
{
    public class CreateCompanyDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}