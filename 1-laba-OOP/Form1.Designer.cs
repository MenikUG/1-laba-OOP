namespace _1_laba_OOP
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
            this.button_Hello = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kolich = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Hello
            // 
            this.button_Hello.Location = new System.Drawing.Point(12, 40);
            this.button_Hello.Name = "button_Hello";
            this.button_Hello.Size = new System.Drawing.Size(75, 28);
            this.button_Hello.TabIndex = 0;
            this.button_Hello.Text = "Hello";
            this.button_Hello.UseVisualStyleBackColor = true;
            this.button_Hello.Click += new System.EventHandler(this.button_Hello_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 15);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Cчётчик нажатий кнопки Hello : ";
            // 
            // kolich
            // 
            this.kolich.AutoSize = true;
            this.kolich.Location = new System.Drawing.Point(228, 12);
            this.kolich.Name = "kolich";
            this.kolich.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kolich.Size = new System.Drawing.Size(16, 17);
            this.kolich.TabIndex = 2;
            this.kolich.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kolich);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Hello;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label kolich;
    }
}

