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
        Point lmbPoint, rmbPoint;

        public fOverlay(fMain fmain)
        {
            InitializeComponent();
            AdjustPositionsAndSizes();
            this.fmain = fmain;

            lmbPoint = new Point(-1, -1);
            rmbPoint = new Point(-1, -1);
        }
        public void ChangelDistanceText(string distance)
        {
            lDistance.Text = distance;
            AdjustPositionsAndSizes();
        }

        public void AdjustPositionsAndSizes()
        {
            lDistance.Location = new Point(0, 0);
            pbMinimapVector.Location = new Point(0, lDistance.Height + 5);
            this.Width = Math.Max(lDistance.Width, pbMinimapVector.Width);
            this.Height = lDistance.Height + pbMinimapVector.Height + 5;
        }

        public void DrawVector(Point player, Point mark)
        {
            if (pbMinimapVector.Image != null) pbMinimapVector.Image.Dispose();
            pbMinimapVector.Image = BitmapWorker.DrawVector(player, mark, pbMinimapVector.Image);

            System.Timers.Timer timer = new System.Timers.Timer(2000);//2 секунды
            timer.AutoReset = false;
            timer.Elapsed += (sender, e) => Invoke(new Action(() => { pbMinimapVector.Image = null; timer.Dispose(); }));
            timer.Start();
        }

        private void lDistance_Click(object sender, EventArgs e)
        {
            lDistance.Text = "Select 2 points. 7 Sec";
            if (pbMinimapVector.Image != null) pbMinimapVector.Dispose();
            pbMinimapVector.Image = BitmapWorker.getMinimap(BitmapWorker.getScreenshot_1080p(), this);

            System.Timers.Timer timer = new System.Timers.Timer(7000);//7 секунды
            timer.AutoReset = false;
            timer.Elapsed += (S, E) => Invoke(new Action(() => { pbMinimapVector.Image = null; lDistance.Text = "Distance"; timer.Dispose(); }));
            timer.Start();
        }

        private void lDistance_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fmain.FindRangeFromScreenshot();
            }
            else if (e.Button == MouseButtons.Right)
            {
                lDistance.Text = "Select 2 points. 7 Sec";
                if (pbMinimapVector.Image != null) pbMinimapVector.Dispose();
                pbMinimapVector.Image = BitmapWorker.getMinimap(BitmapWorker.getScreenshot_1080p(), this);

                System.Timers.Timer timer = new System.Timers.Timer(7000);//7 секунды
                timer.AutoReset = false;
                timer.Elapsed += (S, E) => Invoke(new Action(() => { pbMinimapVector.Image = null; lDistance.Text = "Distance"; timer.Dispose(); }));
                timer.Start();
            }
        }

        private void pbMinimapVector_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lmbPoint = new Point((int)(e.X * 1.25), (int)(e.Y * 1.25));
            }
            else if (e.Button == MouseButtons.Right)
            {
                rmbPoint = new Point((int)(e.X * 1.25), (int)(e.Y * 1.25));
            }
            if (PointWorker.IsPointValid(lmbPoint) && PointWorker.IsPointValid(rmbPoint))
            {
                fmain.setPointsAndMinimap(lmbPoint, rmbPoint, new Bitmap(pbMinimapVector.Image));
                fmain.FindRangeFromSavedPoints();
                lmbPoint = new Point(-1, -1);
                rmbPoint = new Point(-1, -1);
            }
        }
    }
}
