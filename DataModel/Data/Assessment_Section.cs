namespace Edulms.Data
{
    public class Assessment_Section
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public int Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
