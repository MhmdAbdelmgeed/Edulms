namespace Edulms.Data
{
    public class Assessment_Question_Relation
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public Assessment_Question Question { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
