namespace NutriTrack
{
    partial class ManageMealsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlContent = new Panel();
            picHeaderIcon = new PictureBox();
            lblHeaderTitle = new Label();
            lblHeaderSubtitle = new Label();
            btnAddNewMeal = new Button();
            pnlFilterBar = new Panel();
            pnlSearchBorder = new Panel();
            pnlSearch = new Panel();
            picSearchIcon = new PictureBox();
            txtSearch = new TextBox();
            lblFilterType = new Label();
            cmbFilterType = new ComboBox();
            btnSearch = new Button();
            dgvMeals = new DataGridView();
            colMealName = new DataGridViewTextBoxColumn();
            colMealType = new DataGridViewTextBoxColumn();
            colCalories = new DataGridViewTextBoxColumn();
            colProtein = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            pnlSidebar = new Panel();
            picSidebarLogo = new PictureBox();
            lblSidebarBrand = new Label();
            btnNavDashboard = new Button();
            btnNavLogMeal = new Button();
            btnNavManageMeals = new Button();
            btnNavWeight = new Button();
            btnNavAnalytics = new Button();
            btnNavReports = new Button();
            btnNavProfile = new Button();
            btnNavLogout = new Button();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHeaderIcon).BeginInit();
            pnlFilterBar.SuspendLayout();
            pnlSearchBorder.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMeals).BeginInit();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSidebarLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(246, 247, 242);
            pnlContent.Controls.Add(picHeaderIcon);
            pnlContent.Controls.Add(lblHeaderTitle);
            pnlContent.Controls.Add(lblHeaderSubtitle);
            pnlContent.Controls.Add(btnAddNewMeal);
            pnlContent.Controls.Add(pnlFilterBar);
            pnlContent.Controls.Add(dgvMeals);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(210, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(890, 680);
            pnlContent.TabIndex = 0;
            // 
            // picHeaderIcon
            // 
            picHeaderIcon.Image = Properties.Resources.hd_list;
            picHeaderIcon.Location = new Point(24, 22);
            picHeaderIcon.Name = "picHeaderIcon";
            picHeaderIcon.Size = new Size(44, 44);
            picHeaderIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            picHeaderIcon.TabIndex = 0;
            picHeaderIcon.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.FromArgb(33, 41, 35);
            lblHeaderTitle.Location = new Point(74, 16);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(204, 37);
            lblHeaderTitle.TabIndex = 11;
            lblHeaderTitle.Text = "Manage Meals";
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(110, 120, 112);
            lblHeaderSubtitle.Location = new Point(77, 56);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(170, 19);
            lblHeaderSubtitle.TabIndex = 12;
            lblHeaderSubtitle.Text = "Add, edit or remove meals";
            // 
            // btnAddNewMeal
            // 
            btnAddNewMeal.BackColor = Color.FromArgb(46, 94, 62);
            btnAddNewMeal.Cursor = Cursors.Hand;
            btnAddNewMeal.FlatAppearance.BorderSize = 0;
            btnAddNewMeal.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 123, 79);
            btnAddNewMeal.FlatStyle = FlatStyle.Flat;
            btnAddNewMeal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewMeal.ForeColor = Color.White;
            btnAddNewMeal.Image = Properties.Resources.btn_plus;
            btnAddNewMeal.Location = new Point(708, 28);
            btnAddNewMeal.Name = "btnAddNewMeal";
            btnAddNewMeal.Size = new Size(160, 42);
            btnAddNewMeal.TabIndex = 13;
            btnAddNewMeal.Tag = "round";
            btnAddNewMeal.Text = "Add Meal";
            btnAddNewMeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNewMeal.UseVisualStyleBackColor = false;
            btnAddNewMeal.Click += btnAddNewMeal_Click;
            // 
            // pnlFilterBar
            // 
            pnlFilterBar.BackColor = Color.White;
            pnlFilterBar.Controls.Add(pnlSearchBorder);
            pnlFilterBar.Controls.Add(lblFilterType);
            pnlFilterBar.Controls.Add(cmbFilterType);
            pnlFilterBar.Controls.Add(btnSearch);
            pnlFilterBar.Location = new Point(22, 95);
            pnlFilterBar.Name = "pnlFilterBar";
            pnlFilterBar.Size = new Size(846, 60);
            pnlFilterBar.TabIndex = 14;
            pnlFilterBar.Tag = "round";
            // 
            // pnlSearchBorder
            // 
            pnlSearchBorder.BackColor = Color.FromArgb(208, 214, 205);
            pnlSearchBorder.Controls.Add(pnlSearch);
            pnlSearchBorder.Location = new Point(14, 8);
            pnlSearchBorder.Name = "pnlSearchBorder";
            pnlSearchBorder.Padding = new Padding(1);
            pnlSearchBorder.Size = new Size(380, 44);
            pnlSearchBorder.TabIndex = 15;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(picSearchIcon);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Dock = DockStyle.Fill;
            pnlSearch.Location = new Point(1, 1);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(378, 42);
            pnlSearch.TabIndex = 16;
            // 
            // picSearchIcon
            // 
            picSearchIcon.Image = Properties.Resources.in_search;
            picSearchIcon.Location = new Point(12, 12);
            picSearchIcon.Name = "picSearchIcon";
            picSearchIcon.Size = new Size(18, 18);
            picSearchIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            picSearchIcon.TabIndex = 0;
            picSearchIcon.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(42, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search meals...";
            txtSearch.Size = new Size(324, 20);
            txtSearch.TabIndex = 17;
            // 
            // lblFilterType
            // 
            lblFilterType.AutoSize = true;
            lblFilterType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterType.ForeColor = Color.FromArgb(33, 41, 35);
            lblFilterType.Location = new Point(420, 20);
            lblFilterType.Name = "lblFilterType";
            lblFilterType.Size = new Size(82, 19);
            lblFilterType.TabIndex = 18;
            lblFilterType.Text = "Meal Type:";
            // 
            // cmbFilterType
            // 
            cmbFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterType.FlatStyle = FlatStyle.Flat;
            cmbFilterType.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterType.FormattingEnabled = true;
            cmbFilterType.Items.AddRange(new object[] { "All Meals", "Breakfast", "Lunch", "Dinner", "Snack" });
            cmbFilterType.Location = new Point(510, 17);
            cmbFilterType.Name = "cmbFilterType";
            cmbFilterType.Size = new Size(170, 27);
            cmbFilterType.TabIndex = 19;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(46, 94, 62);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 243, 232);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(46, 94, 62);
            btnSearch.Location = new Point(700, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 34);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvMeals
            // 
            dgvMeals.AllowUserToAddRows = false;
            dgvMeals.AllowUserToDeleteRows = false;
            dgvMeals.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 246);
            dgvMeals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMeals.BackgroundColor = Color.White;
            dgvMeals.BorderStyle = BorderStyle.None;
            dgvMeals.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMeals.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(236, 243, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 41, 35);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(236, 243, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(33, 41, 35);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMeals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMeals.ColumnHeadersHeight = 44;
            dgvMeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMeals.Columns.AddRange(new DataGridViewColumn[] { colMealName, colMealType, colCalories, colProtein, colDate, colEdit, colDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 41, 35);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(214, 232, 208);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(33, 41, 35);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMeals.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMeals.EnableHeadersVisualStyles = false;
            dgvMeals.GridColor = Color.FromArgb(229, 234, 227);
            dgvMeals.Location = new Point(22, 170);
            dgvMeals.MultiSelect = false;
            dgvMeals.Name = "dgvMeals";
            dgvMeals.ReadOnly = true;
            dgvMeals.RowHeadersVisible = false;
            dgvMeals.RowTemplate.Height = 42;
            dgvMeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeals.Size = new Size(846, 480);
            dgvMeals.TabIndex = 21;
            dgvMeals.CellContentClick += dgvMeals_CellContentClick;
            // 
            // colMealName
            // 
            colMealName.FillWeight = 30F;
            colMealName.HeaderText = "Meal Name";
            colMealName.Name = "colMealName";
            colMealName.ReadOnly = true;
            // 
            // colMealType
            // 
            colMealType.FillWeight = 15F;
            colMealType.HeaderText = "Meal Type";
            colMealType.Name = "colMealType";
            colMealType.ReadOnly = true;
            // 
            // colCalories
            // 
            colCalories.FillWeight = 12F;
            colCalories.HeaderText = "Calories";
            colCalories.Name = "colCalories";
            colCalories.ReadOnly = true;
            // 
            // colProtein
            // 
            colProtein.FillWeight = 12F;
            colProtein.HeaderText = "Protein (g)";
            colProtein.Name = "colProtein";
            colProtein.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 15F;
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.FillWeight = 8F;
            colEdit.HeaderText = "Edit";
            colEdit.Image = Properties.Resources.act_edit;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.ToolTipText = "Edit meal";
            // 
            // colDelete
            // 
            colDelete.FillWeight = 8F;
            colDelete.HeaderText = "Delete";
            colDelete.Image = Properties.Resources.act_delete;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.ToolTipText = "Delete meal";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(46, 94, 62);
            pnlSidebar.Controls.Add(picSidebarLogo);
            pnlSidebar.Controls.Add(lblSidebarBrand);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(btnNavLogMeal);
            pnlSidebar.Controls.Add(btnNavManageMeals);
            pnlSidebar.Controls.Add(btnNavWeight);
            pnlSidebar.Controls.Add(btnNavAnalytics);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnNavProfile);
            pnlSidebar.Controls.Add(btnNavLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(210, 680);
            pnlSidebar.TabIndex = 1;
            // 
            // picSidebarLogo
            // 
            picSidebarLogo.Image = Properties.Resources.logo_small;
            picSidebarLogo.Location = new Point(88, 20);
            picSidebarLogo.Name = "picSidebarLogo";
            picSidebarLogo.Size = new Size(34, 34);
            picSidebarLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picSidebarLogo.TabIndex = 0;
            picSidebarLogo.TabStop = false;
            // 
            // lblSidebarBrand
            // 
            lblSidebarBrand.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSidebarBrand.ForeColor = Color.White;
            lblSidebarBrand.Location = new Point(0, 58);
            lblSidebarBrand.Name = "lblSidebarBrand";
            lblSidebarBrand.Size = new Size(210, 30);
            lblSidebarBrand.TabIndex = 2;
            lblSidebarBrand.Text = "NutriTrack";
            lblSidebarBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.BackColor = Color.FromArgb(46, 94, 62);
            btnNavDashboard.Cursor = Cursors.Hand;
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 112, 77);
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavDashboard.ForeColor = Color.White;
            btnNavDashboard.Image = Properties.Resources.nav_dashboard;
            btnNavDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.Location = new Point(12, 110);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Padding = new Padding(14, 0, 0, 0);
            btnNavDashboard.Size = new Size(186, 40);
            btnNavDashboard.TabIndex = 3;
            btnNavDashboard.Tag = "round";
            btnNavDashboard.Text = "  Dashboard";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavDashboard.UseVisualStyleBackColor = false;
            btnNavDashboard.Click += btnNavDashboard_Click;
            // 
            // btnNavLogMeal
            // 
            btnNavLogMeal.BackColor = Color.FromArgb(46, 94, 62);
            btnNavLogMeal.Cursor = Cursors.Hand;
            btnNavLogMeal.FlatAppearance.BorderSize = 0;
            btnNavLogMeal.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 112, 77);
            btnNavLogMeal.FlatStyle = FlatStyle.Flat;
            btnNavLogMeal.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavLogMeal.ForeColor = Color.White;
            btnNavLogMeal.Image = Properties.Resources.nav_logmeal;
            btnNavLogMeal.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavLogMeal.Location = new Point(12, 156);
            btnNavLogMeal.Name = "btnNavLogMeal";
            btnNavLogMeal.Padding = new Padding(14, 0, 0, 0);
            btnNavLogMeal.Size = new Size(186, 40);
            btnNavLogMeal.TabIndex = 4;
            btnNavLogMeal.Tag = "round";
            btnNavLogMeal.Text = "  Log Meal";
            btnNavLogMeal.TextAlign = ContentAlignment.MiddleLeft;
            btnNavLogMeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavLogMeal.UseVisualStyleBackColor = false;
            btnNavLogMeal.Click += btnNavLogMeal_Click;
            // 
            // btnNavManageMeals
            // 
            btnNavManageMeals.BackColor = Color.FromArgb(78, 128, 92);
            btnNavManageMeals.Cursor = Cursors.Hand;
            btnNavManageMeals.FlatAppearance.BorderSize = 0;
            btnNavManageMeals.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 128, 92);
            btnNavManageMeals.FlatStyle = FlatStyle.Flat;
            btnNavManageMeals.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavManageMeals.ForeColor = Color.White;
            btnNavManageMeals.Image = Properties.Resources.nav_manage;
            btnNavManageMeals.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavManageMeals.Location = new Point(12, 202);
            btnNavManageMeals.Name = "btnNavManageMeals";
            btnNavManageMeals.Padding = new Padding(14, 0, 0, 0);
            btnNavManageMeals.Size = new Size(186, 40);
            btnNavManageMeals.TabIndex = 5;
            btnNavManageMeals.Tag = "round";
            btnNavManageMeals.Text = "  Manage Meals";
            btnNavManageMeals.TextAlign = ContentAlignment.MiddleLeft;
            btnNavManageMeals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavManageMeals.UseVisualStyleBackColor = false;
            btnNavManageMeals.Click += btnNavManageMeals_Click;
            // 
            // btnNavWeight
            // 
            btnNavWeight.BackColor = Color.FromArgb(46, 94, 62);
            btnNavWeight.Cursor = Cursors.Hand;
            btnNavWeight.FlatAppearance.BorderSize = 0;
            btnNavWeight.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 112, 77);
            btnNavWeight.FlatStyle = FlatStyle.Flat;
            btnNavWeight.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavWeight.ForeColor = Color.White;
            btnNavWeight.Image = Properties.Resources.nav_weight;
            btnNavWeight.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavWeight.Location = new Point(12, 248);
            btnNavWeight.Name = "btnNavWeight";
            btnNavWeight.Padding = new Padding(14, 0, 0, 0);
            btnNavWeight.Size = new Size(186, 40);
            btnNavWeight.TabIndex = 6;
            btnNavWeight.Tag = "round";
            btnNavWeight.Text = "  Weight";
            btnNavWeight.TextAlign = ContentAlignment.MiddleLeft;
            btnNavWeight.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavWeight.UseVisualStyleBackColor = false;
            btnNavWeight.Click += btnNavWeight_Click;
            // 
            // btnNavAnalytics
            // 
            btnNavAnalytics.BackColor = Color.FromArgb(46, 94, 62);
            btnNavAnalytics.Cursor = Cursors.Hand;
            btnNavAnalytics.FlatAppearance.BorderSize = 0;
            btnNavAnalytics.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 112, 77);
            btnNavAnalytics.FlatStyle = FlatStyle.Flat;
            btnNavAnalytics.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavAnalytics.ForeColor = Color.White;
            btnNavAnalytics.Image = Properties.Resources.nav_analytics;
            btnNavAnalytics.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAnalytics.Location = new Point(12, 294);
            btnNavAnalytics.Name = "btnNavAnalytics";
            btnNavAnalytics.Padding = new Padding(14, 0, 0, 0);
            btnNavAnalytics.Size = new Size(186, 40);
            btnNavAnalytics.TabIndex = 7;
            btnNavAnalytics.Tag = "round";
            btnNavAnalytics.Text = "  Analytics";
            btnNavAnalytics.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAnalytics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavAnalytics.UseVisualStyleBackColor = false;
            btnNavAnalytics.Click += btnNavAnalytics_Click;
            // 
            // btnNavReports
            // 
            btnNavReports.BackColor = Color.FromArgb(46, 94, 62);
            btnNavReports.Cursor = Cursors.Hand;
            btnNavReports.FlatAppearance.BorderSize = 0;
            btnNavReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 112, 77);
            btnNavReports.FlatStyle = FlatStyle.Flat;
            btnNavReports.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavReports.ForeColor = Color.White;
            btnNavReports.Image = Properties.Resources.nav_reports;
            btnNavReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavReports.Location = new Point(12, 340);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Padding = new Padding(14, 0, 0, 0);
            btnNavReports.Size = new Size(186, 40);
            btnNavReports.TabIndex = 8;
            btnNavReports.Tag = "round";
            btnNavReports.Text = "  Reports";
            btnNavReports.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavReports.UseVisualStyleBackColor = false;
            btnNavReports.Click += btnNavReports_Click;
            // 
            // btnNavProfile
            // 
            btnNavProfile.BackColor = Color.FromArgb(46, 94, 62);
            btnNavProfile.Cursor = Cursors.Hand;
            btnNavProfile.FlatAppearance.BorderSize = 0;
            btnNavProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 112, 77);
            btnNavProfile.FlatStyle = FlatStyle.Flat;
            btnNavProfile.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavProfile.ForeColor = Color.White;
            btnNavProfile.Image = Properties.Resources.nav_profile;
            btnNavProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavProfile.Location = new Point(12, 386);
            btnNavProfile.Name = "btnNavProfile";
            btnNavProfile.Padding = new Padding(14, 0, 0, 0);
            btnNavProfile.Size = new Size(186, 40);
            btnNavProfile.TabIndex = 9;
            btnNavProfile.Tag = "round";
            btnNavProfile.Text = "  Profile";
            btnNavProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnNavProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavProfile.UseVisualStyleBackColor = false;
            btnNavProfile.Click += btnNavProfile_Click;
            // 
            // btnNavLogout
            // 
            btnNavLogout.BackColor = Color.FromArgb(46, 94, 62);
            btnNavLogout.Cursor = Cursors.Hand;
            btnNavLogout.FlatAppearance.BorderSize = 0;
            btnNavLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 112, 77);
            btnNavLogout.FlatStyle = FlatStyle.Flat;
            btnNavLogout.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavLogout.ForeColor = Color.White;
            btnNavLogout.Image = Properties.Resources.nav_logout;
            btnNavLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavLogout.Location = new Point(12, 616);
            btnNavLogout.Name = "btnNavLogout";
            btnNavLogout.Padding = new Padding(14, 0, 0, 0);
            btnNavLogout.Size = new Size(186, 40);
            btnNavLogout.TabIndex = 10;
            btnNavLogout.Tag = "round";
            btnNavLogout.Text = "  Logout";
            btnNavLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnNavLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavLogout.UseVisualStyleBackColor = false;
            btnNavLogout.Click += btnNavLogout_Click;
            // 
            // ManageMealsForm
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 242);
            ClientSize = new Size(1100, 680);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = Properties.Resources.app;
            MaximizeBox = false;
            Name = "ManageMealsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriTrack - Manage Meals";
            Load += ManageMealsForm_Load;
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHeaderIcon).EndInit();
            pnlFilterBar.ResumeLayout(false);
            pnlFilterBar.PerformLayout();
            pnlSearchBorder.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMeals).EndInit();
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSidebarLogo).EndInit();
            ResumeLayout(false);

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
        private System.Windows.Forms.Button btnAddNewMeal;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.Panel pnlSearchBorder;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMealType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalories;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProtein;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
