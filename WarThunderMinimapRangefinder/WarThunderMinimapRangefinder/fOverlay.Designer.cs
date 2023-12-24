namespace WarThunderMinimapRangefinder
{
    partial class fOverlay
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
            this.lDistance = new System.Windows.Forms.Label();
            this.pbMinimapVector = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimapVector)).BeginInit();
            this.SuspendLayout();
            // 
            // lDistance
            // 
            this.lDistance.AutoSize = true;
            this.lDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDistance.ForeColor = System.Drawing.Color.Red;
            this.lDistance.Location = new System.Drawing.Point(0, 0);
            this.lDistance.Name = "lDistance";
            this.lDistance.Size = new System.Drawing.Size(133, 32);
            this.lDistance.TabIndex = 0;
            this.lDistance.Text = "Distance";
            this.lDistance.Click += new System.EventHandler(this.lDistance_Click);
            // 
            // pbMinimapVector
            // 
            this.pbMinimapVector.Location = new System.Drawing.Point(0, 35);
            this.pbMinimapVector.Name = "pbMinimapVector";
            this.pbMinimapVector.Size = new System.Drawing.Size(345, 345);
            this.pbMinimapVector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimapVector.TabIndex = 1;
            this.pbMinimapVector.TabStop = false;
            this.pbMinimapVector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMinimapVector_MouseClick);
            // 
            // fOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(425, 444);
            this.Controls.Add(this.pbMinimapVector);
            this.Controls.Add(this.lDistance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fOverlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fOverlay";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimapVector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDistance;
        private System.Windows.Forms.PictureBox pbMinimapVector;
    }
}