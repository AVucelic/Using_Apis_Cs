using Newtonsoft.Json;

namespace Proj3.Models
{
    public class FacultyModel
    {
            public string? username { get; set; }
            public string? name { get; set; }
            public string? tagline { get; set; }
            public string? imagePath { get; set; }
            public string? title { get; set; }
            public string? interestArea { get; set; }
            public string? office { get; set; }
            public string? website { get; set; }
            public string? phone { get; set; }
            public string? email { get; set; }
            public string? twitter { get; set; }
            public string? facebook { get; set; }

        public static async Task<FacultyViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/people/faculty");
            return JsonConvert.DeserializeObject<FacultyViewModel>(json);
        }

    }
}
