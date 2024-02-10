namespace Edulms.Data
{
    public class Assessment_Meta
    {
        public long Id { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
