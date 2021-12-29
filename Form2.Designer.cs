
namespace recreation_center
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loggedIn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.completedBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkOutBox = new System.Windows.Forms.DateTimePicker();
            this.checkInBox = new System.Windows.Forms.DateTimePicker();
            this.isWeekendBox = new System.Windows.Forms.CheckBox();
            this.ageGroupBox = new System.Windows.Forms.ComboBox();
            this.visitorNameBox = new System.Windows.Forms.TextBox();
            this.checkOutTimeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.MenuTable = new System.Windows.Forms.DataGridView();
            this.TicketRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneHr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoHr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threeHrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateMenu = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.VisitorTable = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isWeeknd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loggedIn
            // 
            this.loggedIn.AutoSize = true;
            this.loggedIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedIn.Location = new System.Drawing.Point(506, 9);
            this.loggedIn.Name = "loggedIn";
            this.loggedIn.Size = new System.Drawing.Size(126, 19);
            this.loggedIn.TabIndex = 0;
            this.loggedIn.Text = "Logged in as:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(782, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(646, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 19);
            this.userNameLabel.TabIndex = 2;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabPage1);
            this.MainTab.Controls.Add(this.tabPage2);
            this.MainTab.Controls.Add(this.tabPage3);
            this.MainTab.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTab.Location = new System.Drawing.Point(22, 50);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(988, 427);
            this.MainTab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DatePicker);
            this.tabPage1.Controls.Add(this.completedBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.checkOutBox);
            this.tabPage1.Controls.Add(this.checkInBox);
            this.tabPage1.Controls.Add(this.isWeekendBox);
            this.tabPage1.Controls.Add(this.ageGroupBox);
            this.tabPage1.Controls.Add(this.visitorNameBox);
            this.tabPage1.Controls.Add(this.checkOutTimeLabel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(603, 25);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 26);
            this.DatePicker.TabIndex = 14;
            // 
            // completedBox
            // 
            this.completedBox.AutoSize = true;
            this.completedBox.Checked = true;
            this.completedBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.completedBox.Location = new System.Drawing.Point(221, 252);
            this.completedBox.Name = "completedBox";
            this.completedBox.Size = new System.Drawing.Size(15, 14);
            this.completedBox.TabIndex = 13;
            this.completedBox.UseVisualStyleBackColor = true;
            this.completedBox.CheckedChanged += new System.EventHandler(this.completedBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Completed?";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(118, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add visitor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkOutBox
            // 
            this.checkOutBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.checkOutBox.Location = new System.Drawing.Point(221, 284);
            this.checkOutBox.Name = "checkOutBox";
            this.checkOutBox.ShowUpDown = true;
            this.checkOutBox.Size = new System.Drawing.Size(153, 26);
            this.checkOutBox.TabIndex = 10;
            // 
            // checkInBox
            // 
            this.checkInBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.checkInBox.Location = new System.Drawing.Point(221, 207);
            this.checkInBox.Name = "checkInBox";
            this.checkInBox.ShowUpDown = true;
            this.checkInBox.Size = new System.Drawing.Size(153, 26);
            this.checkInBox.TabIndex = 9;
            // 
            // isWeekendBox
            // 
            this.isWeekendBox.AutoSize = true;
            this.isWeekendBox.Location = new System.Drawing.Point(221, 166);
            this.isWeekendBox.Name = "isWeekendBox";
            this.isWeekendBox.Size = new System.Drawing.Size(15, 14);
            this.isWeekendBox.TabIndex = 8;
            this.isWeekendBox.UseVisualStyleBackColor = true;
            // 
            // ageGroupBox
            // 
            this.ageGroupBox.DisplayMember = "1";
            this.ageGroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageGroupBox.Location = new System.Drawing.Point(221, 122);
            this.ageGroupBox.Name = "ageGroupBox";
            this.ageGroupBox.Size = new System.Drawing.Size(153, 27);
            this.ageGroupBox.TabIndex = 7;
            // 
            // visitorNameBox
            // 
            this.visitorNameBox.Location = new System.Drawing.Point(221, 87);
            this.visitorNameBox.Name = "visitorNameBox";
            this.visitorNameBox.Size = new System.Drawing.Size(153, 26);
            this.visitorNameBox.TabIndex = 6;
            // 
            // checkOutTimeLabel
            // 
            this.checkOutTimeLabel.AutoSize = true;
            this.checkOutTimeLabel.Location = new System.Drawing.Point(76, 284);
            this.checkOutTimeLabel.Name = "checkOutTimeLabel";
            this.checkOutTimeLabel.Size = new System.Drawing.Size(126, 19);
            this.checkOutTimeLabel.TabIndex = 5;
            this.checkOutTimeLabel.Text = "CheckOut time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "CheckIn time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weekend";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age Group/Group Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visitor Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new visitor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.refreshButton);
            this.tabPage2.Controls.Add(this.MenuTable);
            this.tabPage2.Controls.Add(this.UpdateMenu);
            this.tabPage2.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(543, 278);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(96, 38);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // MenuTable
            // 
            this.MenuTable.AllowUserToOrderColumns = true;
            this.MenuTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.MenuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketRate,
            this.oneHr,
            this.thoHr,
            this.threeHrs,
            this.WholeDay});
            this.MenuTable.Location = new System.Drawing.Point(16, 6);
            this.MenuTable.Name = "MenuTable";
            this.MenuTable.Size = new System.Drawing.Size(793, 250);
            this.MenuTable.TabIndex = 0;
            // 
            // TicketRate
            // 
            this.TicketRate.FillWeight = 200F;
            this.TicketRate.HeaderText = "Ticket Rate";
            this.TicketRate.Name = "TicketRate";
            this.TicketRate.ReadOnly = true;
            this.TicketRate.Width = 150;
            // 
            // oneHr
            // 
            this.oneHr.HeaderText = "1-2 Hr";
            this.oneHr.Name = "oneHr";
            this.oneHr.ReadOnly = true;
            this.oneHr.Width = 150;
            // 
            // thoHr
            // 
            this.thoHr.HeaderText = "2-4 Hrs";
            this.thoHr.Name = "thoHr";
            this.thoHr.ReadOnly = true;
            this.thoHr.Width = 150;
            // 
            // threeHrs
            // 
            this.threeHrs.HeaderText = "4-6Hrs";
            this.threeHrs.Name = "threeHrs";
            this.threeHrs.ReadOnly = true;
            this.threeHrs.Width = 150;
            // 
            // WholeDay
            // 
            this.WholeDay.HeaderText = "Whole Day";
            this.WholeDay.Name = "WholeDay";
            this.WholeDay.Width = 150;
            // 
            // UpdateMenu
            // 
            this.UpdateMenu.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMenu.Location = new System.Drawing.Point(645, 278);
            this.UpdateMenu.Name = "UpdateMenu";
            this.UpdateMenu.Size = new System.Drawing.Size(105, 38);
            this.UpdateMenu.TabIndex = 4;
            this.UpdateMenu.Text = "Update Rate";
            this.UpdateMenu.UseVisualStyleBackColor = true;
            this.UpdateMenu.Click += new System.EventHandler(this.UpdateMenu_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.VisitorTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(980, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visistors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // VisitorTable
            // 
            this.VisitorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Group,
            this.isWeeknd,
            this.Completed,
            this.CheckInTime,
            this.CheckoutTime,
            this.Date});
            this.VisitorTable.Location = new System.Drawing.Point(6, 6);
            this.VisitorTable.Name = "VisitorTable";
            this.VisitorTable.Size = new System.Drawing.Size(992, 390);
            this.VisitorTable.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Visitor Name";
            this.Name.Name = "Name";
            // 
            // Group
            // 
            this.Group.HeaderText = "Age Group/ Group Size";
            this.Group.Name = "Group";
            this.Group.Width = 200;
            // 
            // isWeeknd
            // 
            this.isWeeknd.HeaderText = "Weeknd";
            this.isWeeknd.Name = "isWeeknd";
            // 
            // Completed
            // 
            this.Completed.HeaderText = "Completed";
            this.Completed.Name = "Completed";
            // 
            // CheckInTime
            // 
            this.CheckInTime.HeaderText = "Check In Time";
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.Width = 180;
            // 
            // CheckoutTime
            // 
            this.CheckoutTime.HeaderText = "CheckoutTime";
            this.CheckoutTime.Name = "CheckoutTime";
            this.CheckoutTime.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4});
            this.menuItem1.Text = "File";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6,
            this.menuItem7});
            this.menuItem3.Text = "Export Rate Menu";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Save as Xml";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Save as binary file";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "CSV file";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem9,
            this.menuItem10});
            this.menuItem4.Text = "Import Menu";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "From CSV";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "From Xml";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.Text = "From binary file";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(recreation_center.Form2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 528);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loggedIn);
            this.Menu = this.mainMenu1;
            this.Text = "Recreation Center";
            this.MainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loggedIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView MenuTable;
        private System.Windows.Forms.Button UpdateMenu;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneHr;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoHr;
        private System.Windows.Forms.DataGridViewTextBoxColumn threeHrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn WholeDay;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.TextBox visitorNameBox;
        private System.Windows.Forms.Label checkOutTimeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker checkInBox;
        private System.Windows.Forms.CheckBox isWeekendBox;
        private System.Windows.Forms.ComboBox ageGroupBox;
        private System.Windows.Forms.DateTimePicker checkOutBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox completedBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView VisitorTable;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn isWeeknd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckoutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}