namespace QuizExam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LLoginError = new System.Windows.Forms.Label();
            this.LPassError = new System.Windows.Forms.Label();
            this.DateTimePick = new System.Windows.Forms.DateTimePicker();
            this.BAccept = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.LDateError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения:";
            // 
            // TBLogin
            // 
            this.TBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLogin.Location = new System.Drawing.Point(126, 65);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(184, 26);
            this.TBLogin.TabIndex = 3;
            // 
            // TBPassword
            // 
            this.TBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPassword.Location = new System.Drawing.Point(126, 140);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(184, 26);
            this.TBPassword.TabIndex = 4;
            // 
            // LLoginError
            // 
            this.LLoginError.AutoSize = true;
            this.LLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLoginError.Location = new System.Drawing.Point(108, 94);
            this.LLoginError.Name = "LLoginError";
            this.LLoginError.Size = new System.Drawing.Size(219, 12);
            this.LLoginError.TabIndex = 5;
            this.LLoginError.Text = "(логин должен состоять из не менее 3х символов)";
            // 
            // LPassError
            // 
            this.LPassError.AutoSize = true;
            this.LPassError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPassError.Location = new System.Drawing.Point(108, 169);
            this.LPassError.Name = "LPassError";
            this.LPassError.Size = new System.Drawing.Size(0, 12);
            this.LPassError.TabIndex = 6;
            // 
            // DateTimePick
            // 
            this.DateTimePick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePick.Location = new System.Drawing.Point(164, 210);
            this.DateTimePick.Name = "DateTimePick";
            this.DateTimePick.Size = new System.Drawing.Size(176, 20);
            this.DateTimePick.TabIndex = 7;
            // 
            // BAccept
            // 
            this.BAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAccept.Location = new System.Drawing.Point(33, 292);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(125, 56);
            this.BAccept.TabIndex = 8;
            this.BAccept.Text = "Подтвердить";
            this.BAccept.UseVisualStyleBackColor = true;
            this.BAccept.Click += new System.EventHandler(this.BAccept_Click);
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCancel.Location = new System.Drawing.Point(184, 292);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(126, 56);
            this.BCancel.TabIndex = 9;
            this.BCancel.Text = "Отменить";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // LDateError
            // 
            this.LDateError.AutoSize = true;
            this.LDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDateError.Location = new System.Drawing.Point(162, 242);
            this.LDateError.Name = "LDateError";
            this.LDateError.Size = new System.Drawing.Size(0, 12);
            this.LDateError.TabIndex = 10;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 401);
            this.Controls.Add(this.LDateError);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.DateTimePick);
            this.Controls.Add(this.LPassError);
            this.Controls.Add(this.LLoginError);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LLoginError;
        private System.Windows.Forms.Label LPassError;
        private System.Windows.Forms.DateTimePicker DateTimePick;
        private System.Windows.Forms.Button BAccept;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Label LDateError;
    }
}