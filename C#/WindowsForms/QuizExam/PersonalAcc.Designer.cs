namespace QuizExam
{
    partial class PersonalAcc
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
            this.components = new System.ComponentModel.Container();
            this.BStartQuiz = new System.Windows.Forms.Button();
            this.BResult = new System.Windows.Forms.Button();
            this.BTop20 = new System.Windows.Forms.Button();
            this.CMSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BAdmin = new System.Windows.Forms.Button();
            this.BSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BStartQuiz
            // 
            this.BStartQuiz.Location = new System.Drawing.Point(106, 116);
            this.BStartQuiz.Name = "BStartQuiz";
            this.BStartQuiz.Size = new System.Drawing.Size(137, 67);
            this.BStartQuiz.TabIndex = 0;
            this.BStartQuiz.Text = "Старт";
            this.BStartQuiz.UseVisualStyleBackColor = true;
            this.BStartQuiz.Click += new System.EventHandler(this.BStartQuiz_Click);
            // 
            // BResult
            // 
            this.BResult.Location = new System.Drawing.Point(106, 216);
            this.BResult.Name = "BResult";
            this.BResult.Size = new System.Drawing.Size(137, 67);
            this.BResult.TabIndex = 1;
            this.BResult.Text = "Ваши результаты";
            this.BResult.UseVisualStyleBackColor = true;
            // 
            // BTop20
            // 
            this.BTop20.Location = new System.Drawing.Point(106, 312);
            this.BTop20.Name = "BTop20";
            this.BTop20.Size = new System.Drawing.Size(137, 67);
            this.BTop20.TabIndex = 2;
            this.BTop20.Text = "Топ 20";
            this.BTop20.UseVisualStyleBackColor = true;
            // 
            // CMSetting
            // 
            this.CMSetting.Name = "CMSetting";
            this.CMSetting.Size = new System.Drawing.Size(61, 4);
            this.CMSetting.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMSetting_ItemClicked);
            // 
            // BAdmin
            // 
            this.BAdmin.BackgroundImage = global::QuizExam.Properties.Resources.Wrench;
            this.BAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BAdmin.Location = new System.Drawing.Point(12, 12);
            this.BAdmin.Name = "BAdmin";
            this.BAdmin.Size = new System.Drawing.Size(53, 49);
            this.BAdmin.TabIndex = 4;
            this.BAdmin.UseVisualStyleBackColor = true;
            this.BAdmin.Click += new System.EventHandler(this.BAdmin_Click);
            // 
            // BSetting
            // 
            this.BSetting.BackgroundImage = global::QuizExam.Properties.Resources.GearWheel2;
            this.BSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BSetting.Location = new System.Drawing.Point(290, 12);
            this.BSetting.Name = "BSetting";
            this.BSetting.Size = new System.Drawing.Size(53, 49);
            this.BSetting.TabIndex = 3;
            this.BSetting.UseVisualStyleBackColor = true;
            this.BSetting.Click += new System.EventHandler(this.BSetting_Click);
            // 
            // PersonalAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 435);
            this.Controls.Add(this.BAdmin);
            this.Controls.Add(this.BSetting);
            this.Controls.Add(this.BTop20);
            this.Controls.Add(this.BResult);
            this.Controls.Add(this.BStartQuiz);
            this.Name = "PersonalAcc";
            this.Text = "Аккаунт";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BStartQuiz;
        private System.Windows.Forms.Button BResult;
        private System.Windows.Forms.Button BTop20;
        private System.Windows.Forms.Button BSetting;
        private System.Windows.Forms.Button BAdmin;
        private System.Windows.Forms.ContextMenuStrip CMSetting;
    }
}