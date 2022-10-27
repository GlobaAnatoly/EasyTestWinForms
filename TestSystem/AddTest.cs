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
    public partial class AddTest : Form
    {
        private Teacher teacher;
        private TestDB testDB;
        private Test test;
        public AddTest(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            testDB = new TestDB();
            var subj = testDB.Subject.Select(p => p.name);
            foreach (var item in subj)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void AddQuestbutton2_Click(object sender, EventArgs e)
        {
            AddQuestion addQuestion = new AddQuestion(test.Id);
            addQuestion.Show();
        }

        private void Createbutton2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TestNametextBox2.Text))
            {
                test = new Test
                {
                    TeacherID = teacher.Id,
                    SubjectId =testDB.Subject.Where(s => s.name == comboBox1.Text).Select(s=>s.Id).FirstOrDefault(),
                    name = TestNametextBox2.Text
                };
                testDB.Test.Add(test);
                testDB.SaveChanges();
                AddQuestion addQuestion = new AddQuestion(test.Id);
                addQuestion.Show();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && textBox1.Visible == true && MessageBox.Show("Подтвердить", "Предмет", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Subject subject = new Subject { name = textBox1.Text };
                testDB.Subject.Add(subject);
                testDB.SaveChanges();
                testDB = new TestDB();
                comboBox1.Items.Clear();
                foreach (var item in testDB.Subject.Select(p => p.name))
                {
                    comboBox1.Items.Add(item);
                }
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible = true;
            }
        }

        //private void btnEyePassword_Click(object sender, EventArgs e)
        //{
        //    checkedListBox1.Items.Clear();
        //    var quest = testDB.Question;
        //    foreach (Question item in quest)
        //    {
        //        checkedListBox1.Items.Add($"{item.name}");
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if(checkedListBox1.Items.Count > 0)
        //    {
        //        foreach (var item in checkedListBox1.CheckedItems)
        //        {
        //            Question tmp = testDB.Question.FirstOrDefault(t => t.name == item.ToString());
        //            Question question = new Question
        //            {
        //                TestID = test.Id,
        //                name = tmp.name,
        //                picture = tmp.picture,
        //                QuestionTypeId = tmp.QuestionTypeId,
        //                value = tmp.value
        //            };
        //            testDB.Question.Add(question);
        //            //var variants = testDB.AnswerVariant.Where(t=> t.idQuestion ==question.i)
        //        }
        //    }
        //}
    }
}
