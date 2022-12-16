using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MyHotel.Models.RequestModels
{
    public class RegisterRequestModel
    {

        [StringLength(15)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string LastName { get; set; }
        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public string Aadhar { get; set; }

        public string Email { get; set; }
    }
}
