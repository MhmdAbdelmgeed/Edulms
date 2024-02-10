namespace Edulms.DTO
{
    public class AssessmentAnswerDto
    {
        public long Id { get; set; }
        public long Assessment_Id { get; set; }
        public long Question_Id { get; set; }
        public string Answer { get; set; }
        public long User_Id { get; set; }
        public byte Score { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
