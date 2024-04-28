using static Proj3.Models.GraduateModel;

namespace Proj3.Models
{
    /// <summary>
    /// View model class for representing graduate program data.
    /// </summary>
    public class GraduateViewModel
    {
        /// <summary>
        /// Gets or sets the array of graduate programs.
        /// </summary>
        public GraduateModel[]? graduate { get; set; }
    }
}
