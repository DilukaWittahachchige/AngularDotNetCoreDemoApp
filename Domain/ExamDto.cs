
using System;

namespace Domain
{
    public class ExamDto
    {
        public int ExamId { get; set; }
        public string ClassId { get; set; }
        public string StudentId { get; set; }
        public string SubjectId { get; set; }
        public int Marks { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
