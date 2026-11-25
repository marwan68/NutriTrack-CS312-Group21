using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new DashboardForm());
        }

        private void btnNavLogMeal_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new LogMealForm());
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
            // You are already on this screen
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Navigator.Go(this, new LoginForm());
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            UiHelper.ApplyRoundedCorners(this);
            cmbGender.SelectedIndex = 0;
            cmbGoal.SelectedIndex = 0;
            nudCalorieGoal.Value=Math.Clamp(TrackingData.CalorieGoal,nudCalorieGoal.Minimum,nudCalorieGoal.Maximum);
            nudTargetWeight.Value=Math.Clamp(TrackingData.WeightGoal,nudTargetWeight.Minimum,nudTargetWeight.Maximum);
            nudHeight.Value=Math.Clamp(TrackingData.Height,nudHeight.Minimum,nudHeight.Maximum);
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Choose a profile photo";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = Image.FromFile(dlg.FileName);
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            TrackingData.CalorieGoal = Math.Max(1,(int)nudCalorieGoal.Value);
            TrackingData.WeightGoal = nudTargetWeight.Value;
            TrackingData.Height = Math.Max(1,nudHeight.Value);
            lblProfileName.Text = txtProfileName.Text;
            lblProfileEmail.Text = txtProfileEmail.Text;
            MessageBox.Show("Your profile has been updated.", "Profile",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
