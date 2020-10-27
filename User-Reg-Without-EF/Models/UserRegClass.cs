using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel;

namespace User_Reg_Without_EF.Models {
    public class UserRegClass {

        [Key]
        public int UserId { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter user name")]
        public string Username { get; set; }

        [Display(Name ="Email")]
        [Required(ErrorMessage = "Please Enter Email")]
        public string Uemail { get; set; }

        [Display(Name ="Password")]
        [Required(ErrorMessage ="Please Enter Password")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }

        [Display(Name = "ConfirmPassword")]
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Pwd")]
        public string ConfirmPwd { get; set; }

        [Display(Name ="Martial Status")]
        [Required(ErrorMessage ="Please Select Martial Status")]
        public string MartialStatus { get; set; }


        [Display(Name ="Gender")]
        [Required(ErrorMessage ="Please Select Gender")]
        public char Gender { get; set; }
    }
}
