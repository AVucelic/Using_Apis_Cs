using Newtonsoft.Json;

namespace Proj3.Models
{
    /// <summary>
    /// Model class representing cooperative education information.
    /// </summary>
    public class CoopModel
    {
        /// <summary>
        /// Gets or sets the name of the employer.
        /// </summary>
        public string? employer { get; set; }

        /// <summary>
        /// Gets or sets the degree obtained during cooperative education.
        /// </summary>
        public string? degree { get; set; }

        /// <summary>
        /// Gets or sets the city where the cooperative education took place.
        /// </summary>
        public string? city { get; set; }

        /// <summary>
        /// Gets or sets the term of the cooperative education.
        /// </summary>
        public string? term { get; set; }

        /// <summary>
        /// Asynchronously retrieves the view model for the cooperative education page.
        /// </summary>
        /// <returns>The view model for the cooperative education page.</returns>
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

