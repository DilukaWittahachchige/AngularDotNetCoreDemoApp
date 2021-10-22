using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
    /// <summary>
    ///  Student entity  
    /// </summary>
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string StudentPhoneNumber { get; set; }
        public string StudentEmailAddress { get; set; }
        public string StudentNRIC { get; set; }
        public DateTime StudentDateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}