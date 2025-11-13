namespace RevVise1.Forms.Views
{
    partial class SettingView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dashboardLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            userStatsPanel = new Panel();
            tableLayoutPanel13 = new TableLayoutPanel();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            userVehicleRegisteredText = new Label();
            userResolvedText = new Label();
            userUnresolvedText = new Label();
            adminStatsPanel = new Panel();
            tableLayoutPanel14 = new TableLayoutPanel();
            adminTotalUnresolvedText = new Label();
            adminUserRegisteredText = new Label();
            adminTotalResolvedText = new Label();
            label10 = new Label();
            adminTotalVehicleText = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            userPanel = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label13 = new Label();
            userChangePasswordButton = new Button();
            userDeleteUserButton = new Button();
            userResetVehicleDataButton = new Button();
            label5 = new Label();
            label14 = new Label();
            adminPanel = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            userComboBox = new ComboBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            adminDeleteUserButton = new Button();
            adminResetUserPassButton = new Button();
            adminClearUserButton = new Button();
            label3 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            adminClearDatabaseButton = new Button();
            adminResetLogDatabaseButton = new Button();
            label4 = new Label();
            adminResetVehicleDatabaseButton = new Button();
            label2 = new Label();
            exportDBButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            userStatsPanel.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            adminStatsPanel.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            userPanel.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            adminPanel.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 514F));
            tableLayoutPanel1.Controls.Add(dashboardLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(946, 687);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardLabel.ForeColor = Color.DarkGray;
            dashboardLabel.Location = new Point(13, 10);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(198, 65);
            dashboardLabel.TabIndex = 0;
            dashboardLabel.Text = "Settings";
            dashboardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.5652161F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.434782F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Location = new Point(10, 85);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(926, 592);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(userStatsPanel, 0, 0);
            tableLayoutPanel3.Controls.Add(adminStatsPanel, 0, 1);
            tableLayoutPanel3.Location = new Point(690, 1);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.22034F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 66.77966F));
            tableLayoutPanel3.Size = new Size(235, 590);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // userStatsPanel
            // 
            userStatsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userStatsPanel.BackColor = Color.FromArgb(115, 91, 115);
            userStatsPanel.BorderStyle = BorderStyle.Fixed3D;
            userStatsPanel.Controls.Add(tableLayoutPanel13);
            userStatsPanel.Location = new Point(3, 3);
            userStatsPanel.Name = "userStatsPanel";
            userStatsPanel.Size = new Size(229, 190);
            userStatsPanel.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Controls.Add(label8, 0, 2);
            tableLayoutPanel13.Controls.Add(label6, 0, 0);
            tableLayoutPanel13.Controls.Add(label7, 0, 1);
            tableLayoutPanel13.Controls.Add(userVehicleRegisteredText, 1, 0);
            tableLayoutPanel13.Controls.Add(userResolvedText, 1, 1);
            tableLayoutPanel13.Controls.Add(userUnresolvedText, 1, 2);
            tableLayoutPanel13.Location = new Point(3, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 6;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(219, 180);
            tableLayoutPanel13.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(3, 40);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 2;
            label8.Text = "Unresolved Cases:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 0;
            label6.Text = "Vehicles Registered:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(3, 20);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 1;
            label7.Text = "Resolved Cases:";
            // 
            // userVehicleRegisteredText
            // 
            userVehicleRegisteredText.AutoSize = true;
            userVehicleRegisteredText.ForeColor = SystemColors.ControlLight;
            userVehicleRegisteredText.Location = new Point(171, 0);
            userVehicleRegisteredText.Name = "userVehicleRegisteredText";
            userVehicleRegisteredText.Size = new Size(13, 15);
            userVehicleRegisteredText.TabIndex = 3;
            userVehicleRegisteredText.Text = "0";
            // 
            // userResolvedText
            // 
            userResolvedText.AutoSize = true;
            userResolvedText.ForeColor = SystemColors.ControlLight;
            userResolvedText.Location = new Point(171, 20);
            userResolvedText.Name = "userResolvedText";
            userResolvedText.Size = new Size(13, 15);
            userResolvedText.TabIndex = 4;
            userResolvedText.Text = "0";
            // 
            // userUnresolvedText
            // 
            userUnresolvedText.AutoSize = true;
            userUnresolvedText.ForeColor = SystemColors.ControlLight;
            userUnresolvedText.Location = new Point(171, 40);
            userUnresolvedText.Name = "userUnresolvedText";
            userUnresolvedText.Size = new Size(13, 15);
            userUnresolvedText.TabIndex = 5;
            userUnresolvedText.Text = "0";
            // 
            // adminStatsPanel
            // 
            adminStatsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminStatsPanel.BackColor = SystemColors.ControlLight;
            adminStatsPanel.BorderStyle = BorderStyle.Fixed3D;
            adminStatsPanel.Controls.Add(tableLayoutPanel14);
            adminStatsPanel.Location = new Point(3, 199);
            adminStatsPanel.Name = "adminStatsPanel";
            adminStatsPanel.Size = new Size(229, 388);
            adminStatsPanel.TabIndex = 1;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(adminTotalUnresolvedText, 1, 3);
            tableLayoutPanel14.Controls.Add(adminUserRegisteredText, 1, 0);
            tableLayoutPanel14.Controls.Add(adminTotalResolvedText, 1, 2);
            tableLayoutPanel14.Controls.Add(label10, 0, 3);
            tableLayoutPanel14.Controls.Add(adminTotalVehicleText, 1, 1);
            tableLayoutPanel14.Controls.Add(label12, 0, 2);
            tableLayoutPanel14.Controls.Add(label11, 0, 1);
            tableLayoutPanel14.Controls.Add(label9, 0, 0);
            tableLayoutPanel14.Controls.Add(exportDBButton, 0, 6);
            tableLayoutPanel14.Location = new Point(3, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 7;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel14.Size = new Size(219, 378);
            tableLayoutPanel14.TabIndex = 1;
            // 
            // adminTotalUnresolvedText
            // 
            adminTotalUnresolvedText.AutoSize = true;
            adminTotalUnresolvedText.ForeColor = SystemColors.ControlDarkDark;
            adminTotalUnresolvedText.Location = new Point(171, 60);
            adminTotalUnresolvedText.Name = "adminTotalUnresolvedText";
            adminTotalUnresolvedText.Size = new Size(13, 15);
            adminTotalUnresolvedText.TabIndex = 9;
            adminTotalUnresolvedText.Text = "0";
            // 
            // adminUserRegisteredText
            // 
            adminUserRegisteredText.AutoSize = true;
            adminUserRegisteredText.ForeColor = SystemColors.ControlDarkDark;
            adminUserRegisteredText.Location = new Point(171, 0);
            adminUserRegisteredText.Name = "adminUserRegisteredText";
            adminUserRegisteredText.Size = new Size(13, 15);
            adminUserRegisteredText.TabIndex = 6;
            adminUserRegisteredText.Text = "0";
            // 
            // adminTotalResolvedText
            // 
            adminTotalResolvedText.AutoSize = true;
            adminTotalResolvedText.ForeColor = SystemColors.ControlDarkDark;
            adminTotalResolvedText.Location = new Point(171, 40);
            adminTotalResolvedText.Name = "adminTotalResolvedText";
            adminTotalResolvedText.Size = new Size(13, 15);
            adminTotalResolvedText.TabIndex = 7;
            adminTotalResolvedText.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(3, 60);
            label10.Name = "label10";
            label10.Size = new Size(131, 15);
            label10.TabIndex = 2;
            label10.Text = "Total Unresolved Cases:";
            // 
            // adminTotalVehicleText
            // 
            adminTotalVehicleText.AutoSize = true;
            adminTotalVehicleText.ForeColor = SystemColors.ControlDarkDark;
            adminTotalVehicleText.Location = new Point(171, 20);
            adminTotalVehicleText.Name = "adminTotalVehicleText";
            adminTotalVehicleText.Size = new Size(13, 15);
            adminTotalVehicleText.TabIndex = 8;
            adminTotalVehicleText.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(3, 40);
            label12.Name = "label12";
            label12.Size = new Size(119, 15);
            label12.TabIndex = 1;
            label12.Text = "Total Resolved Cases:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(3, 20);
            label11.Name = "label11";
            label11.Size = new Size(139, 15);
            label11.TabIndex = 0;
            label11.Text = "Total Vehicles Registered:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 0;
            label9.Text = "Users Registered:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(userPanel, 0, 0);
            tableLayoutPanel4.Controls.Add(adminPanel, 0, 1);
            tableLayoutPanel4.Location = new Point(1, 1);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel4.Size = new Size(688, 590);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // userPanel
            // 
            userPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userPanel.BorderStyle = BorderStyle.Fixed3D;
            userPanel.Controls.Add(tableLayoutPanel6);
            userPanel.Location = new Point(3, 3);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(682, 190);
            userPanel.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.BackColor = SystemColors.ControlLight;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel6.Location = new Point(-2, -2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(683, 190);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 35);
            label1.TabIndex = 2;
            label1.Text = "User Settings";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label13, 1, 1);
            tableLayoutPanel5.Controls.Add(userChangePasswordButton, 0, 0);
            tableLayoutPanel5.Controls.Add(userDeleteUserButton, 0, 4);
            tableLayoutPanel5.Controls.Add(userResetVehicleDataButton, 0, 1);
            tableLayoutPanel5.Controls.Add(label5, 1, 0);
            tableLayoutPanel5.Controls.Add(label14, 1, 4);
            tableLayoutPanel5.Location = new Point(3, 38);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(677, 149);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(127, 29);
            label13.Name = "label13";
            label13.Size = new Size(155, 29);
            label13.TabIndex = 4;
            label13.Text = "Reset your vehicle database.";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userChangePasswordButton
            // 
            userChangePasswordButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userChangePasswordButton.Location = new Point(3, 3);
            userChangePasswordButton.Name = "userChangePasswordButton";
            userChangePasswordButton.Size = new Size(118, 23);
            userChangePasswordButton.TabIndex = 1;
            userChangePasswordButton.Text = "Change Password";
            userChangePasswordButton.UseVisualStyleBackColor = true;
            userChangePasswordButton.Click += userChangePasswordButton_Click;
            // 
            // userDeleteUserButton
            // 
            userDeleteUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDeleteUserButton.Location = new Point(3, 119);
            userDeleteUserButton.Name = "userDeleteUserButton";
            userDeleteUserButton.Size = new Size(118, 27);
            userDeleteUserButton.TabIndex = 2;
            userDeleteUserButton.Text = "Delete User";
            userDeleteUserButton.UseVisualStyleBackColor = true;
            userDeleteUserButton.Click += userDeleteUserButton_Click;
            // 
            // userResetVehicleDataButton
            // 
            userResetVehicleDataButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userResetVehicleDataButton.ForeColor = SystemColors.ControlText;
            userResetVehicleDataButton.Location = new Point(3, 32);
            userResetVehicleDataButton.Name = "userResetVehicleDataButton";
            userResetVehicleDataButton.Size = new Size(118, 23);
            userResetVehicleDataButton.TabIndex = 0;
            userResetVehicleDataButton.Text = "Reset Vehicle Data";
            userResetVehicleDataButton.UseVisualStyleBackColor = true;
            userResetVehicleDataButton.Click += userResetVehicleDataButton_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(127, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 29);
            label5.TabIndex = 3;
            label5.Text = "Change your password.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ControlDark;
            label14.Location = new Point(127, 116);
            label14.Name = "label14";
            label14.Size = new Size(318, 33);
            label14.TabIndex = 5;
            label14.Text = "Deletes user. (WARNING: User data will be lost completely.)";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // adminPanel
            // 
            adminPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminPanel.BackColor = SystemColors.ControlDark;
            adminPanel.BorderStyle = BorderStyle.Fixed3D;
            adminPanel.Controls.Add(tableLayoutPanel7);
            adminPanel.Location = new Point(3, 199);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(682, 388);
            adminPanel.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.BackColor = SystemColors.ControlDark;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel7.Controls.Add(label2, 0, 0);
            tableLayoutPanel7.Location = new Point(4, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(671, 378);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.79941F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.20059F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel8.Location = new Point(0, 35);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(671, 343);
            tableLayoutPanel8.TabIndex = 5;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel11.BackColor = Color.FromArgb(170, 170, 170);
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel11.Controls.Add(label3, 0, 0);
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10.404624F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 89.5953751F));
            tableLayoutPanel11.Size = new Size(408, 337);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(userComboBox, 1, 0);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel10.Location = new Point(0, 35);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(408, 302);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // userComboBox
            // 
            userComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(207, 3);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(198, 23);
            userComboBox.TabIndex = 6;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Controls.Add(adminDeleteUserButton, 0, 2);
            tableLayoutPanel12.Controls.Add(adminResetUserPassButton, 0, 0);
            tableLayoutPanel12.Controls.Add(adminClearUserButton, 0, 1);
            tableLayoutPanel12.Location = new Point(0, 0);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 4;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(204, 302);
            tableLayoutPanel12.TabIndex = 7;
            // 
            // adminDeleteUserButton
            // 
            adminDeleteUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adminDeleteUserButton.Location = new Point(3, 73);
            adminDeleteUserButton.Name = "adminDeleteUserButton";
            adminDeleteUserButton.Size = new Size(198, 23);
            adminDeleteUserButton.TabIndex = 2;
            adminDeleteUserButton.Text = "Delete Selected User";
            adminDeleteUserButton.UseVisualStyleBackColor = true;
            adminDeleteUserButton.Click += adminDeleteUserButton_Click;
            // 
            // adminResetUserPassButton
            // 
            adminResetUserPassButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adminResetUserPassButton.Location = new Point(3, 3);
            adminResetUserPassButton.Name = "adminResetUserPassButton";
            adminResetUserPassButton.Size = new Size(198, 23);
            adminResetUserPassButton.TabIndex = 1;
            adminResetUserPassButton.Text = "Reset Password";
            adminResetUserPassButton.UseVisualStyleBackColor = true;
            adminResetUserPassButton.Click += adminResetUserPassButton_Click;
            // 
            // adminClearUserButton
            // 
            adminClearUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adminClearUserButton.ForeColor = SystemColors.ControlText;
            adminClearUserButton.Location = new Point(3, 38);
            adminClearUserButton.Name = "adminClearUserButton";
            adminClearUserButton.Size = new Size(198, 23);
            adminClearUserButton.TabIndex = 0;
            adminClearUserButton.Text = "Clear Selected User Data";
            adminClearUserButton.UseVisualStyleBackColor = true;
            adminClearUserButton.Click += adminClearUserButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 35);
            label3.TabIndex = 6;
            label3.Text = "Modify User Data";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel9.BackColor = Color.FromArgb(170, 170, 170);
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(adminClearDatabaseButton, 0, 5);
            tableLayoutPanel9.Controls.Add(adminResetLogDatabaseButton, 0, 2);
            tableLayoutPanel9.Controls.Add(label4, 0, 0);
            tableLayoutPanel9.Controls.Add(adminResetVehicleDatabaseButton, 0, 1);
            tableLayoutPanel9.Location = new Point(417, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 6;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel9.Size = new Size(251, 337);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // adminClearDatabaseButton
            // 
            adminClearDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adminClearDatabaseButton.Location = new Point(3, 305);
            adminClearDatabaseButton.Name = "adminClearDatabaseButton";
            adminClearDatabaseButton.Size = new Size(245, 23);
            adminClearDatabaseButton.TabIndex = 5;
            adminClearDatabaseButton.Text = "Clear Database";
            adminClearDatabaseButton.UseVisualStyleBackColor = true;
            adminClearDatabaseButton.Click += adminClearDatabaseButton_Click;
            // 
            // adminResetLogDatabaseButton
            // 
            adminResetLogDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adminResetLogDatabaseButton.Location = new Point(3, 73);
            adminResetLogDatabaseButton.Name = "adminResetLogDatabaseButton";
            adminResetLogDatabaseButton.Size = new Size(245, 23);
            adminResetLogDatabaseButton.TabIndex = 4;
            adminResetLogDatabaseButton.Text = "Reset Log Database";
            adminResetLogDatabaseButton.UseVisualStyleBackColor = true;
            adminResetLogDatabaseButton.Click += adminResetLogDatabaseButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 35);
            label4.TabIndex = 7;
            label4.Text = "Modify Database";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // adminResetVehicleDatabaseButton
            // 
            adminResetVehicleDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adminResetVehicleDatabaseButton.Location = new Point(3, 38);
            adminResetVehicleDatabaseButton.Name = "adminResetVehicleDatabaseButton";
            adminResetVehicleDatabaseButton.Size = new Size(245, 23);
            adminResetVehicleDatabaseButton.TabIndex = 3;
            adminResetVehicleDatabaseButton.Text = "Reset Vehicle Database";
            adminResetVehicleDatabaseButton.UseVisualStyleBackColor = true;
            adminResetVehicleDatabaseButton.Click += adminResetVehicleDatabaseButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 35);
            label2.TabIndex = 3;
            label2.Text = "Admin Settings";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exportDBButton
            // 
            exportDBButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exportDBButton.Location = new Point(3, 345);
            exportDBButton.Name = "exportDBButton";
            exportDBButton.Size = new Size(162, 23);
            exportDBButton.TabIndex = 10;
            exportDBButton.Text = "Export Database";
            exportDBButton.UseVisualStyleBackColor = true;
            exportDBButton.Click += exportDBButton_Click;
            // 
            // SettingView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "SettingView";
            Size = new Size(949, 690);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            userStatsPanel.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            adminStatsPanel.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            adminPanel.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label dashboardLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel userStatsPanel;
        private Panel adminStatsPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button userResetVehicleDataButton;
        private Button userChangePasswordButton;
        private Button userDeleteUserButton;
        private Button adminResetUserPassButton;
        private Button adminResetVehicleDatabaseButton;
        private Button adminResetLogDatabaseButton;
        private Button adminDeleteUserButton;
        private Button adminClearUserButton;
        private Button adminClearDatabaseButton;
        private ComboBox userComboBox;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label4;
        private Panel adminPanel;
        private Panel userPanel;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label8;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label userVehicleRegisteredText;
        private Label userResolvedText;
        private Label userUnresolvedText;
        private Label adminTotalUnresolvedText;
        private Label adminUserRegisteredText;
        private Label adminTotalResolvedText;
        private Label adminTotalVehicleText;
        private Label label13;
        private Label label5;
        private Label label14;
        private Button exportDBButton;
    }
}
