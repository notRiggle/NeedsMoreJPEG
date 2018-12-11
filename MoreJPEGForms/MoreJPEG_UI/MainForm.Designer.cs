namespace MoreJPEG_UI
{
    partial class MainForm
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
            this.DoOnce = new System.Windows.Forms.Button();
            this.Continuous = new System.Windows.Forms.Button();
            this.JPEGLevel = new System.Windows.Forms.TextBox();
            this.LevelOfJPEG = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoOnce
            // 
            this.DoOnce.Location = new System.Drawing.Point(319, 89);
            this.DoOnce.Name = "DoOnce";
            this.DoOnce.Size = new System.Drawing.Size(75, 23);
            this.DoOnce.TabIndex = 0;
            this.DoOnce.Text = "JPEG once";
            this.DoOnce.UseVisualStyleBackColor = true;
            this.DoOnce.Click += new System.EventHandler(this.JPEGOnce_click);
            // 
            // Continuous
            // 
            this.Continuous.Location = new System.Drawing.Point(12, 89);
            this.Continuous.Name = "Continuous";
            this.Continuous.Size = new System.Drawing.Size(107, 23);
            this.Continuous.TabIndex = 1;
            this.Continuous.Text = "Continuous JPEG";
            this.Continuous.UseVisualStyleBackColor = true;
            this.Continuous.Click += new System.EventHandler(this.ContJPEG_click);
            // 
            // JPEGLevel
            // 
            this.JPEGLevel.Location = new System.Drawing.Point(182, 53);
            this.JPEGLevel.Name = "JPEGLevel";
            this.JPEGLevel.Size = new System.Drawing.Size(37, 20);
            this.JPEGLevel.TabIndex = 2;
            this.JPEGLevel.Text = "20";
            // 
            // LevelOfJPEG
            // 
            this.LevelOfJPEG.AutoSize = true;
            this.LevelOfJPEG.Location = new System.Drawing.Point(161, 37);
            this.LevelOfJPEG.Name = "LevelOfJPEG";
            this.LevelOfJPEG.Size = new System.Drawing.Size(75, 13);
            this.LevelOfJPEG.TabIndex = 3;
            this.LevelOfJPEG.Text = "Level of JPEG";
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(12, 9);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(53, 13);
            this.Test.TabIndex = 4;
            this.Test.Text = "Test label";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(406, 124);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.LevelOfJPEG);
            this.Controls.Add(this.JPEGLevel);
            this.Controls.Add(this.Continuous);
            this.Controls.Add(this.DoOnce);
            this.Name = "MainForm";
            this.Text = "Needs more JPEG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoOnce;
        private System.Windows.Forms.Button Continuous;
        private System.Windows.Forms.TextBox JPEGLevel;
        private System.Windows.Forms.Label LevelOfJPEG;
        private System.Windows.Forms.Label Test;
    }
}

