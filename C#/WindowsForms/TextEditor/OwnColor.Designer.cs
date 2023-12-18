namespace TextEditor
{
    partial class OwnColor
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
            this.LRed = new System.Windows.Forms.Label();
            this.LGreen = new System.Windows.Forms.Label();
            this.LBlue = new System.Windows.Forms.Label();
            this.BOk = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.TrackR = new System.Windows.Forms.TrackBar();
            this.TrackG = new System.Windows.Forms.TrackBar();
            this.TrackB = new System.Windows.Forms.TrackBar();
            this.RTBCheckColor = new System.Windows.Forms.RichTextBox();
            this.TBRed = new System.Windows.Forms.TextBox();
            this.TBGreen = new System.Windows.Forms.TextBox();
            this.TBBlue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrackR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackB)).BeginInit();
            this.SuspendLayout();
            // 
            // LRed
            // 
            this.LRed.AutoSize = true;
            this.LRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LRed.Location = new System.Drawing.Point(12, 18);
            this.LRed.Name = "LRed";
            this.LRed.Size = new System.Drawing.Size(25, 20);
            this.LRed.TabIndex = 0;
            this.LRed.Text = "R:";
            // 
            // LGreen
            // 
            this.LGreen.AutoSize = true;
            this.LGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LGreen.Location = new System.Drawing.Point(13, 72);
            this.LGreen.Name = "LGreen";
            this.LGreen.Size = new System.Drawing.Size(26, 20);
            this.LGreen.TabIndex = 1;
            this.LGreen.Text = "G:";
            // 
            // LBlue
            // 
            this.LBlue.AutoSize = true;
            this.LBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBlue.Location = new System.Drawing.Point(13, 129);
            this.LBlue.Name = "LBlue";
            this.LBlue.Size = new System.Drawing.Size(24, 20);
            this.LBlue.TabIndex = 2;
            this.LBlue.Text = "B:";
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(167, 180);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(133, 49);
            this.BOk.TabIndex = 3;
            this.BOk.Text = "Принять";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(362, 180);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(133, 49);
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "Отменить";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // TrackR
            // 
            this.TrackR.Location = new System.Drawing.Point(101, 21);
            this.TrackR.Maximum = 255;
            this.TrackR.Name = "TrackR";
            this.TrackR.Size = new System.Drawing.Size(584, 45);
            this.TrackR.TabIndex = 5;
            this.TrackR.Scroll += new System.EventHandler(this.TrackR_Scroll);
            // 
            // TrackG
            // 
            this.TrackG.Location = new System.Drawing.Point(101, 72);
            this.TrackG.Maximum = 255;
            this.TrackG.Name = "TrackG";
            this.TrackG.Size = new System.Drawing.Size(584, 45);
            this.TrackG.TabIndex = 6;
            this.TrackG.Scroll += new System.EventHandler(this.TrackG_Scroll);
            // 
            // TrackB
            // 
            this.TrackB.Location = new System.Drawing.Point(101, 123);
            this.TrackB.Maximum = 255;
            this.TrackB.Name = "TrackB";
            this.TrackB.Size = new System.Drawing.Size(584, 45);
            this.TrackB.TabIndex = 7;
            this.TrackB.Scroll += new System.EventHandler(this.TrackB_Scroll);
            // 
            // RTBCheckColor
            // 
            this.RTBCheckColor.Location = new System.Drawing.Point(579, 180);
            this.RTBCheckColor.Name = "RTBCheckColor";
            this.RTBCheckColor.ReadOnly = true;
            this.RTBCheckColor.Size = new System.Drawing.Size(68, 62);
            this.RTBCheckColor.TabIndex = 8;
            this.RTBCheckColor.Text = "";
            // 
            // TBRed
            // 
            this.TBRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBRed.Location = new System.Drawing.Point(43, 18);
            this.TBRed.MaxLength = 255;
            this.TBRed.Name = "TBRed";
            this.TBRed.Size = new System.Drawing.Size(52, 26);
            this.TBRed.TabIndex = 9;
            this.TBRed.TextChanged += new System.EventHandler(this.TBRed_TextChanged);
            // 
            // TBGreen
            // 
            this.TBGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBGreen.Location = new System.Drawing.Point(43, 72);
            this.TBGreen.MaxLength = 255;
            this.TBGreen.Name = "TBGreen";
            this.TBGreen.Size = new System.Drawing.Size(52, 26);
            this.TBGreen.TabIndex = 10;
            this.TBGreen.TextChanged += new System.EventHandler(this.TBGreen_TextChanged);
            // 
            // TBBlue
            // 
            this.TBBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBBlue.Location = new System.Drawing.Point(43, 127);
            this.TBBlue.MaxLength = 255;
            this.TBBlue.Name = "TBBlue";
            this.TBBlue.Size = new System.Drawing.Size(52, 26);
            this.TBBlue.TabIndex = 11;
            this.TBBlue.TextChanged += new System.EventHandler(this.TBBlue_TextChanged);
            // 
            // OwnColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 273);
            this.Controls.Add(this.TBBlue);
            this.Controls.Add(this.TBGreen);
            this.Controls.Add(this.TBRed);
            this.Controls.Add(this.RTBCheckColor);
            this.Controls.Add(this.TrackB);
            this.Controls.Add(this.TrackG);
            this.Controls.Add(this.TrackR);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.LBlue);
            this.Controls.Add(this.LGreen);
            this.Controls.Add(this.LRed);
            this.MaximumSize = new System.Drawing.Size(722, 312);
            this.MinimumSize = new System.Drawing.Size(722, 312);
            this.Name = "OwnColor";
            this.Text = "OwnColor";
            ((System.ComponentModel.ISupportInitialize)(this.TrackR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LRed;
        private System.Windows.Forms.Label LGreen;
        private System.Windows.Forms.Label LBlue;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.TrackBar TrackR;
        private System.Windows.Forms.TrackBar TrackG;
        private System.Windows.Forms.TrackBar TrackB;
        private System.Windows.Forms.RichTextBox RTBCheckColor;
        private System.Windows.Forms.TextBox TBRed;
        private System.Windows.Forms.TextBox TBGreen;
        private System.Windows.Forms.TextBox TBBlue;
    }
}