namespace Edulms.Data
{
    public class Assessment_Enrol
    {
        public long Id { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public int? Result { get; set; }
        public byte Score { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
