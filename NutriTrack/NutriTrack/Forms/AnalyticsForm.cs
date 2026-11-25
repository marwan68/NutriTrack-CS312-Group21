using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class AnalyticsForm : Form
    {
        public AnalyticsForm()
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
            // You are already on this screen
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

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            UiHelper.ApplyRoundedCorners(this);
            picDonut.Configure("donut"); picWeightAnalytics.Configure("weight"); picMacros.Configure("macros");
            lblLegendConsumed.Text=$"Consumed ({TrackingData.Calories:N0} kcal)";
            lblLegendRemaining.Text=TrackingData.Remaining;
            lblSumCaloriesValue.Text=$"{TrackingData.Calories:N0} / {TrackingData.CalorieGoal:N0} kcal";
            lblSumProteinValue.Text=$"{TrackingData.Protein:0.#} g / 120 g";
            lblSumCarbsValue.Text=$"{TrackingData.Carbs:0.#} g / 250 g";
            lblSumFatValue.Text=$"{TrackingData.Fat:0.#} g / 70 g";
            lblInsight.Text=$"You have reached {TrackingData.Percent}% of your daily calorie goal. {TrackingData.Remaining}.";
            var weights=TrackingData.WeightPeriod(30);
            lblWtStarting.Text=weights.Length==0?"Starting weight: —":$"Starting weight: {weights.First().Value:0.0} kg";
            lblWtCurrent.Text=$"Current weight: {TrackingData.Current:0.0} kg";
            lblWtLowest.Text=weights.Length==0?"Lowest weight: —":$"Lowest weight: {weights.Min(w=>w.Value):0.0} kg";
            lblWtGoal.Text=$"Goal weight: {TrackingData.WeightGoal:0.0} kg";
            lblWtWeekly.Text=(weights.Length<2 || weights.Last().Key<=weights.First().Key)?"Average per week: —":$"Average per week: {(weights.Last().Value-weights.First().Value)*7/(decimal)(weights.Last().Key-weights.First().Key).TotalDays:0.00} kg";
            lblWeightInsight.Text="Record your weight regularly to monitor your progress.";
            // Each macro is measured against its own daily goal.
            int proteinPercent = TrackingData.MacroPercent(TrackingData.Protein, 120m);
            int carbsPercent = TrackingData.MacroPercent(TrackingData.Carbs, 250m);
            int fatPercent = TrackingData.MacroPercent(TrackingData.Fat, 70m);
            int scale = TrackingData.MacroScale;
            lblSplitProtein.Text = $"Protein {proteinPercent}%";
            lblSplitCarbs.Text = $"Carbs {carbsPercent}%";
            lblSplitFat.Text = $"Fat {fatPercent}%";
            foreach (var bar in new[] { prgSplitProtein, prgSplitCarbs, prgSplitFat })
            {
                bar.Maximum = scale;
                bar.GoalMarker = 100;
            }
            prgSplitProtein.Value = proteinPercent;
            prgSplitCarbs.Value = carbsPercent;
            prgSplitFat.Value = fatPercent;
            lblMacroScale.Text = $"Scale: 0–{scale}%" + (scale > 100 ? " | Line = 100% goal" : "");
            picDonut.Invalidate();
            picWeightAnalytics.Invalidate();
            picMacros.Invalidate();
            lblMacroInsight.Text="Each macro has its own daily goal. Both charts use the same scale, which expands when a goal is exceeded.";
        }
    }
}
