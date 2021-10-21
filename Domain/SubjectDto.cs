using System;

namespace Domain
{
    public class SubjectDto
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}