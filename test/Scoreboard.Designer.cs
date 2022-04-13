namespace test
{
    partial class Scoreboard
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scorepointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreboardDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreboardDbDataSet = new test.ScoreboardDbDataSet();
            this.scoreboardDbTableAdapter = new test.ScoreboardDbDataSetTableAdapters.ScoreboardDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nicknameDataGridViewTextBoxColumn,
            this.scorepointsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scoreboardDbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(143, 456);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "CLOSE";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nick";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            // 
            // scorepointsDataGridViewTextBoxColumn
            // 
            this.scorepointsDataGridViewTextBoxColumn.DataPropertyName = "Scorepoints";
            this.scorepointsDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scorepointsDataGridViewTextBoxColumn.Name = "scorepointsDataGridViewTextBoxColumn";
            // 
            // scoreboardDbBindingSource
            // 
            this.scoreboardDbBindingSource.DataMember = "ScoreboardDb";
            this.scoreboardDbBindingSource.DataSource = this.scoreboardDbDataSet;
            // 
            // scoreboardDbDataSet
            // 
            this.scoreboardDbDataSet.DataSetName = "ScoreboardDbDataSet";
            this.scoreboardDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreboardDbTableAdapter
            // 
            this.scoreboardDbTableAdapter.ClearBeforeFill = true;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 496);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ScoreboardDbDataSet scoreboardDbDataSet;
        private System.Windows.Forms.BindingSource scoreboardDbBindingSource;
        private ScoreboardDbDataSetTableAdapters.ScoreboardDbTableAdapter scoreboardDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scorepointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CloseBtn;
    }
}