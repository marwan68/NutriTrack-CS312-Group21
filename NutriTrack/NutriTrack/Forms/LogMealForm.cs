using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class LogMealForm : Form
    {
        private Image _defaultMealPhoto;
        public LogMealForm()
        {
            InitializeComponent();
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new DashboardForm());
        }

        private void btnNavLogMeal_Click(object sender, EventArgs e)
        {
            // You are already on this screen
        }

        private void btnNavManageMeals_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new ManageMealsForm());
        }

        private void btnNavWeight_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new WeightForm());
        }

        private void btnNavAnalytics_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new AnalyticsForm());
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new ReportsForm());
        }

        private void btnNavProfile_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new ProfileForm());
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Navigator.Go(this, new LoginForm());
            }
        }

        private void LogMealForm_Load(object sender, EventArgs e)
        {
            cmbMealType.SelectedIndex = 0;

            // Retain the genuine, editable input widgets and their behaviour, but
            // surround them with soft rounded frames instead of square borders.
            RoundedInputHost.Wrap(cmbMealType);
            RoundedInputHost.Wrap(txtFoodName);
            RoundedInputHost.Wrap(dtpMealDate);
            RoundedInputHost.Wrap(dtpMealTime);
            RoundedInputHost.Wrap(txtNotes);
            RoundedInputHost.Wrap(nudCalories);
            RoundedInputHost.Wrap(nudProtein);
            RoundedInputHost.Wrap(nudCarbs);
            RoundedInputHost.Wrap(nudFat);

            // The default meal photo comes from the project resources (set in the designer).
            // User-selected photos still replace it with the existing Choose Photo button.
            _defaultMealPhoto = picMeal.Image;
            picMeal.SizeMode = PictureBoxSizeMode.Zoom;

            AddDailyCalorieGoalCard();
            UiHelper.ApplyRoundedCorners(this, 12);
        }

        private void AddDailyCalorieGoalCard()
        {
            // This is the same goal visual used on the Dashboard, now included
            // beside the Log a Meal heading as shown in the approved design.
            var card = new Panel
            {
                Name = "pnlDailyCalorieGoal",
                Location = new Point(435, 7),
                Size = new Size(433, 79),
                BackColor = Color.FromArgb(238, 246, 234),
                Tag = "round"
            };
            var label = new Label
            {
                Text = "Daily calorie goal",
                Font = new Font("Segoe UI", 10.5f, FontStyle.Regular),
                ForeColor = Color.FromArgb(35, 51, 39),
                Location = new Point(18, 7),
                Size = new Size(245, 24)
            };
            var percentage = new Label
            {
                Text = $"{TrackingData.Percent}%",
                Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                ForeColor = Color.FromArgb(29, 114, 43),
                Location = new Point(353, 7),
                Size = new Size(59, 24),
                TextAlign = ContentAlignment.MiddleRight
            };
            var goalBar = new RoundedProgressBar
            {
                Name = "goalProgressBar",
                Value = TrackingData.Percent,
                Location = new Point(18, 34),
                Size = new Size(394, 16)
            };
            var remaining = new Label
            {
                Text = TrackingData.Remaining,
                Font = new Font("Segoe UI", 9f),
                ForeColor = Color.FromArgb(99, 112, 100),
                Location = new Point(18, 54),
                Size = new Size(300, 19)
            };
            card.Controls.Add(label);
            card.Controls.Add(percentage);
            card.Controls.Add(goalBar);
            card.Controls.Add(remaining);
            pnlContent.Controls.Add(card);
            card.BringToFront();
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Choose a meal photo";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Copy into memory so the chosen image file is not locked.
                    using (var selected = Image.FromFile(dlg.FileName))
                    {
                        Image previous = picMeal.Image;
                        picMeal.Image = new Bitmap(selected);
                        if (previous != _defaultMealPhoto)
                            previous?.Dispose();
                    }
                }
            }
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFoodName.Text)) { MessageBox.Show("Enter a food name."); return; }
            if(dtpMealDate.Value.Date>DateTime.Today) { MessageBox.Show("Choose today or an earlier date."); return; }
            TrackingData.Meals.Add(new TrackingData.Meal(txtFoodName.Text.Trim(),cmbMealType.Text,dtpMealDate.Value.Date,nudCalories.Value,nudProtein.Value,nudCarbs.Value,nudFat.Value));
            var oldCard = pnlContent.Controls["pnlDailyCalorieGoal"];
            if(oldCard!=null) oldCard.Dispose();
            AddDailyCalorieGoalCard();
            MessageBox.Show(txtFoodName.Text + " was added to your " + cmbMealType.Text + " meals.", "Meal Added",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFoodName.Clear();
            txtNotes.Clear();
            cmbMealType.SelectedIndex = 0;
            nudCalories.Value = 0;
            nudProtein.Value = 0;
            nudCarbs.Value = 0;
            nudFat.Value = 0;
            dtpMealDate.Value = DateTime.Today;
            dtpMealTime.Value = DateTime.Now;
            Image previous = picMeal.Image;
            picMeal.Image = _defaultMealPhoto;
            if (previous != _defaultMealPhoto)
                previous?.Dispose();
        }
    }
}
