using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SurveyProject.Models;
using SurveyProject.Services;

namespace SurveyProject.Pages
{
    public class SurveyModel : PageModel
    {
        private readonly SurveyService _surveyService;

        public SurveyModel(SurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        [BindProperty]
        public Survey Survey { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _surveyService.Add(Survey);
            return RedirectToPage("Thanks");
        }
    }
}
