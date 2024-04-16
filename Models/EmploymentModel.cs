using Newtonsoft.Json;

namespace Proj3.Models
{
    public class EmploymentModel
    {
            public string? employer { get; set; }
            public string? degree { get; set; }
            public string? city { get; set; }
            public string? title { get; set; }
            public string? startDate { get; set; }

        public static async Task<EmploymentViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/employment/employmentTable");
            return JsonConvert.DeserializeObject<EmploymentViewModel>(json);
        }

    }

    public class EmploymentTable
    {
        public string? title { get; set; }
        public List<EmploymentModel>? professionalEmploymentInformation { get; set; }
    }
}
