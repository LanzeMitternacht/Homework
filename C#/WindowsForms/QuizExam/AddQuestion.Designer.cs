namespace QuizExam
{
    partial class AddQuestion
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.BAddQue = new System.Windows.Forms.Button();
            this.BDeleteQue = new System.Windows.Forms.Button();
            this.BEditQue = new System.Windows.Forms.Button();
            this.BSaveQue = new System.Windows.Forms.Button();
            this.TBQuestion = new System.Windows.Forms.TextBox();
            this.TBAnswer = new System.Windows.Forms.TextBox();
            this.TBCorQue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataGridView.Location = new System.Drawing.Point(12, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(598, 506);
            this.DataGridView.TabIndex = 0;
            // 
            // BAddQue
            // 
            this.BAddQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddQue.Location = new System.Drawing.Point(12, 524);
            this.BAddQue.Name = "BAddQue";
            this.BAddQue.Size = new System.Drawing.Size(145, 56);
            this.BAddQue.TabIndex = 1;
            this.BAddQue.Text = "Добавить";
            this.BAddQue.UseVisualStyleBackColor = true;
            this.BAddQue.Click += new System.EventHandler(this.BAddQue_Click);
            // 
            // BDeleteQue
            // 
            this.BDeleteQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDeleteQue.Location = new System.Drawing.Point(163, 524);
            this.BDeleteQue.Name = "BDeleteQue";
            this.BDeleteQue.Size = new System.Drawing.Size(145, 56);
            this.BDeleteQue.TabIndex = 2;
            this.BDeleteQue.Text = "Удалить";
            this.BDeleteQue.UseVisualStyleBackColor = true;
            this.BDeleteQue.Click += new System.EventHandler(this.BDeleteQue_Click);
            // 
            // BEditQue
            // 
            this.BEditQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEditQue.Location = new System.Drawing.Point(314, 524);
            this.BEditQue.Name = "BEditQue";
            this.BEditQue.Size = new System.Drawing.Size(145, 56);
            this.BEditQue.TabIndex = 3;
            this.BEditQue.Text = "Редактировать";
            this.BEditQue.UseVisualStyleBackColor = true;
            this.BEditQue.Click += new System.EventHandler(this.BEditQue_Click);
            // 
            // BSaveQue
            // 
            this.BSaveQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSaveQue.Location = new System.Drawing.Point(465, 524);
            this.BSaveQue.Name = "BSaveQue";
            this.BSaveQue.Size = new System.Drawing.Size(145, 56);
            this.BSaveQue.TabIndex = 4;
            this.BSaveQue.Text = "Сохранить";
            this.BSaveQue.UseVisualStyleBackColor = true;
            this.BSaveQue.Click += new System.EventHandler(this.BSaveQue_Click);
            // 
            // TBQuestion
            // 
            this.TBQuestion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBQuestion.Location = new System.Drawing.Point(664, 37);
            this.TBQuestion.Name = "TBQuestion";
            this.TBQuestion.Size = new System.Drawing.Size(472, 26);
            this.TBQuestion.TabIndex = 5;
            // 
            // TBAnswer
            // 
            this.TBAnswer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAnswer.Location = new System.Drawing.Point(664, 102);
            this.TBAnswer.Name = "TBAnswer";
            this.TBAnswer.Size = new System.Drawing.Size(472, 26);
            this.TBAnswer.TabIndex = 6;
            // 
            // TBCorQue
            // 
            this.TBCorQue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBCorQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBCorQue.Location = new System.Drawing.Point(664, 169);
            this.TBCorQue.Name = "TBCorQue";
            this.TBCorQue.Size = new System.Drawing.Size(472, 26);
            this.TBCorQue.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(817, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Правильный ответ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(858, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ответ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(858, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вопрос";
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1183, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCorQue);
            this.Controls.Add(this.TBAnswer);
            this.Controls.Add(this.TBQuestion);
            this.Controls.Add(this.BSaveQue);
            this.Controls.Add(this.BEditQue);
            this.Controls.Add(this.BDeleteQue);
            this.Controls.Add(this.BAddQue);
            this.Controls.Add(this.DataGridView);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BAddQue;
        private System.Windows.Forms.Button BDeleteQue;
        private System.Windows.Forms.Button BEditQue;
        private System.Windows.Forms.Button BSaveQue;
        private System.Windows.Forms.TextBox TBQuestion;
        private System.Windows.Forms.TextBox TBAnswer;
        private System.Windows.Forms.TextBox TBCorQue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}