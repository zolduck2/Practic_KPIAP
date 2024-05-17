namespace zad2
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
            this.userControlTimer21 = new zad2.UserControlTimer2();
            this.userControlTimer1 = new zad2.UserControlTimer();
            this.clickButton1 = new zad2.ClickButton();
            this.SuspendLayout();
            // 
            // userControlTimer21
            // 
            this.userControlTimer21.Location = new System.Drawing.Point(46, 48);
            this.userControlTimer21.Name = "userControlTimer21";
            this.userControlTimer21.Size = new System.Drawing.Size(150, 25);
            this.userControlTimer21.TabIndex = 1;
            // 
            // userControlTimer1
            // 
            this.userControlTimer1.Location = new System.Drawing.Point(46, 89);
            this.userControlTimer1.Name = "userControlTimer1";
            this.userControlTimer1.Size = new System.Drawing.Size(150, 19);
            this.userControlTimer1.TabIndex = 0;
            this.userControlTimer1.TimeEnabled = true;
            this.userControlTimer1.Load += new System.EventHandler(this.userControlTimer1_Load);
            // 
            // clickButton1
            // 
            this.clickButton1.Location = new System.Drawing.Point(80, 145);
            this.clickButton1.Name = "clickButton1";
            this.clickButton1.Size = new System.Drawing.Size(159, 49);
            this.clickButton1.TabIndex = 2;
            this.clickButton1.Text = "Клик";
            this.clickButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 217);
            this.Controls.Add(this.clickButton1);
            this.Controls.Add(this.userControlTimer21);
            this.Controls.Add(this.userControlTimer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer userControlTimer1;
        private UserControlTimer2 userControlTimer21;
        private ClickButton clickButton1;
    }
}

