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
    public partial class AddQuestion : Form
    {
        private TestDB _testDB;
        private bool lockTrueAnswers = false;
        private bool freeAnsw = false;
        private byte[] imageAr = null;
        private int TestId;
        private Question question;
        public AddQuestion(int testId)
        {
            InitializeComponent();
            this.TestId = testId;
            _testDB = new TestDB();
            var quest = _testDB.QuestionType.Select(p=> p.name);
            foreach (var item in quest)
            {
                comboBox1.Items.Add(item);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                lockTrueAnswers = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                freeAnsw = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lockTrueAnswers = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                freeAnsw = true;
            }
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && MessageBox.Show("Подтвердить", "Предмет", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _testDB.AnswerVariant.Add(new AnswerVariant
                {
                    name = textBox1.Text,
                    isCorrect = checkBox1.Checked,
                    idQuestion = question.Id
                });
                if (lockTrueAnswers && checkBox1.Checked)
                {
                    checkBox1.Enabled = false;
                    checkBox1.Checked = false;
                }
                textBox1.Text = "";
                _testDB.SaveChanges();
                if (freeAnsw)
                {
                    Closebutton3_Click(sender, e);
                }
               
            }
        }

        private void Createbutton2_Click(object sender, EventArgs e)
        {
            int value;
            if (!string.IsNullOrWhiteSpace(QuestNametextBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && int.TryParse(textBox2.Text, out value))
            {
                question = new Question
                {
                    TestID = TestId,
                    name = QuestNametextBox2.Text,
                    value = value,
                    picture = imageAr,
                    QuestionTypeId = comboBox1.SelectedIndex + 1
                };
                _testDB.Question.Add(question);
                _testDB.SaveChanges();
                groupBox1.Visible = true;
                button2.Visible = false;
                Createbutton2.Visible = false;
                label4.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image tmp = Image.FromFile(openFileDialog.FileName);
                imageAr = (byte[])(new ImageConverter()).ConvertTo(tmp, typeof(byte[]));
            }
        }

        private void Closebutton3_Click(object sender, EventArgs e)
        {
            QuestNametextBox2.Text = "";
            comboBox1.SelectedIndex = 0;
            textBox2.Text = "";
            checkBox1.Enabled = true;
            checkBox1.Checked = false;
            groupBox1.Visible = false;
            button2.Visible = true;
            Createbutton2.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            freeAnsw = false;
            lockTrueAnswers = false;
        }
    }
}
