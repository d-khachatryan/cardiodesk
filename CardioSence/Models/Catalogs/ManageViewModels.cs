using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace CardioSence.Models
{
    public class UserItem
    {
        //[Required(ErrorMessageResourceName = "User_Name_Required", ErrorMessageResourceType = typeof(Resources.Resources))]
        //[StringLength(100, ErrorMessageResourceName = "User_Name_Val", MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "The UserName is required")]
        public string UserName { get; set; }

        //[Required(ErrorMessageResourceName = "User_Email_Required", ErrorMessageResourceType = typeof(Resources.Resources))]
        //[EmailAddress(ErrorMessageResourceName = "User_Email_Val", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "The Email is required")]
        public string Email { get; set; }

        //[Required(ErrorMessageResourceName = "User_Password_Required", ErrorMessageResourceType = typeof(Resources.Resources))]
        //[StringLength(100, ErrorMessageResourceName = "User_Password_Val", MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Resources))]
        //[RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*(_|[^\\w])).+$", ErrorMessageResourceName = "User_Password_ValGlob", ErrorMessageResourceType = typeof(Resources.Resources))]
        //[DataType(DataType.Password)]
        [Required(ErrorMessage = "The Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //[DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "The Confirm Password is required")]
        [Compare("Password", ErrorMessage = "The Confirm Password does not mach with Password")]
        //[Compare("Password", ErrorMessageResourceName = "User_Password_Confirm", ErrorMessageResourceType = typeof(Resources.Resources))]
        public string ConfirmPassword { get; set; }

        [Key]
        public string Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

    }

    [Table("vwAspNetUserRoles")]
    public class UserRoleItem
    {
        [Column(Order = 0), Key]
        public string UserId { get; set; }

        [Column(Order = 1), Key]
        [Display(Name = "Role")]
        public string RoleId { get; set; }

        [Display(Name = "Role Name")]
        public string Name { get; set; }
    }
}