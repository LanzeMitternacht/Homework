namespace WindowsFormsApp1
{
    partial class Clicker
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
            this.BCLick = new System.Windows.Forms.Button();
            this.BReset = new System.Windows.Forms.Button();
            this.LNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCLick
            // 
            this.BCLick.Location = new System.Drawing.Point(66, 105);
            this.BCLick.Name = "BCLick";
            this.BCLick.Size = new System.Drawing.Size(94, 59);
            this.BCLick.TabIndex = 0;
            this.BCLick.Text = "Клик";
            this.BCLick.UseVisualStyleBackColor = true;
            this.BCLick.Click += new System.EventHandler(this.BCLick_Click);
            // 
            // BReset
            // 
            this.BReset.Location = new System.Drawing.Point(206, 105);
            this.BReset.Name = "BReset";
            this.BReset.Size = new System.Drawing.Size(94, 59);
            this.BReset.TabIndex = 1;
            this.BReset.Text = "Сброс";
            this.BReset.UseVisualStyleBackColor = true;
            this.BReset.Click += new System.EventHandler(this.BReset_Click);
            // 
            // LNumber
            // 
            this.LNumber.AutoSize = true;
            this.LNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNumber.Location = new System.Drawing.Point(157, 26);
            this.LNumber.Name = "LNumber";
            this.LNumber.Size = new System.Drawing.Size(51, 55);
            this.LNumber.TabIndex = 2;
            this.LNumber.Text = "0";
            // 
            // Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 186);
            this.Controls.Add(this.LNumber);
            this.Controls.Add(this.BReset);
            this.Controls.Add(this.BCLick);
            this.Name = "Clicker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCLick;
        private System.Windows.Forms.Button BReset;
        private System.Windows.Forms.Label LNumber;
    }
}

