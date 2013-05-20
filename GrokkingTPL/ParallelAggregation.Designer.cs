namespace GrokkingTPL
{
    partial class ParallelAggregation
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
            this.ElapsedLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.ReadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.WordsGridView = new System.Windows.Forms.DataGridView();
            this.WordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlinqRadioButton = new System.Windows.Forms.RadioButton();
            this.ParallelRadioButton = new System.Windows.Forms.RadioButton();
            this.SequentialRadioButton = new System.Windows.Forms.RadioButton();
            this.BadParallelRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.WordsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ElapsedLabel
            // 
            this.ElapsedLabel.AutoSize = true;
            this.ElapsedLabel.Location = new System.Drawing.Point(256, 18);
            this.ElapsedLabel.Name = "ElapsedLabel";
            this.ElapsedLabel.Size = new System.Drawing.Size(110, 13);
            this.ElapsedLabel.TabIndex = 6;
            this.ElapsedLabel.Text = "IO:  / CPU: / Writing: ";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(134, 13);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(116, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(12, 12);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(116, 23);
            this.ChooseFileButton.TabIndex = 4;
            this.ChooseFileButton.Text = "Choose File...";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // ReadFileDialog
            // 
            this.ReadFileDialog.DefaultExt = "txt";
            this.ReadFileDialog.Filter = "Text Files|*.txt";
            this.ReadFileDialog.Title = "Choose File";
            // 
            // WordsGridView
            // 
            this.WordsGridView.AllowUserToAddRows = false;
            this.WordsGridView.AllowUserToDeleteRows = false;
            this.WordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WordColumn,
            this.CountColumn});
            this.WordsGridView.Location = new System.Drawing.Point(13, 64);
            this.WordsGridView.Name = "WordsGridView";
            this.WordsGridView.ReadOnly = true;
            this.WordsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.WordsGridView.ShowEditingIcon = false;
            this.WordsGridView.Size = new System.Drawing.Size(468, 231);
            this.WordsGridView.TabIndex = 7;
            // 
            // WordColumn
            // 
            this.WordColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WordColumn.DataPropertyName = "Word";
            this.WordColumn.HeaderText = "Word";
            this.WordColumn.Name = "WordColumn";
            this.WordColumn.ReadOnly = true;
            // 
            // CountColumn
            // 
            this.CountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CountColumn.DataPropertyName = "Count";
            this.CountColumn.HeaderText = "Count";
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.ReadOnly = true;
            // 
            // PlinqRadioButton
            // 
            this.PlinqRadioButton.AutoSize = true;
            this.PlinqRadioButton.Location = new System.Drawing.Point(159, 41);
            this.PlinqRadioButton.Name = "PlinqRadioButton";
            this.PlinqRadioButton.Size = new System.Drawing.Size(57, 17);
            this.PlinqRadioButton.TabIndex = 10;
            this.PlinqRadioButton.Text = "PLINQ";
            this.PlinqRadioButton.UseVisualStyleBackColor = true;
            // 
            // ParallelRadioButton
            // 
            this.ParallelRadioButton.AutoSize = true;
            this.ParallelRadioButton.Location = new System.Drawing.Point(94, 41);
            this.ParallelRadioButton.Name = "ParallelRadioButton";
            this.ParallelRadioButton.Size = new System.Drawing.Size(59, 17);
            this.ParallelRadioButton.TabIndex = 9;
            this.ParallelRadioButton.Text = "Parallel";
            this.ParallelRadioButton.UseVisualStyleBackColor = true;
            // 
            // SequentialRadioButton
            // 
            this.SequentialRadioButton.AutoSize = true;
            this.SequentialRadioButton.Checked = true;
            this.SequentialRadioButton.Location = new System.Drawing.Point(13, 41);
            this.SequentialRadioButton.Name = "SequentialRadioButton";
            this.SequentialRadioButton.Size = new System.Drawing.Size(75, 17);
            this.SequentialRadioButton.TabIndex = 8;
            this.SequentialRadioButton.TabStop = true;
            this.SequentialRadioButton.Text = "Sequential";
            this.SequentialRadioButton.UseVisualStyleBackColor = true;
            // 
            // BadParallelRadioButton
            // 
            this.BadParallelRadioButton.AutoSize = true;
            this.BadParallelRadioButton.Location = new System.Drawing.Point(222, 41);
            this.BadParallelRadioButton.Name = "BadParallelRadioButton";
            this.BadParallelRadioButton.Size = new System.Drawing.Size(81, 17);
            this.BadParallelRadioButton.TabIndex = 10;
            this.BadParallelRadioButton.Text = "Bad Parallel";
            this.BadParallelRadioButton.UseVisualStyleBackColor = true;
            // 
            // ParallelAggregation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 307);
            this.Controls.Add(this.BadParallelRadioButton);
            this.Controls.Add(this.PlinqRadioButton);
            this.Controls.Add(this.ParallelRadioButton);
            this.Controls.Add(this.SequentialRadioButton);
            this.Controls.Add(this.WordsGridView);
            this.Controls.Add(this.ElapsedLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ChooseFileButton);
            this.Name = "ParallelAggregation";
            this.Text = "ParallelAggregation";
            ((System.ComponentModel.ISupportInitialize)(this.WordsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ElapsedLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.OpenFileDialog ReadFileDialog;
        private System.Windows.Forms.DataGridView WordsGridView;
        private System.Windows.Forms.RadioButton PlinqRadioButton;
        private System.Windows.Forms.RadioButton ParallelRadioButton;
        private System.Windows.Forms.RadioButton SequentialRadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.RadioButton BadParallelRadioButton;
    }
}