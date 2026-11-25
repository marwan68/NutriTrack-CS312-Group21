using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class ManageMealsForm : Form
    {
        public ManageMealsForm()
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
            // You are already on this screen
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

        private void ManageMealsForm_Load(object sender, EventArgs e)
        {
            UiHelper.ApplyRoundedCorners(this);
            cmbFilterType.SelectedIndex = 0;
            cmbFilterType.SelectedIndexChanged += (s,e) => RefreshMeals();
            RefreshMeals();
        }

        private void RefreshMeals()
        {
            dgvMeals.Rows.Clear();
            foreach(var meal in TrackingData.Meals.Where(m => (cmbFilterType.SelectedIndex<=0 || m.Type==cmbFilterType.Text) && m.Name.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).OrderByDescending(m=>m.Date))
            {
                int index=dgvMeals.Rows.Add(meal.Name,meal.Type,meal.Calories,meal.Protein,meal.Date.ToString("dd/MM/yyyy"),colEdit.Image,colDelete.Image);
                dgvMeals.Rows[index].Tag=meal;
            }
            dgvMeals.ClearSelection();
        }

        private void btnAddNewMeal_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new LogMealForm());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshMeals();
        }

        private void dgvMeals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string meal = dgvMeals.Rows[e.RowIndex].Cells["colMealName"].Value.ToString();
            if (e.ColumnIndex == dgvMeals.Columns["colEdit"].Index)
            {
                MessageBox.Show("Editing \"" + meal + "\" will be available in the next stage.", "Edit Meal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.ColumnIndex == dgvMeals.Columns["colDelete"].Index)
            {
                if (MessageBox.Show("Delete \"" + meal + "\"?", "Delete Meal",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if(dgvMeals.Rows[e.RowIndex].Tag is TrackingData.Meal record) TrackingData.Meals.Remove(record);
                    RefreshMeals();
                }
            }
        }
    }
}
