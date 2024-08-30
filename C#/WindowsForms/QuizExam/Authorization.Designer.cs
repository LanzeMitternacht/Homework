namespace QuizExam
{
    partial class Authorization
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
            this.BSignIn = new System.Windows.Forms.Button();
            this.BSignUp = new System.Windows.Forms.Button();
            this.LStartInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BSignIn
            // 
            this.BSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSignIn.Location = new System.Drawing.Point(123, 109);
            this.BSignIn.Name = "BSignIn";
            this.BSignIn.Size = new System.Drawing.Size(148, 67);
            this.BSignIn.TabIndex = 0;
            this.BSignIn.Text = "Войти в систему";
            this.BSignIn.UseVisualStyleBackColor = true;
            this.BSignIn.Click += new System.EventHandler(this.BSignIn_Click);
            // 
            // BSignUp
            // 
            this.BSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSignUp.Location = new System.Drawing.Point(123, 226);
            this.BSignUp.Name = "BSignUp";
            this.BSignUp.Size = new System.Drawing.Size(148, 67);
            this.BSignUp.TabIndex = 1;
            this.BSignUp.Text = "Регистрация";
            this.BSignUp.UseVisualStyleBackColor = true;
            this.BSignUp.Click += new System.EventHandler(this.BSignUp_Click);
            // 
            // LStartInfo
            // 
            this.LStartInfo.AutoSize = true;
            this.LStartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LStartInfo.Location = new System.Drawing.Point(132, 38);
            this.LStartInfo.Name = "LStartInfo";
            this.LStartInfo.Size = new System.Drawing.Size(139, 29);
            this.LStartInfo.TabIndex = 2;
            this.LStartInfo.Text = "Викторина";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 350);
            this.Controls.Add(this.LStartInfo);
            this.Controls.Add(this.BSignUp);
            this.Controls.Add(this.BSignIn);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSignIn;
        private System.Windows.Forms.Button BSignUp;
        private System.Windows.Forms.Label LStartInfo;
    }
}

