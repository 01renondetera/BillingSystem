using Billing_System;
using BillingSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;   // NEW: for smooth anti-aliased drawing
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class SplashScreen : Form
    {
        // ---- NEW: spinner fields ----
        private System.Windows.Forms.Timer animationTimer;
        private float rotationAngle = 0f;

        private Color spinnerColor = Color.White; // use a dark color if your background is light
        private int segments = 90;       // higher = smoother gradient
        private int ringThickness = 10;  // line width of the ring
        private int ringSize = 50;      // diameter of the spinner
        // -----------------------------

        public SplashScreen()
        {
            InitializeComponent();

            // ---- NEW: set up the spinner animation ----
            this.DoubleBuffered = true;          // stops flickering while spinning

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 15;        // smaller = faster spin
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
            // -------------------------------------------
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Apply AppTheme colors
            this.BackColor = AppTheme.PrimaryColor;
            // Start the splash timer
            splashTimer.Start();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop();
            animationTimer.Stop();   // NEW: stop the spinner before leaving
            // Close the splash and open the Login Form
            this.Hide();
            var loginForm = new LoginForm();
            // When login form actually closes, close the hidden splash so the app can exit cleanly.
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {
        }

        // ---- NEW: rotate the ring each tick ----
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            rotationAngle += 6f;                 // spin speed (degrees per tick)
            if (rotationAngle >= 360f) rotationAngle -= 360f;
            this.Invalidate();                   // request repaint
        }

        // ---- NEW: draw the gradient spinner ----
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int cx = this.Width / 2;
            int cy = this.Height / 2 + 40;            // raise/lower the spinner by changing this
            int radius = ringSize / 2;
            float sweep = 360f / segments;

            for (int i = 0; i < segments; i++)
            {
                // alpha fades around the ring: 0 (invisible) -> 255 (solid)
                int alpha = (int)(255f * i / segments);
                Color c = Color.FromArgb(alpha, spinnerColor);

                using (Pen pen = new Pen(c, ringThickness))
                {
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;

                    float startAngle = rotationAngle + (i * sweep);
                    g.DrawArc(pen,
                        cx - radius, cy - radius,
                        radius * 2, radius * 2,
                        startAngle, sweep + 0.5f);   // tiny overlap = no gaps
                }
            }
        }
    }
}