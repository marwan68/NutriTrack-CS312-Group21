using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    /// <summary>
    /// Switches between the application screens (one window open at a time).
    /// The application exits when the last window is closed.
    /// </summary>
    internal static class Navigator
    {
        private static int openForms;

        public static void Start(Form first)
        {
            Track(first);
            first.Show();
        }

        public static void Go(Form from, Form to)
        {
            if (from.GetType() == to.GetType())
            {
                to.Dispose();
                return;
            }

            // open the new screen centred on the old one
            Point centre = new Point(from.Left + from.Width / 2, from.Top + from.Height / 2);
            to.StartPosition = FormStartPosition.Manual;
            to.Location = new Point(Math.Max(0, centre.X - to.Width / 2), Math.Max(0, centre.Y - to.Height / 2));

            Track(to);
            to.Show();
            from.Close();
        }

        private static void Track(Form form)
        {
            openForms++;
            form.FormClosed += (s, e) =>
            {
                openForms--;
                if (openForms <= 0)
                {
                    Application.ExitThread();
                }
            };
        }
    }
}
