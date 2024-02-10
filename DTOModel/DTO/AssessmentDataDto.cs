namespace Edulms.DTO
{
    public class AssessmentDataDto
    {
        public long Id { get; set; }
        public long AssessmentId { get; set; }
        public string Data { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
