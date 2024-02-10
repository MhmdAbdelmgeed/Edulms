namespace Edulms.DTO
{
    public class AssessmentOptionDto
    {
        public long Id { get; set; }
        public string OptionText { get; set; }
        public long QuestionId { get; set; }
        public bool Correct { get; set; }
        public int Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
