using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WarThunderMinimapRangefinder
{
    public partial class fOverlay : Form
    {
        fMain fmain;
        private bool isDragging = false;
        private Point lastMousePosition;

        public fOverlay(fMain fmain)
        {
            InitializeComponent();
            ChangeFormSize();
            this.fmain = fmain;
        }
        public void ChangeDistance(string distance)
        {
            lDistance.Text = distance;
            ChangeFormSize();
        }

        private void ChangeFormSize()
        {
            this.Width = Math.Max(lDistance.Width, pbMinimap.Width);
            this.Height = lDistance.Height + pbMinimap.Height + 5;
        }

        public void DrawVector(Point player, Point mark)
        {
            if (pbMinimap.Image != null)
            {
                pbMinimap.Image.Dispose();
            }
            // Создаем изображение, если его нет
            pbMinimap.Image = new Bitmap(320, 320);
            

            // Создаем копию текущего изображения в pbMinimap
            Bitmap screenBitmap = new Bitmap(pbMinimap.Image);

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

            // Присваиваем измененное изображение обратно в pbMinimap
            pbMinimap.Image = screenBitmap;

            System.Timers.Timer timer = new System.Timers.Timer(2000);//2 секунды
            timer.AutoReset = false;
            timer.Elapsed += (sender, e) => { pbMinimap.Image = null; };
            timer.Start();
        }

        private void lDistance_Click(object sender, EventArgs e)
        {
            fmain.FindRange();
        }
    }
}
