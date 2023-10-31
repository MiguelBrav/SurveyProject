using System.ComponentModel.DataAnnotations;

namespace SurveyProject.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public bool IsTrue { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
    }
}
