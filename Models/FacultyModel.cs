using Newtonsoft.Json; 

namespace Proj3.Models
{
    /// <summary>
    /// Model class representing faculty information.
    /// </summary>
    public class FacultyModel
    {
        /// <summary>
        /// Gets or sets the username of the faculty member.
        /// </summary>
        public string? username { get; set; }

        /// <summary>
        /// Gets or sets the name of the faculty member.
        /// </summary>
        public string? name { get; set; }

        /// <summary>
        /// Gets or sets the tagline of the faculty member.
        /// </summary>
        public string? tagline { get; set; }

        /// <summary>
        /// Gets or sets the image path of the faculty member.
        /// </summary>
        public string? imagePath { get; set; }

        /// <summary>
        /// Gets or sets the title of the faculty member.
        /// </summary>
        public string? title { get; set; }

        /// <summary>
        /// Gets or sets the interest area of the faculty member.
        /// </summary>
        public string? interestArea { get; set; }

        /// <summary>
        /// Gets or sets the office location of the faculty member.
        /// </summary>
        public string? office { get; set; }

        /// <summary>
        /// Gets or sets the website URL of the faculty member.
        /// </summary>
        public string? website { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the faculty member.
        /// </summary>
        public string? phone { get; set; }

        /// <summary>
        /// Gets or sets the email address of the faculty member.
        /// </summary>
        public string? email { get; set; }

        /// <summary>
        /// Gets or sets the Twitter handle of the faculty member.
        /// </summary>
        public string? twitter { get; set; }

        /// <summary>
        /// Gets or sets the Facebook profile link of the faculty member.
        /// </summary>
        public string? facebook { get; set; }

        /// <summary>
        /// Asynchronously retrieves the view model for the faculty page.
        /// </summary>
        /// <returns>The view model for the faculty page.</returns>
        public static async Task<FacultyViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "https://ischool.gccis.rit.edu/api/people/faculty");
            return JsonConvert.DeserializeObject<FacultyViewModel>(json);
        }

    }
}
