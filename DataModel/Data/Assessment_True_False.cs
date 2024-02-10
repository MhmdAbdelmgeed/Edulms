namespace Edulms.Data
{
    public class Assessment_True_False
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public Assessment_Question Question { get; set; }
        public bool IsTrue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
