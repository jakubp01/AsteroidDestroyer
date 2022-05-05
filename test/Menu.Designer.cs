namespace test
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ScoreBoardBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(108, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "AsteroidDestroyer";
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Black;
            this.PlayBtn.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayBtn.Location = new System.Drawing.Point(182, 230);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(249, 67);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.Text = "PLAY";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // ScoreBoardBtn
            // 
            this.ScoreBoardBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScoreBoardBtn.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreBoardBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreBoardBtn.Location = new System.Drawing.Point(182, 313);
            this.ScoreBoardBtn.Name = "ScoreBoardBtn";
            this.ScoreBoardBtn.Size = new System.Drawing.Size(249, 67);
            this.ScoreBoardBtn.TabIndex = 2;
            this.ScoreBoardBtn.Text = "SCOREBOARD";
            this.ScoreBoardBtn.UseVisualStyleBackColor = false;
            this.ScoreBoardBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(182, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.space;
            this.ClientSize = new System.Drawing.Size(634, 761);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ScoreBoardBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button ScoreBoardBtn;
        private System.Windows.Forms.Button button3;
    }
}