using System.ComponentModel.DataAnnotations;

namespace InterviewTaskWeb.DTOModels
{
    public class CreateOtdelDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int DepartmentId { get; set; }
    }
}