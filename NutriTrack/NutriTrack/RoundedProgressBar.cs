using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NutriTrack
{
    /// <summary>
    /// A calm, non-animated pill-shaped goal indicator, deliberately replacing the
    /// Windows ProgressBar (whose default rendering resembles a download meter).
    /// </summary>
    public sealed class RoundedProgressBar : Control
    {
        private int _value = 0;
        private int _maximum = 100;

        public int Maximum
        {
            get => _maximum;
            set { _maximum = Math.Max(1, value); _value = Math.Min(_value, _maximum); Invalidate(); }
        }

        public int Value
        {
            get => _value;
            set { _value = Math.Max(0, Math.Min(value, _maximum)); Invalidate(); }
        }

        internal static readonly Color StandardTrack = Color.FromArgb(224, 236, 221);
        internal static readonly Color StandardFill = Color.FromArgb(55, 119, 83);
        private int _goalMarker;
        public int GoalMarker
        {
            get => _goalMarker;
            set { _goalMarker = Math.Max(0, value); Invalidate(); }
        }
        public Color TrackColor { get; set; } = StandardTrack;
        public Color FillColor { get; set; } = StandardFill;
        public Color FillEndColor { get; set; } = StandardFill;

        public RoundedProgressBar()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Size = new Size(384, 16);
            TabStop = false;
        }

        private static GraphicsPath Pill(RectangleF rect)
        {
            var path = new GraphicsPath();
            if (rect.Width <= 0 || rect.Height <= 0) return path;
            float d = rect.Height;
            if (rect.Width <= d) { path.AddEllipse(rect); return path; }
            path.AddArc(rect.X, rect.Y, d, d, 90, 180);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 180);
            path.CloseFigure();
            return path;
        }

        internal static void DrawBar(Graphics g, RectangleF rect, float fraction,
            Color track, Color fill, float goalFraction = 0f)
        {
            if (rect.Width <= 0 || rect.Height <= 0) return;
            fraction = Math.Max(0f, Math.Min(1f, fraction));
            using (var path = Pill(rect))
            using (var brush = new SolidBrush(track))
                g.FillPath(brush, path);
            if (fraction > 0)
            {
            var filled = new RectangleF(rect.X, rect.Y, rect.Width * fraction, rect.Height);
            using (var path = Pill(filled))
            using (var brush = new SolidBrush(fill))
                g.FillPath(brush, path);
            }
            if (goalFraction > 0f && goalFraction < 1f)
            {
                float x = rect.X + rect.Width * goalFraction;
                using var marker = new Pen(Color.FromArgb(46, 94, 62), 1.5f);
                // A light outline keeps the goal line visible on the filled portion.
                using var outline = new Pen(Color.White, 3f);
                g.DrawLine(outline, x, rect.Y + 2, x, rect.Bottom - 2);
                g.DrawLine(marker, x, rect.Y + 2, x, rect.Bottom - 2);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Width < 2 || Height < 2) return;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawBar(e.Graphics, new RectangleF(0.5f, 0.5f, Width - 1f, Height - 1f),
                (float)_value / _maximum, TrackColor, FillColor,
                (float)_goalMarker / _maximum);
        }
    }
}
