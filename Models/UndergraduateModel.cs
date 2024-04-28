using Newtonsoft.Json;

namespace Proj3.Models
{
    /// <summary>
    /// Model class representing undergraduate program information.
    /// </summary>
    public class UndergraduateModel
    {
        /// <summary>
        /// Gets or sets the name of the undergraduate degree.
        /// </summary>
        public string? degreeName { get; set; }

        /// <summary>
        /// Gets or sets the title of the undergraduate program.
        /// </summary>
        public string? title { get; set; }

        /// <summary>
        /// Gets or sets the description of the undergraduate program.
        /// </summary>
        public string? description { get; set; }

        /// <summary>
        /// Gets or sets the array of concentrations available in the undergraduate program.
        /// </summary>
        public string[]? concentrations { get; set; }

        /// <summary>
        /// Asynchronously retrieves the view model for the undergraduate program page.
        /// </summary>
        /// <returns>The view model for the undergraduate program page.</returns>

        public static async Task<UndergraduateViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/degrees/undergraduate");
            return JsonConvert.DeserializeObject<UndergraduateViewModel>(json);
        }


    }
}
