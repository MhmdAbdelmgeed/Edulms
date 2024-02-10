using Microsoft.EntityFrameworkCore;

namespace Edulms.Data
{

        public class ApplicationDbContext : DbContext
        {


            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Assessment_Answer> Assessment_Answer { get; set; }
        public DbSet<Assessment_Data> AssessmentData { get; set; }
        public DbSet<Assessment_Department> AssessmentDepartments { get; set; }
        public DbSet<Assessment_Enrol> AssessmentEnrols { get; set; }
        public DbSet<Assessment_Group> AssessmentGroups { get; set; }
        public DbSet<Assessment_Match> AssessmentMatches { get; set; }
        public DbSet<Assessment_Meta> AssessmentMetas { get; set; }
        public DbSet<Assessment_Option> AssessmentOptions { get; set; }
        public DbSet<Assessment_Question> AssessmentQuestions { get; set; }
        public DbSet<Assessment_Question_Relation> AssessmentQuestionRelations { get; set; }
        public DbSet<Assessment_Section> AssessmentSections { get; set; }
        public DbSet<Assessment_Text> AssessmentTexts { get; set; }
        public DbSet<Assessment_True_False> AssessmentTrueFalses { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Assessment_Category> AssessmentCategories { get; set; }
        public DbSet<User> Users { get; set; }

        //modelBuilder.Entity<Assessment_Answer>()
        //    .HasOne(a => a.Assessment)
        //    .WithMany()
        //    .HasForeignKey(a => a.Assessment_Id);

        //modelBuilder.Entity<Assessment_Answer>()
        //    .HasOne(a => a.Question)
        //    .WithMany()
        //    .HasForeignKey(a => a.Question_Id);

        //modelBuilder.Entity<Assessment_Answer>()
        //    .HasOne(a => a.User)
        //    .WithMany()
        //    .HasForeignKey(a => a.User_Id);

        //modelBuilder.Entity<Assessment_Data>()
        //    .HasOne(ad => ad.Assessment)
        //    .WithMany()
        //    .HasForeignKey(ad => ad.AssessmentId);

        //modelBuilder.Entity<Assessment_Department>()
        //    .HasOne(ad => ad.Group)
        //    .WithMany(g => g.Departments)
        //    .HasForeignKey(ad => ad.GroupId);

        //modelBuilder.Entity<Assessment_Department>()
        //    .HasOne(ad => ad.Assessment)
        //    .WithMany()
        //    .HasForeignKey(ad => ad.AssessmentId);

        //modelBuilder.Entity<Assessment_Enrol>()
        //    .HasOne(ae => ae.Assessment)
        //    .WithMany()
        //    .HasForeignKey(ae => ae.AssessmentId);

        //modelBuilder.Entity<Assessment_Enrol>()
        //    .HasOne(ae => ae.User)
        //    .WithMany()
        //    .HasForeignKey(ae => ae.UserId);

        //modelBuilder.Entity<Assessment_Match>()
        //    .HasOne(am => am.Question)
        //    .WithMany()
        //    .HasForeignKey(am => am.QuestionId);

        //modelBuilder.Entity<Assessment_Meta>()
        //    .HasOne(am => am.Assessment)
        //    .WithMany()
        //    .HasForeignKey(am => am.AssessmentId);

        //modelBuilder.Entity<Assessment_Option>()
        //    .HasOne(ao => ao.Question)
        //    .WithMany(q => q.Options)
        //    .HasForeignKey(ao => ao.QuestionId);

        //modelBuilder.Entity<Assessment_Category>()
        //    .HasMany(ac => ac.Assessments)
        //    .WithOne(a => a.Category)
        //    .HasForeignKey(a => a.CategoryId);


        //modelBuilder.Entity<Assessment_Question_Relation>()
        //    .HasOne(aqr => aqr.Question)
        //    .WithMany()
        //    .HasForeignKey(aqr => aqr.QuestionId);

        //modelBuilder.Entity<Assessment_Question_Relation>()
        //    .HasOne(aqr => aqr.Assessment)
        //    .WithMany()
        //    .HasForeignKey(aqr => aqr.AssessmentId);

        //modelBuilder.Entity<Assessment_Section>()
        //    .HasOne(asn => asn.Assessment)
        //    .WithMany()
        //    .HasForeignKey(asn => asn.AssessmentId);

        //modelBuilder.Entity<Assessment_Text>()
        //    .HasOne(at => at.Question)
        //    .WithMany(q => q.Texts)
        //    .HasForeignKey(at => at.QuestionId);

        //modelBuilder.Entity<Assessment_True_False>()
        //    .HasOne(atf => atf.Question)
        //    .WithMany(q => q.TrueFalses)
        //    .HasForeignKey(atf => atf.QuestionId);

        //modelBuilder.Entity<Assessment_Category>()
        //    .HasMany(ac => ac.Assessments)
        //    .WithOne(a => a.Category)
        //    .HasForeignKey(a => a.CategoryId);
    }
}

