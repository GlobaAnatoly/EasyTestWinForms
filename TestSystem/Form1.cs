using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    
    public partial class Form1 : Form
    {
        private TestDB _testDB;
        public Form1()
        {
            InitializeComponent();
            passwordtextBox2.UseSystemPasswordChar = true;
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _testDB = new TestDB();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void TeacherRegisterbutton4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(logintextBox1.Text) && !string.IsNullOrWhiteSpace(passwordtextBox2.Text))
            {
                Teacher teacher = _testDB.Teacher.FirstOrDefault(t => t.teacherLogin == logintextBox1.Text); 
                MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
                byte[] bytes = cryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(passwordtextBox2.Text));
                //MessageBox.Show(String.Join(" ", bytes));
                if (teacher != null && teacher.teacherPassword.SequenceEqual(cryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(passwordtextBox2.Text))))
                {
                    Registration registration = new Registration("Teacher");
                    if (registration.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Регистрация успешна!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка регистрации!");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Для добавления нового преподователя в систему необходимо\nввести логин и пароль существующего преподавателя", "Ошибка");
            }
                
        }

        private void TeacherEnterbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(logintextBox1.Text) && !string.IsNullOrWhiteSpace(passwordtextBox2.Text) )
                {
                    Teacher teacher = _testDB.Teacher.FirstOrDefault(t => t.teacherLogin == logintextBox1.Text);
                    //StringBuilder sb = new StringBuilder();
                    //for (int i = 0; i < teacher.teacherPassword.Length; i++)
                    //{
                    //    sb.Append(teacher.teacherPassword[i].ToString("X2"));
                    //}
                    //MessageBox.Show(sb.ToString());
                   
                    MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
                    //MessageBox.Show(teacher.teacherPassword.SequenceEqual(cryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(passwordtextBox2.Text))).ToString());
                    if (teacher!=null && teacher.teacherPassword.SequenceEqual(cryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(passwordtextBox2.Text))))
                    {
                       
                        TeacherForm teacherForm = new TeacherForm(teacher);
                        teacherForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверные данные!");
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void StudentRegisterbutton3_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration("Student");
            if (registration.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Регистрация успешна!");
            }
            else
            {
                MessageBox.Show("Ошибка регистрации!");
            }
        }

        private void studentEnterbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(logintextBox1.Text) && !string.IsNullOrWhiteSpace(passwordtextBox2.Text))
                {
                    Student student = _testDB.Student.FirstOrDefault(t => t.studentLogin == logintextBox1.Text); MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
                    if (student != null && student.studentPassword.SequenceEqual(cryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(passwordtextBox2.Text))))
                    {
                        StudentForm studentForm = new StudentForm(student);
                        studentForm.Show();
                        Hide();
                    }
                    else
                        MessageBox.Show("Неверные данные!");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnEyePassword_MouseDown(object sender, MouseEventArgs e)
        {
            passwordtextBox2.UseSystemPasswordChar = false;
        }

        private void btnEyePassword_MouseUp(object sender, MouseEventArgs e)
        {
            passwordtextBox2.UseSystemPasswordChar = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
