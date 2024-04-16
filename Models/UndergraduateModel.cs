using Newtonsoft.Json;

namespace Proj3.Models
{
    public class UndergraduateModel
    {



            public string? degreeName { get; set; }
            public string? title { get; set; }
            public string? description { get; set; }
            public string[]? concentrations { get; set; }

        public static async Task<UndergraduateViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/degrees/undergraduate");
            return JsonConvert.DeserializeObject<UndergraduateViewModel>(json);
        }


    }
}
