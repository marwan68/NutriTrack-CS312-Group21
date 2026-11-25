namespace NutriTrack
{
    partial class ProfileForm
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
            this.pnlAvatarCard = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.pnlAccountCard = new System.Windows.Forms.Panel();
            this.lblAccountTitle = new System.Windows.Forms.Label();
            this.lblAccMember = new System.Windows.Forms.Label();
            this.lblAccMeals = new System.Windows.Forms.Label();
            this.lblAccStreak = new System.Windows.Forms.Label();
            this.lblAccPlan = new System.Windows.Forms.Label();
            this.pnlInfoCard = new System.Windows.Forms.Panel();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.lblProfFullName = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblProfEmail = new System.Windows.Forms.Label();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.lblProfAge = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblProfGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblProfHeight = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblProfGoal = new System.Windows.Forms.Label();
            this.cmbGoal = new System.Windows.Forms.ComboBox();
            this.lblProfTargetWeight = new System.Windows.Forms.Label();
            this.nudTargetWeight = new System.Windows.Forms.NumericUpDown();
            this.lblProfCalorieGoal = new System.Windows.Forms.Label();
            this.nudCalorieGoal = new System.Windows.Forms.NumericUpDown();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebarLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderIcon)).BeginInit();
            this.pnlAvatarCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlAccountCard.SuspendLayout();
            this.pnlInfoCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorieGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.picHeaderIcon);
            this.pnlContent.Controls.Add(this.lblHeaderTitle);
            this.pnlContent.Controls.Add(this.lblHeaderSubtitle);
            this.pnlContent.Controls.Add(this.pnlAvatarCard);
            this.pnlContent.Controls.Add(this.pnlAccountCard);
            this.pnlContent.Controls.Add(this.pnlInfoCard);
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
            this.btnNavProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavProfile.FlatAppearance.BorderSize = 0;
            this.btnNavProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.btnNavProfile.ForeColor = System.Drawing.Color.White;
            this.btnNavProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfile.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.picHeaderIcon.Image = global::NutriTrack.Properties.Resources.hd_user;
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
            this.lblHeaderTitle.Text = "My Profile";
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.TabIndex = 11;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(77, 56);
            this.lblHeaderSubtitle.Text = "Manage your personal information";
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.TabIndex = 12;
            // 
            // pnlAvatarCard
            // 
            this.pnlAvatarCard.Controls.Add(this.picAvatar);
            this.pnlAvatarCard.Controls.Add(this.lblProfileName);
            this.pnlAvatarCard.Controls.Add(this.lblProfileEmail);
            this.pnlAvatarCard.Controls.Add(this.btnChangePhoto);
            this.pnlAvatarCard.BackColor = System.Drawing.Color.White;
            this.pnlAvatarCard.Location = new System.Drawing.Point(22, 95);
            this.pnlAvatarCard.Size = new System.Drawing.Size(260, 320);
            this.pnlAvatarCard.Tag = "round";
            this.pnlAvatarCard.Name = "pnlAvatarCard";
            this.pnlAvatarCard.TabIndex = 13;
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::NutriTrack.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(55, 26);
            this.picAvatar.Size = new System.Drawing.Size(150, 150);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.Name = "picAvatar";
            // 
            // lblProfileName
            // 
            this.lblProfileName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProfileName.Location = new System.Drawing.Point(0, 188);
            this.lblProfileName.Size = new System.Drawing.Size(260, 26);
            this.lblProfileName.Text = "Sarah Ahmed";
            this.lblProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.TabIndex = 14;
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(112)))));
            this.lblProfileEmail.Location = new System.Drawing.Point(0, 214);
            this.lblProfileEmail.Size = new System.Drawing.Size(260, 20);
            this.lblProfileEmail.Text = "sarah@example.com";
            this.lblProfileEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.TabIndex = 15;
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.btnChangePhoto.FlatAppearance.BorderSize = 0;
            this.btnChangePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.btnChangePhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.btnChangePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePhoto.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePhoto.Image = global::NutriTrack.Properties.Resources.btn_camera;
            this.btnChangePhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangePhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePhoto.Location = new System.Drawing.Point(52, 254);
            this.btnChangePhoto.Size = new System.Drawing.Size(156, 38);
            this.btnChangePhoto.Text = "Change Photo";
            this.btnChangePhoto.UseVisualStyleBackColor = false;
            this.btnChangePhoto.Tag = "round";
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.TabIndex = 16;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // pnlAccountCard
            // 
            this.pnlAccountCard.Controls.Add(this.lblAccountTitle);
            this.pnlAccountCard.Controls.Add(this.lblAccMember);
            this.pnlAccountCard.Controls.Add(this.lblAccMeals);
            this.pnlAccountCard.Controls.Add(this.lblAccStreak);
            this.pnlAccountCard.Controls.Add(this.lblAccPlan);
            this.pnlAccountCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pnlAccountCard.Location = new System.Drawing.Point(22, 430);
            this.pnlAccountCard.Size = new System.Drawing.Size(260, 220);
            this.pnlAccountCard.Tag = "round";
            this.pnlAccountCard.Name = "pnlAccountCard";
            this.pnlAccountCard.TabIndex = 17;
            // 
            // lblAccountTitle
            // 
            this.lblAccountTitle.AutoSize = true;
            this.lblAccountTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblAccountTitle.Location = new System.Drawing.Point(18, 16);
            this.lblAccountTitle.Text = "Account";
            this.lblAccountTitle.Name = "lblAccountTitle";
            this.lblAccountTitle.TabIndex = 18;
            // 
            // lblAccMember
            // 
            this.lblAccMember.AutoSize = true;
            this.lblAccMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblAccMember.Location = new System.Drawing.Point(18, 54);
            this.lblAccMember.Text = "Member since: Sep 2026";
            this.lblAccMember.Name = "lblAccMember";
            this.lblAccMember.TabIndex = 19;
            // 
            // lblAccMeals
            // 
            this.lblAccMeals.AutoSize = true;
            this.lblAccMeals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccMeals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblAccMeals.Location = new System.Drawing.Point(18, 88);
            this.lblAccMeals.Text = "Meals logged: 86";
            this.lblAccMeals.Name = "lblAccMeals";
            this.lblAccMeals.TabIndex = 20;
            // 
            // lblAccStreak
            // 
            this.lblAccStreak.AutoSize = true;
            this.lblAccStreak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccStreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblAccStreak.Location = new System.Drawing.Point(18, 122);
            this.lblAccStreak.Text = "Current streak: 12 days";
            this.lblAccStreak.Name = "lblAccStreak";
            this.lblAccStreak.TabIndex = 21;
            // 
            // lblAccPlan
            // 
            this.lblAccPlan.AutoSize = true;
            this.lblAccPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblAccPlan.Location = new System.Drawing.Point(18, 156);
            this.lblAccPlan.Text = "Plan: Lose Weight";
            this.lblAccPlan.Name = "lblAccPlan";
            this.lblAccPlan.TabIndex = 22;
            // 
            // pnlInfoCard
            // 
            this.pnlInfoCard.Controls.Add(this.lblPersonalInfo);
            this.pnlInfoCard.Controls.Add(this.lblProfFullName);
            this.pnlInfoCard.Controls.Add(this.txtProfileName);
            this.pnlInfoCard.Controls.Add(this.lblProfEmail);
            this.pnlInfoCard.Controls.Add(this.txtProfileEmail);
            this.pnlInfoCard.Controls.Add(this.lblProfAge);
            this.pnlInfoCard.Controls.Add(this.nudAge);
            this.pnlInfoCard.Controls.Add(this.lblProfGender);
            this.pnlInfoCard.Controls.Add(this.cmbGender);
            this.pnlInfoCard.Controls.Add(this.lblProfHeight);
            this.pnlInfoCard.Controls.Add(this.nudHeight);
            this.pnlInfoCard.Controls.Add(this.lblProfGoal);
            this.pnlInfoCard.Controls.Add(this.cmbGoal);
            this.pnlInfoCard.Controls.Add(this.lblProfTargetWeight);
            this.pnlInfoCard.Controls.Add(this.nudTargetWeight);
            this.pnlInfoCard.Controls.Add(this.lblProfCalorieGoal);
            this.pnlInfoCard.Controls.Add(this.nudCalorieGoal);
            this.pnlInfoCard.Controls.Add(this.btnSaveChanges);
            this.pnlInfoCard.BackColor = System.Drawing.Color.White;
            this.pnlInfoCard.Location = new System.Drawing.Point(297, 95);
            this.pnlInfoCard.Size = new System.Drawing.Size(571, 555);
            this.pnlInfoCard.Tag = "round";
            this.pnlInfoCard.Name = "pnlInfoCard";
            this.pnlInfoCard.TabIndex = 23;
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblPersonalInfo.Location = new System.Drawing.Point(24, 18);
            this.lblPersonalInfo.Text = "Personal Information";
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.TabIndex = 24;
            // 
            // lblProfFullName
            // 
            this.lblProfFullName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProfFullName.Location = new System.Drawing.Point(24, 67);
            this.lblProfFullName.Size = new System.Drawing.Size(160, 22);
            this.lblProfFullName.Text = "Full Name:";
            this.lblProfFullName.Name = "lblProfFullName";
            this.lblProfFullName.TabIndex = 25;
            // 
            // txtProfileName
            // 
            this.txtProfileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfileName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileName.Location = new System.Drawing.Point(200, 64);
            this.txtProfileName.Size = new System.Drawing.Size(340, 26);
            this.txtProfileName.Text = "Sarah Ahmed";
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.TabIndex = 26;
            // 
            // lblProfEmail
            // 
            this.lblProfEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProfEmail.Location = new System.Drawing.Point(24, 117);
            this.lblProfEmail.Size = new System.Drawing.Size(160, 22);
            this.lblProfEmail.Text = "Email:";
            this.lblProfEmail.Name = "lblProfEmail";
            this.lblProfEmail.TabIndex = 27;
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfileEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileEmail.Location = new System.Drawing.Point(200, 114);
            this.txtProfileEmail.Size = new System.Drawing.Size(340, 26);
            this.txtProfileEmail.Text = "sarah@example.com";
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.TabIndex = 28;
            // 
            // lblProfAge
            // 
            this.lblProfAge.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProfAge.Location = new System.Drawing.Point(24, 167);
            this.lblProfAge.Size = new System.Drawing.Size(160, 22);
            this.lblProfAge.Text = "Age:";
            this.lblProfAge.Name = "lblProfAge";
            this.lblProfAge.TabIndex = 29;
            // 
            // nudAge
            // 
            this.nudAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudAge.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAge.Location = new System.Drawing.Point(200, 164);
            this.nudAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAge.Size = new System.Drawing.Size(340, 26);
            this.nudAge.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.TabIndex = 30;
            // 
            // lblProfGender
            // 
            this.lblProfGender.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProfGender.Location = new System.Drawing.Point(24, 217);
            this.lblProfGender.Size = new System.Drawing.Size(160, 22);
            this.lblProfGender.Text = "Gender:";
            this.lblProfGender.Name = "lblProfGender";
            this.lblProfGender.TabIndex = 31;
            // 
            // cmbGender
            // 
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(200, 214);
            this.cmbGender.Size = new System.Drawing.Size(340, 27);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.TabIndex = 32;
            // 
            // lblProfHeight
            // 
            this.lblProfHeight.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProfHeight.Location = new System.Drawing.Point(24, 267);
            this.lblProfHeight.Size = new System.Drawing.Size(160, 22);
            this.lblProfHeight.Text = "Height (cm):";
            this.lblProfHeight.Name = "lblProfHeight";
            this.lblProfHeight.TabIndex = 33;
            // 
            // nudHeight
            // 
            this.nudHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHeight.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeight.Location = new System.Drawing.Point(200, 264);
            this.nudHeight.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHeight.Size = new System.Drawing.Size(340, 26);
            this.nudHeight.Value = new decimal(new int[] {
            165,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.TabIndex = 34;
            // 
            // lblProfGoal
            // 
            this.lblProfGoal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProfGoal.Location = new System.Drawing.Point(24, 317);
            this.lblProfGoal.Size = new System.Drawing.Size(160, 22);
            this.lblProfGoal.Text = "Goal:";
            this.lblProfGoal.Name = "lblProfGoal";
            this.lblProfGoal.TabIndex = 35;
            // 
            // cmbGoal
            // 
            this.cmbGoal.Items.AddRange(new object[] {
            "Lose Weight",
            "Maintain Weight",
            "Gain Weight"});
            this.cmbGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGoal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGoal.FormattingEnabled = true;
            this.cmbGoal.Location = new System.Drawing.Point(200, 314);
            this.cmbGoal.Size = new System.Drawing.Size(340, 27);
            this.cmbGoal.Name = "cmbGoal";
            this.cmbGoal.TabIndex = 36;
            // 
            // lblProfTargetWeight
            // 
            this.lblProfTargetWeight.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfTargetWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProfTargetWeight.Location = new System.Drawing.Point(24, 367);
            this.lblProfTargetWeight.Size = new System.Drawing.Size(160, 22);
            this.lblProfTargetWeight.Text = "Target Weight (kg):";
            this.lblProfTargetWeight.Name = "lblProfTargetWeight";
            this.lblProfTargetWeight.TabIndex = 37;
            // 
            // nudTargetWeight
            // 
            this.nudTargetWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTargetWeight.DecimalPlaces = 1;
            this.nudTargetWeight.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTargetWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTargetWeight.Location = new System.Drawing.Point(200, 364);
            this.nudTargetWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudTargetWeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTargetWeight.Size = new System.Drawing.Size(340, 26);
            this.nudTargetWeight.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.nudTargetWeight.Name = "nudTargetWeight";
            this.nudTargetWeight.TabIndex = 38;
            // 
            // lblProfCalorieGoal
            // 
            this.lblProfCalorieGoal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfCalorieGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(35)))));
            this.lblProfCalorieGoal.Location = new System.Drawing.Point(24, 417);
            this.lblProfCalorieGoal.Size = new System.Drawing.Size(160, 22);
            this.lblProfCalorieGoal.Text = "Daily Calorie Goal:";
            this.lblProfCalorieGoal.Name = "lblProfCalorieGoal";
            this.lblProfCalorieGoal.TabIndex = 39;
            // 
            // nudCalorieGoal
            // 
            this.nudCalorieGoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCalorieGoal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCalorieGoal.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCalorieGoal.Location = new System.Drawing.Point(200, 414);
            this.nudCalorieGoal.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.nudCalorieGoal.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nudCalorieGoal.Size = new System.Drawing.Size(340, 26);
            this.nudCalorieGoal.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCalorieGoal.Name = "nudCalorieGoal";
            this.nudCalorieGoal.TabIndex = 40;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(94)))), ((int)(((byte)(62)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(123)))), ((int)(((byte)(79)))));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Image = global::NutriTrack.Properties.Resources.btn_save;
            this.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChanges.Location = new System.Drawing.Point(372, 480);
            this.btnSaveChanges.Size = new System.Drawing.Size(168, 44);
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Tag = "round";
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.TabIndex = 41;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // ProfileForm
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
            this.Name = "ProfileForm";
            this.Text = "NutriTrack - My Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorieGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.pnlInfoCard.ResumeLayout(false);
            this.pnlInfoCard.PerformLayout();
            this.pnlAccountCard.ResumeLayout(false);
            this.pnlAccountCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlAvatarCard.ResumeLayout(false);
            this.pnlAvatarCard.PerformLayout();
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
        private System.Windows.Forms.Panel pnlAvatarCard;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Button btnChangePhoto;
        private System.Windows.Forms.Panel pnlAccountCard;
        private System.Windows.Forms.Label lblAccountTitle;
        private System.Windows.Forms.Label lblAccMember;
        private System.Windows.Forms.Label lblAccMeals;
        private System.Windows.Forms.Label lblAccStreak;
        private System.Windows.Forms.Label lblAccPlan;
        private System.Windows.Forms.Panel pnlInfoCard;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Label lblProfFullName;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblProfEmail;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Label lblProfAge;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblProfGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblProfHeight;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lblProfGoal;
        private System.Windows.Forms.ComboBox cmbGoal;
        private System.Windows.Forms.Label lblProfTargetWeight;
        private System.Windows.Forms.NumericUpDown nudTargetWeight;
        private System.Windows.Forms.Label lblProfCalorieGoal;
        private System.Windows.Forms.NumericUpDown nudCalorieGoal;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}
