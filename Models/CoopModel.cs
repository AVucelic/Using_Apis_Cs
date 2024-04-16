using Newtonsoft.Json;

namespace Proj3.Models
{
    public class CoopModel
    {
            public string? employer { get; set; }
            public string? degree { get; set; }
            public string? city { get; set; }
            public string? term { get; set; }

        public static async Task<CoopViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/employment/coopTable");
            return JsonConvert.DeserializeObject<CoopViewModel>(json);
        }
    }

    public class CoopTable
    {
        public string? title { get; set; }
        public List<CoopModel>? coopInformation { get; set; }
    }
}

