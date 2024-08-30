namespace QuizExam
{
    partial class Quiz
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
            this.CLBAnswer = new System.Windows.Forms.CheckedListBox();
            this.BNext = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.LQuestion = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CLBAnswer
            // 
            this.CLBAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CLBAnswer.FormattingEnabled = true;
            this.CLBAnswer.Location = new System.Drawing.Point(26, 123);
            this.CLBAnswer.Name = "CLBAnswer";
            this.CLBAnswer.Size = new System.Drawing.Size(431, 277);
            this.CLBAnswer.TabIndex = 1;
            this.CLBAnswer.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBAnswer_ItemCheck);
            // 
            // BNext
            // 
            this.BNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BNext.Location = new System.Drawing.Point(376, 406);
            this.BNext.Name = "BNext";
            this.BNext.Size = new System.Drawing.Size(81, 41);
            this.BNext.TabIndex = 2;
            this.BNext.Text = "Дальше";
            this.BNext.UseVisualStyleBackColor = true;
            this.BNext.Click += new System.EventHandler(this.BNext_Click);
            // 
            // BBack
            // 
            this.BBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBack.Location = new System.Drawing.Point(26, 406);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(81, 41);
            this.BBack.TabIndex = 3;
            this.BBack.Text = "Назад";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // LQuestion
            // 
            this.LQuestion.AutoSize = true;
            this.LQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LQuestion.Location = new System.Drawing.Point(3, 0);
            this.LQuestion.Name = "LQuestion";
            this.LQuestion.Size = new System.Drawing.Size(105, 24);
            this.LQuestion.TabIndex = 0;
            this.LQuestion.Text = "LQuestion";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LQuestion);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(431, 105);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 459);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BNext);
            this.Controls.Add(this.CLBAnswer);
            this.Name = "Quiz";
            this.Text = "Викторина";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox CLBAnswer;
        private System.Windows.Forms.Button BNext;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Label LQuestion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}