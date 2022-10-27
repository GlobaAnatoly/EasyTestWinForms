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
    public partial class TeacherForm : Form
    {
        private Teacher teacher;
        private TestDB testDB;
        public TeacherForm(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            label1.Text += " " + teacher.teacherName;
            //TestsdataGridView1.Columns.Add("column1", "Название теста");
            //TestsdataGridView1.Columns.Add("column2", "Предмет");
            //TestsdataGridView1.Columns.Add("column3", "Автор теста");
            testDB = new TestDB();
            RefreshListBoxes();
        }


        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Form1 parent = new Form1();
            parent.Show();

        }

        private void AddTestbutton2_Click(object sender, EventArgs e)
        {
            AddTest addTest = new AddTest(teacher);
            addTest.Show();
        }

        private void btnEyePassword_Click(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }

        private void DelTestbutton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string[] words = listBox1.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = words[0].Substring(0, words[0].Length - 1);
                if (MessageBox.Show($"Удалить тест {name}?", "Удалить",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    testDB.Test.Remove(testDB.Test.FirstOrDefault(t => t.name == name));
                    testDB.SaveChanges();
                }
                Refresh();

            }
        }
        private void RefreshListBoxes()
        {
            var subj = testDB.Test;
            listBox1.Items.Clear();
            foreach (var item in subj)
            {
                listBox1.Items.Add($"{item.name}, {testDB.Subject.FirstOrDefault(t => t.Id == item.SubjectId).name}, {testDB.Teacher.FirstOrDefault(t => t.Id == item.TeacherID).teacherName}");
            }
            var studstests = testDB.StudentsTest;
            listBox2.Items.Clear();
            foreach (var item in studstests)
            {
                listBox2.Items.Add($"{item.Test.name}, оценка:{item.result}, Студент: {item.Student.studentName}");

            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void TeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }
    }
}
