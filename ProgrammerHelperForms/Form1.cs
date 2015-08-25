using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerHelperForms
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);
        
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr dc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);

        static readonly IntPtr HWND_TOP = new IntPtr(0);

        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);

        const UInt32 SWP_NOSIZE = 0x0001;

        const UInt32 SWP_NOMOVE = 0x0002;

        const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;



        [DllImport("user32.dll")]

        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private bool _updateColor = true;

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            mouseMoveTimer = new Timer();
            mouseMoveTimer.Interval = 10;
            mouseMoveTimer.Tick += new EventHandler(MouseMoveTimer_Tick);
            mouseMoveTimer.Start();
            MouseHook.Start();
            MouseHook.MouseAction += new EventHandler(Event);
        }

 
        private void MouseMoveTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            if (Bounds.Contains(cursor.X, cursor.Y)) return;

            var c = GetColorAt(cursor);
            GetScreenshot(cursor);
            //this.BackColor = c;
            panel1.BackColor = c;
           // Console.WriteLine(c.ToString());

            intBtn.Text = IntConverter(c);
            hexBtn.Text = HexConverter(c);
            rgbBtn.Text = RGBConverter(c);
        }

        private static String IntConverter(System.Drawing.Color c)
        {
            return "0x" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static String RGBConverter(System.Drawing.Color c)
        {
            return "(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        }

        private Timer mouseMoveTimer;


        Bitmap screenBlock = new Bitmap(200, 150, PixelFormat.Format32bppRgb);
        public Color GetScreenshot(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenBlock))
            {
                Graphics g = Graphics.FromImage(screenBlock);
                g.CopyFromScreen(Math.Max(0,location.X-50), Math.Max(0, location.Y-75), 0, 0, screenBlock.Size, CopyPixelOperation.SourceCopy);
                pictureBox1.Image = ResizeImage(screenBlock,800,600);
            }

            return screenPixel.GetPixel(0, 0);
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        Point lastPoint;
        private void Event(object sender, EventArgs e) {
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            Console.WriteLine("Left mouse click! X:"+ cursor.X+ " Y:" + cursor.Y);
            //DrawRect(cursor.X, cursor.Y, this.BackColor);
            if (!Bounds.Contains(cursor.X,cursor.Y))
            {
                if (_updateColor)
                {
                    mouseMoveTimer.Stop();
                    detecting.Visible = false;
                    startDetect.Visible = true;
                    _updateColor = false;
                }
                AddDistance(cursor);
                SetTopLevel(true);
            }
        }

        private void AddDistance(Point point, int scale = 1)
        {
            if (lastPoint == null)
            {
                lastPoint = point;
                return;
            }
            if (lastPoint.X != 0 && lastPoint.Y != 0)
            {
                double distance = Math.Round(Math.Sqrt(Math.Pow(point.X - lastPoint.X, 2) + Math.Pow(point.Y - lastPoint.Y, 2))/scale, 2);
                lblDistanceTravelled.Text = distance.ToString();
            }
            lastPoint = point;
        }

        void DrawRect(int x, int y, Color c)

        {

            SolidBrush b = new SolidBrush(c);
            IntPtr desktopPtr = GetDC(IntPtr.Zero);
            Graphics g = Graphics.FromHdc(desktopPtr);

            g.FillRectangle(b, new Rectangle(x, y, 100, 100));

            g.Dispose();
            ReleaseDC(IntPtr.Zero, desktopPtr);

        }


        private void Start(object sender, EventArgs e)
        {
            MouseHook.Start();
        }

        private void Stop(object sender, EventArgs e)
        {
            MouseHook.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HexConverter(panel1.BackColor));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(IntConverter(panel1.BackColor));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RGBConverter(panel1.BackColor));
        }

        private void startDetect_Click(object sender, EventArgs e)
        {
            startDetect.Visible = false;
            detecting.Visible = true;
            mouseMoveTimer.Start();
            _updateColor = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            // Console.WriteLine(c.ToString());
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            AddDistance(cursor,4);
            var c = GetColorAt(cursor);
            panel1.BackColor = c;
            intBtn.Text = IntConverter(c);
            hexBtn.Text = HexConverter(c);
            rgbBtn.Text = RGBConverter(c);
        }
    }
}
