using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPoco
{
    public class User
    {
        public int UserId { get; set; }
        
        [Required(ErrorMessage = "Email address is required.")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password cannot be less than 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Passwords do not match")]
        //[Required(ErrorMessage = "Please confirm Password")]
        //[DataType(DataType.Password)]
        //public string RetypePassword { get; set; }


        

        //[RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        //[Required(ErrorMessage = "Please enter your email address.")]
        //[Compare("EmailAddress", ErrorMessage = "Email addresses do not match.")]
        //[StringLength(50)]
        //public string RetypeEmailAddress { get; set; }

        //public string AccountType { get; set; }

        public ICollection<Basket> Baskets { get; set; }
        
        public ICollection<Address> Addresses { get; set; }
    }
}
