namespace TicTacToe
{
    partial class WinForm
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
            this.LWinPlayer = new System.Windows.Forms.Label();
            this.BNewGame = new System.Windows.Forms.Button();
            this.BEndGame = new System.Windows.Forms.Button();
            this.TBWin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LWinPlayer
            // 
            this.LWinPlayer.AutoSize = true;
            this.LWinPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LWinPlayer.Location = new System.Drawing.Point(29, 21);
            this.LWinPlayer.Name = "LWinPlayer";
            this.LWinPlayer.Size = new System.Drawing.Size(0, 20);
            this.LWinPlayer.TabIndex = 0;
            // 
            // BNewGame
            // 
            this.BNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BNewGame.Location = new System.Drawing.Point(65, 76);
            this.BNewGame.Name = "BNewGame";
            this.BNewGame.Size = new System.Drawing.Size(166, 56);
            this.BNewGame.TabIndex = 1;
            this.BNewGame.Text = "Новая игра";
            this.BNewGame.UseVisualStyleBackColor = true;
            this.BNewGame.Click += new System.EventHandler(this.BNewGame_Click);
            // 
            // BEndGame
            // 
            this.BEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEndGame.Location = new System.Drawing.Point(250, 76);
            this.BEndGame.Name = "BEndGame";
            this.BEndGame.Size = new System.Drawing.Size(166, 56);
            this.BEndGame.TabIndex = 2;
            this.BEndGame.Text = "Закончить игру";
            this.BEndGame.UseVisualStyleBackColor = true;
            this.BEndGame.Click += new System.EventHandler(this.BEndGame_Click);
            // 
            // TBWin
            // 
            this.TBWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBWin.Location = new System.Drawing.Point(289, 21);
            this.TBWin.Name = "TBWin";
            this.TBWin.Size = new System.Drawing.Size(206, 26);
            this.TBWin.TabIndex = 3;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 151);
            this.Controls.Add(this.TBWin);
            this.Controls.Add(this.BEndGame);
            this.Controls.Add(this.BNewGame);
            this.Controls.Add(this.LWinPlayer);
            this.Name = "WinForm";
            this.Text = "Игра окончена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LWinPlayer;
        private System.Windows.Forms.Button BNewGame;
        private System.Windows.Forms.Button BEndGame;
        private System.Windows.Forms.TextBox TBWin;
    }
}