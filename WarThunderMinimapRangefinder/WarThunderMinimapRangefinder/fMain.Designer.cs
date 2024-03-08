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
            this.lPlayerCords = new System.Windows.Forms.Label();
            this.lMarkCords = new System.Windows.Forms.Label();
            this.tbRangeCoeficient = new System.Windows.Forms.TextBox();
            this.pbMinimap = new System.Windows.Forms.PictureBox();
            this.chbAutoDetection = new System.Windows.Forms.CheckBox();
            this.btnOpenOverlaySettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chbShowOverlay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimap)).BeginInit();
            this.SuspendLayout();
            // 
            // lPlayerCords
            // 
            this.lPlayerCords.AutoSize = true;
            this.lPlayerCords.Location = new System.Drawing.Point(612, 9);
            this.lPlayerCords.Name = "lPlayerCords";
            this.lPlayerCords.Size = new System.Drawing.Size(0, 16);
            this.lPlayerCords.TabIndex = 2;
            // 
            // lMarkCords
            // 
            this.lMarkCords.AutoSize = true;
            this.lMarkCords.Location = new System.Drawing.Point(612, 40);
            this.lMarkCords.Name = "lMarkCords";
            this.lMarkCords.Size = new System.Drawing.Size(0, 16);
            this.lMarkCords.TabIndex = 2;
            // 
            // tbRangeCoeficient
            // 
            this.tbRangeCoeficient.Location = new System.Drawing.Point(496, 97);
            this.tbRangeCoeficient.Name = "tbRangeCoeficient";
            this.tbRangeCoeficient.Size = new System.Drawing.Size(171, 22);
            this.tbRangeCoeficient.TabIndex = 4;
            this.tbRangeCoeficient.Text = "250";
            this.tbRangeCoeficient.TextChanged += new System.EventHandler(this.tbRangeCoeficient_TextChanged);
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
            // chbAutoDetection
            // 
            this.chbAutoDetection.AutoSize = true;
            this.chbAutoDetection.Location = new System.Drawing.Point(496, 125);
            this.chbAutoDetection.Name = "chbAutoDetection";
            this.chbAutoDetection.Size = new System.Drawing.Size(167, 20);
            this.chbAutoDetection.TabIndex = 9;
            this.chbAutoDetection.Text = "DetectMarkAutomaticly";
            this.chbAutoDetection.UseVisualStyleBackColor = true;
            this.chbAutoDetection.CheckedChanged += new System.EventHandler(this.chbAutoDetection_CheckedChanged);
            // 
            // btnOpenOverlaySettings
            // 
            this.btnOpenOverlaySettings.Location = new System.Drawing.Point(496, 414);
            this.btnOpenOverlaySettings.Name = "btnOpenOverlaySettings";
            this.btnOpenOverlaySettings.Size = new System.Drawing.Size(174, 24);
            this.btnOpenOverlaySettings.TabIndex = 10;
            this.btnOpenOverlaySettings.Text = "Open overlay settings";
            this.btnOpenOverlaySettings.UseVisualStyleBackColor = true;
            this.btnOpenOverlaySettings.Click += new System.EventHandler(this.btnOpenOverlaySettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Distance in one cell";
            // 
            // chbShowOverlay
            // 
            this.chbShowOverlay.AutoSize = true;
            this.chbShowOverlay.Location = new System.Drawing.Point(496, 360);
            this.chbShowOverlay.Name = "chbShowOverlay";
            this.chbShowOverlay.Size = new System.Drawing.Size(110, 20);
            this.chbShowOverlay.TabIndex = 12;
            this.chbShowOverlay.Text = "Show overlay";
            this.chbShowOverlay.UseVisualStyleBackColor = true;
            this.chbShowOverlay.CheckedChanged += new System.EventHandler(this.chbShowOverlay_CheckedChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.chbShowOverlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenOverlaySettings);
            this.Controls.Add(this.chbAutoDetection);
            this.Controls.Add(this.tbRangeCoeficient);
            this.Controls.Add(this.lMarkCords);
            this.Controls.Add(this.lPlayerCords);
            this.Controls.Add(this.pbMinimap);
            this.Name = "fMain";
            this.Text = "fMain";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMinimap;
        private System.Windows.Forms.Label lPlayerCords;
        private System.Windows.Forms.Label lMarkCords;
        private System.Windows.Forms.TextBox tbRangeCoeficient;
        private System.Windows.Forms.CheckBox chbAutoDetection;
        private System.Windows.Forms.Button btnOpenOverlaySettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbShowOverlay;
    }
}

