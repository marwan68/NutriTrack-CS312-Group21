using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            // You are already on this screen
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

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            UiHelper.ApplyRoundedCorners(this);
            lblToday.Text = DateTime.Today.ToString("ddd, MMM d, yyyy");
            prgCalories.Value = TrackingData.Percent;
            lblGoalPercent.Text = $"{TrackingData.Percent}%";
            lblCaloriesRemaining.Text = TrackingData.Remaining;
            lblStatCaloriesValue.Text = $"{TrackingData.Calories:N0} kcal";
            lblStatCaloriesSub.Text = $"of {TrackingData.CalorieGoal:N0} kcal goal";
            lblStatProteinValue.Text = $"{TrackingData.Protein:0.#} g";
            lblStatWeightValue.Text = $"{TrackingData.Current:0.0} kg";
            lblStatWeightSub.Text = $"Goal: {TrackingData.WeightGoal:0.0} kg";
            lblWeightStartValue.Text = $"{TrackingData.Start:0.0} kg";
            lblWeightCurrentValue.Text = lblStatWeightValue.Text;
            lblWeightGoalValue.Text = $"{TrackingData.WeightGoal:0.0} kg";
            lblWeightTip.Text = $"Weight change since start: {TrackingData.Change:+0.0;-0.0;0.0} kg";
            BuildMealRows();
            picWeightChart.Configure("weight");
            RefreshWater();
        }

        private Panel mealList;
        private string expandedMealType;

        private void BuildMealRows()
        {
            foreach (Control control in new Control[] {
                lblMealType1, lblMealType2, lblMealType3, lblMealType4,
                lblMealFood1, lblMealFood2, lblMealFood3, lblMealFood4,
                lblMealKcal1, lblMealKcal2, lblMealKcal3, lblMealKcal4,
                sepMeal1, sepMeal2, sepMeal3, sepMeal4 })
                control.Visible = false;

            if (mealList == null)
            {
                mealList = new Panel {
                    Location = new Point(18, 44), Size = new Size(384, 136),
                    AutoScroll = true, BackColor = Color.White,
                    AccessibleName = "Today's meal categories"
                };
                pnlTodayMeals.Controls.Add(mealList);
                mealList.BringToFront();
            }
            RenderMealCategories();
        }

        private void RenderMealCategories()
        {
            mealList.SuspendLayout();
            try
            {
                mealList.AutoScrollPosition = Point.Empty;
                foreach (Control old in mealList.Controls.Cast<Control>().ToArray())
                    old.Dispose();
                var today = TrackingData.Today.ToArray();
                var types = new[] { "Breakfast", "Lunch", "Snack", "Dinner" };
                int details = expandedMealType == null ? 0 :
                    Math.Max(1, today.Count(m => m.Type == expandedMealType));
                int contentHeight = 4 * 34 + details * 28;
                int width = mealList.ClientSize.Width -
                    (contentHeight > mealList.ClientSize.Height ? SystemInformation.VerticalScrollBarWidth : 0);
                int y = 0;
                Control selectedHeader = null;
                foreach (string type in types)
                {
                    var meals = today.Where(m => m.Type == type).ToArray();
                    bool expanded = expandedMealType == type;
                    var header = new Button {
                        Location = new Point(0, y), Size = new Size(width, 32),
                        BackColor = Color.FromArgb(234, 241, 230),
                        ForeColor = Color.FromArgb(45, 89, 61),
                        FlatStyle = FlatStyle.Flat, UseVisualStyleBackColor = false,
                        Cursor = Cursors.Hand, TextAlign = ContentAlignment.MiddleLeft,
                        Font = lblMealKcal1.Font, UseMnemonic = false,
                        AccessibleName = $"{type}, {meals.Length} meals, {meals.Sum(m => m.Calories):N0} calories, {(expanded ? "expanded" : "collapsed")}",
                        AccessibleDescription = "Click or press Space to expand or collapse meals",
                        Text = $"{(expanded ? "▾" : "▸")}  {type}  ·  {meals.Length} {(meals.Length == 1 ? "meal" : "meals")}  |  {meals.Sum(m => m.Calories):N0} kcal",
                        Tag = "round"
                    };
                    header.FlatAppearance.BorderSize = 0;
                    header.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 236, 221);
                    header.Click += (sender, args) => {
                        expandedMealType = expandedMealType == type ? null : type;
                        RenderMealCategories();
                    };
                    mealList.Controls.Add(header);
                    y += 34;
                    if (!expanded) continue;
                    selectedHeader = header;
                    if (meals.Length == 0)
                    {
                        AddMealDetail(width, y, "Not logged yet", "—");
                        y += 28;
                    }
                    else
                    {
                        foreach (var meal in meals)
                        {
                            AddMealDetail(width, y, meal.Name, $"{meal.Calories:N0} kcal");
                            y += 28;
                        }
                    }
                }
                mealList.AutoScrollMinSize = new Size(0, y);
                UiHelper.ApplyRoundedCorners(mealList, 6);
                if (selectedHeader != null) mealList.ScrollControlIntoView(selectedHeader);
            }
            finally { mealList.ResumeLayout(true); }
        }

        private void AddMealDetail(int width, int y, string food, string calories)
        {
            var name = new Label {
                Location = new Point(18, y), Size = new Size(width - 122, 26),
                Font = lblMealFood1.Font, ForeColor = lblMealFood1.ForeColor,
                Text = food, TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true, UseMnemonic = false,
                AccessibleName = food
            };
            var kcal = new Label {
                Location = new Point(width - 100, y), Size = new Size(96, 26),
                Font = lblMealKcal1.Font, ForeColor = lblMealKcal1.ForeColor,
                Text = calories, TextAlign = ContentAlignment.MiddleRight
            };
            mealList.Controls.Add(name);
            mealList.Controls.Add(kcal);
        }

        private void RefreshWater()
        {
            int ml = TrackingData.WaterTodayMl;
            int goal = TrackingData.WaterGoalMl;
            int percent = TrackingData.WaterPercent;
            lblStatWaterValue.Text = $"{ml / 1000m:0.##} L";
            lblStatWaterSub.Text = $"of {goal / 1000m:0.##} L goal";
            lblWaterPercent.Text = $"{percent}%";
            prgWater.Maximum = Math.Max(100, (int)(Math.Ceiling(percent / 100m) * 100));
            prgWater.GoalMarker = 100;
            prgWater.Value = percent;
            string status = ml < goal ? $"{goal - ml:N0} mL remaining" :
                ml == goal ? "Goal reached" : $"{ml - goal:N0} mL over goal";
            lblWaterRemaining.Text = $"{ml / 1000m:0.##} / {goal / 1000m:0.##} L • {status}";
        }

        private void btnLogWater_Click(object sender, EventArgs e)
        {
            using var dialog = new WaterLogForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                TrackingData.LogWater(dialog.AmountMl);
                RefreshWater();
            }
        }

        private void btnQuickLogMeal_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new LogMealForm());
        }
    }
}
