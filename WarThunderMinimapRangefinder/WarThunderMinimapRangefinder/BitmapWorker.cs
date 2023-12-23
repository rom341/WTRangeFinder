﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarThunderMinimapRangefinder
{
    public class BitmapWorker
    {
        static public int screenWidth { get; set; } = 1920;
        static public int screenHeight { get; set; } = 1080;
        public Point lastFoundPoint { get; set; }
        static public Image getImageFromClipboard()
        {
            Image returnImage = null;
            if (Clipboard.ContainsImage())
            {
                returnImage = Clipboard.GetImage();
            }
            return returnImage;
        }
        static public Bitmap getScreenshot()
        {
            // Получаем размеры экрана
            int screenWidth = 1920;
            int screenHeight = 1080;

            Bitmap screenshot = new Bitmap(screenWidth, screenHeight);
            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
            return screenshot;
        }
        static public Bitmap getMinimap(Bitmap screenBitmap)
        {
            // Создаем прямоугольник для вырезания части изображения
            int cropWidth = 320;
            int cropHeight = 320;
            int cropX = screenWidth - cropWidth - 20; // правый край с учетом отступа
            int cropY = screenHeight - cropHeight - 20; // нижний край с учетом отступа
            Rectangle cropRect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

            // Вырезаем квадрат изображения
            Bitmap croppedBitmap = screenBitmap.Clone(cropRect, screenBitmap.PixelFormat);
            screenBitmap.Dispose();
            return croppedBitmap;
        }
        static public Bitmap DrawVector(Point player, Point mark, Image imageSource)
        {
            if (imageSource != null)
            {
                imageSource.Dispose();
            }

            // Создаем копию текущего изображения в pictureBox
            Bitmap screenBitmap = new Bitmap(320, 320);

            using (Graphics g = Graphics.FromImage(screenBitmap))
            {
                // Устанавливаем цвет и стиль линии
                using (Pen pen = new Pen(Color.Red))
                {
                    pen.Width = 5;
                    pen.DashStyle = DashStyle.Dash;

                    // Рисуем линию между двумя точками
                    g.DrawLine(pen, player, mark);
                }
            }
            return screenBitmap;
        }
        static public int FindBlackStripeLength(Bitmap image)
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
        public Point FindPixelCoordinates(Bitmap bitmap, Color targetColor)
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

                    if (ColorMatch(pixelColor, targetColor, 5))
                    {
                        bitmap.UnlockBits(bitmapData);
                        lastFoundPoint = new Point(x / bytesPerPixel, y);
                        return lastFoundPoint;
                    }
                }
            }

            // Если цвет не найден, возвращаем (-1, -1)
            bitmap.UnlockBits(bitmapData);
            lastFoundPoint = new Point(-1, -1);
            return lastFoundPoint;
        }

        //диапазон допустимых цветов
        private bool ColorMatch(Color color1, Color color2, int tolerance = 5)
        {
            return Math.Abs(color1.R - color2.R) <= tolerance &&
                   Math.Abs(color1.G - color2.G) <= tolerance &&
                   Math.Abs(color1.B - color2.B) <= tolerance;
        }
    }
}
