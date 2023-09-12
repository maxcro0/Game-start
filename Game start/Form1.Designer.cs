namespace Game_start
{
    partial class gameBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameBackground));
            this.buttonStart = new System.Windows.Forms.Button();
            this.gameStartText = new System.Windows.Forms.Label();
            this.Countdown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStart.Location = new System.Drawing.Point(157, 202);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(117, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start game?";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameStartText
            // 
            this.gameStartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStartText.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gameStartText.Location = new System.Drawing.Point(46, 39);
            this.gameStartText.Name = "gameStartText";
            this.gameStartText.Size = new System.Drawing.Size(342, 57);
            this.gameStartText.TabIndex = 1;
            this.gameStartText.Text = "Game starting in:";
            this.gameStartText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameStartText.Click += new System.EventHandler(this.gameStartText_Click);
            // 
            // Countdown
            // 
            this.Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.ForeColor = System.Drawing.Color.Transparent;
            this.Countdown.Location = new System.Drawing.Point(154, 96);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(120, 102);
            this.Countdown.TabIndex = 2;
            this.Countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Countdown.Visible = false;
            this.Countdown.Click += new System.EventHandler(this.Countdown_Click);
            // 
            // gameBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(430, 420);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.gameStartText);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameBackground";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label gameStartText;
        private System.Windows.Forms.Label Countdown;
    }
}

