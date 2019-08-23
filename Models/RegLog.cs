using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

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
        public string Password {get; set;}

        [Column("created_at")]
        public DateTime CreatedAt{get; set;} = DateTime.Now;
        
        [Column("updated_at")]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get; set;}

    }

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