namespace NutriTrack
{
    partial class AnalyticsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.picSidebarLogo = new System.Windows.Forms.PictureBox();
            this.lblSidebarBrand = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavLogMeal = new System.Windows.Forms.Button();
            this.btnNavManageMeals = new System.Windows.Forms.Button();
            this.btnNavWeight = new System.Windows.Forms.Button();
            this.btnNavAnalytics = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnNavProfile = new System.Windows.Forms.Button();
            this.btnNavLogout = new System.Windows.Forms.Button();
            this.picHeaderIcon = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.tabAnalytics = new System.Windows.Forms.TabControl();
            this.tabCalories = new System.Windows.Forms.TabPage();
            this.tabWeight = new System.Windows.Forms.TabPage();
            this.tabMacros = new System.Windows.Forms.TabPage();
            this.picDonut = new NutriTrack.DynamicChart();
            this.pnlDotConsumed = new System.Windows.Forms.Panel();
            this.lblLegendConsumed = new System.Windows.Forms.Label();
            this.pnlDotRemaining = new System.Windows.Forms.Panel();
            this.lblLegendRemaining = new System.Windows.Forms.Label();
            this.pnlNutritionSummary = new System.Windows.Forms.Panel();
            this.lblNutritionSummary = new System.Windows.Forms.Label();
            this.lblSumCalories = new System.Windows.Forms.Label();
            this.lblSumCaloriesValue = new System.Windows.Forms.Label();
            this.sepSum1 = new System.Windows.Forms.Panel();
            this.lblSumProtein = new System.Windows.Forms.Label();
            this.lblSumProteinValue = new System.Windows.Forms.Label();
            this.sepSum2 = new System.Windows.Forms.Panel();
            this.lblSumCarbs = new System.Windows.Forms.Label();
            this.lblSumCarbsValue = new System.Windows.Forms.Label();
            this.sepSum3 = new System.Windows.Forms.Panel();
            this.lblSumFat = new System.Windows.Forms.Label();
            this.lblSumFatValue = new System.Windows.Forms.Label();
            this.sepSum4 = new System.Windows.Forms.Panel();
            this.lblSumWater = new System.Windows.Forms.Label();
            this.lblSumWaterValue = new System.Windows.Forms.Label();
            this.pnlInsight = new System.Windows.Forms.Panel();
            this.lblInsight = new System.Windows.Forms.Label();
            this.picWeightAnalytics = new NutriTrack.DynamicChart();
            this.lblWeightLast30 = new System.Windows.Forms.Label();
            this.lblWtStarting = new System.Windows.Forms.Label();
            this.lblWtCurrent = new System.Windows.Forms.Label();
            this.lblWtLowest = new System.Windows.Forms.Label();
            this.lblWtGoal = new System.Windows.Forms.Label();
            this.lblWtWeekly = new System.Windows.Forms.Label();
            this.pnlWeightInsight = new System.Windows.Forms.Panel();
            this.lblWeightInsight = new System.Windows.Forms.Label();
            this.lblMacrosTitle = new System.Windows.Forms.Label();
            this.picMacros = new NutriTrack.DynamicChart();
            this.lblMacroSplit = new System.Windows.Forms.Label();
            this.lblSplitProtein = new System.Windows.Forms.Label();
            this.prgSplitProtein = new NutriTrack.RoundedProgressBar();
            this.lblSplitCarbs = new System.Windows.Forms.Label();
            this.prgSplitCarbs = new NutriTrack.RoundedProgressBar();
            this.lblSplitFat = new System.Windows.Forms.Label();
            this.prgSplitFat = new NutriTrack.RoundedProgressBar();
            this.pnlMacroInsight = new System.Windows.Forms.Panel();
            this.lblMacroInsight = new System.Windows.Forms.Label();
            this.lblMacroScale = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebarLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderIcon)).BeginInit();
            this.tabAnalytics.SuspendLayout();
            this.tabCalories.SuspendLayout();
            this.tabWeight.SuspendLayout();
            this.tabMacros.SuspendLayout();
            this.pnlDotConsumed.SuspendLayout();
            this.pnlDotRemaining.SuspendLayout();
            this.pnlNutritionSummary.SuspendLayout();
            this.sepSum1.SuspendLayout();
            this.sepSum2.SuspendLayout();
            this.sepSum3.SuspendLayout();
            this.sepSum4.SuspendLayout();
            this.pnlInsight.SuspendLayout();
            this.pnlWeightInsight.SuspendLayout();
            this.pnlMacroInsight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.picHeaderIcon);
            this.pnlContent.Controls.Add(this.lblHeaderTitle);
            this.pnlContent.Controls.Add(this.lblHeaderSubtitle);
            this.pnlContent.Controls.Add(this.tabAnalytics);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.picSidebarLogo);
            this.pnlSidebar.Controls.Add(this.lblSidebarBrand);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavLogMeal);
            this.pnlSidebar.Controls.Add(this.btnNavManageMeals);
            this.pnlSidebar.Controls.Add(this.btnNavWeight);
            this.pnlSidebar.Controls.Add(this.btnNavAnalytics);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavLogout);
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Size = new System.Drawing.Size(210, 680);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.TabIndex = 1;
            // 
            // picSidebarLogo
            // 
            this.picSidebarLogo.Image = global::NutriTrack.Properties.Resources.logo_small;
            this.picSidebarLogo.Location = new System.Drawing.Point(88, 20);
            this.picSidebarLogo.Size = new System.Drawing.Size(34, 34);
            this.picSidebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSidebarLogo.Name = "picSidebarLogo";
            // 
            // lblSidebarBrand
            // 
            this.lblSidebarBrand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarBrand.ForeColor = System.Drawing.Color.White;
            this.lblSidebarBrand.Location = new System.Drawing.Point(0, 58);
            this.lblSidebarBrand.Size = new System.Drawing.Size(210, 30);
            this.lblSidebarBrand.Text = "NutriTrack";
            this.lblSidebarBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSidebarBrand.Name = "lblSidebarBrand";
            this.lblSidebarBrand.TabIndex = 2;
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.Image = global::NutriTrack.Properties.Resources.nav_dashboard;
            this.btnNavDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.Location = new System.Drawing.Point(12, 110);
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavDashboard.Size = new System.Drawing.Size(186, 40);
            this.btnNavDashboard.Tag = "round";
            this.btnNavDashboard.Text = "  Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.TabIndex = 3;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // btnNavLogMeal
            // 
            this.btnNavLogMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnNavLogMeal.FlatAppearance.BorderSize = 0;
            this.btnNavLogMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.btnNavLogMeal.ForeColor = System.Drawing.Color.White;
            this.btnNavLogMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLogMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogMeal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavLogMeal.Image = global::NutriTrack.Properties.Resources.nav_logmeal;
            this.btnNavLogMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogMeal.Location = new System.Drawing.Point(12, 156);
            this.btnNavLogMeal.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavLogMeal.Size = new System.Drawing.Size(186, 40);
            this.btnNavLogMeal.Tag = "round";
            this.btnNavLogMeal.Text = "  Log Meal";
            this.btnNavLogMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogMeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavLogMeal.UseVisualStyleBackColor = false;
            this.btnNavLogMeal.Name = "btnNavLogMeal";
            this.btnNavLogMeal.TabIndex = 4;
            this.btnNavLogMeal.Click += new System.EventHandler(this.btnNavLogMeal_Click);
            // 
            // btnNavManageMeals
            // 
            this.btnNavManageMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnNavManageMeals.FlatAppearance.BorderSize = 0;
            this.btnNavManageMeals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.btnNavManageMeals.ForeColor = System.Drawing.Color.White;
            this.btnNavManageMeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavManageMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageMeals.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavManageMeals.Image = global::NutriTrack.Properties.Resources.nav_manage;
            this.btnNavManageMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageMeals.Location = new System.Drawing.Point(12, 202);
            this.btnNavManageMeals.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavManageMeals.Size = new System.Drawing.Size(186, 40);
            this.btnNavManageMeals.Tag = "round";
            this.btnNavManageMeals.Text = "  Manage Meals";
            this.btnNavManageMeals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageMeals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavManageMeals.UseVisualStyleBackColor = false;
            this.btnNavManageMeals.Name = "btnNavManageMeals";
            this.btnNavManageMeals.TabIndex = 5;
            this.btnNavManageMeals.Click += new System.EventHandler(this.btnNavManageMeals_Click);
            // 
            // btnNavWeight
            // 
            this.btnNavWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnNavWeight.FlatAppearance.BorderSize = 0;
            this.btnNavWeight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.btnNavWeight.ForeColor = System.Drawing.Color.White;
            this.btnNavWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavWeight.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavWeight.Image = global::NutriTrack.Properties.Resources.nav_weight;
            this.btnNavWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavWeight.Location = new System.Drawing.Point(12, 248);
            this.btnNavWeight.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavWeight.Size = new System.Drawing.Size(186, 40);
            this.btnNavWeight.Tag = "round";
            this.btnNavWeight.Text = "  Weight";
            this.btnNavWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavWeight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavWeight.UseVisualStyleBackColor = false;
            this.btnNavWeight.Name = "btnNavWeight";
            this.btnNavWeight.TabIndex = 6;
            this.btnNavWeight.Click += new System.EventHandler(this.btnNavWeight_Click);
            // 
            // btnNavAnalytics
            // 
            this.btnNavAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavAnalytics.FlatAppearance.BorderSize = 0;
            this.btnNavAnalytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnNavAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAnalytics.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAnalytics.Image = global::NutriTrack.Properties.Resources.nav_analytics;
            this.btnNavAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAnalytics.Location = new System.Drawing.Point(12, 294);
            this.btnNavAnalytics.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavAnalytics.Size = new System.Drawing.Size(186, 40);
            this.btnNavAnalytics.Tag = "round";
            this.btnNavAnalytics.Text = "  Analytics";
            this.btnNavAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavAnalytics.UseVisualStyleBackColor = false;
            this.btnNavAnalytics.Name = "btnNavAnalytics";
            this.btnNavAnalytics.TabIndex = 7;
            this.btnNavAnalytics.Click += new System.EventHandler(this.btnNavAnalytics_Click);
            // 
            // btnNavReports
            // 
            this.btnNavReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnNavReports.FlatAppearance.BorderSize = 0;
            this.btnNavReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.btnNavReports.ForeColor = System.Drawing.Color.White;
            this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavReports.Image = global::NutriTrack.Properties.Resources.nav_reports;
            this.btnNavReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.Location = new System.Drawing.Point(12, 340);
            this.btnNavReports.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavReports.Size = new System.Drawing.Size(186, 40);
            this.btnNavReports.Tag = "round";
            this.btnNavReports.Text = "  Reports";
            this.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavReports.UseVisualStyleBackColor = false;
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.TabIndex = 8;
            this.btnNavReports.Click += new System.EventHandler(this.btnNavReports_Click);
            // 
            // btnNavProfile
            // 
            this.btnNavProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnNavProfile.FlatAppearance.BorderSize = 0;
            this.btnNavProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.btnNavProfile.ForeColor = System.Drawing.Color.White;
            this.btnNavProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfile.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavProfile.Image = global::NutriTrack.Properties.Resources.nav_profile;
            this.btnNavProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProfile.Location = new System.Drawing.Point(12, 386);
            this.btnNavProfile.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavProfile.Size = new System.Drawing.Size(186, 40);
            this.btnNavProfile.Tag = "round";
            this.btnNavProfile.Text = "  Profile";
            this.btnNavProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavProfile.UseVisualStyleBackColor = false;
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.TabIndex = 9;
            this.btnNavProfile.Click += new System.EventHandler(this.btnNavProfile_Click);
            // 
            // btnNavLogout
            // 
            this.btnNavLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnNavLogout.FlatAppearance.BorderSize = 0;
            this.btnNavLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.btnNavLogout.ForeColor = System.Drawing.Color.White;
            this.btnNavLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogout.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavLogout.Image = global::NutriTrack.Properties.Resources.nav_logout;
            this.btnNavLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.Location = new System.Drawing.Point(12, 616);
            this.btnNavLogout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavLogout.Size = new System.Drawing.Size(186, 40);
            this.btnNavLogout.Tag = "round";
            this.btnNavLogout.Text = "  Logout";
            this.btnNavLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavLogout.UseVisualStyleBackColor = false;
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.TabIndex = 10;
            this.btnNavLogout.Click += new System.EventHandler(this.btnNavLogout_Click);
            // 
            // picHeaderIcon
            // 
            this.picHeaderIcon.Image = global::NutriTrack.Properties.Resources.hd_chart;
            this.picHeaderIcon.Location = new System.Drawing.Point(24, 22);
            this.picHeaderIcon.Size = new System.Drawing.Size(44, 44);
            this.picHeaderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHeaderIcon.Name = "picHeaderIcon";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(74, 16);
            this.lblHeaderTitle.Text = "Analytics";
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.TabIndex = 11;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(77, 56);
            this.lblHeaderSubtitle.Text = "View your progress and insights";
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.TabIndex = 12;
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.Controls.Add(this.tabCalories);
            this.tabAnalytics.Controls.Add(this.tabWeight);
            this.tabAnalytics.Controls.Add(this.tabMacros);
            this.tabAnalytics.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAnalytics.Location = new System.Drawing.Point(22, 95);
            this.tabAnalytics.Padding = new System.Drawing.Point(16, 6);
            this.tabAnalytics.SelectedIndex = 0;
            this.tabAnalytics.Size = new System.Drawing.Size(846, 556);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.TabIndex = 13;
            // 
            // tabCalories
            // 
            this.tabCalories.Controls.Add(this.picDonut);
            this.tabCalories.Controls.Add(this.pnlDotConsumed);
            this.tabCalories.Controls.Add(this.lblLegendConsumed);
            this.tabCalories.Controls.Add(this.pnlDotRemaining);
            this.tabCalories.Controls.Add(this.lblLegendRemaining);
            this.tabCalories.Controls.Add(this.pnlNutritionSummary);
            this.tabCalories.Controls.Add(this.pnlInsight);
            this.tabCalories.BackColor = System.Drawing.Color.White;
            this.tabCalories.Location = new System.Drawing.Point(4, 32);
            this.tabCalories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalories.Size = new System.Drawing.Size(838, 520);
            this.tabCalories.Text = "Calories";
            this.tabCalories.UseVisualStyleBackColor = false;
            this.tabCalories.Name = "tabCalories";
            this.tabCalories.TabIndex = 14;
            // 
            // tabWeight
            // 
            this.tabWeight.Controls.Add(this.picWeightAnalytics);
            this.tabWeight.Controls.Add(this.lblWeightLast30);
            this.tabWeight.Controls.Add(this.lblWtStarting);
            this.tabWeight.Controls.Add(this.lblWtCurrent);
            this.tabWeight.Controls.Add(this.lblWtLowest);
            this.tabWeight.Controls.Add(this.lblWtGoal);
            this.tabWeight.Controls.Add(this.lblWtWeekly);
            this.tabWeight.Controls.Add(this.pnlWeightInsight);
            this.tabWeight.BackColor = System.Drawing.Color.White;
            this.tabWeight.Location = new System.Drawing.Point(4, 32);
            this.tabWeight.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeight.Size = new System.Drawing.Size(838, 520);
            this.tabWeight.Text = "Weight";
            this.tabWeight.UseVisualStyleBackColor = false;
            this.tabWeight.Name = "tabWeight";
            this.tabWeight.TabIndex = 15;
            // 
            // tabMacros
            // 
            this.tabMacros.Controls.Add(this.lblMacrosTitle);
            this.tabMacros.Controls.Add(this.picMacros);
            this.tabMacros.Controls.Add(this.lblMacroSplit);
            this.tabMacros.Controls.Add(this.lblSplitProtein);
            this.tabMacros.Controls.Add(this.prgSplitProtein);
            this.tabMacros.Controls.Add(this.lblSplitCarbs);
            this.tabMacros.Controls.Add(this.prgSplitCarbs);
            this.tabMacros.Controls.Add(this.lblSplitFat);
            this.tabMacros.Controls.Add(this.prgSplitFat);
            this.tabMacros.Controls.Add(this.lblMacroScale);
            this.tabMacros.Controls.Add(this.pnlMacroInsight);
            this.tabMacros.BackColor = System.Drawing.Color.White;
            this.tabMacros.Location = new System.Drawing.Point(4, 32);
            this.tabMacros.Padding = new System.Windows.Forms.Padding(3);
            this.tabMacros.Size = new System.Drawing.Size(838, 520);
            this.tabMacros.Text = "Macros";
            this.tabMacros.UseVisualStyleBackColor = false;
            this.tabMacros.Name = "tabMacros";
            this.tabMacros.TabIndex = 16;
            // 
            // picDonut
            // 
            this.picDonut.Location = new System.Drawing.Point(40, 30);
            this.picDonut.Size = new System.Drawing.Size(240, 240);
            this.picDonut.Name = "picDonut";
            // 
            // pnlDotConsumed
            // 
            this.pnlDotConsumed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(123)))), ((int)(((byte)(79)))));
            this.pnlDotConsumed.Location = new System.Drawing.Point(76, 296);
            this.pnlDotConsumed.Size = new System.Drawing.Size(12, 12);
            this.pnlDotConsumed.Name = "pnlDotConsumed";
            this.pnlDotConsumed.TabIndex = 17;
            // 
            // lblLegendConsumed
            // 
            this.lblLegendConsumed.AutoSize = true;
            this.lblLegendConsumed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendConsumed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblLegendConsumed.Location = new System.Drawing.Point(96, 290);
            this.lblLegendConsumed.Text = "Consumed (1,450 kcal)";
            this.lblLegendConsumed.Name = "lblLegendConsumed";
            this.lblLegendConsumed.TabIndex = 18;
            // 
            // pnlDotRemaining
            // 
            this.pnlDotRemaining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.pnlDotRemaining.Location = new System.Drawing.Point(76, 324);
            this.pnlDotRemaining.Size = new System.Drawing.Size(12, 12);
            this.pnlDotRemaining.Name = "pnlDotRemaining";
            this.pnlDotRemaining.TabIndex = 19;
            // 
            // lblLegendRemaining
            // 
            this.lblLegendRemaining.AutoSize = true;
            this.lblLegendRemaining.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblLegendRemaining.Location = new System.Drawing.Point(96, 318);
            this.lblLegendRemaining.Text = "Remaining (550 kcal)";
            this.lblLegendRemaining.Name = "lblLegendRemaining";
            this.lblLegendRemaining.TabIndex = 20;
            // 
            // pnlNutritionSummary
            // 
            this.pnlNutritionSummary.Controls.Add(this.lblNutritionSummary);
            this.pnlNutritionSummary.Controls.Add(this.lblSumCalories);
            this.pnlNutritionSummary.Controls.Add(this.lblSumCaloriesValue);
            this.pnlNutritionSummary.Controls.Add(this.sepSum1);
            this.pnlNutritionSummary.Controls.Add(this.lblSumProtein);
            this.pnlNutritionSummary.Controls.Add(this.lblSumProteinValue);
            this.pnlNutritionSummary.Controls.Add(this.sepSum2);
            this.pnlNutritionSummary.Controls.Add(this.lblSumCarbs);
            this.pnlNutritionSummary.Controls.Add(this.lblSumCarbsValue);
            this.pnlNutritionSummary.Controls.Add(this.sepSum3);
            this.pnlNutritionSummary.Controls.Add(this.lblSumFat);
            this.pnlNutritionSummary.Controls.Add(this.lblSumFatValue);
            this.pnlNutritionSummary.Controls.Add(this.sepSum4);
            this.pnlNutritionSummary.Controls.Add(this.lblSumWater);
            this.pnlNutritionSummary.Controls.Add(this.lblSumWaterValue);
            this.pnlNutritionSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.pnlNutritionSummary.Location = new System.Drawing.Point(330, 24);
            this.pnlNutritionSummary.Size = new System.Drawing.Size(480, 352);
            this.pnlNutritionSummary.Tag = "round";
            this.pnlNutritionSummary.Name = "pnlNutritionSummary";
            this.pnlNutritionSummary.TabIndex = 21;
            // 
            // lblNutritionSummary
            // 
            this.lblNutritionSummary.AutoSize = true;
            this.lblNutritionSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNutritionSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblNutritionSummary.Location = new System.Drawing.Point(20, 16);
            this.lblNutritionSummary.Text = "Nutrition Summary";
            this.lblNutritionSummary.Name = "lblNutritionSummary";
            this.lblNutritionSummary.TabIndex = 22;
            // 
            // lblSumCalories
            // 
            this.lblSumCalories.AutoSize = true;
            this.lblSumCalories.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumCalories.Location = new System.Drawing.Point(20, 78);
            this.lblSumCalories.Text = "Calories:";
            this.lblSumCalories.Name = "lblSumCalories";
            this.lblSumCalories.TabIndex = 23;
            // 
            // lblSumCaloriesValue
            // 
            this.lblSumCaloriesValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumCaloriesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumCaloriesValue.Location = new System.Drawing.Point(200, 78);
            this.lblSumCaloriesValue.Size = new System.Drawing.Size(260, 22);
            this.lblSumCaloriesValue.Text = "1,450 / 2,000 kcal";
            this.lblSumCaloriesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumCaloriesValue.Name = "lblSumCaloriesValue";
            this.lblSumCaloriesValue.TabIndex = 24;
            // 
            // sepSum1
            // 
            this.sepSum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.sepSum1.Location = new System.Drawing.Point(20, 116);
            this.sepSum1.Size = new System.Drawing.Size(440, 1);
            this.sepSum1.Name = "sepSum1";
            this.sepSum1.TabIndex = 25;
            // 
            // lblSumProtein
            // 
            this.lblSumProtein.AutoSize = true;
            this.lblSumProtein.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumProtein.Location = new System.Drawing.Point(20, 134);
            this.lblSumProtein.Text = "Protein:";
            this.lblSumProtein.Name = "lblSumProtein";
            this.lblSumProtein.TabIndex = 26;
            // 
            // lblSumProteinValue
            // 
            this.lblSumProteinValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumProteinValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumProteinValue.Location = new System.Drawing.Point(200, 134);
            this.lblSumProteinValue.Size = new System.Drawing.Size(260, 22);
            this.lblSumProteinValue.Text = "82 g / 120 g";
            this.lblSumProteinValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumProteinValue.Name = "lblSumProteinValue";
            this.lblSumProteinValue.TabIndex = 27;
            // 
            // sepSum2
            // 
            this.sepSum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.sepSum2.Location = new System.Drawing.Point(20, 172);
            this.sepSum2.Size = new System.Drawing.Size(440, 1);
            this.sepSum2.Name = "sepSum2";
            this.sepSum2.TabIndex = 28;
            // 
            // lblSumCarbs
            // 
            this.lblSumCarbs.AutoSize = true;
            this.lblSumCarbs.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumCarbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumCarbs.Location = new System.Drawing.Point(20, 190);
            this.lblSumCarbs.Text = "Carbs:";
            this.lblSumCarbs.Name = "lblSumCarbs";
            this.lblSumCarbs.TabIndex = 29;
            // 
            // lblSumCarbsValue
            // 
            this.lblSumCarbsValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumCarbsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumCarbsValue.Location = new System.Drawing.Point(200, 190);
            this.lblSumCarbsValue.Size = new System.Drawing.Size(260, 22);
            this.lblSumCarbsValue.Text = "180 g / 250 g";
            this.lblSumCarbsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumCarbsValue.Name = "lblSumCarbsValue";
            this.lblSumCarbsValue.TabIndex = 30;
            // 
            // sepSum3
            // 
            this.sepSum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.sepSum3.Location = new System.Drawing.Point(20, 228);
            this.sepSum3.Size = new System.Drawing.Size(440, 1);
            this.sepSum3.Name = "sepSum3";
            this.sepSum3.TabIndex = 31;
            // 
            // lblSumFat
            // 
            this.lblSumFat.AutoSize = true;
            this.lblSumFat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumFat.Location = new System.Drawing.Point(20, 246);
            this.lblSumFat.Text = "Fat:";
            this.lblSumFat.Name = "lblSumFat";
            this.lblSumFat.TabIndex = 32;
            // 
            // lblSumFatValue
            // 
            this.lblSumFatValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumFatValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumFatValue.Location = new System.Drawing.Point(200, 246);
            this.lblSumFatValue.Size = new System.Drawing.Size(260, 22);
            this.lblSumFatValue.Text = "45 g / 70 g";
            this.lblSumFatValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumFatValue.Name = "lblSumFatValue";
            this.lblSumFatValue.TabIndex = 33;
            // 
            // sepSum4
            // 
            this.sepSum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.sepSum4.Location = new System.Drawing.Point(20, 284);
            this.sepSum4.Size = new System.Drawing.Size(440, 1);
            this.sepSum4.Name = "sepSum4";
            this.sepSum4.TabIndex = 34;
            // 
            // lblSumWater
            // 
            this.lblSumWater.AutoSize = true;
            this.lblSumWater.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumWater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumWater.Location = new System.Drawing.Point(20, 302);
            this.lblSumWater.Text = "Water:";
            this.lblSumWater.Name = "lblSumWater";
            this.lblSumWater.TabIndex = 35;
            // 
            // lblSumWaterValue
            // 
            this.lblSumWaterValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumWaterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSumWaterValue.Location = new System.Drawing.Point(200, 302);
            this.lblSumWaterValue.Size = new System.Drawing.Size(260, 22);
            this.lblSumWaterValue.Text = "1.5 L / 2.5 L";
            this.lblSumWaterValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumWaterValue.Name = "lblSumWaterValue";
            this.lblSumWaterValue.TabIndex = 36;
            // 
            // pnlInsight
            // 
            this.pnlInsight.Controls.Add(this.lblInsight);
            this.pnlInsight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlInsight.Location = new System.Drawing.Point(30, 400);
            this.pnlInsight.Size = new System.Drawing.Size(780, 72);
            this.pnlInsight.Tag = "round";
            this.pnlInsight.Name = "pnlInsight";
            this.pnlInsight.TabIndex = 37;
            // 
            // lblInsight
            // 
            this.lblInsight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.lblInsight.Location = new System.Drawing.Point(18, 0);
            this.lblInsight.Size = new System.Drawing.Size(744, 72);
            this.lblInsight.Text = "You have reached 72% of your daily calorie goal. A light, protein-rich dinner (about 550 kcal) will complete your plan for today.";
            this.lblInsight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInsight.Name = "lblInsight";
            this.lblInsight.TabIndex = 38;
            // 
            // picWeightAnalytics
            // 
            this.picWeightAnalytics.Location = new System.Drawing.Point(20, 24);
            this.picWeightAnalytics.Size = new System.Drawing.Size(560, 330);
            this.picWeightAnalytics.Name = "picWeightAnalytics";
            // 
            // lblWeightLast30
            // 
            this.lblWeightLast30.AutoSize = true;
            this.lblWeightLast30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightLast30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWeightLast30.Location = new System.Drawing.Point(610, 30);
            this.lblWeightLast30.Text = "Last 30 days";
            this.lblWeightLast30.Name = "lblWeightLast30";
            this.lblWeightLast30.TabIndex = 39;
            // 
            // lblWtStarting
            // 
            this.lblWtStarting.AutoSize = true;
            this.lblWtStarting.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWtStarting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWtStarting.Location = new System.Drawing.Point(610, 70);
            this.lblWtStarting.Text = "Starting weight:   69.0 kg";
            this.lblWtStarting.Name = "lblWtStarting";
            this.lblWtStarting.TabIndex = 40;
            // 
            // lblWtCurrent
            // 
            this.lblWtCurrent.AutoSize = true;
            this.lblWtCurrent.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWtCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWtCurrent.Location = new System.Drawing.Point(610, 106);
            this.lblWtCurrent.Text = "Current weight:    68.5 kg";
            this.lblWtCurrent.Name = "lblWtCurrent";
            this.lblWtCurrent.TabIndex = 41;
            // 
            // lblWtLowest
            // 
            this.lblWtLowest.AutoSize = true;
            this.lblWtLowest.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWtLowest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWtLowest.Location = new System.Drawing.Point(610, 142);
            this.lblWtLowest.Text = "Lowest weight:     68.4 kg";
            this.lblWtLowest.Name = "lblWtLowest";
            this.lblWtLowest.TabIndex = 42;
            // 
            // lblWtGoal
            // 
            this.lblWtGoal.AutoSize = true;
            this.lblWtGoal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWtGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWtGoal.Location = new System.Drawing.Point(610, 178);
            this.lblWtGoal.Text = "Goal weight:       65.0 kg";
            this.lblWtGoal.Name = "lblWtGoal";
            this.lblWtGoal.TabIndex = 43;
            // 
            // lblWtWeekly
            // 
            this.lblWtWeekly.AutoSize = true;
            this.lblWtWeekly.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWtWeekly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWtWeekly.Location = new System.Drawing.Point(610, 214);
            this.lblWtWeekly.Text = "Average per week:  -0.13 kg";
            this.lblWtWeekly.Name = "lblWtWeekly";
            this.lblWtWeekly.TabIndex = 44;
            // 
            // pnlWeightInsight
            // 
            this.pnlWeightInsight.Controls.Add(this.lblWeightInsight);
            this.pnlWeightInsight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlWeightInsight.Location = new System.Drawing.Point(20, 380);
            this.pnlWeightInsight.Size = new System.Drawing.Size(790, 72);
            this.pnlWeightInsight.Tag = "round";
            this.pnlWeightInsight.Name = "pnlWeightInsight";
            this.pnlWeightInsight.TabIndex = 45;
            // 
            // lblWeightInsight
            // 
            this.lblWeightInsight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightInsight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.lblWeightInsight.Location = new System.Drawing.Point(18, 0);
            this.lblWeightInsight.Size = new System.Drawing.Size(754, 72);
            this.lblWeightInsight.Text = "At your current pace you will reach your goal weight of 65.0 kg in about 6 months. Keep tracking every week!";
            this.lblWeightInsight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWeightInsight.Name = "lblWeightInsight";
            this.lblWeightInsight.TabIndex = 46;
            // 
            // lblMacrosTitle
            // 
            this.lblMacrosTitle.AutoSize = true;
            this.lblMacrosTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacrosTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblMacrosTitle.Location = new System.Drawing.Point(30, 24);
            this.lblMacrosTitle.Text = "Today's macros vs goal";
            this.lblMacrosTitle.Name = "lblMacrosTitle";
            this.lblMacrosTitle.TabIndex = 47;
            // 
            // picMacros
            // 
            this.picMacros.Location = new System.Drawing.Point(24, 56);
            this.picMacros.Size = new System.Drawing.Size(520, 220);
            this.picMacros.Name = "picMacros";
            // 
            // lblMacroSplit
            // 
            this.lblMacroSplit.AutoSize = true;
            this.lblMacroSplit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacroSplit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblMacroSplit.Location = new System.Drawing.Point(590, 24);
            this.lblMacroSplit.Text = "Macro Goal Progress";
            this.lblMacroSplit.Name = "lblMacroSplit";
            this.lblMacroSplit.TabIndex = 48;
            // 
            // lblSplitProtein
            // 
            this.lblSplitProtein.AutoSize = true;
            this.lblSplitProtein.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplitProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSplitProtein.Location = new System.Drawing.Point(590, 66);
            this.lblSplitProtein.Text = "Protein  23%";
            this.lblSplitProtein.Name = "lblSplitProtein";
            this.lblSplitProtein.TabIndex = 49;
            // 
            // prgSplitProtein
            // 
            this.prgSplitProtein.Location = new System.Drawing.Point(590, 92);
            this.prgSplitProtein.Size = new System.Drawing.Size(220, 16);
            this.prgSplitProtein.Value = 0;
            this.prgSplitProtein.Name = "prgSplitProtein";
            this.prgSplitProtein.TabIndex = 50;
            // 
            // lblSplitCarbs
            // 
            this.lblSplitCarbs.AutoSize = true;
            this.lblSplitCarbs.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplitCarbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSplitCarbs.Location = new System.Drawing.Point(590, 132);
            this.lblSplitCarbs.Text = "Carbs  50%";
            this.lblSplitCarbs.Name = "lblSplitCarbs";
            this.lblSplitCarbs.TabIndex = 51;
            // 
            // prgSplitCarbs
            // 
            this.prgSplitCarbs.Location = new System.Drawing.Point(590, 158);
            this.prgSplitCarbs.Size = new System.Drawing.Size(220, 16);
            this.prgSplitCarbs.Value = 0;
            this.prgSplitCarbs.Name = "prgSplitCarbs";
            this.prgSplitCarbs.TabIndex = 52;
            // 
            // lblSplitFat
            // 
            this.lblSplitFat.AutoSize = true;
            this.lblSplitFat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplitFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblSplitFat.Location = new System.Drawing.Point(590, 198);
            this.lblSplitFat.Text = "Fat  28%";
            this.lblSplitFat.Name = "lblSplitFat";
            this.lblSplitFat.TabIndex = 53;
            // 
            // prgSplitFat
            // 
            this.prgSplitFat.Location = new System.Drawing.Point(590, 224);
            this.prgSplitFat.Size = new System.Drawing.Size(220, 16);
            this.prgSplitFat.Value = 0;
            this.prgSplitFat.Name = "prgSplitFat";
            this.prgSplitFat.TabIndex = 54;
            // 
            // lblMacroScale
            //
            this.lblMacroScale.AutoSize = true;
            this.lblMacroScale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMacroScale.ForeColor = System.Drawing.Color.FromArgb(85, 100, 88);
            this.lblMacroScale.Location = new System.Drawing.Point(590, 252);
            this.lblMacroScale.Name = "lblMacroScale";
            this.lblMacroScale.Text = "Scale: 0–100%";
            //
            // pnlMacroInsight
            // 
            this.pnlMacroInsight.Controls.Add(this.lblMacroInsight);
            this.pnlMacroInsight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlMacroInsight.Location = new System.Drawing.Point(20, 380);
            this.pnlMacroInsight.Size = new System.Drawing.Size(790, 72);
            this.pnlMacroInsight.Tag = "round";
            this.pnlMacroInsight.Name = "pnlMacroInsight";
            this.pnlMacroInsight.TabIndex = 55;
            // 
            // lblMacroInsight
            // 
            this.lblMacroInsight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacroInsight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.lblMacroInsight.Location = new System.Drawing.Point(18, 0);
            this.lblMacroInsight.Size = new System.Drawing.Size(754, 72);
            this.lblMacroInsight.Text = "Protein is the macro furthest from its goal today (38 g left). Try adding eggs, chicken, lentils or Greek yogurt.";
            this.lblMacroInsight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMacroInsight.Name = "lblMacroInsight";
            this.lblMacroInsight.TabIndex = 56;
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Icon = global::NutriTrack.Properties.Resources.app;
            this.Name = "AnalyticsForm";
            this.Text = "NutriTrack - Analytics";
            this.Load += new System.EventHandler(this.AnalyticsForm_Load);
            this.pnlMacroInsight.ResumeLayout(false);
            this.pnlMacroInsight.PerformLayout();
            this.pnlWeightInsight.ResumeLayout(false);
            this.pnlWeightInsight.PerformLayout();
            this.pnlInsight.ResumeLayout(false);
            this.pnlInsight.PerformLayout();
            this.sepSum4.ResumeLayout(false);
            this.sepSum4.PerformLayout();
            this.sepSum3.ResumeLayout(false);
            this.sepSum3.PerformLayout();
            this.sepSum2.ResumeLayout(false);
            this.sepSum2.PerformLayout();
            this.sepSum1.ResumeLayout(false);
            this.sepSum1.PerformLayout();
            this.pnlNutritionSummary.ResumeLayout(false);
            this.pnlNutritionSummary.PerformLayout();
            this.pnlDotRemaining.ResumeLayout(false);
            this.pnlDotRemaining.PerformLayout();
            this.pnlDotConsumed.ResumeLayout(false);
            this.pnlDotConsumed.PerformLayout();
            this.tabMacros.ResumeLayout(false);
            this.tabMacros.PerformLayout();
            this.tabWeight.ResumeLayout(false);
            this.tabWeight.PerformLayout();
            this.tabCalories.ResumeLayout(false);
            this.tabCalories.PerformLayout();
            this.tabAnalytics.ResumeLayout(false);
            this.tabAnalytics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebarLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox picSidebarLogo;
        private System.Windows.Forms.Label lblSidebarBrand;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavLogMeal;
        private System.Windows.Forms.Button btnNavManageMeals;
        private System.Windows.Forms.Button btnNavWeight;
        private System.Windows.Forms.Button btnNavAnalytics;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnNavProfile;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.PictureBox picHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.TabControl tabAnalytics;
        private System.Windows.Forms.TabPage tabCalories;
        private System.Windows.Forms.TabPage tabWeight;
        private System.Windows.Forms.TabPage tabMacros;
        private NutriTrack.DynamicChart picDonut;
        private System.Windows.Forms.Panel pnlDotConsumed;
        private System.Windows.Forms.Label lblLegendConsumed;
        private System.Windows.Forms.Panel pnlDotRemaining;
        private System.Windows.Forms.Label lblLegendRemaining;
        private System.Windows.Forms.Panel pnlNutritionSummary;
        private System.Windows.Forms.Label lblNutritionSummary;
        private System.Windows.Forms.Label lblSumCalories;
        private System.Windows.Forms.Label lblSumCaloriesValue;
        private System.Windows.Forms.Panel sepSum1;
        private System.Windows.Forms.Label lblSumProtein;
        private System.Windows.Forms.Label lblSumProteinValue;
        private System.Windows.Forms.Panel sepSum2;
        private System.Windows.Forms.Label lblSumCarbs;
        private System.Windows.Forms.Label lblSumCarbsValue;
        private System.Windows.Forms.Panel sepSum3;
        private System.Windows.Forms.Label lblSumFat;
        private System.Windows.Forms.Label lblSumFatValue;
        private System.Windows.Forms.Panel sepSum4;
        private System.Windows.Forms.Label lblSumWater;
        private System.Windows.Forms.Label lblSumWaterValue;
        private System.Windows.Forms.Panel pnlInsight;
        private System.Windows.Forms.Label lblInsight;
        private NutriTrack.DynamicChart picWeightAnalytics;
        private System.Windows.Forms.Label lblWeightLast30;
        private System.Windows.Forms.Label lblWtStarting;
        private System.Windows.Forms.Label lblWtCurrent;
        private System.Windows.Forms.Label lblWtLowest;
        private System.Windows.Forms.Label lblWtGoal;
        private System.Windows.Forms.Label lblWtWeekly;
        private System.Windows.Forms.Panel pnlWeightInsight;
        private System.Windows.Forms.Label lblWeightInsight;
        private System.Windows.Forms.Label lblMacrosTitle;
        private NutriTrack.DynamicChart picMacros;
        private System.Windows.Forms.Label lblMacroSplit;
        private System.Windows.Forms.Label lblSplitProtein;
        private NutriTrack.RoundedProgressBar prgSplitProtein;
        private System.Windows.Forms.Label lblSplitCarbs;
        private NutriTrack.RoundedProgressBar prgSplitCarbs;
        private System.Windows.Forms.Label lblSplitFat;
        private NutriTrack.RoundedProgressBar prgSplitFat;
        private System.Windows.Forms.Panel pnlMacroInsight;
        private System.Windows.Forms.Label lblMacroInsight;
        private System.Windows.Forms.Label lblMacroScale;
    }
}
