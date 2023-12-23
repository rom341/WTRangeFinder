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
        public void ChangelDistanceText(string distance)
        {
            lDistance.Text = distance;
            ChangeFormSize();
        }

        private void ChangeFormSize()
        {
            this.Width = Math.Max(lDistance.Width, pbMinimapVector.Width);
            this.Height = lDistance.Height + pbMinimapVector.Height + 5;
        }

        public void DrawVector(Point player, Point mark)
        {
            // Присваиваем измененное изображение обратно в pbMinimap
            pbMinimapVector.Image = BitmapWorker.DrawVector(player, mark, pbMinimapVector.Image);

            System.Timers.Timer timer = new System.Timers.Timer(2000);//2 секунды
            timer.AutoReset = false;
            timer.Elapsed += (sender, e) => Invoke(new Action(() => { pbMinimapVector.Image = null; timer.Dispose(); }));
            timer.Start();
        }

        private void lDistance_Click(object sender, EventArgs e)
        {
            fmain.FindRangeFromScreenshot();
        }
    }
}
