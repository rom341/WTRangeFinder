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
        System.Timers.Timer autoMarkDetectionTimer = new System.Timers.Timer(5000);//5 sec
        fOverlay overlayForm;
        BitmapWorker bitmapWorker = new BitmapWorker();
        Point markPoint { get; set; }
        Point playerPoint { get; set; }
        int rangeCoeficient = -1;
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            Bitmap screenBitmap = new Bitmap(pbMinimap.Image);

            // Находим координаты метки
            Color markColor = Color.FromArgb(215, 215, 5);
            bitmapWorker.FindPixelCoordinates(screenBitmap, markColor);
            markPoint = bitmapWorker.lastFoundPoint;
            lYellowPixelLCords.Text = $"Mark Pixel: ({markPoint.X}, {markPoint.Y})";

            // Находим координаты игрока
            Color playerColor = Color.FromArgb(250, 250, 250);
            bitmapWorker.FindPixelCoordinates(screenBitmap, playerColor);
            playerPoint = bitmapWorker.lastFoundPoint;
            lWhitePixelCords.Text = $"Player Pixel: ({playerPoint.X}, {playerPoint.Y})";

            screenBitmap.Dispose();
        }

        private void btnPasteImage_Click(object sender, EventArgs e)
        {
            Image imageFromClipboard = BitmapWorker.getImageFromClipboard();
            // Проверяем, есть ли изображение в буфере обмена
            if (imageFromClipboard!=null)
            {
                // Отображаем изображение в PictureBox
                pbMinimap.Image = imageFromClipboard;
            }
            else
            {
                MessageBox.Show("No image in clipboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetRangeCoeficient_Click(object sender, EventArgs e)
        {
            updateRangeCoeficient();

            if (PointWorker.IsPointValid(playerPoint) && PointWorker.IsPointValid(markPoint))
            {
                updatePixelsInOneCellValue();

                double distanceInMeters = Math.Round(metersInOnePixel * PointWorker.GetDistance(playerPoint, markPoint), 2);

                overlayForm.ChangelDistanceText($"Distance: {distanceInMeters}m");
                overlayForm.DrawVector(playerPoint, markPoint);
            }
            else
            {
                overlayForm.ChangelDistanceText("");
            }
        }

        private void updatePixelsInOneCellValue()
        {
            int pixelsInOneCell = BitmapWorker.FindBlackStripeLength(new Bitmap(pbMinimap.Image));
            metersInOnePixel = rangeCoeficient / (double)pixelsInOneCell;
        }

        private void updateRangeCoeficient()
        {
            if (!int.TryParse(tbRangeCoeficient.Text, out rangeCoeficient))
            {
                MessageBox.Show("Wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rangeCoeficient = -1;
            }
        }

        private void btnOverlayShow_Click(object sender, EventArgs e)
        {
            if (overlayForm == null)
            {
                overlayForm = new fOverlay(this);
                SetOverlayLocation();
            }
            if (overlayForm.Visible) overlayForm.Hide();
            else overlayForm.Show();
        }
        private void SetOverlayLocation()
        {
            int x = Screen.PrimaryScreen.Bounds.Right - overlayForm.Width - 16;
            int y = Screen.PrimaryScreen.Bounds.Bottom - overlayForm.Height - 3;
            overlayForm.Location = new Point(x, y);
        }

        private void btnPasteFullscreenImage_Click(object sender, EventArgs e)
        {   
            if(pbMinimap.Image!=null)pbMinimap.Image.Dispose();
            Bitmap minimap = BitmapWorker.getMinimap(BitmapWorker.getScreenshot());

            // Выводим вырезанное изображение в PictureBox
            pbMinimap.Image = minimap;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            //Вывести оверлей
            btnOverlay.PerformClick();
        }

        private void chbAutoDetection_CheckedChanged(object sender, EventArgs e)
        {
            if(chbAutoDetection.Checked)autoMarkDetectionTimer.Start();
            else autoMarkDetectionTimer.Stop();
        }

        public void FindRangeFromScreenshot()
        {
            btnPasteFullscreenImage.PerformClick();
            btnGetCords.PerformClick();
            btnGetRangeCoeficient.PerformClick();
        }
    }
}
