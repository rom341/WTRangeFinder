namespace WarThunderMinimapRangefinder
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetCords = new System.Windows.Forms.Button();
            this.lWhitePixelCords = new System.Windows.Forms.Label();
            this.lYellowPixelLCords = new System.Windows.Forms.Label();
            this.btnPasteMinimapImage = new System.Windows.Forms.Button();
            this.tbRangeCoeficient = new System.Windows.Forms.TextBox();
            this.btnGetRangeCoeficient = new System.Windows.Forms.Button();
            this.btnOverlay = new System.Windows.Forms.Button();
            this.pbMinimap = new System.Windows.Forms.PictureBox();
            this.btnPasteFullscreenImage = new System.Windows.Forms.Button();
            this.chbAutoDetection = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetCords
            // 
            this.btnGetCords.Location = new System.Drawing.Point(614, 59);
            this.btnGetCords.Name = "btnGetCords";
            this.btnGetCords.Size = new System.Drawing.Size(171, 23);
            this.btnGetCords.TabIndex = 1;
            this.btnGetCords.Text = "GetCordsOfObjects";
            this.btnGetCords.UseVisualStyleBackColor = true;
            this.btnGetCords.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lWhitePixelCords
            // 
            this.lWhitePixelCords.AutoSize = true;
            this.lWhitePixelCords.Location = new System.Drawing.Point(612, 9);
            this.lWhitePixelCords.Name = "lWhitePixelCords";
            this.lWhitePixelCords.Size = new System.Drawing.Size(109, 16);
            this.lWhitePixelCords.TabIndex = 2;
            this.lWhitePixelCords.Text = "lWhitePixelCords";
            // 
            // lYellowPixelLCords
            // 
            this.lYellowPixelLCords.AutoSize = true;
            this.lYellowPixelLCords.Location = new System.Drawing.Point(612, 40);
            this.lYellowPixelLCords.Name = "lYellowPixelLCords";
            this.lYellowPixelLCords.Size = new System.Drawing.Size(122, 16);
            this.lYellowPixelLCords.TabIndex = 2;
            this.lYellowPixelLCords.Text = "lYellowPixelLCords";
            // 
            // btnPasteMinimapImage
            // 
            this.btnPasteMinimapImage.Location = new System.Drawing.Point(614, 252);
            this.btnPasteMinimapImage.Name = "btnPasteMinimapImage";
            this.btnPasteMinimapImage.Size = new System.Drawing.Size(171, 23);
            this.btnPasteMinimapImage.TabIndex = 3;
            this.btnPasteMinimapImage.Text = "PasteMinimapImage";
            this.btnPasteMinimapImage.UseVisualStyleBackColor = true;
            this.btnPasteMinimapImage.Click += new System.EventHandler(this.btnPasteImage_Click);
            // 
            // tbRangeCoeficient
            // 
            this.tbRangeCoeficient.Location = new System.Drawing.Point(614, 97);
            this.tbRangeCoeficient.Name = "tbRangeCoeficient";
            this.tbRangeCoeficient.Size = new System.Drawing.Size(171, 22);
            this.tbRangeCoeficient.TabIndex = 4;
            this.tbRangeCoeficient.Text = "250";
            // 
            // btnGetRangeCoeficient
            // 
            this.btnGetRangeCoeficient.Location = new System.Drawing.Point(614, 125);
            this.btnGetRangeCoeficient.Name = "btnGetRangeCoeficient";
            this.btnGetRangeCoeficient.Size = new System.Drawing.Size(171, 23);
            this.btnGetRangeCoeficient.TabIndex = 5;
            this.btnGetRangeCoeficient.Text = "GetRange";
            this.btnGetRangeCoeficient.UseVisualStyleBackColor = true;
            this.btnGetRangeCoeficient.Click += new System.EventHandler(this.btnGetRangeCoeficient_Click);
            // 
            // btnOverlay
            // 
            this.btnOverlay.Location = new System.Drawing.Point(617, 386);
            this.btnOverlay.Name = "btnOverlay";
            this.btnOverlay.Size = new System.Drawing.Size(171, 23);
            this.btnOverlay.TabIndex = 7;
            this.btnOverlay.Text = "Overlay";
            this.btnOverlay.UseVisualStyleBackColor = true;
            this.btnOverlay.Click += new System.EventHandler(this.btnOverlayShow_Click);
            // 
            // pbMinimap
            // 
            this.pbMinimap.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbMinimap.Image = global::WarThunderMinimapRangefinder.Properties.Resources.WTMinimapExample2_180m;
            this.pbMinimap.Location = new System.Drawing.Point(0, 0);
            this.pbMinimap.Name = "pbMinimap";
            this.pbMinimap.Size = new System.Drawing.Size(490, 450);
            this.pbMinimap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimap.TabIndex = 0;
            this.pbMinimap.TabStop = false;
            // 
            // btnPasteFullscreenImage
            // 
            this.btnPasteFullscreenImage.Location = new System.Drawing.Point(615, 281);
            this.btnPasteFullscreenImage.Name = "btnPasteFullscreenImage";
            this.btnPasteFullscreenImage.Size = new System.Drawing.Size(171, 23);
            this.btnPasteFullscreenImage.TabIndex = 8;
            this.btnPasteFullscreenImage.Text = "PasteFullscreenImage";
            this.btnPasteFullscreenImage.UseVisualStyleBackColor = true;
            this.btnPasteFullscreenImage.Click += new System.EventHandler(this.btnPasteFullscreenImage_Click);
            // 
            // chbAutoDetection
            // 
            this.chbAutoDetection.AutoSize = true;
            this.chbAutoDetection.Location = new System.Drawing.Point(614, 163);
            this.chbAutoDetection.Name = "chbAutoDetection";
            this.chbAutoDetection.Size = new System.Drawing.Size(167, 20);
            this.chbAutoDetection.TabIndex = 9;
            this.chbAutoDetection.Text = "DetectMarkAutomaticly";
            this.chbAutoDetection.UseVisualStyleBackColor = true;
            this.chbAutoDetection.CheckedChanged += new System.EventHandler(this.chbAutoDetection_CheckedChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbAutoDetection);
            this.Controls.Add(this.btnPasteFullscreenImage);
            this.Controls.Add(this.btnOverlay);
            this.Controls.Add(this.btnGetRangeCoeficient);
            this.Controls.Add(this.tbRangeCoeficient);
            this.Controls.Add(this.btnPasteMinimapImage);
            this.Controls.Add(this.lYellowPixelLCords);
            this.Controls.Add(this.lWhitePixelCords);
            this.Controls.Add(this.btnGetCords);
            this.Controls.Add(this.pbMinimap);
            this.Name = "fMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMinimap;
        private System.Windows.Forms.Button btnGetCords;
        private System.Windows.Forms.Label lWhitePixelCords;
        private System.Windows.Forms.Label lYellowPixelLCords;
        private System.Windows.Forms.Button btnPasteMinimapImage;
        private System.Windows.Forms.TextBox tbRangeCoeficient;
        private System.Windows.Forms.Button btnGetRangeCoeficient;
        private System.Windows.Forms.Button btnOverlay;
        private System.Windows.Forms.Button btnPasteFullscreenImage;
        private System.Windows.Forms.CheckBox chbAutoDetection;
    }
}

