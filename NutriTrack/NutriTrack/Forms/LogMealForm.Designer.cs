namespace NutriTrack
{
    partial class LogMealForm
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
            this.pnlMealCard = new System.Windows.Forms.Panel();
            this.picMeal = new System.Windows.Forms.PictureBox();
            this.lblPhotoHint = new System.Windows.Forms.Label();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.lblMealType = new System.Windows.Forms.Label();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lblMealDate = new System.Windows.Forms.Label();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.lblMealTime = new System.Windows.Forms.Label();
            this.dtpMealTime = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.nudCalories = new System.Windows.Forms.NumericUpDown();
            this.lblProtein = new System.Windows.Forms.Label();
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.nudCarbs = new System.Windows.Forms.NumericUpDown();
            this.lblFat = new System.Windows.Forms.Label();
            this.nudFat = new System.Windows.Forms.NumericUpDown();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlMealTip = new System.Windows.Forms.Panel();
            this.lblMealTip = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebarLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderIcon)).BeginInit();
            this.pnlMealCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            this.pnlMealTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.picHeaderIcon);
            this.pnlContent.Controls.Add(this.lblHeaderTitle);
            this.pnlContent.Controls.Add(this.lblHeaderSubtitle);
            this.pnlContent.Controls.Add(this.pnlMealCard);
            this.pnlContent.Controls.Add(this.pnlMealTip);
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
            this.btnNavLogMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavLogMeal.FlatAppearance.BorderSize = 0;
            this.btnNavLogMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavLogMeal.ForeColor = System.Drawing.Color.White;
            this.btnNavLogMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLogMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogMeal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.picHeaderIcon.Image = global::NutriTrack.Properties.Resources.hd_utensils;
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
            this.lblHeaderTitle.Text = "Log a Meal";
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.TabIndex = 11;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(77, 56);
            this.lblHeaderSubtitle.Text = "Add your meal details";
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.TabIndex = 12;
            // 
            // pnlMealCard
            // 
            this.pnlMealCard.Controls.Add(this.picMeal);
            this.pnlMealCard.Controls.Add(this.lblPhotoHint);
            this.pnlMealCard.Controls.Add(this.btnChoosePhoto);
            this.pnlMealCard.Controls.Add(this.lblMealType);
            this.pnlMealCard.Controls.Add(this.cmbMealType);
            this.pnlMealCard.Controls.Add(this.lblFoodName);
            this.pnlMealCard.Controls.Add(this.txtFoodName);
            this.pnlMealCard.Controls.Add(this.lblMealDate);
            this.pnlMealCard.Controls.Add(this.dtpMealDate);
            this.pnlMealCard.Controls.Add(this.lblMealTime);
            this.pnlMealCard.Controls.Add(this.dtpMealTime);
            this.pnlMealCard.Controls.Add(this.lblNotes);
            this.pnlMealCard.Controls.Add(this.txtNotes);
            this.pnlMealCard.Controls.Add(this.lblCalories);
            this.pnlMealCard.Controls.Add(this.nudCalories);
            this.pnlMealCard.Controls.Add(this.lblProtein);
            this.pnlMealCard.Controls.Add(this.nudProtein);
            this.pnlMealCard.Controls.Add(this.lblCarbs);
            this.pnlMealCard.Controls.Add(this.nudCarbs);
            this.pnlMealCard.Controls.Add(this.lblFat);
            this.pnlMealCard.Controls.Add(this.nudFat);
            this.pnlMealCard.Controls.Add(this.btnAddMeal);
            this.pnlMealCard.Controls.Add(this.btnClear);
            this.pnlMealCard.BackColor = System.Drawing.Color.White;
            this.pnlMealCard.Location = new System.Drawing.Point(22, 95);
            this.pnlMealCard.Size = new System.Drawing.Size(846, 470);
            this.pnlMealCard.Tag = "round";
            this.pnlMealCard.Name = "pnlMealCard";
            this.pnlMealCard.TabIndex = 13;
            // 
            // picMeal
            // 
            this.picMeal.Image = global::NutriTrack.Properties.Resources.meal_photo;
            this.picMeal.Location = new System.Drawing.Point(24, 24);
            this.picMeal.Size = new System.Drawing.Size(200, 240);
            this.picMeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMeal.Tag = "round";
            this.picMeal.Name = "picMeal";
            // 
            // lblPhotoHint
            // 
            this.lblPhotoHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblPhotoHint.Location = new System.Drawing.Point(24, 272);
            this.lblPhotoHint.Size = new System.Drawing.Size(200, 20);
            this.lblPhotoHint.Text = "Meal photo (optional)";
            this.lblPhotoHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhotoHint.Name = "lblPhotoHint";
            this.lblPhotoHint.TabIndex = 14;
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.btnChoosePhoto.FlatAppearance.BorderSize = 0;
            this.btnChoosePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.btnChoosePhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.btnChoosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePhoto.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePhoto.Image = global::NutriTrack.Properties.Resources.btn_camera;
            this.btnChoosePhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChoosePhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChoosePhoto.Location = new System.Drawing.Point(46, 298);
            this.btnChoosePhoto.Size = new System.Drawing.Size(156, 36);
            this.btnChoosePhoto.Text = "Choose Photo";
            this.btnChoosePhoto.UseVisualStyleBackColor = false;
            this.btnChoosePhoto.Tag = "round";
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.TabIndex = 15;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblMealType.Location = new System.Drawing.Point(254, 24);
            this.lblMealType.Text = "Meal Type:";
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.TabIndex = 16;
            // 
            // cmbMealType
            // 
            this.cmbMealType.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snack"});
            this.cmbMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMealType.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Location = new System.Drawing.Point(254, 48);
            this.cmbMealType.Size = new System.Drawing.Size(270, 27);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.TabIndex = 17;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblFoodName.Location = new System.Drawing.Point(254, 92);
            this.lblFoodName.Text = "Food Name:";
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.TabIndex = 18;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(254, 116);
            this.txtFoodName.PlaceholderText = "e.g. Oatmeal Bowl";
            this.txtFoodName.Size = new System.Drawing.Size(270, 26);
            this.txtFoodName.Text = "Oatmeal Bowl";
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.TabIndex = 19;
            // 
            // lblMealDate
            // 
            this.lblMealDate.AutoSize = true;
            this.lblMealDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblMealDate.Location = new System.Drawing.Point(254, 160);
            this.lblMealDate.Text = "Date:";
            this.lblMealDate.Name = "lblMealDate";
            this.lblMealDate.TabIndex = 20;
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMealDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMealDate.Location = new System.Drawing.Point(254, 184);
            this.dtpMealDate.Size = new System.Drawing.Size(270, 26);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.TabIndex = 21;
            // 
            // lblMealTime
            // 
            this.lblMealTime.AutoSize = true;
            this.lblMealTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblMealTime.Location = new System.Drawing.Point(254, 228);
            this.lblMealTime.Text = "Time:";
            this.lblMealTime.Name = "lblMealTime";
            this.lblMealTime.TabIndex = 22;
            // 
            // dtpMealTime
            // 
            this.dtpMealTime.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMealTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpMealTime.Location = new System.Drawing.Point(254, 252);
            this.dtpMealTime.ShowUpDown = true;
            this.dtpMealTime.Size = new System.Drawing.Size(270, 26);
            this.dtpMealTime.Name = "dtpMealTime";
            this.dtpMealTime.TabIndex = 23;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblNotes.Location = new System.Drawing.Point(254, 296);
            this.lblNotes.Text = "Notes:";
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.TabIndex = 24;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(254, 320);
            this.txtNotes.Multiline = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.PlaceholderText = "Any notes about this meal (optional)";
            this.txtNotes.Size = new System.Drawing.Size(568, 64);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.TabIndex = 25;
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblCalories.Location = new System.Drawing.Point(556, 24);
            this.lblCalories.Text = "Calories (kcal):";
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.TabIndex = 26;
            // 
            // nudCalories
            // 
            this.nudCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCalories.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCalories.Location = new System.Drawing.Point(556, 48);
            this.nudCalories.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCalories.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCalories.Size = new System.Drawing.Size(266, 26);
            this.nudCalories.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.nudCalories.Name = "nudCalories";
            this.nudCalories.TabIndex = 27;
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProtein.Location = new System.Drawing.Point(556, 92);
            this.lblProtein.Text = "Protein (g):";
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.TabIndex = 28;
            // 
            // nudProtein
            // 
            this.nudProtein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudProtein.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProtein.Location = new System.Drawing.Point(556, 116);
            this.nudProtein.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudProtein.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudProtein.Size = new System.Drawing.Size(266, 26);
            this.nudProtein.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.TabIndex = 29;
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblCarbs.Location = new System.Drawing.Point(556, 160);
            this.lblCarbs.Text = "Carbs (g):";
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.TabIndex = 30;
            // 
            // nudCarbs
            // 
            this.nudCarbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCarbs.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCarbs.Location = new System.Drawing.Point(556, 184);
            this.nudCarbs.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCarbs.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCarbs.Size = new System.Drawing.Size(266, 26);
            this.nudCarbs.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.nudCarbs.Name = "nudCarbs";
            this.nudCarbs.TabIndex = 31;
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblFat.Location = new System.Drawing.Point(556, 228);
            this.lblFat.Text = "Fat (g):";
            this.lblFat.Name = "lblFat";
            this.lblFat.TabIndex = 32;
            // 
            // nudFat
            // 
            this.nudFat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudFat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFat.Location = new System.Drawing.Point(556, 252);
            this.nudFat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudFat.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFat.Size = new System.Drawing.Size(266, 26);
            this.nudFat.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudFat.Name = "nudFat";
            this.nudFat.TabIndex = 33;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnAddMeal.FlatAppearance.BorderSize = 0;
            this.btnAddMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(123)))), ((int)(((byte)(79)))));
            this.btnAddMeal.ForeColor = System.Drawing.Color.White;
            this.btnAddMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeal.Image = global::NutriTrack.Properties.Resources.btn_plus;
            this.btnAddMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddMeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMeal.Location = new System.Drawing.Point(254, 404);
            this.btnAddMeal.Size = new System.Drawing.Size(170, 44);
            this.btnAddMeal.Text = "Add Meal";
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Tag = "round";
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.TabIndex = 34;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(438, 404);
            this.btnClear.Size = new System.Drawing.Size(120, 44);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Tag = "round";
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 35;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlMealTip
            // 
            this.pnlMealTip.Controls.Add(this.lblMealTip);
            this.pnlMealTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlMealTip.Location = new System.Drawing.Point(22, 580);
            this.pnlMealTip.Size = new System.Drawing.Size(846, 70);
            this.pnlMealTip.Tag = "round";
            this.pnlMealTip.Name = "pnlMealTip";
            this.pnlMealTip.TabIndex = 36;
            // 
            // lblMealTip
            // 
            this.lblMealTip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.lblMealTip.Location = new System.Drawing.Point(20, 0);
            this.lblMealTip.Size = new System.Drawing.Size(806, 70);
            this.lblMealTip.Text = "Tip: Log your meals right after eating to keep your daily totals accurate.";
            this.lblMealTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMealTip.Name = "lblMealTip";
            this.lblMealTip.TabIndex = 37;
            // 
            // LogMealForm
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
            this.Name = "LogMealForm";
            this.Text = "NutriTrack - Log a Meal";
            this.Load += new System.EventHandler(this.LogMealForm_Load);
            this.pnlMealTip.ResumeLayout(false);
            this.pnlMealTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeal)).EndInit();
            this.pnlMealCard.ResumeLayout(false);
            this.pnlMealCard.PerformLayout();
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
        private System.Windows.Forms.Panel pnlMealCard;
        private System.Windows.Forms.PictureBox picMeal;
        private System.Windows.Forms.Label lblPhotoHint;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lblMealDate;
        private System.Windows.Forms.DateTimePicker dtpMealDate;
        private System.Windows.Forms.Label lblMealTime;
        private System.Windows.Forms.DateTimePicker dtpMealTime;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.NumericUpDown nudCalories;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.NumericUpDown nudCarbs;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.NumericUpDown nudFat;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlMealTip;
        private System.Windows.Forms.Label lblMealTip;
    }
}
