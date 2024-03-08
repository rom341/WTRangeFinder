namespace WarThunderMinimapRangefinder
{
    partial class fOverlaySettings
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
            this.btnMoveLabelFormRight = new System.Windows.Forms.Button();
            this.btnMoveLabelFormUp = new System.Windows.Forms.Button();
            this.btnMoveLabelFormLeft = new System.Windows.Forms.Button();
            this.btnMoveLabelFormDown = new System.Windows.Forms.Button();
            this.tbMoveStep = new System.Windows.Forms.TextBox();
            this.gbOverlayPosition = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnOverlayLabelFont = new System.Windows.Forms.Button();
            this.gbPBVectorSize = new System.Windows.Forms.GroupBox();
            this.lPBVectorHeight = new System.Windows.Forms.Label();
            this.btnPBVectorHeightPlus = new System.Windows.Forms.Button();
            this.lPBVectorWidth = new System.Windows.Forms.Label();
            this.btnPBVectorWidthPlus = new System.Windows.Forms.Button();
            this.btnPBVectorHeightMinus = new System.Windows.Forms.Button();
            this.tbPBVectorSize = new System.Windows.Forms.TextBox();
            this.btnPBVectorWidthMinus = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.lOverlayPosition = new System.Windows.Forms.Label();
            this.lPBVectorSize = new System.Windows.Forms.Label();
            this.gbOverlayPosition.SuspendLayout();
            this.gbPBVectorSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoveLabelFormRight
            // 
            this.btnMoveLabelFormRight.Location = new System.Drawing.Point(173, 59);
            this.btnMoveLabelFormRight.Name = "btnMoveLabelFormRight";
            this.btnMoveLabelFormRight.Size = new System.Drawing.Size(83, 40);
            this.btnMoveLabelFormRight.TabIndex = 0;
            this.btnMoveLabelFormRight.Text = "Move right";
            this.btnMoveLabelFormRight.UseVisualStyleBackColor = true;
            this.btnMoveLabelFormRight.Click += new System.EventHandler(this.btnMoveLabelFormRight_Click);
            // 
            // btnMoveLabelFormUp
            // 
            this.btnMoveLabelFormUp.Location = new System.Drawing.Point(89, 21);
            this.btnMoveLabelFormUp.Name = "btnMoveLabelFormUp";
            this.btnMoveLabelFormUp.Size = new System.Drawing.Size(83, 40);
            this.btnMoveLabelFormUp.TabIndex = 1;
            this.btnMoveLabelFormUp.Text = "Move up";
            this.btnMoveLabelFormUp.UseVisualStyleBackColor = true;
            this.btnMoveLabelFormUp.Click += new System.EventHandler(this.btnMoveLabelFormUp_Click);
            // 
            // btnMoveLabelFormLeft
            // 
            this.btnMoveLabelFormLeft.Location = new System.Drawing.Point(6, 58);
            this.btnMoveLabelFormLeft.Name = "btnMoveLabelFormLeft";
            this.btnMoveLabelFormLeft.Size = new System.Drawing.Size(83, 40);
            this.btnMoveLabelFormLeft.TabIndex = 2;
            this.btnMoveLabelFormLeft.Text = "Move left";
            this.btnMoveLabelFormLeft.UseVisualStyleBackColor = true;
            this.btnMoveLabelFormLeft.Click += new System.EventHandler(this.btnMoveLabelFormLeft_Click);
            // 
            // btnMoveLabelFormDown
            // 
            this.btnMoveLabelFormDown.Location = new System.Drawing.Point(89, 105);
            this.btnMoveLabelFormDown.Name = "btnMoveLabelFormDown";
            this.btnMoveLabelFormDown.Size = new System.Drawing.Size(83, 40);
            this.btnMoveLabelFormDown.TabIndex = 3;
            this.btnMoveLabelFormDown.Text = "Move down";
            this.btnMoveLabelFormDown.UseVisualStyleBackColor = true;
            this.btnMoveLabelFormDown.Click += new System.EventHandler(this.btnMoveLabelFormDown_Click);
            // 
            // tbMoveStep
            // 
            this.tbMoveStep.Location = new System.Drawing.Point(95, 67);
            this.tbMoveStep.Name = "tbMoveStep";
            this.tbMoveStep.Size = new System.Drawing.Size(72, 22);
            this.tbMoveStep.TabIndex = 4;
            this.tbMoveStep.Text = "10";
            this.tbMoveStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMoveStep.TextChanged += new System.EventHandler(this.tbMoveStep_TextChanged);
            // 
            // gbOverlayPosition
            // 
            this.gbOverlayPosition.Controls.Add(this.btnMoveLabelFormUp);
            this.gbOverlayPosition.Controls.Add(this.lOverlayPosition);
            this.gbOverlayPosition.Controls.Add(this.tbMoveStep);
            this.gbOverlayPosition.Controls.Add(this.btnMoveLabelFormRight);
            this.gbOverlayPosition.Controls.Add(this.btnMoveLabelFormDown);
            this.gbOverlayPosition.Controls.Add(this.btnMoveLabelFormLeft);
            this.gbOverlayPosition.Location = new System.Drawing.Point(12, 12);
            this.gbOverlayPosition.Name = "gbOverlayPosition";
            this.gbOverlayPosition.Size = new System.Drawing.Size(275, 199);
            this.gbOverlayPosition.TabIndex = 5;
            this.gbOverlayPosition.TabStop = false;
            this.gbOverlayPosition.Text = "Overlay position";
            // 
            // btnOverlayLabelFont
            // 
            this.btnOverlayLabelFont.Location = new System.Drawing.Point(185, 277);
            this.btnOverlayLabelFont.Name = "btnOverlayLabelFont";
            this.btnOverlayLabelFont.Size = new System.Drawing.Size(225, 23);
            this.btnOverlayLabelFont.TabIndex = 6;
            this.btnOverlayLabelFont.Text = "Overlay label font";
            this.btnOverlayLabelFont.UseVisualStyleBackColor = true;
            this.btnOverlayLabelFont.Click += new System.EventHandler(this.btnOverlayLabelFont_Click);
            // 
            // gbPBVectorSize
            // 
            this.gbPBVectorSize.Controls.Add(this.lPBVectorSize);
            this.gbPBVectorSize.Controls.Add(this.lPBVectorHeight);
            this.gbPBVectorSize.Controls.Add(this.btnPBVectorHeightPlus);
            this.gbPBVectorSize.Controls.Add(this.lPBVectorWidth);
            this.gbPBVectorSize.Controls.Add(this.btnPBVectorWidthPlus);
            this.gbPBVectorSize.Controls.Add(this.btnPBVectorHeightMinus);
            this.gbPBVectorSize.Controls.Add(this.tbPBVectorSize);
            this.gbPBVectorSize.Controls.Add(this.btnPBVectorWidthMinus);
            this.gbPBVectorSize.Location = new System.Drawing.Point(293, 12);
            this.gbPBVectorSize.Name = "gbPBVectorSize";
            this.gbPBVectorSize.Size = new System.Drawing.Size(264, 199);
            this.gbPBVectorSize.TabIndex = 7;
            this.gbPBVectorSize.TabStop = false;
            this.gbPBVectorSize.Text = "Vector picturebox size";
            // 
            // lPBVectorHeight
            // 
            this.lPBVectorHeight.AutoSize = true;
            this.lPBVectorHeight.Location = new System.Drawing.Point(110, 125);
            this.lPBVectorHeight.Name = "lPBVectorHeight";
            this.lPBVectorHeight.Size = new System.Drawing.Size(46, 16);
            this.lPBVectorHeight.TabIndex = 5;
            this.lPBVectorHeight.Text = "Height";
            // 
            // btnPBVectorHeightPlus
            // 
            this.btnPBVectorHeightPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPBVectorHeightPlus.Location = new System.Drawing.Point(175, 105);
            this.btnPBVectorHeightPlus.Name = "btnPBVectorHeightPlus";
            this.btnPBVectorHeightPlus.Size = new System.Drawing.Size(83, 40);
            this.btnPBVectorHeightPlus.TabIndex = 0;
            this.btnPBVectorHeightPlus.Text = "+";
            this.btnPBVectorHeightPlus.UseVisualStyleBackColor = true;
            this.btnPBVectorHeightPlus.Click += new System.EventHandler(this.btnPBVectorHeightPlus_Click);
            // 
            // lPBVectorWidth
            // 
            this.lPBVectorWidth.AutoSize = true;
            this.lPBVectorWidth.Location = new System.Drawing.Point(110, 21);
            this.lPBVectorWidth.Name = "lPBVectorWidth";
            this.lPBVectorWidth.Size = new System.Drawing.Size(41, 16);
            this.lPBVectorWidth.TabIndex = 5;
            this.lPBVectorWidth.Text = "Width";
            // 
            // btnPBVectorWidthPlus
            // 
            this.btnPBVectorWidthPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPBVectorWidthPlus.Location = new System.Drawing.Point(175, 21);
            this.btnPBVectorWidthPlus.Name = "btnPBVectorWidthPlus";
            this.btnPBVectorWidthPlus.Size = new System.Drawing.Size(83, 40);
            this.btnPBVectorWidthPlus.TabIndex = 0;
            this.btnPBVectorWidthPlus.Text = "+";
            this.btnPBVectorWidthPlus.UseVisualStyleBackColor = true;
            this.btnPBVectorWidthPlus.Click += new System.EventHandler(this.btnPBVectorWidthPlus_Click);
            // 
            // btnPBVectorHeightMinus
            // 
            this.btnPBVectorHeightMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPBVectorHeightMinus.Location = new System.Drawing.Point(5, 106);
            this.btnPBVectorHeightMinus.Name = "btnPBVectorHeightMinus";
            this.btnPBVectorHeightMinus.Size = new System.Drawing.Size(83, 40);
            this.btnPBVectorHeightMinus.TabIndex = 2;
            this.btnPBVectorHeightMinus.Text = "-";
            this.btnPBVectorHeightMinus.UseVisualStyleBackColor = true;
            this.btnPBVectorHeightMinus.Click += new System.EventHandler(this.btnPBVectorHeightMinus_Click);
            // 
            // tbPBVectorSize
            // 
            this.tbPBVectorSize.Location = new System.Drawing.Point(94, 76);
            this.tbPBVectorSize.Name = "tbPBVectorSize";
            this.tbPBVectorSize.Size = new System.Drawing.Size(72, 22);
            this.tbPBVectorSize.TabIndex = 4;
            this.tbPBVectorSize.Text = "10";
            this.tbPBVectorSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPBVectorSize.TextChanged += new System.EventHandler(this.tbPBVectorSize_TextChanged);
            // 
            // btnPBVectorWidthMinus
            // 
            this.btnPBVectorWidthMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPBVectorWidthMinus.Location = new System.Drawing.Point(5, 21);
            this.btnPBVectorWidthMinus.Name = "btnPBVectorWidthMinus";
            this.btnPBVectorWidthMinus.Size = new System.Drawing.Size(83, 40);
            this.btnPBVectorWidthMinus.TabIndex = 2;
            this.btnPBVectorWidthMinus.Text = "-";
            this.btnPBVectorWidthMinus.UseVisualStyleBackColor = true;
            this.btnPBVectorWidthMinus.Click += new System.EventHandler(this.btnPBVectorWidthMinus_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(320, 316);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(90, 23);
            this.btnload.TabIndex = 9;
            this.btnload.Text = "load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // lOverlayPosition
            // 
            this.lOverlayPosition.AutoSize = true;
            this.lOverlayPosition.Location = new System.Drawing.Point(6, 170);
            this.lOverlayPosition.Name = "lOverlayPosition";
            this.lOverlayPosition.Size = new System.Drawing.Size(0, 16);
            this.lOverlayPosition.TabIndex = 10;
            this.lOverlayPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lPBVectorSize
            // 
            this.lPBVectorSize.AutoSize = true;
            this.lPBVectorSize.Location = new System.Drawing.Point(6, 170);
            this.lPBVectorSize.Name = "lPBVectorSize";
            this.lPBVectorSize.Size = new System.Drawing.Size(0, 16);
            this.lPBVectorSize.TabIndex = 11;
            this.lPBVectorSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fOverlaySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 345);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPBVectorSize);
            this.Controls.Add(this.btnOverlayLabelFont);
            this.Controls.Add(this.gbOverlayPosition);
            this.Name = "fOverlaySettings";
            this.Text = "fLabelGuider";
            this.gbOverlayPosition.ResumeLayout(false);
            this.gbOverlayPosition.PerformLayout();
            this.gbPBVectorSize.ResumeLayout(false);
            this.gbPBVectorSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoveLabelFormRight;
        private System.Windows.Forms.Button btnMoveLabelFormUp;
        private System.Windows.Forms.Button btnMoveLabelFormLeft;
        private System.Windows.Forms.Button btnMoveLabelFormDown;
        private System.Windows.Forms.TextBox tbMoveStep;
        private System.Windows.Forms.GroupBox gbOverlayPosition;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnOverlayLabelFont;
        private System.Windows.Forms.GroupBox gbPBVectorSize;
        private System.Windows.Forms.Button btnPBVectorWidthPlus;
        private System.Windows.Forms.TextBox tbPBVectorSize;
        private System.Windows.Forms.Button btnPBVectorWidthMinus;
        private System.Windows.Forms.Label lPBVectorHeight;
        private System.Windows.Forms.Button btnPBVectorHeightPlus;
        private System.Windows.Forms.Label lPBVectorWidth;
        private System.Windows.Forms.Button btnPBVectorHeightMinus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Label lOverlayPosition;
        private System.Windows.Forms.Label lPBVectorSize;
    }
}