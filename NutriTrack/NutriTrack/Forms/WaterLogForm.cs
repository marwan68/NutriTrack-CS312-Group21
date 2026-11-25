using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    internal sealed class WaterLogForm : Form
    {
        private readonly NumericUpDown amount;
        internal int AmountMl => (int)amount.Value;

        internal WaterLogForm()
        {
            Text = "NutriTrack - Log Water";
            ClientSize = new Size(360, 245);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F);
            Controls.Add(new Label { Text = "Log Water", Font = new Font("Segoe UI", 16F, FontStyle.Bold), Location = new Point(20, 15), AutoSize = true });
            Controls.Add(new Label { Text = "Choose an amount or enter millilitres.", Location = new Point(20, 52), AutoSize = true });
            amount = new NumericUpDown { Minimum = 1, Maximum = 5000, Increment = 50, Value = 250, Location = new Point(20, 125), Size = new Size(250, 30), ThousandsSeparator = true };
            Controls.Add(amount);
            Controls.Add(new Label { Text = "mL", Location = new Point(280, 127), AutoSize = true });
            int[] presets = { 250, 500, 1000 };
            for (int i = 0; i < presets.Length; i++)
            {
                int ml = presets[i];
                var preset = MakeButton($"{ml} mL", new Point(20 + i * 108, 82), new Size(100, 32), false);
                preset.Click += (s, e) => amount.Value = ml;
                Controls.Add(preset);
            }
            var cancel = MakeButton("Cancel", new Point(20, 183), new Size(150, 42), false);
            cancel.DialogResult = DialogResult.Cancel;
            var save = MakeButton("+ Add Water", new Point(190, 183), new Size(150, 42), true);
            save.DialogResult = DialogResult.OK;
            Controls.Add(cancel);
            Controls.Add(save);
            AcceptButton = save;
            CancelButton = cancel;
            UiHelper.ApplyRoundedCorners(this);
        }

        private static Button MakeButton(string text, Point location, Size size, bool primary)
        {
            var button = new Button { Text = text, Location = location, Size = size, FlatStyle = FlatStyle.Flat,
                BackColor = primary ? Color.FromArgb(46, 94, 62) : Color.FromArgb(224, 236, 221),
                ForeColor = primary ? Color.White : Color.FromArgb(46, 94, 62),
                Cursor = Cursors.Hand, Tag = "round", UseVisualStyleBackColor = false };
            button.FlatAppearance.BorderSize = 0;
            return button;
        }
    }
}
