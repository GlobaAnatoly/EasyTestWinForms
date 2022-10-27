using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestSystem
{
    public partial class TestDB : DbContext
    {
        public TestDB()
            : base("name=TestDB")
        {
        }

        public virtual DbSet<AnswerVariant> AnswerVariant { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionType> QuestionType { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentsTest> StudentsTest { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
                .HasMany(e => e.AnswerVariant)
                .WithRequired(e => e.Question)
                .HasForeignKey(e => e.idQuestion);

            modelBuilder.Entity<QuestionType>()
                .HasMany(e => e.Question)
                .WithRequired(e => e.QuestionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Test)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Test)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Question)
                .WithOptional(e => e.Test)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Test>()
                .HasMany(e => e.StudentsTest)
                .WithOptional(e => e.Test)
                .WillCascadeOnDelete();
        }
    }
}
