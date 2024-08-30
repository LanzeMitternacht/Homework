namespace QuizExam
{
    partial class SelectionMenu
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
            this.BHistory = new System.Windows.Forms.Button();
            this.BBiology = new System.Windows.Forms.Button();
            this.BRandom = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BHistory
            // 
            this.BHistory.Location = new System.Drawing.Point(85, 46);
            this.BHistory.Name = "BHistory";
            this.BHistory.Size = new System.Drawing.Size(115, 58);
            this.BHistory.TabIndex = 0;
            this.BHistory.Text = "История";
            this.BHistory.UseVisualStyleBackColor = true;
            this.BHistory.Click += new System.EventHandler(this.BHistory_Click);
            // 
            // BBiology
            // 
            this.BBiology.Location = new System.Drawing.Point(85, 134);
            this.BBiology.Name = "BBiology";
            this.BBiology.Size = new System.Drawing.Size(115, 58);
            this.BBiology.TabIndex = 1;
            this.BBiology.Text = "Биология";
            this.BBiology.UseVisualStyleBackColor = true;
            // 
            // BRandom
            // 
            this.BRandom.Location = new System.Drawing.Point(85, 222);
            this.BRandom.Name = "BRandom";
            this.BRandom.Size = new System.Drawing.Size(115, 58);
            this.BRandom.TabIndex = 2;
            this.BRandom.Text = "Смешанные";
            this.BRandom.UseVisualStyleBackColor = true;
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(85, 349);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(115, 58);
            this.BExit.TabIndex = 3;
            this.BExit.Text = "Выход";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // SelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 461);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BRandom);
            this.Controls.Add(this.BBiology);
            this.Controls.Add(this.BHistory);
            this.Name = "SelectionMenu";
            this.Text = "Темы для викторины";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BHistory;
        private System.Windows.Forms.Button BBiology;
        private System.Windows.Forms.Button BRandom;
        private System.Windows.Forms.Button BExit;
    }
}