using Newtonsoft.Json;

namespace Proj3.Models
{
    /// <summary>
    /// Model class representing information about the project.
    /// </summary>
    public class AboutModel
    {
        /// <summary>
        /// Gets or sets the title of the project.
        /// </summary>
        public string? title { get; set; }

        /// <summary>
        /// Gets or sets the description of the project.
        /// </summary>
        public string? description { get; set; }

        /// <summary>
        /// Gets or sets a quote related to the project.
        /// </summary>
        public string? quote { get; set; }

        /// <summary>
        /// Gets or sets the author of the quote related to the project.
        /// </summary>
        public string? quoteAuthor { get; set; }

        /// <summary>
        /// Asynchronously retrieves the view model for the about page.
        /// </summary>
        /// <returns>The view model for the about page.</returns>
        public static async Task<AboutModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/about");
            return JsonConvert.DeserializeObject<AboutModel>(json);
        }
    }

    
}