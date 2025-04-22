using System.ComponentModel.DataAnnotations;

namespace InterviewTaskWeb.DTOModels
{
    public class MoveOtdelDto
    {
        [Required]
        public int NewDepartmentId { get; set; }
    }
}