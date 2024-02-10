namespace Edulms.Data
{
    public class Assessment_Department
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public Assessment_Group Group { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
