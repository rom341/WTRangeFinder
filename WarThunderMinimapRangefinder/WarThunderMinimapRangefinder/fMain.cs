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
        System.Timers.Timer timer = new System.Timers.Timer(5000);//5 sec
        fOverlay overlayForm;
        Point foundMarkPoint, foundPlayerPoint;
        int rangeCoeficient = -1;
        double metersInOnePixel = -1;
        public fMain()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer = new System.Timers.Timer(5000); // 5 seconds
            timer.Elapsed += Timer_Elapsed;
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => FindRange())); // Обновляем элементы управления в основном потоке
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Bitmap screenBitmap = new Bitmap(pbMinimapImage.Image);

            // Находим координаты метки
            Color markColor = Color.FromArgb(215, 215, 5);
            Point markPoint = FindPixelCoordinates(screenBitmap, markColor);
            foundMarkPoint = new Point(markPoint.X, markPoint.Y);
            lYellowPixelLCords.Text = $"Mark Pixel: ({foundMarkPoint.X}, {foundMarkPoint.Y})";

            // Находим координаты игрока
            Color playerColor = Color.FromArgb(250, 250, 250);
            Point playerPoint = FindPixelCoordinates(screenBitmap, playerColor);
            foundPlayerPoint = new Point(playerPoint.X, playerPoint.Y);
            lWhitePixelCords.Text = $"Player Pixel: ({foundPlayerPoint.X}, {foundPlayerPoint.Y})";

            screenBitmap.Dispose();
            // Отображение скриншота на PictureBox
            //pbMinimapImage.Image = screenshot;
        }
        private Point FindPixelCoordinates(Bitmap bitmap, Color targetColor)
        {
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytesPerPixel = 4; // По 4 байта на каждый пиксель (ARGB)
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;
            IntPtr startPtr = bitmapData.Scan0;

            for (int y = 0; y < heightInPixels; y++)
            {
                // Получение указателя на начало строки
                IntPtr currentLine = IntPtr.Add(startPtr, y * bitmapData.Stride);

                for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                {
                    byte blue = Marshal.ReadByte(currentLine, x);
                    byte green = Marshal.ReadByte(currentLine, x + 1);
                    byte red = Marshal.ReadByte(currentLine, x + 2);
                    byte alpha = Marshal.ReadByte(currentLine, x + 3);

                    Color pixelColor = Color.FromArgb(alpha, red, green, blue);

                    if (ColorMatch(pixelColor, targetColor))
                    {
                        bitmap.UnlockBits(bitmapData);
                        return new Point(x / bytesPerPixel, y);
                    }
                }
            }

            // Если цвет не найден, возвращаем (-1, -1)
            bitmap.UnlockBits(bitmapData);
            return new Point(-1, -1);
        }

        private void btnPasteImage_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли изображение в буфере обмена
            if (Clipboard.ContainsImage())
            {
                // Получаем изображение из буфера обмена
                Image imageFromClipboard = Clipboard.GetImage();

                // Отображаем изображение в PictureBox
                pbMinimapImage.Image = imageFromClipboard;
            }
            else
            {
                MessageBox.Show("No image in clipboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetRangeCoeficient_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbRangeCoeficient.Text, out rangeCoeficient))
            {
                tbRangeCoeficient.Text = "Wrong Format";
                return;
            }

            int pixelsInOneCell = FindBlackStripeLength(new Bitmap(pbMinimapImage.Image));
            metersInOnePixel = rangeCoeficient / (double)pixelsInOneCell;

            double distanceInMeters = metersInOnePixel * GetDistance(foundPlayerPoint, foundMarkPoint);
            double roundedDistance = Math.Round(distanceInMeters, 2); // Округление до сотых

            lResultDistance.Text = $"Distance: {roundedDistance}m";
            overlayForm.ChangeDistance($"Distance: {roundedDistance}m");

            overlayForm.DrawVector(foundPlayerPoint, foundMarkPoint);
        }

        //диапазон допустимых цветов
        private bool ColorMatch(Color color1, Color color2, int tolerance = 5)
        {
            return Math.Abs(color1.R - color2.R) <= tolerance &&
                   Math.Abs(color1.G - color2.G) <= tolerance &&
                   Math.Abs(color1.B - color2.B) <= tolerance;
        }

        static int FindBlackStripeLength(Bitmap image)
        {
            // Задаем координаты и размеры прямоугольника
            int rectangleWidth = 65;
            int rectangleHeight = 30;
            int rectangleX = image.Width - rectangleWidth;
            int rectangleY = image.Height - rectangleHeight;

            // Переменная для подсчета длины черной полосы
            int longestBlackStripeLength = 0;
            int temp;
            Color black = Color.FromArgb(0, 0, 0);
            // Проходим по каждому пикселю в прямоугольнике
            for (int y = rectangleY; y < image.Height; y++)
            {
                temp = 0;
                for (int x = rectangleX; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    // Проверяем, является ли пиксель черным
                    if (pixelColor == black)
                    {
                        temp++;
                    }
                }
                if (temp > longestBlackStripeLength)
                    longestBlackStripeLength = temp;
            }

            return longestBlackStripeLength;
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
        double GetDistance(Point p1, Point p2)
        {
            double result = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2) * 1.0);
            return result;
        }

        private void btnPasteFullscreenImage_Click(object sender, EventArgs e)
        {   
            if(pbMinimapImage.Image!=null)pbMinimapImage.Image.Dispose();
            // Получаем размеры экрана
            int screenWidth = 1920;//Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = 1080;//Screen.PrimaryScreen.WorkingArea.Height;


            // Создаем битмап для скриншота
            Bitmap screenshot = new Bitmap(screenWidth, screenHeight);

            // Создаем объект Graphics для работы с битмапом
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                // Создаем прямоугольник для скриншота всего экрана
                Rectangle screenBounds = new Rectangle(0, 0, screenWidth, screenHeight);

                // Захватываем изображение экрана
                g.CopyFromScreen(screenBounds.Location, Point.Empty, screenBounds.Size);
            }

            // Создаем прямоугольник для вырезания части изображения
            int cropWidth = 320;
            int cropHeight = 320;
            int cropX = screenWidth - cropWidth - 20; // правый край с учетом отступа
            int cropY = screenHeight - cropHeight - 20; // нижний край с учетом отступа
            Rectangle cropRect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

            // Вырезаем квадрат изображения
            Bitmap croppedImage = screenshot.Clone(cropRect, screenshot.PixelFormat);
            screenshot.Dispose();
            // Выводим вырезанное изображение в PictureBox
            pbMinimapImage.Image = croppedImage;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            btnOverlay.PerformClick();
        }

        private void chbAutoDetection_CheckedChanged(object sender, EventArgs e)
        {
            if(chbAutoDetection.Checked)timer.Start();
            else timer.Stop();
        }

        public void FindRange()
        {
            btnPasteFullscreenImage.PerformClick();
            btnGetCords.PerformClick();
            btnGetRangeCoeficient.PerformClick();
        }
    }
}
