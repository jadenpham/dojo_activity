using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace BeltExam.Models
{
    public class UserReg
    {
        [Key]
        [Column("id")]
        public int UserId {get; set;}

        [Required]
        [Column("f_name")]
        [Display(Name="First Name")]
        [MinLength(2,ErrorMessage="First name must be at least 2 characters.")]
        public string FirstName {get; set;}

        [Required]
        [Column("l_name")]
        [Display(Name="Last Name")]
        [MinLength(2,ErrorMessage="Last name must be at least 2 characters.")]
        public string LastName {get; set;}

        [Required]
        [Column("email")]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Column("pw")]
        [MinLength(8,ErrorMessage="Password must be at least 8 characters.")]
        // [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$)", ErrorMessage="Requires at least 1 number, 1 letter, 1 special character")]
        public string Password {get; set;}

        [Column("created_at")]
        public DateTime CreatedAt{get; set;} = DateTime.Now;
        
        [Column("updated_at")]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get; set;}

        public List<Activities> Activities {get; set;}

    }

    // public class PWValidatorAttribute: ValidationAttribute
    // {
    //     protected override ValidationResult IsValid(string Password, ValidationContext validationContext)
    //     {
    //         Match match = Regex.Match(Password, @"(?-i)(?=^.{8,}$)((?!.*\s)(?=.*[A-Z])(?=.*[a-z]))((?=(.*\d){1,})|(?=(.*\W){1,}))^.*$");
    //         if (match.Success && match.Index == 0 && match.Length == Password.Length)
	// 			return true;
	// 		else
	// 			return false;
    //     }
    // }

     public class UserLog
    {
        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get; set;}
    }

}