using Newtonsoft.Json;

namespace Proj3.Models
{
    /// <summary>
    /// Model class representing employment information.
    /// </summary>
    public class EmploymentModel
    {
        /// <summary>
        /// Gets or sets the name of the employer.
        /// </summary>
        public string? employer { get; set; }

        /// <summary>
        /// Gets or sets the degree obtained during employment.
        /// </summary>
        public string? degree { get; set; }

        /// <summary>
        /// Gets or sets the city where the employment took place.
        /// </summary>
        public string? city { get; set; }

        /// <summary>
        /// Gets or sets the job title.
        /// </summary>
        public string? title { get; set; }

        /// <summary>
        /// Gets or sets the start date of the employment.
        /// </summary>
        public string? startDate { get; set; }

        /// <summary>
        /// Asynchronously retrieves the view model for the employment page.
        /// </summary>
        /// <returns>The view model for the employment page.</returns>
        public static async Task<EmploymentViewModel?> GetViewModelAsync()
        {
            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/employment/employmentTable");
            return JsonConvert.DeserializeObject<EmploymentViewModel>(json);
        }
    }

    /// <summary>
    /// Model class representing a table of employment information.
    /// </summary>
    public class EmploymentTable
    {
        /// <summary>
        /// Gets or sets the title of the employment table.
        /// </summary>
        public string? title { get; set; }

        /// <summary>
        /// Gets or sets the list of professional employment information.
        /// </summary>
        public List<EmploymentModel>? professionalEmploymentInformation { get; set; }
    }
}
