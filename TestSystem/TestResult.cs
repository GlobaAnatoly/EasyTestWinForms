using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{

    public partial class TestResult : Form
    {
        private Test test;
        private Student student;
        private TestDB testDB;
        private int score = 0;
        public TestResult(Test test, Student student, int score)
        {
            InitializeComponent();
            this.test = test;
            this.student = student;
            this.score = score;
            testDB = new TestDB();
        }

        private void TestResult_Load(object sender, EventArgs e)
        {
            if (testDB.StudentsTest.AsNoTracking().FirstOrDefault(t => t.StudentId == student.Id && t.TestID == test.Id) != null)
            {
                StudentsTest entity = testDB.StudentsTest.AsNoTracking().FirstOrDefault(t => t.StudentId == student.Id && t.TestID == test.Id);
                if (entity.result <= score)
                {
                    using (var context = new TestDB())
                    {
                        context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        entity.result = score;
                        entity.attemtsLeft = entity.attemtsLeft - 1;
                        entity.time = DateTime.Now;
                        context.SaveChanges();
                        ShowStat(entity);
                    }

                }
                else
                {
                    using (var context = new TestDB())
                    {
                        context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        entity.result = entity.result;
                        entity.attemtsLeft = entity.attemtsLeft - 1;
                        entity.time = entity.time;
                        context.SaveChanges();
                        ShowStat(entity);
                        label3.Text += "(У вас уже был результат лучше)";
                    }

                }

            }
            else
            {
                StudentsTest studentsTest = new StudentsTest
                {
                    TestID = test.Id,
                    StudentId = student.Id,
                    result = score,
                    attemtsLeft = 2,
                    time = DateTime.Now
                };
                testDB.StudentsTest.Add(studentsTest);
                testDB.SaveChanges();
                ShowStat(studentsTest);
            }
        }
        private void ShowStat(StudentsTest studentsTest)
        {
            label1.Text += " " + testDB.Student.FirstOrDefault(t => t.Id == studentsTest.StudentId).studentName;
            label2.Text += " " + testDB.Test.FirstOrDefault(t => t.Id == studentsTest.TestID).name;
            label3.Text += " " + score;
            label4.Text += " " + studentsTest.time;
            label5.Text += " " + studentsTest.attemtsLeft;
        }
    }
}
