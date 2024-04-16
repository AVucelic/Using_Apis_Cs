using Newtonsoft.Json;

namespace Proj3.Models
{
    public class NewsModel
    {
        public string? Date { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public static async Task<NewsViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/news");
            return JsonConvert.DeserializeObject<NewsViewModel>(json);
        }
    }
}
