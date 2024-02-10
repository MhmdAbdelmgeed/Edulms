namespace Edulms.Data
{
    public class Assessment
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int Duration { get; set; }
        public long? CategoryId { get; set; }
        public Assessment_Category Category { get; set; }
        public string Thumbnail { get; set; }
        public bool Published { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<Assessment_Answer> Answers { get; set; }
        public List<Assessment_Data> Data { get; set; }
        public List<Assessment_Department> Departments { get; set; }
        public List<Assessment_Enrol> Enrols { get; set; }
        public List<Assessment_Question_Relation> QuestionRelations { get; set; }
        public List<Assessment_Section> Sections { get; set; }
        public List<Assessment_Meta> Metas { get; set; }
    }
}
