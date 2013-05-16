namespace GrokkingTPL
{
    partial class ParallelLoop
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
            this.ReadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.SequentialRadioButton = new System.Windows.Forms.RadioButton();
            this.ParallelRadioButton = new System.Windows.Forms.RadioButton();
            this.PlinqRadioButton = new System.Windows.Forms.RadioButton();
            this.ElapsedLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadFileDialog
            // 
            this.ReadFileDialog.DefaultExt = "txt";
            this.ReadFileDialog.Filter = "Text Files|*.txt";
            this.ReadFileDialog.Title = "Choose file to read";
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(12, 12);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(116, 23);
            this.ChooseFileButton.TabIndex = 0;
            this.ChooseFileButton.Text = "Choose File...";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 65);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsTextBox.Size = new System.Drawing.Size(860, 338);
            this.ResultsTextBox.TabIndex = 1;
            this.ResultsTextBox.WordWrap = false;
            // 
            // SequentialRadioButton
            // 
            this.SequentialRadioButton.AutoSize = true;
            this.SequentialRadioButton.Checked = true;
            this.SequentialRadioButton.Location = new System.Drawing.Point(13, 42);
            this.SequentialRadioButton.Name = "SequentialRadioButton";
            this.SequentialRadioButton.Size = new System.Drawing.Size(75, 17);
            this.SequentialRadioButton.TabIndex = 2;
            this.SequentialRadioButton.TabStop = true;
            this.SequentialRadioButton.Text = "Sequential";
            this.SequentialRadioButton.UseVisualStyleBackColor = true;
            // 
            // ParallelRadioButton
            // 
            this.ParallelRadioButton.AutoSize = true;
            this.ParallelRadioButton.Location = new System.Drawing.Point(94, 42);
            this.ParallelRadioButton.Name = "ParallelRadioButton";
            this.ParallelRadioButton.Size = new System.Drawing.Size(59, 17);
            this.ParallelRadioButton.TabIndex = 2;
            this.ParallelRadioButton.Text = "Parallel";
            this.ParallelRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlinqRadioButton
            // 
            this.PlinqRadioButton.AutoSize = true;
            this.PlinqRadioButton.Location = new System.Drawing.Point(159, 42);
            this.PlinqRadioButton.Name = "PlinqRadioButton";
            this.PlinqRadioButton.Size = new System.Drawing.Size(57, 17);
            this.PlinqRadioButton.TabIndex = 2;
            this.PlinqRadioButton.Text = "PLINQ";
            this.PlinqRadioButton.UseVisualStyleBackColor = true;
            // 
            // ElapsedLabel
            // 
            this.ElapsedLabel.AutoSize = true;
            this.ElapsedLabel.Location = new System.Drawing.Point(256, 18);
            this.ElapsedLabel.Name = "ElapsedLabel";
            this.ElapsedLabel.Size = new System.Drawing.Size(110, 13);
            this.ElapsedLabel.TabIndex = 3;
            this.ElapsedLabel.Text = "IO:  / CPU: / Writing: ";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(134, 13);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(116, 23);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ParallelLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 415);
            this.Controls.Add(this.ElapsedLabel);
            this.Controls.Add(this.PlinqRadioButton);
            this.Controls.Add(this.ParallelRadioButton);
            this.Controls.Add(this.SequentialRadioButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ChooseFileButton);
            this.Name = "ParallelLoop";
            this.Text = "Parallel Loop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ReadFileDialog;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.RadioButton SequentialRadioButton;
        private System.Windows.Forms.RadioButton ParallelRadioButton;
        private System.Windows.Forms.RadioButton PlinqRadioButton;
        private System.Windows.Forms.Label ElapsedLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}