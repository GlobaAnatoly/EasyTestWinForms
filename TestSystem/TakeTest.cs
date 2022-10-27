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
    public partial class TakeTest : Form
    {
        private Test test;
        private Student student;
        private TestDB testDB;
        private List<Question> questions;
        private int questionCount = 0;
        private int score = 0;
        private Picture picture;
        public TakeTest(Test test, Student student)
        {
            InitializeComponent();
            this.test = test;
            this.student = student;
            testDB = new TestDB();
            questions = testDB.Question.Where(t => t.TestID == test.Id).ToList();
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
            SetVariats();
        }
        private void SetVariats()
        {
            label1.Text = questionCount + 1 + "/" + questions.Count();
            if (questions[questionCount].picture != null)
            {
                picture = new Picture(questions[questionCount].picture);
                picture.Show();
            }
            int questID = questions[questionCount].Id;
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            groupBox1.Visible = true;
            List<AnswerVariant> answerVariants = (from t in testDB.AnswerVariant where t.idQuestion == questID select t).ToList();
            if (questions[questionCount].QuestionType.name == "Одиночный")
            {
                label3.Visible = false;
                richTextBox2.Visible = false;
                checkedListBox1.Visible = true;
                checkedListBox2.Visible = false;
                foreach (AnswerVariant item in answerVariants)
                {
                    checkedListBox1.Items.Add(item.name);
                }
            }
            if (questions[questionCount].QuestionType.name == "Множественный")
            {
                label3.Visible = false;
                richTextBox2.Visible = false;
                checkedListBox1.Visible = false; 
                checkedListBox2.Visible = true;
                foreach (AnswerVariant item in answerVariants)
                {
                    checkedListBox2.Items.Add(item.name);
                }
            }
            if (questions[questionCount].QuestionType.name == "Свободный")
            {
                label3.Visible = true;
                checkedListBox1.Visible = false;
                richTextBox2.Visible = true;
                checkedListBox2.Visible = false;

            }
            richTextBox1.Text = questions[questionCount].name;
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; ++i)
                if (i != e.Index) checkedListBox1.SetItemChecked(i, false);
        }

        private void Nextbutton2_Click(object sender, EventArgs e)
        {
            int questId = questions[questionCount].Id;
            if (questions[questionCount].QuestionType.name == "Одиночный")
            {
                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    string answer = checkedListBox1.CheckedItems[0].ToString();
                    AnswerVariant answerVariant = testDB.AnswerVariant.Where(t => t.name == answer && t.idQuestion==questId).First();
                    if (answerVariant.isCorrect == true)
                    {
                        score += questions[questionCount].value;
                    }
                }
            }
            if (questions[questionCount].QuestionType.name == "Множественный")
            {
                if(checkedListBox2.CheckedItems.Count > 0)
                {
                    List <AnswerVariant> answerVariants = testDB.AnswerVariant.Where(t => t.idQuestion == questId && t.isCorrect == true).ToList();
                    int count = 0;
                    foreach (var item in answerVariants)
                    {
                        if (item.isCorrect)
                            count++;
                    }
                    int rightAns = 0;
                    foreach (var item in checkedListBox2.CheckedItems)
                    {
                        
                        string answer = item.ToString();
                        AnswerVariant answerVariant = testDB.AnswerVariant.FirstOrDefault(t => t.name == answer && t.idQuestion == questId);
                        if (answerVariants.Contains(answerVariant))
                            rightAns++;
                    }
                    if (rightAns == count)
                        score += questions[questionCount].value;
                }
            }
            if (questions[questionCount].QuestionType.name == "Свободный")
            {
                string answer = richTextBox2.Text;
                AnswerVariant answerVariant = testDB.AnswerVariant.FirstOrDefault(t => t.name.Trim().ToLower() == answer.Trim().ToLower() && t.idQuestion == questId);
                if (answerVariant != null && answerVariant.name == answer && answerVariant.isCorrect)
                {
                    score += questions[questionCount].value;
                }
               
            }
            questionCount++;
            if (questionCount >= questions.Count)
            {
                TestResult testResult = new TestResult(test, student, score);
                testResult.Show();
                if (picture != null)
                    picture.Close();
                Close();
            }
           
            else if (questionCount < questions.Count)
            {
                if (picture != null)
                    picture.Close();
                SetVariats();
            }
            
        }
    }
}
