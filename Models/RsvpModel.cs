using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeltExam.Models
{
    public class Response
    {
        [Key]
        [Column("resp_id")]
        public int RespId{get; set;}
        
        [Column("user_id")]
        public int UserId{get; set;}

        [Column("activity_id")]
        public int ActivityId{get; set;}

        public UserReg Attendee {get; set;}

        public Activities Activities {get; set;}
    }
}