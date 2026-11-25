namespace NutriTrack
{
    partial class ReportsForm
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
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.pnlRepAvgCalories = new System.Windows.Forms.Panel();
            this.picRepAvgCalories = new System.Windows.Forms.PictureBox();
            this.lblRepAvgCaloriesTitle = new System.Windows.Forms.Label();
            this.lblRepAvgCaloriesValue = new System.Windows.Forms.Label();
            this.pnlRepWeightChange = new System.Windows.Forms.Panel();
            this.picRepWeightChange = new System.Windows.Forms.PictureBox();
            this.lblRepWeightChangeTitle = new System.Windows.Forms.Label();
            this.lblRepWeightChangeValue = new System.Windows.Forms.Label();
            this.pnlRepMealsLogged = new System.Windows.Forms.Panel();
            this.picRepMealsLogged = new System.Windows.Forms.PictureBox();
            this.lblRepMealsLoggedTitle = new System.Windows.Forms.Label();
            this.lblRepMealsLoggedValue = new System.Windows.Forms.Label();
            this.pnlRepGoalDays = new System.Windows.Forms.Panel();
            this.picRepGoalDays = new System.Windows.Forms.PictureBox();
            this.lblRepGoalDaysTitle = new System.Windows.Forms.Label();
            this.lblRepGoalDaysValue = new System.Windows.Forms.Label();
            this.pnlTrendCard = new System.Windows.Forms.Panel();
            this.picTrendIcon = new System.Windows.Forms.PictureBox();
            this.lblTrendTitle = new System.Windows.Forms.Label();
            this.picCaloriesTrend = new NutriTrack.DynamicChart();
            this.pnlHighlights = new System.Windows.Forms.Panel();
            this.lblHighlights = new System.Windows.Forms.Label();
            this.lblHighlight1 = new System.Windows.Forms.Label();
            this.lblHighlight2 = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebarLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderIcon)).BeginInit();
            this.pnlRepAvgCalories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepAvgCalories)).BeginInit();
            this.pnlRepWeightChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepWeightChange)).BeginInit();
            this.pnlRepMealsLogged.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepMealsLogged)).BeginInit();
            this.pnlRepGoalDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepGoalDays)).BeginInit();
            this.pnlTrendCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrendIcon)).BeginInit();
            this.pnlHighlights.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.picHeaderIcon);
            this.pnlContent.Controls.Add(this.lblHeaderTitle);
            this.pnlContent.Controls.Add(this.lblHeaderSubtitle);
            this.pnlContent.Controls.Add(this.cmbPeriod);
            this.pnlContent.Controls.Add(this.pnlRepAvgCalories);
            this.pnlContent.Controls.Add(this.pnlRepWeightChange);
            this.pnlContent.Controls.Add(this.pnlRepMealsLogged);
            this.pnlContent.Controls.Add(this.pnlRepGoalDays);
            this.pnlContent.Controls.Add(this.pnlTrendCard);
            this.pnlContent.Controls.Add(this.pnlHighlights);
            this.pnlContent.Controls.Add(this.btnExportReport);
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
            this.btnNavAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnNavAnalytics.FlatAppearance.BorderSize = 0;
            this.btnNavAnalytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.btnNavAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnNavAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAnalytics.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnNavReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavReports.FlatAppearance.BorderSize = 0;
            this.btnNavReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavReports.ForeColor = System.Drawing.Color.White;
            this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.picHeaderIcon.Image = global::NutriTrack.Properties.Resources.hd_report;
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
            this.lblHeaderTitle.Text = "Summary Report";
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.TabIndex = 11;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(77, 56);
            this.lblHeaderSubtitle.Text = "Your overall health summary";
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.TabIndex = 12;
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.Items.AddRange(new object[] {
            "Last 7 Days",
            "Last 30 Days",
            "Last 90 Days"});
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPeriod.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Location = new System.Drawing.Point(708, 34);
            this.cmbPeriod.Size = new System.Drawing.Size(160, 27);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.TabIndex = 13;
            // 
            // pnlRepAvgCalories
            // 
            this.pnlRepAvgCalories.Controls.Add(this.picRepAvgCalories);
            this.pnlRepAvgCalories.Controls.Add(this.lblRepAvgCaloriesTitle);
            this.pnlRepAvgCalories.Controls.Add(this.lblRepAvgCaloriesValue);
            this.pnlRepAvgCalories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlRepAvgCalories.Location = new System.Drawing.Point(22, 95);
            this.pnlRepAvgCalories.Size = new System.Drawing.Size(200, 96);
            this.pnlRepAvgCalories.Tag = "round";
            this.pnlRepAvgCalories.Name = "pnlRepAvgCalories";
            this.pnlRepAvgCalories.TabIndex = 14;
            // 
            // picRepAvgCalories
            // 
            this.picRepAvgCalories.Image = global::NutriTrack.Properties.Resources.ic_fire;
            this.picRepAvgCalories.Location = new System.Drawing.Point(14, 18);
            this.picRepAvgCalories.Size = new System.Drawing.Size(32, 32);
            this.picRepAvgCalories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRepAvgCalories.Name = "picRepAvgCalories";
            // 
            // lblRepAvgCaloriesTitle
            // 
            this.lblRepAvgCaloriesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepAvgCaloriesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblRepAvgCaloriesTitle.Location = new System.Drawing.Point(54, 18);
            this.lblRepAvgCaloriesTitle.Size = new System.Drawing.Size(140, 18);
            this.lblRepAvgCaloriesTitle.Text = "Avg. Daily Calories";
            this.lblRepAvgCaloriesTitle.Name = "lblRepAvgCaloriesTitle";
            this.lblRepAvgCaloriesTitle.TabIndex = 15;
            // 
            // lblRepAvgCaloriesValue
            // 
            this.lblRepAvgCaloriesValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepAvgCaloriesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblRepAvgCaloriesValue.Location = new System.Drawing.Point(54, 38);
            this.lblRepAvgCaloriesValue.Size = new System.Drawing.Size(144, 30);
            this.lblRepAvgCaloriesValue.Text = "1,650 kcal";
            this.lblRepAvgCaloriesValue.Name = "lblRepAvgCaloriesValue";
            this.lblRepAvgCaloriesValue.TabIndex = 16;
            // 
            // pnlRepWeightChange
            // 
            this.pnlRepWeightChange.Controls.Add(this.picRepWeightChange);
            this.pnlRepWeightChange.Controls.Add(this.lblRepWeightChangeTitle);
            this.pnlRepWeightChange.Controls.Add(this.lblRepWeightChangeValue);
            this.pnlRepWeightChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlRepWeightChange.Location = new System.Drawing.Point(237, 95);
            this.pnlRepWeightChange.Size = new System.Drawing.Size(200, 96);
            this.pnlRepWeightChange.Tag = "round";
            this.pnlRepWeightChange.Name = "pnlRepWeightChange";
            this.pnlRepWeightChange.TabIndex = 17;
            // 
            // picRepWeightChange
            // 
            this.picRepWeightChange.Image = global::NutriTrack.Properties.Resources.ic_scale;
            this.picRepWeightChange.Location = new System.Drawing.Point(14, 18);
            this.picRepWeightChange.Size = new System.Drawing.Size(32, 32);
            this.picRepWeightChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRepWeightChange.Name = "picRepWeightChange";
            // 
            // lblRepWeightChangeTitle
            // 
            this.lblRepWeightChangeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepWeightChangeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblRepWeightChangeTitle.Location = new System.Drawing.Point(54, 18);
            this.lblRepWeightChangeTitle.Size = new System.Drawing.Size(140, 18);
            this.lblRepWeightChangeTitle.Text = "Weight Change";
            this.lblRepWeightChangeTitle.Name = "lblRepWeightChangeTitle";
            this.lblRepWeightChangeTitle.TabIndex = 18;
            // 
            // lblRepWeightChangeValue
            // 
            this.lblRepWeightChangeValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepWeightChangeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblRepWeightChangeValue.Location = new System.Drawing.Point(54, 38);
            this.lblRepWeightChangeValue.Size = new System.Drawing.Size(144, 30);
            this.lblRepWeightChangeValue.Text = "-0.5 kg";
            this.lblRepWeightChangeValue.Name = "lblRepWeightChangeValue";
            this.lblRepWeightChangeValue.TabIndex = 19;
            // 
            // pnlRepMealsLogged
            // 
            this.pnlRepMealsLogged.Controls.Add(this.picRepMealsLogged);
            this.pnlRepMealsLogged.Controls.Add(this.lblRepMealsLoggedTitle);
            this.pnlRepMealsLogged.Controls.Add(this.lblRepMealsLoggedValue);
            this.pnlRepMealsLogged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlRepMealsLogged.Location = new System.Drawing.Point(452, 95);
            this.pnlRepMealsLogged.Size = new System.Drawing.Size(200, 96);
            this.pnlRepMealsLogged.Tag = "round";
            this.pnlRepMealsLogged.Name = "pnlRepMealsLogged";
            this.pnlRepMealsLogged.TabIndex = 20;
            // 
            // picRepMealsLogged
            // 
            this.picRepMealsLogged.Image = global::NutriTrack.Properties.Resources.ic_utensils_c;
            this.picRepMealsLogged.Location = new System.Drawing.Point(14, 18);
            this.picRepMealsLogged.Size = new System.Drawing.Size(32, 32);
            this.picRepMealsLogged.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRepMealsLogged.Name = "picRepMealsLogged";
            // 
            // lblRepMealsLoggedTitle
            // 
            this.lblRepMealsLoggedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepMealsLoggedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblRepMealsLoggedTitle.Location = new System.Drawing.Point(54, 18);
            this.lblRepMealsLoggedTitle.Size = new System.Drawing.Size(140, 18);
            this.lblRepMealsLoggedTitle.Text = "Meals Logged";
            this.lblRepMealsLoggedTitle.Name = "lblRepMealsLoggedTitle";
            this.lblRepMealsLoggedTitle.TabIndex = 21;
            // 
            // lblRepMealsLoggedValue
            // 
            this.lblRepMealsLoggedValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepMealsLoggedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblRepMealsLoggedValue.Location = new System.Drawing.Point(54, 38);
            this.lblRepMealsLoggedValue.Size = new System.Drawing.Size(144, 30);
            this.lblRepMealsLoggedValue.Text = "86 meals";
            this.lblRepMealsLoggedValue.Name = "lblRepMealsLoggedValue";
            this.lblRepMealsLoggedValue.TabIndex = 22;
            // 
            // pnlRepGoalDays
            // 
            this.pnlRepGoalDays.Controls.Add(this.picRepGoalDays);
            this.pnlRepGoalDays.Controls.Add(this.lblRepGoalDaysTitle);
            this.pnlRepGoalDays.Controls.Add(this.lblRepGoalDaysValue);
            this.pnlRepGoalDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlRepGoalDays.Location = new System.Drawing.Point(667, 95);
            this.pnlRepGoalDays.Size = new System.Drawing.Size(200, 96);
            this.pnlRepGoalDays.Tag = "round";
            this.pnlRepGoalDays.Name = "pnlRepGoalDays";
            this.pnlRepGoalDays.TabIndex = 23;
            // 
            // picRepGoalDays
            // 
            this.picRepGoalDays.Image = global::NutriTrack.Properties.Resources.ic_bullseye;
            this.picRepGoalDays.Location = new System.Drawing.Point(14, 18);
            this.picRepGoalDays.Size = new System.Drawing.Size(32, 32);
            this.picRepGoalDays.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRepGoalDays.Name = "picRepGoalDays";
            // 
            // lblRepGoalDaysTitle
            // 
            this.lblRepGoalDaysTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepGoalDaysTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblRepGoalDaysTitle.Location = new System.Drawing.Point(54, 18);
            this.lblRepGoalDaysTitle.Size = new System.Drawing.Size(140, 18);
            this.lblRepGoalDaysTitle.Text = "Goal Days Met";
            this.lblRepGoalDaysTitle.Name = "lblRepGoalDaysTitle";
            this.lblRepGoalDaysTitle.TabIndex = 24;
            // 
            // lblRepGoalDaysValue
            // 
            this.lblRepGoalDaysValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepGoalDaysValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblRepGoalDaysValue.Location = new System.Drawing.Point(54, 38);
            this.lblRepGoalDaysValue.Size = new System.Drawing.Size(144, 30);
            this.lblRepGoalDaysValue.Text = "21 / 30";
            this.lblRepGoalDaysValue.Name = "lblRepGoalDaysValue";
            this.lblRepGoalDaysValue.TabIndex = 25;
            // 
            // pnlTrendCard
            // 
            this.pnlTrendCard.Controls.Add(this.picTrendIcon);
            this.pnlTrendCard.Controls.Add(this.lblTrendTitle);
            this.pnlTrendCard.Controls.Add(this.picCaloriesTrend);
            this.pnlTrendCard.BackColor = System.Drawing.Color.White;
            this.pnlTrendCard.Location = new System.Drawing.Point(22, 206);
            this.pnlTrendCard.Size = new System.Drawing.Size(846, 330);
            this.pnlTrendCard.Tag = "round";
            this.pnlTrendCard.Name = "pnlTrendCard";
            this.pnlTrendCard.TabIndex = 26;
            // 
            // picTrendIcon
            // 
            this.picTrendIcon.Image = global::NutriTrack.Properties.Resources.ic_chartline;
            this.picTrendIcon.Location = new System.Drawing.Point(18, 18);
            this.picTrendIcon.Size = new System.Drawing.Size(20, 20);
            this.picTrendIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTrendIcon.Name = "picTrendIcon";
            // 
            // lblTrendTitle
            // 
            this.lblTrendTitle.AutoSize = true;
            this.lblTrendTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrendTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblTrendTitle.Location = new System.Drawing.Point(46, 16);
            this.lblTrendTitle.Text = "Calories Trend";
            this.lblTrendTitle.Name = "lblTrendTitle";
            this.lblTrendTitle.TabIndex = 27;
            // 
            // picCaloriesTrend
            // 
            this.picCaloriesTrend.Location = new System.Drawing.Point(22, 50);
            this.picCaloriesTrend.Size = new System.Drawing.Size(800, 270);
            this.picCaloriesTrend.Name = "picCaloriesTrend";
            // 
            // pnlHighlights
            // 
            this.pnlHighlights.Controls.Add(this.lblHighlights);
            this.pnlHighlights.Controls.Add(this.lblHighlight1);
            this.pnlHighlights.Controls.Add(this.lblHighlight2);
            this.pnlHighlights.BackColor = System.Drawing.Color.White;
            this.pnlHighlights.Location = new System.Drawing.Point(22, 550);
            this.pnlHighlights.Size = new System.Drawing.Size(620, 100);
            this.pnlHighlights.Tag = "round";
            this.pnlHighlights.Name = "pnlHighlights";
            this.pnlHighlights.TabIndex = 28;
            // 
            // lblHighlights
            // 
            this.lblHighlights.AutoSize = true;
            this.lblHighlights.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblHighlights.Location = new System.Drawing.Point(18, 12);
            this.lblHighlights.Text = "Highlights";
            this.lblHighlights.Name = "lblHighlights";
            this.lblHighlights.TabIndex = 29;
            // 
            // lblHighlight1
            // 
            this.lblHighlight1.AutoSize = true;
            this.lblHighlight1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighlight1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblHighlight1.Location = new System.Drawing.Point(18, 42);
            this.lblHighlight1.Text = "•  You stayed under your calorie goal on 21 of the last 30 days.";
            this.lblHighlight1.Name = "lblHighlight1";
            this.lblHighlight1.TabIndex = 30;
            // 
            // lblHighlight2
            // 
            this.lblHighlight2.AutoSize = true;
            this.lblHighlight2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighlight2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblHighlight2.Location = new System.Drawing.Point(18, 66);
            this.lblHighlight2.Text = "•  Your best day was Oct 15 with 1,580 kcal and 95 g protein.";
            this.lblHighlight2.Name = "lblHighlight2";
            this.lblHighlight2.TabIndex = 31;
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.Color.White;
            this.btnExportReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnExportReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.btnExportReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnExportReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportReport.Image = global::NutriTrack.Properties.Resources.btn_export;
            this.btnExportReport.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportReport.Location = new System.Drawing.Point(658, 578);
            this.btnExportReport.Size = new System.Drawing.Size(210, 44);
            this.btnExportReport.Text = "Export Report";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.TabIndex = 32;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // ReportsForm
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
            this.Name = "ReportsForm";
            this.Text = "NutriTrack - Reports / Summary";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnlHighlights.ResumeLayout(false);
            this.pnlHighlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrendIcon)).EndInit();
            this.pnlTrendCard.ResumeLayout(false);
            this.pnlTrendCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepGoalDays)).EndInit();
            this.pnlRepGoalDays.ResumeLayout(false);
            this.pnlRepGoalDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepMealsLogged)).EndInit();
            this.pnlRepMealsLogged.ResumeLayout(false);
            this.pnlRepMealsLogged.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepWeightChange)).EndInit();
            this.pnlRepWeightChange.ResumeLayout(false);
            this.pnlRepWeightChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepAvgCalories)).EndInit();
            this.pnlRepAvgCalories.ResumeLayout(false);
            this.pnlRepAvgCalories.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.Panel pnlRepAvgCalories;
        private System.Windows.Forms.PictureBox picRepAvgCalories;
        private System.Windows.Forms.Label lblRepAvgCaloriesTitle;
        private System.Windows.Forms.Label lblRepAvgCaloriesValue;
        private System.Windows.Forms.Panel pnlRepWeightChange;
        private System.Windows.Forms.PictureBox picRepWeightChange;
        private System.Windows.Forms.Label lblRepWeightChangeTitle;
        private System.Windows.Forms.Label lblRepWeightChangeValue;
        private System.Windows.Forms.Panel pnlRepMealsLogged;
        private System.Windows.Forms.PictureBox picRepMealsLogged;
        private System.Windows.Forms.Label lblRepMealsLoggedTitle;
        private System.Windows.Forms.Label lblRepMealsLoggedValue;
        private System.Windows.Forms.Panel pnlRepGoalDays;
        private System.Windows.Forms.PictureBox picRepGoalDays;
        private System.Windows.Forms.Label lblRepGoalDaysTitle;
        private System.Windows.Forms.Label lblRepGoalDaysValue;
        private System.Windows.Forms.Panel pnlTrendCard;
        private System.Windows.Forms.PictureBox picTrendIcon;
        private System.Windows.Forms.Label lblTrendTitle;
        private NutriTrack.DynamicChart picCaloriesTrend;
        private System.Windows.Forms.Panel pnlHighlights;
        private System.Windows.Forms.Label lblHighlights;
        private System.Windows.Forms.Label lblHighlight1;
        private System.Windows.Forms.Label lblHighlight2;
        private System.Windows.Forms.Button btnExportReport;
    }
}
