
namespace TestSystem
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.logintextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOtextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEyePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordtextBox2.Location = new System.Drawing.Point(148, 114);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.Size = new System.Drawing.Size(148, 33);
            this.passwordtextBox2.TabIndex = 7;
            // 
            // logintextBox1
            // 
            this.logintextBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logintextBox1.Location = new System.Drawing.Point(148, 73);
            this.logintextBox1.Name = "logintextBox1";
            this.logintextBox1.Size = new System.Drawing.Size(148, 33);
            this.logintextBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // FIOtextBox1
            // 
            this.FIOtextBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOtextBox1.Location = new System.Drawing.Point(148, 34);
            this.FIOtextBox1.Name = "FIOtextBox1";
            this.FIOtextBox1.Size = new System.Drawing.Size(148, 33);
            this.FIOtextBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "ФИО";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(43, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Зарегистрироваться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEyePassword
            // 
            this.btnEyePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEyePassword.BackgroundImage")));
            this.btnEyePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEyePassword.Location = new System.Drawing.Point(300, 122);
            this.btnEyePassword.Name = "btnEyePassword";
            this.btnEyePassword.Size = new System.Drawing.Size(25, 21);
            this.btnEyePassword.TabIndex = 13;
            this.btnEyePassword.UseVisualStyleBackColor = true;
            this.btnEyePassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEyePassword_MouseDown);
            this.btnEyePassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEyePassword_MouseUp);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 210);
            this.Controls.Add(this.btnEyePassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FIOtextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.logintextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.TextBox logintextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIOtextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEyePassword;
    }
}