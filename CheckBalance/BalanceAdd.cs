namespace BalanceProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class BalanceAdd
    {
        public int AccountID { get; set; }
     //  [Required(ErrorMessage ="UserName should be Provided")]
        public string UserName { get; set; }
      // [Required(ErrorMessage = "Password should be Provided")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
   //  [Required(ErrorMessage = "AccountNo should be Provided")]
        public string AccountNo { get; set; }
      
        public Nullable<double> Amount { get; set; }
    }
}
