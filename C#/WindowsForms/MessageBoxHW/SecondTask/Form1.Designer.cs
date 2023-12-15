namespace WindowsFormsApp3
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
            this.BStart = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.LUserN = new System.Windows.Forms.Label();
            this.LTry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BStart
            // 
            this.BStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStart.Location = new System.Drawing.Point(59, 115);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(84, 63);
            this.BStart.TabIndex = 0;
            this.BStart.Text = "Старт";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // BExit
            // 
            this.BExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExit.Location = new System.Drawing.Point(177, 115);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(84, 63);
            this.BExit.TabIndex = 1;
            this.BExit.Text = "Выход";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // LUserN
            // 
            this.LUserN.AutoSize = true;
            this.LUserN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LUserN.Location = new System.Drawing.Point(24, 22);
            this.LUserN.Name = "LUserN";
            this.LUserN.Size = new System.Drawing.Size(104, 20);
            this.LUserN.TabIndex = 2;
            this.LUserN.Text = "Ваше число:";
            // 
            // LTry
            // 
            this.LTry.AutoSize = true;
            this.LTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTry.Location = new System.Drawing.Point(24, 58);
            this.LTry.Name = "LTry";
            this.LTry.Size = new System.Drawing.Size(129, 20);
            this.LTry.TabIndex = 3;
            this.LTry.Text = "Число попыток:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 213);
            this.Controls.Add(this.LTry);
            this.Controls.Add(this.LUserN);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Label LUserN;
        private System.Windows.Forms.Label LTry;
    }
}

