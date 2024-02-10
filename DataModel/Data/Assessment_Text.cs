﻿namespace Edulms.Data
{
    public class Assessment_Text
    {
        public long Id { get; set; }
        public string Answer { get; set; }
        public long QuestionId { get; set; }
        public Assessment_Question Question { get; set; }
        public int Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
