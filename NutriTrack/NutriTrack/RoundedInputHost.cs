using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NutriTrack
{
    /// <summary>
    /// A real editable WinForms input inside a rounded white frame. Wrapping the
    /// existing controls keeps their original values, events, validation and native
    /// dropdown / calendar / spinner behaviour intact.
    /// </summary>
    internal sealed class RoundedInputHost : Panel
    {
        private readonly Control _input;
        private readonly bool _multiline;
        private bool _focused;

        private RoundedInputHost(Control input)
        {
            _input = input;
            _multiline = input is TextBox text && text.Multiline;
            DoubleBuffered = true;
            BackColor = Color.White;
            TabStop = false;
            Padding = new Padding(1);
            Name = "roundedHost_" + input.Name;

            if (input is TextBox tb)
            {
                tb.BorderStyle = BorderStyle.None;
                tb.BackColor = Color.White;
            }
            else if (input is NumericUpDown numeric)
            {
                numeric.BorderStyle = BorderStyle.None;
                numeric.BackColor = Color.White;
            }
            else if (input is ComboBox cb)
            {
                cb.FlatStyle = FlatStyle.Flat;
                cb.BackColor = Color.White;
                cb.IntegralHeight = false;
            }
            else if (input is DateTimePicker picker)
            {
                picker.CalendarMonthBackground = Color.White;
            }

            input.Enter += (s, e) => { _focused = true; Invalidate(); };
            input.Leave += (s, e) => { _focused = false; Invalidate(); };
            SizeChanged += (s, e) => PositionInput();
            Controls.Add(input);
            PositionInput();
        }

        public static RoundedInputHost Wrap(Control input)
        {
            Control parent = input.Parent ?? throw new InvalidOperationException("Input must have a parent.");
            int index = parent.Controls.GetChildIndex(input);
            Rectangle originalBounds = input.Bounds;
            int originalTabIndex = input.TabIndex;
            bool isMultiline = input is TextBox textBox && textBox.Multiline;
            var host = new RoundedInputHost(input)
            {
                Bounds = new Rectangle(originalBounds.Left, originalBounds.Top, originalBounds.Width,
                         isMultiline ? Math.Max(68, originalBounds.Height) : 36),
                TabIndex = originalTabIndex
            };
            // Parent controls are repositioned only; their actual functionality is unchanged.
            parent.Controls.Add(host);
            parent.Controls.SetChildIndex(host, index);
            host.PositionInput();
            return host;
        }

        private void PositionInput()
        {
            if (_input == null) return;
            if (_multiline)
            {
                _input.Bounds = new Rectangle(12, 9, Math.Max(1, Width - 24), Math.Max(1, Height - 18));
            }
            else
            {
                _input.Width = Math.Max(1, Width - 22);
                // WinForms pickers/combos have OS-managed heights; preserve them.
                _input.Left = 11;
                _input.Top = Math.Max(1, (Height - _input.Height) / 2);
            }
        }

        private static GraphicsPath RoundRect(RectangleF bounds, float radius)
        {
            float d = Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height));
            var p = new GraphicsPath();
            p.AddArc(bounds.Left, bounds.Top, d, d, 180, 90);
            p.AddArc(bounds.Right - d, bounds.Top, d, d, 270, 90);
            p.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            p.AddArc(bounds.Left, bounds.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var r = new RectangleF(0.7f, 0.7f, Width - 2f, Height - 2f);
            using (var path = RoundRect(r, 10))
            using (var background = new SolidBrush(Color.White))
            using (var stroke = new Pen(_focused ? Color.FromArgb(71, 142, 89) :
                       Color.FromArgb(205, 213, 204), _focused ? 1.5f : 1f))
            {
                e.Graphics.FillPath(background, path);
                e.Graphics.DrawPath(stroke, path);
            }
        }
    }
}
