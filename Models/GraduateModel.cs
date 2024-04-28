using Newtonsoft.Json;

namespace Proj3.Models
{
    /// <summary>
    /// Model class representing graduate program information.
    /// </summary>
    public class GraduateModel
    {
        /// <summary>
        /// Gets or sets the name of the graduate degree.
        /// </summary>
        public string? degreeName { get; set; }

        /// <summary>
        /// Gets or sets the title of the graduate program.
        /// </summary>
        public string? title { get; set; }

        /// <summary>
        /// Gets or sets the description of the graduate program.
        /// </summary>
        public string? description { get; set; }

        /// <summary>
        /// Gets or sets the array of concentrations available in the graduate program.
        /// </summary>
        public string[]? concentrations { get; set; }

        /// <summary>
        /// Gets or sets the array of available certificates in the graduate program.
        /// </summary>
        public string[]? availableCertificates { get; set; }

        /// <summary>
        /// Asynchronously retrieves the view model for the graduate program page.
        /// </summary>
        /// <returns>The view model for the graduate program page.</returns>
        public static async Task<GraduateViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/degrees/graduate");
            return JsonConvert.DeserializeObject<GraduateViewModel>(json);
        }
    }
}
