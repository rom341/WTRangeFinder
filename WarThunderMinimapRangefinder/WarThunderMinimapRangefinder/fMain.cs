using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace WarThunderMinimapRangefinder
{
    public partial class fMain : Form
    {
        System.Timers.Timer autoMarkDetectionTimer;
        fOverlay overlayForm;
        fOverlaySettings overlaySettingsForm;
        BitmapWorker bitmapWorker = new BitmapWorker();
        Point markPoint { get; set; }
        Point playerPoint { get; set; }
        int rangeCoeficient = 250;
        double metersInOnePixel = -1;
        public fMain()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            autoMarkDetectionTimer = new System.Timers.Timer(5000); // 5 seconds
            autoMarkDetectionTimer.Elapsed += Timer_Elapsed;
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => FindRangeFromScreenshot())); // Обновляем элементы управления в основном потоке
        }

        private void findMarkAndPlayer()
        {
            Bitmap screenBitmap = new Bitmap(pbMinimap.Image);

            // Находим координаты метки
            Color markColor = Color.FromArgb(215, 215, 5);
            bitmapWorker.FindPixelCoordinates(screenBitmap, markColor);
            markPoint = bitmapWorker.FindPixelCoordinates(screenBitmap, markColor);
            lMarkCords.Text = $"Mark Pixel: ({markPoint.X}, {markPoint.Y})";

            // Находим координаты игрока
            Color playerColor = Color.FromArgb(250, 250, 250);
            playerPoint = bitmapWorker.FindPixelCoordinates(screenBitmap, playerColor); ;
            lPlayerCords.Text = $"Player Pixel: ({playerPoint.X}, {playerPoint.Y})";

            screenBitmap.Dispose();
        }
        private double getDistanceInMeters()
        {
            metersInOnePixel = getMetersInOnePixelValue();
            return Math.Round(metersInOnePixel * PointWorker.GetDistance(playerPoint, markPoint), 2);
        }
        public void updateOverlayDistance()
        {
            if (PointWorker.IsPointValid(playerPoint) && PointWorker.IsPointValid(markPoint))
            {
                double distanceInMeters = getDistanceInMeters();

                overlayForm.ChangelDistanceText($"Distance: {distanceInMeters}m");
                overlayForm.DrawVector(playerPoint, markPoint);
            }
            else
            {
                overlayForm.ChangelDistanceText("Distance: ?");
            }
        }

        private double getMetersInOnePixelValue()
        {
            int pixelsInOneCell = BitmapWorker.FindBlackStripeLength(new Bitmap(pbMinimap.Image));
            return rangeCoeficient / (double)pixelsInOneCell;
        }
        private void SetOverlayLocation()
        {
            int x = Screen.PrimaryScreen.Bounds.Right - overlayForm.Width - 15;
            int y = Screen.PrimaryScreen.Bounds.Bottom - overlayForm.Height - 10;
            overlayForm.Location = new Point(x, y);
        }
        private void pasteFullscreenImage()
        {
            if (pbMinimap.Image != null) pbMinimap.Image.Dispose();
            Bitmap minimap = BitmapWorker.getMinimap(BitmapWorker.getScreenshot(), overlayForm);
            // Выводим вырезанное изображение в PictureBox
            pbMinimap.Image = minimap;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            //Вывести оверлей
            chbShowOverlay.Checked = true;
            //Настройки оверлея
            overlaySettingsForm = new fOverlaySettings(ref overlayForm);
            overlaySettingsForm.LoadOverlaySettingsFromFile();
        }

        private void chbAutoDetection_CheckedChanged(object sender, EventArgs e)
        {
            if(chbAutoDetection.Checked)autoMarkDetectionTimer.Start();
            else autoMarkDetectionTimer.Stop();
        }

        public void setPointsAndMinimap(Point playerPoint, Point markPoint, Bitmap minimap)
        {
            this.playerPoint = playerPoint;
            this.markPoint = markPoint;
            if (pbMinimap.Image != null) pbMinimap.Image.Dispose();
            pbMinimap.Image=minimap;
        }
        public void FindRangeFromScreenshot()
        {
            pasteFullscreenImage();
            findMarkAndPlayer();
            updateOverlayDistance();
        }
        private void btnOpenOverlaySettings_Click(object sender, EventArgs e)
        {
            if(overlaySettingsForm==null || overlaySettingsForm.IsDisposed)
            {
                overlaySettingsForm = new fOverlaySettings(ref overlayForm);
            }
            if(overlaySettingsForm.Visible) overlaySettingsForm.Hide();
            else overlaySettingsForm.Show();
        }
        private void tbRangeCoeficient_TextChanged(object sender, EventArgs e)
        {
            int rangeCoeficientCopy = rangeCoeficient;
            if (!int.TryParse(tbRangeCoeficient.Text, out rangeCoeficient))
            {
                tbRangeCoeficient.Text = rangeCoeficientCopy.ToString();
                rangeCoeficient = rangeCoeficientCopy;
            }
        }

        private void chbShowOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if (overlayForm == null)
            {
                overlayForm = new fOverlay(this);
                SetOverlayLocation();
            }
            if (chbShowOverlay.Checked) overlayForm.Show();
            else overlayForm.Hide();
        }
    }
}
