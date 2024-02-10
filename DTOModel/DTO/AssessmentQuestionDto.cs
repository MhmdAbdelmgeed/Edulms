namespace Edulms.DTO
{
    public class AssessmentQuestionDto
    {
        public long Id { get; set; }
        public string Question { get; set; }
        public long CategoryId { get; set; }
        public int Level { get; set; }
        public int Order { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
