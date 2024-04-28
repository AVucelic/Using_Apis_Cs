using static Proj3.Models.FacultyModel;

namespace Proj3.Models
{
    /// <summary>
    /// View model class for representing faculty data.
    /// </summary>
    public class FacultyViewModel
    {
        /// <summary>
        /// Gets or sets the array of faculty members.
        /// </summary>
        public FacultyModel[]? faculty { get; set; }
    }
}
