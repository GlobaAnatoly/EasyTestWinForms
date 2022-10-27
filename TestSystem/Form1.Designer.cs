
namespace TestSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logintextBox1 = new System.Windows.Forms.TextBox();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.studentEnterbutton1 = new System.Windows.Forms.Button();
            this.TeacherEnterbutton2 = new System.Windows.Forms.Button();
            this.btnEyePassword = new System.Windows.Forms.Button();
            this.StudentRegisterbutton3 = new System.Windows.Forms.Button();
            this.TeacherRegisterbutton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(150, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(286, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // logintextBox1
            // 
            this.logintextBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logintextBox1.Location = new System.Drawing.Point(75, 90);
            this.logintextBox1.Name = "logintextBox1";
            this.logintextBox1.Size = new System.Drawing.Size(148, 33);
            this.logintextBox1.TabIndex = 2;
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordtextBox2.Location = new System.Drawing.Point(291, 90);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.Size = new System.Drawing.Size(148, 33);
            this.passwordtextBox2.TabIndex = 3;
            this.passwordtextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // studentEnterbutton1
            // 
            this.studentEnterbutton1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentEnterbutton1.Location = new System.Drawing.Point(12, 147);
            this.studentEnterbutton1.Name = "studentEnterbutton1";
            this.studentEnterbutton1.Size = new System.Drawing.Size(211, 37);
            this.studentEnterbutton1.TabIndex = 4;
            this.studentEnterbutton1.Text = "Войти как ученик";
            this.studentEnterbutton1.UseVisualStyleBackColor = true;
            this.studentEnterbutton1.Click += new System.EventHandler(this.studentEnterbutton1_Click);
            // 
            // TeacherEnterbutton2
            // 
            this.TeacherEnterbutton2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherEnterbutton2.Location = new System.Drawing.Point(291, 147);
            this.TeacherEnterbutton2.Name = "TeacherEnterbutton2";
            this.TeacherEnterbutton2.Size = new System.Drawing.Size(211, 37);
            this.TeacherEnterbutton2.TabIndex = 5;
            this.TeacherEnterbutton2.Text = "Войти как преподаватель";
            this.TeacherEnterbutton2.UseVisualStyleBackColor = true;
            this.TeacherEnterbutton2.Click += new System.EventHandler(this.TeacherEnterbutton2_Click);
            // 
            // btnEyePassword
            // 
            this.btnEyePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEyePassword.BackgroundImage")));
            this.btnEyePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEyePassword.Location = new System.Drawing.Point(442, 98);
            this.btnEyePassword.Name = "btnEyePassword";
            this.btnEyePassword.Size = new System.Drawing.Size(25, 21);
            this.btnEyePassword.TabIndex = 12;
            this.btnEyePassword.UseVisualStyleBackColor = true;
            this.btnEyePassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEyePassword_MouseDown);
            this.btnEyePassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEyePassword_MouseUp);
            // 
            // StudentRegisterbutton3
            // 
            this.StudentRegisterbutton3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentRegisterbutton3.Location = new System.Drawing.Point(12, 190);
            this.StudentRegisterbutton3.Name = "StudentRegisterbutton3";
            this.StudentRegisterbutton3.Size = new System.Drawing.Size(211, 37);
            this.StudentRegisterbutton3.TabIndex = 13;
            this.StudentRegisterbutton3.Text = "Добавить ученика";
            this.StudentRegisterbutton3.UseVisualStyleBackColor = true;
            this.StudentRegisterbutton3.Click += new System.EventHandler(this.StudentRegisterbutton3_Click);
            // 
            // TeacherRegisterbutton4
            // 
            this.TeacherRegisterbutton4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherRegisterbutton4.Location = new System.Drawing.Point(291, 190);
            this.TeacherRegisterbutton4.Name = "TeacherRegisterbutton4";
            this.TeacherRegisterbutton4.Size = new System.Drawing.Size(211, 37);
            this.TeacherRegisterbutton4.TabIndex = 14;
            this.TeacherRegisterbutton4.Text = "Добавить преподавателя";
            this.TeacherRegisterbutton4.UseVisualStyleBackColor = true;
            this.TeacherRegisterbutton4.Click += new System.EventHandler(this.TeacherRegisterbutton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 236);
            this.Controls.Add(this.TeacherRegisterbutton4);
            this.Controls.Add(this.StudentRegisterbutton3);
            this.Controls.Add(this.btnEyePassword);
            this.Controls.Add(this.TeacherEnterbutton2);
            this.Controls.Add(this.studentEnterbutton1);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.logintextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logintextBox1;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.Button studentEnterbutton1;
        private System.Windows.Forms.Button TeacherEnterbutton2;
        private System.Windows.Forms.Button btnEyePassword;
        private System.Windows.Forms.Button StudentRegisterbutton3;
        private System.Windows.Forms.Button TeacherRegisterbutton4;
    }
}

