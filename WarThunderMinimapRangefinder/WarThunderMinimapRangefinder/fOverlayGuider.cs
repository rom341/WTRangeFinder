using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WarThunderMinimapRangefinder
{
    public partial class fOverlayGuider : Form
    {
        private fOverlay overlay;
        private int overlayLocationStep;
        private int pbVectorSizeStep;
        public fOverlayGuider(ref fOverlay overlay)
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
            overlay.Location = new Point(overlay.Location.X + overlayLocationStep, overlay.Location.Y);
        }
        private void btnMoveLabelFormDown_Click(object sender, EventArgs e)
        {
            overlay.Location = new Point(overlay.Location.X, overlay.Location.Y + overlayLocationStep);
        }

        private void btnMoveLabelFormLeft_Click(object sender, EventArgs e)
        {
            overlay.Location = new Point(overlay.Location.X - overlayLocationStep, overlay.Location.Y);
        }

        private void btnMoveLabelFormUp_Click(object sender, EventArgs e)
        {
            overlay.Location = new Point(overlay.Location.X, overlay.Location.Y - overlayLocationStep);
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
            overlay.AdjustPositionsAndSizes();
        }

        private void btnPBVectorWidthPlus_Click(object sender, EventArgs e)
        {
            overlay.pbMinimapVector.Width += pbVectorSizeStep;
            overlay.AdjustPositionsAndSizes();
        }

        private void btnPBVectorHeightMinus_Click(object sender, EventArgs e)
        {
            overlay.pbMinimapVector.Height -= pbVectorSizeStep;
            overlay.AdjustPositionsAndSizes();
        }

        private void btnPBVectorHeightPlus_Click(object sender, EventArgs e)
        {
            overlay.pbMinimapVector.Height += pbVectorSizeStep;
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
    }
}
