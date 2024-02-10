namespace Edulms.DTO
{
    public class AssessmentQuestionsRelationDto
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public long AssessmentId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
