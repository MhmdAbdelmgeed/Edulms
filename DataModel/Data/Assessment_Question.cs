namespace Edulms.Data
{
    public class Assessment_Question
    {
        public long Id { get; set; }
        public string QuestionText { get; set; }
        public long CategoryId { get; set; }
        public Assessment_Category Category { get; set; }
        public int Level { get; set; }
        public int Order { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<Assessment_Option> Options { get; set; }
        public List<Assessment_Match> Matches { get; set; }
        public List<Assessment_Text> Texts { get; set; }
        public List<Assessment_True_False> TrueFalses { get; set; }
    }
}
