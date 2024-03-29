﻿namespace Edulms.DTO
{
    public class AssessmentDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public int Duration { get; set; }
        public long CategoryId { get; set; }
        public string Thumbnail { get; set; }
        public bool Published { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
