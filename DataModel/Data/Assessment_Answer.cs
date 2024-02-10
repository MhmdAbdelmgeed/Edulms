namespace Edulms.Data
{
    public class Assessment_Answer
    {
        public long Id { get; set; }
        public long Assessment_Id { get; set; }
        public Assessment Assessment { get; set; }
        public long Question_Id { get; set; }
        public Assessment_Question Question { get; set; }
        public string Answer { get; set; }
        public long User_Id { get; set; }
        public User User { get; set; }
        public byte Score { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
