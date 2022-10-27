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
    public partial class Registration : Form
    {
        private string entity;
        public Registration(string entity)
        {
            InitializeComponent();
            passwordtextBox2.UseSystemPasswordChar = true;
            this.entity = entity;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FIOtextBox1.Text) && !string.IsNullOrWhiteSpace(logintextBox1.Text)&& !string.IsNullOrWhiteSpace(passwordtextBox2.Text))
            {
                try
                {
                    TestDB testDB = new TestDB();
                    if (entity == "Teacher")
                    {
                        byte[] hashBytes = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(passwordtextBox2.Text));
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < hashBytes.Length; i++)
                        {
                            sb.Append(hashBytes[i].ToString("X2"));
                        }
                        byte[] buffer = Encoding.ASCII.GetBytes(sb.ToString());
                        //MessageBox.Show(sb.ToString());
                        testDB.Teacher.Add(new Teacher
                        {
                            teacherName = FIOtextBox1.Text,
                            teacherLogin = logintextBox1.Text,
                            teacherPassword = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(passwordtextBox2.Text))
                        });
                    }
                    if (entity == "Student")
                    {
                        testDB.Student.Add(new Student
                        {
                            studentName = FIOtextBox1.Text,
                            studentLogin = logintextBox1.Text,
                            studentPassword = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(passwordtextBox2.Text))
                        });
                    }
                   
                    
                    testDB.SaveChanges();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
    }
}
