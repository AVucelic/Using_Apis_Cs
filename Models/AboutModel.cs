using Newtonsoft.Json;

namespace Proj3.Models
{

        public class AboutModel
        {
            public string? title { get; set; }
            public string? description { get; set; }
            public string? quote { get; set; }
            public string? quoteAuthor { get; set; }

        public static async Task<AboutModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/about");
            return JsonConvert.DeserializeObject<AboutModel>(json);
        }
    }

    
}