using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SurveyProject.Models;
using SurveyProject.Services;

namespace SurveyProject.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly SurveyService _surveyService;

        public ResultsModel(SurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        public List<Survey> surveys { get; set; }

        public void OnGet()
        {
            surveys = _surveyService.Surveys.ToList();
        }
    }
}
