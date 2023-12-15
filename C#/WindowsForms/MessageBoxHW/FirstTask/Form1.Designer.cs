namespace WindowsFormsApp2
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
            this.LNameW = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.LAge = new System.Windows.Forms.Label();
            this.LStudy = new System.Windows.Forms.Label();
            this.BStart = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.TBWork = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBAge = new System.Windows.Forms.TextBox();
            this.TBStudy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBWorkExp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LNameW
            // 
            this.LNameW.AutoSize = true;
            this.LNameW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNameW.Location = new System.Drawing.Point(13, 244);
            this.LNameW.Name = "LNameW";
            this.LNameW.Size = new System.Drawing.Size(128, 20);
            this.LNameW.TabIndex = 0;
            this.LNameW.Text = "Специальность";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(13, 46);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(40, 20);
            this.LName.TabIndex = 1;
            this.LName.Text = "Имя";
            // 
            // LAge
            // 
            this.LAge.AutoSize = true;
            this.LAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAge.Location = new System.Drawing.Point(13, 78);
            this.LAge.Name = "LAge";
            this.LAge.Size = new System.Drawing.Size(72, 20);
            this.LAge.TabIndex = 2;
            this.LAge.Text = "Возраст";
            // 
            // LStudy
            // 
            this.LStudy.AutoSize = true;
            this.LStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LStudy.Location = new System.Drawing.Point(13, 158);
            this.LStudy.Name = "LStudy";
            this.LStudy.Size = new System.Drawing.Size(110, 20);
            this.LStudy.TabIndex = 3;
            this.LStudy.Text = "Образование";
            // 
            // BStart
            // 
            this.BStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStart.Location = new System.Drawing.Point(70, 343);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(132, 59);
            this.BStart.TabIndex = 5;
            this.BStart.Text = "Заполнить";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // BExit
            // 
            this.BExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExit.Location = new System.Drawing.Point(362, 343);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(132, 59);
            this.BExit.TabIndex = 6;
            this.BExit.Text = "Выход";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // TBWork
            // 
            this.TBWork.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBWork.Location = new System.Drawing.Point(145, 241);
            this.TBWork.Name = "TBWork";
            this.TBWork.Size = new System.Drawing.Size(413, 26);
            this.TBWork.TabIndex = 7;
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBName.Location = new System.Drawing.Point(57, 41);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(501, 26);
            this.TBName.TabIndex = 8;
            // 
            // TBAge
            // 
            this.TBAge.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAge.Location = new System.Drawing.Point(89, 73);
            this.TBAge.Name = "TBAge";
            this.TBAge.Size = new System.Drawing.Size(469, 26);
            this.TBAge.TabIndex = 9;
            // 
            // TBStudy
            // 
            this.TBStudy.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBStudy.Location = new System.Drawing.Point(127, 153);
            this.TBStudy.Name = "TBStudy";
            this.TBStudy.Size = new System.Drawing.Size(431, 26);
            this.TBStudy.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Личная информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(202, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Информация о образовании";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(202, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Информация о работе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Опыт работы";
            // 
            // TBWorkExp
            // 
            this.TBWorkExp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBWorkExp.Location = new System.Drawing.Point(145, 279);
            this.TBWorkExp.Name = "TBWorkExp";
            this.TBWorkExp.Size = new System.Drawing.Size(413, 26);
            this.TBWorkExp.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 435);
            this.Controls.Add(this.TBWorkExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBStudy);
            this.Controls.Add(this.TBAge);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.TBWork);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BStart);
            this.Controls.Add(this.LStudy);
            this.Controls.Add(this.LAge);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LNameW);
            this.Name = "Form1";
            this.Text = "Резюме";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNameW;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LAge;
        private System.Windows.Forms.Label LStudy;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.TextBox TBWork;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBAge;
        private System.Windows.Forms.TextBox TBStudy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBWorkExp;
    }
}

