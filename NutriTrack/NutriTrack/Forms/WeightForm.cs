using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class WeightForm : Form
    {
        public WeightForm()
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
            // You are already on this screen
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

        private void WeightForm_Load(object sender, EventArgs e)
        {
            UiHelper.ApplyRoundedCorners(this);
            dtpWeightDate.MaxDate = DateTime.Today;
            RefreshWeight();
        }

        private void RefreshWeight()
        {
            lblWStartValue.Text=$"{TrackingData.Start:0.0} kg";
            lblWNowValue.Text=$"{TrackingData.Current:0.0} kg";
            lblWTargetValue.Text=$"{TrackingData.WeightGoal:0.0} kg";
            var recent=TrackingData.WeightPeriod(30);
            lblWChangeValue.Text=recent.Length<2?"—":$"{recent.Last().Value-recent.First().Value:+0.0;-0.0;0.0} kg";
            lblBmi.Text=$"BMI: {TrackingData.Current/((TrackingData.Height/100)*(TrackingData.Height/100)):0.0}   (Height: {TrackingData.Height:0} cm)";
            picWeightChartLarge.Configure("weight");
        }
        private void btnAddWeight_Click(object sender, EventArgs e)
        {
            TrackingData.Weights[dtpWeightDate.Value.Date] = nudWeight.Value;
            RefreshWeight();
            MessageBox.Show("Weight " + nudWeight.Value + " kg was recorded for " + dtpWeightDate.Value.ToShortDateString() + ".", "Weight Added",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
