namespace Edulms.DTO
{
    public class AssessmentMetaDto
    {
        public long Id { get; set; }
        public long AssessmentId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
