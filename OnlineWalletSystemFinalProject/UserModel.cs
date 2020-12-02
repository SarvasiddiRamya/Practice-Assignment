using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace OnlineWalletProject.Models
{
    public class UserModel
    {
        public int AccountId { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage ="UserName should be provided")]
        [Display(Name ="UserName: ")]
        public string UserName { get; set; }
        
        [Required(AllowEmptyStrings = false,ErrorMessage = "Email should be provided")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage = "Password should be provided")]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage = "Confirm Password should be provided")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password: ")]
        [Compare("Password", ErrorMessage ="Password and ConfirmPassword should be same")]
        public string Confirm_Password { get; set; }

        [Required(ErrorMessage = "Date_of_Birth should be provided")]
        [Display(Name = "Date_Of_Birth: ")]
        public string Date_of_Birth { get; set; }

        [Required(ErrorMessage = "Phone Number should be provided")]
        [Display(Name = "PhoneNo: ")]
        public Nullable<long> PhoneNo { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage = "AccountNo should be provided")]
        [Display(Name = "AccountNo: ")]
        public string AccountNo { get; set; }
        [Display(Name = "To_AccountNo: ")]
        public string To_AccountNo { get; set; }

        //[Required(ErrorMessage = "Amount should be provided")]
        //[Display(Name = "Amount: ")]
        public Nullable<decimal> Amount { get; set; }

        public string SuccessMessage { get; set; }
    }
}