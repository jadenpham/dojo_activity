using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeltExam.Models
{
    public class Activities
    {
        [Key]
        [Column("activity_id")]
        public int ActivityId {get; set;}

        [Required]
        [Column("title")]
        public string Title {get; set;}

        [Required]
        [Column("description")]
        [MinLength(2, ErrorMessage = "Please input at least 2 characters.")]
        public string Description {get; set;}

        [Required]
        [Column("time")]
        [DisplayFormat(DataFormatString = "{hh:mm tt}")]
        [DataType(DataType.Time)]
        public TimeSpan Time {get; set;}


        [Required]
        [Column("duration")]
        public int Duration {get; set;}
        
        [Required]
        [Column("date")]
        [DateValidator]
        [DisplayFormat(DataFormatString="{yyyyMMdd}")]
        [DataType(DataType.Date)]
        public DateTime Date {get; set;}

        [Column("created_at")]
        public DateTime CreatedAt {get; set;} = DateTime.Now;

        [Column("updated_at")]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        [Column("user_id")]
        public int UserId{get; set;}

        public UserReg Creator {get; set;}

        public List<Response> Guests {get; set;}
    }

        public class DateValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object date, ValidationContext validationContext)
        {
            DateTime today = DateTime.Now;
            DateTime ActivityDate = Convert.ToDateTime(date);
            if(today > ActivityDate)
            {
                return new ValidationResult("Activity date must be in the future");
            } else{
                return ValidationResult.Success;
            }
        }
    }
}