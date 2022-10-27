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
    public partial class StudentForm : Form
    {
        private Student student;
        private TestDB testDB;
        
        public StudentForm(Student student)
        {
            InitializeComponent();
            
            this.student = student;
            label1.Text += student.studentName;
            testDB = new TestDB();
            RefreshListBoxes();
        }
        private void RefreshListBoxes()
        {
            testDB = new TestDB();
            var subj = testDB.Test;
            listBox1.Items.Clear();
            foreach (var item in subj)
            {
                listBox1.Items.Add($"{item.name},  {testDB.Subject.FirstOrDefault(t => t.Id == item.SubjectId).name}, Учитель:{testDB.Teacher.FirstOrDefault(t => t.Id == item.TeacherID).teacherName}");
            }
            var studstests = testDB.StudentsTest.Where(t=> t.StudentId == student.Id);
            listBox2.Items.Clear();
            foreach (var item in studstests)
            {
                listBox2.Items.Add($"{testDB.Test.FirstOrDefault(t=> t.Id == item.TestID).name}, оценка:{item.result}, Автор: {testDB.Test.FirstOrDefault(t => t.Id == item.TestID).Teacher.teacherName}, \nосталось попыток: {item.attemtsLeft}");
               
            }
        }

        private void btnEyePassword_Click(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void AddTestbutton2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0&& MessageBox.Show("Начать тест?", "Тест", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Student entity = testDB.Student.AsNoTracking().FirstOrDefault(t => t.studentLogin == student.studentLogin);
                using (var context = new TestDB())
                {
                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    //entity.attemtsLeft--;
                    context.SaveChanges();
                    student = entity;
                }
                string[] words = listBox1.SelectedItem.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = words[0];
                Test test = testDB.Test.FirstOrDefault(t => t.name == name);
                if (testDB.StudentsTest.FirstOrDefault(t => t.StudentId == entity.Id && t.TestID == test.Id) != null)
                {
                    if (testDB.StudentsTest.FirstOrDefault(t => t.StudentId == entity.Id && t.TestID == test.Id).attemtsLeft > 0)
                    {
                        MessageBox.Show($"У вас осталось {testDB.StudentsTest.FirstOrDefault(t => t.StudentId == entity.Id && t.TestID == test.Id && t.attemtsLeft > 0).attemtsLeft} попыток");
                        TakeTest takeTest = new TakeTest(test, student);
                        takeTest.Show();
                    }
                    else
                    {
                        MessageBox.Show("У вас не осталось попыток на прохождение теста");
                    }
                }
                else {
                    TakeTest takeTest = new TakeTest(test, student);
                    takeTest.Show();
                   
                }


            }
            
        }
    }
}
