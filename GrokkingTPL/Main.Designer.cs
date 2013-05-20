namespace GrokkingTPL
{
    partial class Main
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
            this.ParallelLoopButton = new System.Windows.Forms.Button();
            this.ParallelAggregationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParallelLoopButton
            // 
            this.ParallelLoopButton.Location = new System.Drawing.Point(13, 13);
            this.ParallelLoopButton.Name = "ParallelLoopButton";
            this.ParallelLoopButton.Size = new System.Drawing.Size(129, 23);
            this.ParallelLoopButton.TabIndex = 0;
            this.ParallelLoopButton.Text = "Parallel Loop";
            this.ParallelLoopButton.UseVisualStyleBackColor = true;
            this.ParallelLoopButton.Click += new System.EventHandler(this.ParallelLoopButton_Click);
            // 
            // ParallelAggregationButton
            // 
            this.ParallelAggregationButton.Location = new System.Drawing.Point(13, 42);
            this.ParallelAggregationButton.Name = "ParallelAggregationButton";
            this.ParallelAggregationButton.Size = new System.Drawing.Size(129, 23);
            this.ParallelAggregationButton.TabIndex = 0;
            this.ParallelAggregationButton.Text = "Parallel Aggregation";
            this.ParallelAggregationButton.UseVisualStyleBackColor = true;
            this.ParallelAggregationButton.Click += new System.EventHandler(this.ParallelAggregationButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 262);
            this.Controls.Add(this.ParallelAggregationButton);
            this.Controls.Add(this.ParallelLoopButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ParallelLoopButton;
        private System.Windows.Forms.Button ParallelAggregationButton;
    }
}

