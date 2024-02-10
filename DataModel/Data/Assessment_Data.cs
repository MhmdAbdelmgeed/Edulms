namespace Edulms.Data
{
    public class Assessment_Data
    {
        public long Id { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public string Data { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
