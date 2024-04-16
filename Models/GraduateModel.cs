using Newtonsoft.Json;

namespace Proj3.Models
{
    public class GraduateModel
    {



            public string? degreeName { get; set; }
            public string? title { get; set; }
            public string? description { get; set; }
            public string[]? concentrations { get; set; }
            public string[]? availableCertificates { get; set; }

        public static async Task<GraduateViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/degrees/graduate");
            return JsonConvert.DeserializeObject<GraduateViewModel>(json);
        }
    }
}
