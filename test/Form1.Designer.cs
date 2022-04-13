namespace test
{
    partial class GameForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.ammoLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.LifesCounterLabel = new System.Windows.Forms.Label();
            this.BackToMenubtn = new System.Windows.Forms.Button();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // ammoLabel
            // 
            this.ammoLabel.AutoSize = true;
            this.ammoLabel.BackColor = System.Drawing.Color.Transparent;
            this.ammoLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ammoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ammoLabel.Location = new System.Drawing.Point(483, 718);
            this.ammoLabel.Name = "ammoLabel";
            this.ammoLabel.Size = new System.Drawing.Size(139, 34);
            this.ammoLabel.TabIndex = 0;
            this.ammoLabel.Text = "Ammo:10";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pointsLabel.Location = new System.Drawing.Point(1, 9);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(88, 25);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = "Points: 0";
            // 
            // LifesCounterLabel
            // 
            this.LifesCounterLabel.AutoSize = true;
            this.LifesCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.LifesCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LifesCounterLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LifesCounterLabel.Location = new System.Drawing.Point(1, 34);
            this.LifesCounterLabel.Name = "LifesCounterLabel";
            this.LifesCounterLabel.Size = new System.Drawing.Size(75, 25);
            this.LifesCounterLabel.TabIndex = 2;
            this.LifesCounterLabel.Text = "Lifes: 3";
            // 
            // BackToMenubtn
            // 
            this.BackToMenubtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackToMenubtn.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackToMenubtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BackToMenubtn.Location = new System.Drawing.Point(229, 614);
            this.BackToMenubtn.Name = "BackToMenubtn";
            this.BackToMenubtn.Size = new System.Drawing.Size(174, 64);
            this.BackToMenubtn.TabIndex = 4;
            this.BackToMenubtn.Text = "BACK TO MENU";
            this.BackToMenubtn.UseVisualStyleBackColor = false;
            this.BackToMenubtn.Click += new System.EventHandler(this.BackToMenubtn_Click);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LevelLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LevelLabel.Location = new System.Drawing.Point(1, 59);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(75, 25);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "Level 0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.space;
            this.ClientSize = new System.Drawing.Size(634, 761);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.BackToMenubtn);
            this.Controls.Add(this.LifesCounterLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.ammoLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label ammoLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label LifesCounterLabel;
        private System.Windows.Forms.Button BackToMenubtn;
        private System.Windows.Forms.Label LevelLabel;
    }
}

