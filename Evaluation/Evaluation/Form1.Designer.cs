namespace Evaluation
{
    partial class Form1
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
            this.LoGin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoGin
            // 
            this.LoGin.Location = new System.Drawing.Point(385, 278);
            this.LoGin.Name = "LoGin";
            this.LoGin.Size = new System.Drawing.Size(75, 23);
            this.LoGin.TabIndex = 9;
            this.LoGin.Text = "Login";
            this.LoGin.UseVisualStyleBackColor = true;
            this.LoGin.Click += new System.EventHandler(this.LoGin_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Location = new System.Drawing.Point(292, 209);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(53, 13);
            this.PassWord.TabIndex = 6;
            this.PassWord.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(292, 149);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(55, 13);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login Page";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoGin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoGin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label1;
    }
}

