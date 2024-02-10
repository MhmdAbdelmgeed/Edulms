namespace Edulms.Data
{
    public class Assessment_Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<Assessment> Assessments { get; set; }
    }
}
