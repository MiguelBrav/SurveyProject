using SurveyProject.Models;

namespace SurveyProject.Services
{
    public class SurveyService
    {
        public List<Survey>? Surveys { get; set; } = new List<Survey>();

        public void Add(Survey survey)
        {
            Surveys.Add(survey);
        }
    }
}
