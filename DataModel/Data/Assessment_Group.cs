namespace Edulms.Data
{
    public class Assessment_Group
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<Assessment_Department> Departments { get; set; }
    }
}
