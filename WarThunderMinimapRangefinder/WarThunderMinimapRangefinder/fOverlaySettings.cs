using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;

namespace WarThunderMinimapRangefinder
{
    public partial class fOverlaySettings : Form
    {
        private fOverlay overlay;
        private int overlayLocationStep;
        private int pbVectorSizeStep;
        public fOverlaySettings(ref fOverlay overlay)
        {
            InitializeComponent();
            this.overlay = overlay;
            int temp;
            if (int.TryParse(tbMoveStep.Text, out temp))
                overlayLocationStep = temp;

            if (int.TryParse(tbPBVectorSize.Text, out temp))
                pbVectorSizeStep = temp;
        }
        private void tbMoveStep_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbMoveStep.Text, out int tempStep))
                tbMoveStep.Text = overlayLocationStep.ToString();
            else
                overlayLocationStep = tempStep;
        }

        private void btnMoveLabelFormRight_Click(object sender, EventArgs e)
        {
            MoveOverlay(overlayLocationStep, 0);
        }

        private void btnMoveLabelFormDown_Click(object sender, EventArgs e)
        {
            MoveOverlay(0, overlayLocationStep);
        }

        private void btnMoveLabelFormLeft_Click(object sender, EventArgs e)
        {
            MoveOverlay(-overlayLocationStep, 0);
        }

        private void btnMoveLabelFormUp_Click(object sender, EventArgs e)
        {
            MoveOverlay(0, -overlayLocationStep);
        }

        private void MoveOverlay(int offsetX, int offsetY)
        {

            // Перемещаем overlay
            overlay.Location = new Point(overlay.Location.X + offsetX, overlay.Location.Y + offsetY);

            // Обновляем текстовую метку с новыми координатами
            lOverlayPosition.Text = $"Overlay position: ({(int)(overlay.Location.X * 1.2)}, {(int)(overlay.Location.Y * 1.2)})";
        }

        private void btnOverlayLabelFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = overlay.lDistance.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                overlay.lDistance.Font = fontDialog1.Font;
                overlay.AdjustPositionsAndSizes();
            }
        }

        private void tbPBVectorSize_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbPBVectorSize.Text, out int tempStep))
                tbPBVectorSize.Text = overlayLocationStep.ToString();
            else
                pbVectorSizeStep = tempStep;
        }

        private void btnPBVectorWidthMinus_Click(object sender, EventArgs e)
        {
            overlay.pbMinimapVector.Width -= pbVectorSizeStep;
            lPBVectorSize.Text = $"Vector size: ({overlay.pbMinimapVector.Width}, {overlay.pbMinimapVector.Height})";
            overlay.AdjustPositionsAndSizes();
        }

        private void btnPBVectorWidthPlus_Click(object sender, EventArgs e)
        {
            overlay.pbMinimapVector.Width += pbVectorSizeStep;
            lPBVectorSize.Text = $"Vector size: ({overlay.pbMinimapVector.Width}, {overlay.pbMinimapVector.Height})";
            overlay.AdjustPositionsAndSizes();
        }

        private void btnPBVectorHeightMinus_Click(object sender, EventArgs e)
        {
            overlay.pbMinimapVector.Height -= pbVectorSizeStep;
            lPBVectorSize.Text = $"Vector size: ({overlay.pbMinimapVector.Width}, {overlay.pbMinimapVector.Height})";
            overlay.AdjustPositionsAndSizes();
        }

        private void btnPBVectorHeightPlus_Click(object sender, EventArgs e)
        {
            overlay.pbMinimapVector.Height += pbVectorSizeStep;
            lPBVectorSize.Text = $"Vector size: ({overlay.pbMinimapVector.Width}, {overlay.pbMinimapVector.Height})";
            overlay.AdjustPositionsAndSizes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOverlaySettingsToFile();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadOverlaySettingsFromFile();
        }

        public void SaveOverlaySettingsToFile(string filePath = "OverlaySettings.json")
        {
            OverlaySettings settings = new OverlaySettings
            {
                OverlayLocation = overlay.Location,
                OverlayLocationStep = overlayLocationStep,
                OverlayFontInfo = new FontInfo
                {
                    FontName = overlay.lDistance.Font.Name,
                    Size = overlay.lDistance.Font.Size,
                    Style = overlay.lDistance.Font.Style
                },
                PbVectorSizeStep = pbVectorSizeStep,
                PbMinimapVectorWidth = overlay.pbMinimapVector.Width,
                PbMinimapVectorHeight = overlay.pbMinimapVector.Height
            };

            string jsonString = JsonSerializer.Serialize(settings);
            File.WriteAllText(filePath, jsonString);
        }

        public void LoadOverlaySettingsFromFile(string filePath = "OverlaySettings.json")
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                OverlaySettings settings = JsonSerializer.Deserialize<OverlaySettings>(jsonString);

                overlay.Location = settings.OverlayLocation;
                overlayLocationStep = settings.OverlayLocationStep;

                if (settings.OverlayFontInfo != null)
                {
                    overlay.lDistance.Font = new Font(
                        settings.OverlayFontInfo.FontName,
                        settings.OverlayFontInfo.Size,
                        settings.OverlayFontInfo.Style
                    );
                }

                pbVectorSizeStep = settings.PbVectorSizeStep;
                overlay.pbMinimapVector.Width = settings.PbMinimapVectorWidth;
                overlay.pbMinimapVector.Height = settings.PbMinimapVectorHeight;
                overlay.AdjustPositionsAndSizes();
            }
            else
            {
                //MessageBox.Show("File to get overlay position is not found. Overlay will be located at the standert position. Use 'Overlay settings' to change overlay settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
