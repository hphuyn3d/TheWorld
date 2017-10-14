using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelProject.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress] //Validates email address
        public string Email { get; set; }
        [Required]
        [StringLength(4086, MinimumLength = 10)] // Max length of message is 4k and minmum length is 10
        public  string Message { get; set; }
    }
}
