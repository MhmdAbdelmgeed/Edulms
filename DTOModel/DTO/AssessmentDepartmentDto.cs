﻿namespace Edulms.DTO
{
    public class AssessmentDepartmentDto
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public long AssessmentId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
