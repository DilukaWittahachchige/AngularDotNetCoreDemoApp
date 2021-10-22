using System;

namespace Domain
{
    public class StudentDto
    {
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