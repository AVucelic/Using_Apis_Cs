using static Proj3.Models.UndergraduateModel;
namespace Proj3.Models
{
    /// <summary>
    /// View model class for representing undergraduate program data.
    /// </summary>
    public class UndergraduateViewModel
    {
        /// <summary>
        /// Gets or sets the array of undergraduate programs.
        /// </summary>
        public UndergraduateModel[]? undergraduate { get; set; }
    }
}
