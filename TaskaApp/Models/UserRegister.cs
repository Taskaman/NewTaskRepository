using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Taska_DomainModel.UserConfiguration
{
    public class UserRegister
    {

        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(10, ErrorMessage = "Password should be minimum of 8 character", MinimumLength = 8)]
        public string password { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        [DataType(DataType.Password)]
        public string EmailAddress { get; set; }


        [Required]
        [StringLength(10, ErrorMessage = "Phone Number should be 10 characters", MinimumLength = 10)] 
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Please select")]
        public bool isProjectManager { get; set; }

        public bool IsteamMember { get; set; }

        public DateTime RegisteredDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
