using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NutriTrack
{
    /// <summary>
    /// Small visual helpers. Controls whose Tag is "round" get rounded corners at runtime.
    /// </summary>
    internal static class UiHelper
    {
        public static void ApplyRoundedCorners(Control parent, int radius = 10)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Tag is string tag && tag == "round")
                {
                    MakeRounded(c, radius);
                    c.SizeChanged += (s, e) => MakeRounded(c, radius);
                }
                ApplyRoundedCorners(c, radius);
            }
        }

        private static void MakeRounded(Control c, int radius)
        {
            int d = radius * 2;
            if (c.Width < d || c.Height < d) return;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(c.Width - d, 0, d, d, 270, 90);
                path.AddArc(c.Width - d, c.Height - d, d, d, 0, 90);
                path.AddArc(0, c.Height - d, d, d, 90, 90);
                path.CloseFigure();
                c.Region = new Region(path);
            }
        }
    }
}
