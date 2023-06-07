using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AutomapperEx.Models
{
    public class UserViewModel
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        public string AddressCountry { get; set; }

        public string Email { get; set; }
    }
}
