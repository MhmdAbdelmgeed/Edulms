namespace Edulms.DTO
{
    public class AssessmentEnrolDto
    {
        public long Id { get; set; }
        public long AssessmentId { get; set; }
        public long UserId { get; set; }
        public int? Result { get; set; }
        public byte Score { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
