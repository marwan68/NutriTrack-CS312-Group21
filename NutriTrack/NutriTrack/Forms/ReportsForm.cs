using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
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
            // You are already on this screen
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

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            UiHelper.ApplyRoundedCorners(this);
            cmbPeriod.SelectedIndexChanged += (s,e) => RefreshReport();
            cmbPeriod.SelectedIndex = 1;
            RefreshReport();
        }

        private void RefreshReport()
        {
            int days=cmbPeriod.SelectedIndex==0?7:cmbPeriod.SelectedIndex==2?90:30;
            var meals=TrackingData.Meals.Where(m=>m.Date.Date>=DateTime.Today.AddDays(1-days)&&m.Date.Date<=DateTime.Today).ToArray();
            var daily=meals.GroupBy(m=>m.Date.Date).Select(g=>g.Sum(m=>m.Calories)).ToArray();
            var weights=TrackingData.WeightPeriod(days);
            int met=daily.Count(c=>c<=TrackingData.CalorieGoal);
            lblRepAvgCaloriesValue.Text=daily.Length==0?"—":$"{daily.Average():N0} kcal";
            lblRepWeightChangeValue.Text=weights.Length<2?"—":$"{weights.Last().Value-weights.First().Value:+0.0;-0.0;0.0} kg";
            lblRepMealsLoggedValue.Text=$"{meals.Length} meals";
            lblRepGoalDaysValue.Text=$"{met} / {daily.Length}";
            lblHighlight1.Text=$"•  {met} of {daily.Length} logged days were at or under the calorie goal.";
            lblHighlight2.Text=$"•  Average uses logged days only; selected period: {days} days.";
            picCaloriesTrend.Configure("calories",days);
        }
        private void btnExportReport_Click(object sender, EventArgs e)
        {
            // GUI stage: export will be implemented later
            MessageBox.Show("The report for " + cmbPeriod.Text + " will be exported in the next stage.", "Export Report",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
