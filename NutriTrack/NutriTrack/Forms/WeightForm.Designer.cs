namespace NutriTrack
{
    partial class WeightForm
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
            this.pnlWeightEntry = new System.Windows.Forms.Panel();
            this.lblCurrentWeight = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeightDate = new System.Windows.Forms.Label();
            this.dtpWeightDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddWeight = new System.Windows.Forms.Button();
            this.pnlWeightChartCard = new System.Windows.Forms.Panel();
            this.picWeightChartIcon = new System.Windows.Forms.PictureBox();
            this.lblWeightChartTitle = new System.Windows.Forms.Label();
            this.picWeightChartLarge = new NutriTrack.DynamicChart();
            this.pnlWStart = new System.Windows.Forms.Panel();
            this.lblWStartTitle = new System.Windows.Forms.Label();
            this.lblWStartValue = new System.Windows.Forms.Label();
            this.pnlWNow = new System.Windows.Forms.Panel();
            this.lblWNowTitle = new System.Windows.Forms.Label();
            this.lblWNowValue = new System.Windows.Forms.Label();
            this.pnlWTarget = new System.Windows.Forms.Panel();
            this.lblWTargetTitle = new System.Windows.Forms.Label();
            this.lblWTargetValue = new System.Windows.Forms.Label();
            this.pnlWChange = new System.Windows.Forms.Panel();
            this.lblWChangeTitle = new System.Windows.Forms.Label();
            this.lblWChangeValue = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebarLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderIcon)).BeginInit();
            this.pnlWeightEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.pnlWeightChartCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeightChartIcon)).BeginInit();
            this.pnlWStart.SuspendLayout();
            this.pnlWNow.SuspendLayout();
            this.pnlWTarget.SuspendLayout();
            this.pnlWChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.picHeaderIcon);
            this.pnlContent.Controls.Add(this.lblHeaderTitle);
            this.pnlContent.Controls.Add(this.lblHeaderSubtitle);
            this.pnlContent.Controls.Add(this.pnlWeightEntry);
            this.pnlContent.Controls.Add(this.pnlWeightChartCard);
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
            this.btnNavWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavWeight.FlatAppearance.BorderSize = 0;
            this.btnNavWeight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavWeight.ForeColor = System.Drawing.Color.White;
            this.btnNavWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavWeight.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.picHeaderIcon.Image = global::NutriTrack.Properties.Resources.hd_scale;
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
            this.lblHeaderTitle.Text = "Weight Tracking";
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.TabIndex = 11;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(77, 56);
            this.lblHeaderSubtitle.Text = "Track your weight progress";
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.TabIndex = 12;
            // 
            // pnlWeightEntry
            // 
            this.pnlWeightEntry.Controls.Add(this.lblCurrentWeight);
            this.pnlWeightEntry.Controls.Add(this.nudWeight);
            this.pnlWeightEntry.Controls.Add(this.lblWeightDate);
            this.pnlWeightEntry.Controls.Add(this.dtpWeightDate);
            this.pnlWeightEntry.Controls.Add(this.btnAddWeight);
            this.pnlWeightEntry.BackColor = System.Drawing.Color.White;
            this.pnlWeightEntry.Location = new System.Drawing.Point(22, 95);
            this.pnlWeightEntry.Size = new System.Drawing.Size(846, 100);
            this.pnlWeightEntry.Tag = "round";
            this.pnlWeightEntry.Name = "pnlWeightEntry";
            this.pnlWeightEntry.TabIndex = 13;
            // 
            // lblCurrentWeight
            // 
            this.lblCurrentWeight.AutoSize = true;
            this.lblCurrentWeight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblCurrentWeight.Location = new System.Drawing.Point(24, 18);
            this.lblCurrentWeight.Text = "Current Weight (kg):";
            this.lblCurrentWeight.Name = "lblCurrentWeight";
            this.lblCurrentWeight.TabIndex = 14;
            // 
            // nudWeight
            // 
            this.nudWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudWeight.DecimalPlaces = 1;
            this.nudWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudWeight.Location = new System.Drawing.Point(24, 46);
            this.nudWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudWeight.Size = new System.Drawing.Size(200, 26);
            this.nudWeight.Value = new decimal(new int[] {
            685,
            0,
            0,
            65536});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.TabIndex = 15;
            // 
            // lblWeightDate
            // 
            this.lblWeightDate.AutoSize = true;
            this.lblWeightDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWeightDate.Location = new System.Drawing.Point(254, 18);
            this.lblWeightDate.Text = "Date:";
            this.lblWeightDate.Name = "lblWeightDate";
            this.lblWeightDate.TabIndex = 16;
            // 
            // dtpWeightDate
            // 
            this.dtpWeightDate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeightDate.Location = new System.Drawing.Point(254, 46);
            this.dtpWeightDate.Size = new System.Drawing.Size(200, 26);
            this.dtpWeightDate.Name = "dtpWeightDate";
            this.dtpWeightDate.TabIndex = 17;
            // 
            // btnAddWeight
            // 
            this.btnAddWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnAddWeight.FlatAppearance.BorderSize = 0;
            this.btnAddWeight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(123)))), ((int)(((byte)(79)))));
            this.btnAddWeight.ForeColor = System.Drawing.Color.White;
            this.btnAddWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWeight.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWeight.Image = global::NutriTrack.Properties.Resources.btn_plus;
            this.btnAddWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddWeight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddWeight.Location = new System.Drawing.Point(640, 30);
            this.btnAddWeight.Size = new System.Drawing.Size(180, 44);
            this.btnAddWeight.Text = "Add Weight";
            this.btnAddWeight.UseVisualStyleBackColor = false;
            this.btnAddWeight.Tag = "round";
            this.btnAddWeight.Name = "btnAddWeight";
            this.btnAddWeight.TabIndex = 18;
            this.btnAddWeight.Click += new System.EventHandler(this.btnAddWeight_Click);
            // 
            // pnlWeightChartCard
            // 
            this.pnlWeightChartCard.Controls.Add(this.picWeightChartIcon);
            this.pnlWeightChartCard.Controls.Add(this.lblWeightChartTitle);
            this.pnlWeightChartCard.Controls.Add(this.picWeightChartLarge);
            this.pnlWeightChartCard.Controls.Add(this.pnlWStart);
            this.pnlWeightChartCard.Controls.Add(this.pnlWNow);
            this.pnlWeightChartCard.Controls.Add(this.pnlWTarget);
            this.pnlWeightChartCard.Controls.Add(this.pnlWChange);
            this.pnlWeightChartCard.Controls.Add(this.lblBmi);
            this.pnlWeightChartCard.BackColor = System.Drawing.Color.White;
            this.pnlWeightChartCard.Location = new System.Drawing.Point(22, 210);
            this.pnlWeightChartCard.Size = new System.Drawing.Size(846, 440);
            this.pnlWeightChartCard.Tag = "round";
            this.pnlWeightChartCard.Name = "pnlWeightChartCard";
            this.pnlWeightChartCard.TabIndex = 19;
            // 
            // picWeightChartIcon
            // 
            this.picWeightChartIcon.Image = global::NutriTrack.Properties.Resources.ic_chartline;
            this.picWeightChartIcon.Location = new System.Drawing.Point(18, 18);
            this.picWeightChartIcon.Size = new System.Drawing.Size(20, 20);
            this.picWeightChartIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWeightChartIcon.Name = "picWeightChartIcon";
            // 
            // lblWeightChartTitle
            // 
            this.lblWeightChartTitle.AutoSize = true;
            this.lblWeightChartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWeightChartTitle.Location = new System.Drawing.Point(46, 16);
            this.lblWeightChartTitle.Text = "Weight Progress";
            this.lblWeightChartTitle.Name = "lblWeightChartTitle";
            this.lblWeightChartTitle.TabIndex = 20;
            // 
            // picWeightChartLarge
            // 
            this.picWeightChartLarge.Location = new System.Drawing.Point(14, 52);
            this.picWeightChartLarge.Size = new System.Drawing.Size(560, 330);
            this.picWeightChartLarge.Name = "picWeightChartLarge";
            // 
            // pnlWStart
            // 
            this.pnlWStart.Controls.Add(this.lblWStartTitle);
            this.pnlWStart.Controls.Add(this.lblWStartValue);
            this.pnlWStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlWStart.Location = new System.Drawing.Point(598, 56);
            this.pnlWStart.Size = new System.Drawing.Size(226, 72);
            this.pnlWStart.Tag = "round";
            this.pnlWStart.Name = "pnlWStart";
            this.pnlWStart.TabIndex = 21;
            // 
            // lblWStartTitle
            // 
            this.lblWStartTitle.AutoSize = true;
            this.lblWStartTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWStartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblWStartTitle.Location = new System.Drawing.Point(14, 10);
            this.lblWStartTitle.Text = "Start Weight";
            this.lblWStartTitle.Name = "lblWStartTitle";
            this.lblWStartTitle.TabIndex = 22;
            // 
            // lblWStartValue
            // 
            this.lblWStartValue.AutoSize = true;
            this.lblWStartValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWStartValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWStartValue.Location = new System.Drawing.Point(14, 32);
            this.lblWStartValue.Text = "69.0 kg";
            this.lblWStartValue.Name = "lblWStartValue";
            this.lblWStartValue.TabIndex = 23;
            // 
            // pnlWNow
            // 
            this.pnlWNow.Controls.Add(this.lblWNowTitle);
            this.pnlWNow.Controls.Add(this.lblWNowValue);
            this.pnlWNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlWNow.Location = new System.Drawing.Point(598, 140);
            this.pnlWNow.Size = new System.Drawing.Size(226, 72);
            this.pnlWNow.Tag = "round";
            this.pnlWNow.Name = "pnlWNow";
            this.pnlWNow.TabIndex = 24;
            // 
            // lblWNowTitle
            // 
            this.lblWNowTitle.AutoSize = true;
            this.lblWNowTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWNowTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblWNowTitle.Location = new System.Drawing.Point(14, 10);
            this.lblWNowTitle.Text = "Current Weight";
            this.lblWNowTitle.Name = "lblWNowTitle";
            this.lblWNowTitle.TabIndex = 25;
            // 
            // lblWNowValue
            // 
            this.lblWNowValue.AutoSize = true;
            this.lblWNowValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWNowValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWNowValue.Location = new System.Drawing.Point(14, 32);
            this.lblWNowValue.Text = "68.5 kg";
            this.lblWNowValue.Name = "lblWNowValue";
            this.lblWNowValue.TabIndex = 26;
            // 
            // pnlWTarget
            // 
            this.pnlWTarget.Controls.Add(this.lblWTargetTitle);
            this.pnlWTarget.Controls.Add(this.lblWTargetValue);
            this.pnlWTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlWTarget.Location = new System.Drawing.Point(598, 224);
            this.pnlWTarget.Size = new System.Drawing.Size(226, 72);
            this.pnlWTarget.Tag = "round";
            this.pnlWTarget.Name = "pnlWTarget";
            this.pnlWTarget.TabIndex = 27;
            // 
            // lblWTargetTitle
            // 
            this.lblWTargetTitle.AutoSize = true;
            this.lblWTargetTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWTargetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblWTargetTitle.Location = new System.Drawing.Point(14, 10);
            this.lblWTargetTitle.Text = "Goal Weight";
            this.lblWTargetTitle.Name = "lblWTargetTitle";
            this.lblWTargetTitle.TabIndex = 28;
            // 
            // lblWTargetValue
            // 
            this.lblWTargetValue.AutoSize = true;
            this.lblWTargetValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWTargetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblWTargetValue.Location = new System.Drawing.Point(14, 32);
            this.lblWTargetValue.Text = "65.0 kg";
            this.lblWTargetValue.Name = "lblWTargetValue";
            this.lblWTargetValue.TabIndex = 29;
            // 
            // pnlWChange
            // 
            this.pnlWChange.Controls.Add(this.lblWChangeTitle);
            this.pnlWChange.Controls.Add(this.lblWChangeValue);
            this.pnlWChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlWChange.Location = new System.Drawing.Point(598, 308);
            this.pnlWChange.Size = new System.Drawing.Size(226, 72);
            this.pnlWChange.Tag = "round";
            this.pnlWChange.Name = "pnlWChange";
            this.pnlWChange.TabIndex = 30;
            // 
            // lblWChangeTitle
            // 
            this.lblWChangeTitle.AutoSize = true;
            this.lblWChangeTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWChangeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblWChangeTitle.Location = new System.Drawing.Point(14, 10);
            this.lblWChangeTitle.Text = "Change (30 days)";
            this.lblWChangeTitle.Name = "lblWChangeTitle";
            this.lblWChangeTitle.TabIndex = 31;
            // 
            // lblWChangeValue
            // 
            this.lblWChangeValue.AutoSize = true;
            this.lblWChangeValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWChangeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.lblWChangeValue.Location = new System.Drawing.Point(14, 32);
            this.lblWChangeValue.Text = "-0.5 kg";
            this.lblWChangeValue.Name = "lblWChangeValue";
            this.lblWChangeValue.TabIndex = 32;
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblBmi.Location = new System.Drawing.Point(598, 398);
            this.lblBmi.Text = "BMI: 25.2   (Height: 165 cm)";
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.TabIndex = 33;
            // 
            // WeightForm
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
            this.Name = "WeightForm";
            this.Text = "NutriTrack - Weight Tracking";
            this.Load += new System.EventHandler(this.WeightForm_Load);
            this.pnlWChange.ResumeLayout(false);
            this.pnlWChange.PerformLayout();
            this.pnlWTarget.ResumeLayout(false);
            this.pnlWTarget.PerformLayout();
            this.pnlWNow.ResumeLayout(false);
            this.pnlWNow.PerformLayout();
            this.pnlWStart.ResumeLayout(false);
            this.pnlWStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeightChartIcon)).EndInit();
            this.pnlWeightChartCard.ResumeLayout(false);
            this.pnlWeightChartCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.pnlWeightEntry.ResumeLayout(false);
            this.pnlWeightEntry.PerformLayout();
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
        private System.Windows.Forms.Panel pnlWeightEntry;
        private System.Windows.Forms.Label lblCurrentWeight;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label lblWeightDate;
        private System.Windows.Forms.DateTimePicker dtpWeightDate;
        private System.Windows.Forms.Button btnAddWeight;
        private System.Windows.Forms.Panel pnlWeightChartCard;
        private System.Windows.Forms.PictureBox picWeightChartIcon;
        private System.Windows.Forms.Label lblWeightChartTitle;
        private NutriTrack.DynamicChart picWeightChartLarge;
        private System.Windows.Forms.Panel pnlWStart;
        private System.Windows.Forms.Label lblWStartTitle;
        private System.Windows.Forms.Label lblWStartValue;
        private System.Windows.Forms.Panel pnlWNow;
        private System.Windows.Forms.Label lblWNowTitle;
        private System.Windows.Forms.Label lblWNowValue;
        private System.Windows.Forms.Panel pnlWTarget;
        private System.Windows.Forms.Label lblWTargetTitle;
        private System.Windows.Forms.Label lblWTargetValue;
        private System.Windows.Forms.Panel pnlWChange;
        private System.Windows.Forms.Label lblWChangeTitle;
        private System.Windows.Forms.Label lblWChangeValue;
        private System.Windows.Forms.Label lblBmi;
    }
}
