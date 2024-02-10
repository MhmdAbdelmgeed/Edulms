namespace Edulms.DTO
{
    public class AssessmentTrueFalseDto
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public bool IsTrue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
