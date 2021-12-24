
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
            this.loggedIn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MenuTable = new System.Windows.Forms.DataGridView();
            this.TicketRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneHr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoHr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threeHrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateMenu = new System.Windows.Forms.Button();
            this.MainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTable)).BeginInit();
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
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(690, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
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
            this.MainTab.Location = new System.Drawing.Point(2, 49);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(795, 393);
            this.MainTab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MenuTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MenuTable
            // 
            this.MenuTable.AllowUserToOrderColumns = true;
            this.MenuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketRate,
            this.oneHr,
            this.thoHr,
            this.threeHrs,
            this.WholeDay});
            this.MenuTable.Enabled = false;
            this.MenuTable.Location = new System.Drawing.Point(16, 6);
            this.MenuTable.Name = "MenuTable";
            this.MenuTable.Size = new System.Drawing.Size(751, 343);
            this.MenuTable.TabIndex = 0;
            // 
            // TicketRate
            // 
            this.TicketRate.HeaderText = "Ticket Rate";
            this.TicketRate.Name = "TicketRate";
            this.TicketRate.ReadOnly = true;
            // 
            // oneHr
            // 
            this.oneHr.HeaderText = "1-2 Hr";
            this.oneHr.Name = "oneHr";
            this.oneHr.ReadOnly = true;
            // 
            // thoHr
            // 
            this.thoHr.HeaderText = "2-4 Hrs";
            this.thoHr.Name = "thoHr";
            this.thoHr.ReadOnly = true;
            // 
            // threeHrs
            // 
            this.threeHrs.HeaderText = "4-6Hrs";
            this.threeHrs.Name = "threeHrs";
            this.threeHrs.ReadOnly = true;
            // 
            // WholeDay
            // 
            this.WholeDay.HeaderText = "Whole Day";
            this.WholeDay.Name = "WholeDay";
            // 
            // UpdateMenu
            // 
            this.UpdateMenu.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMenu.Location = new System.Drawing.Point(550, 449);
            this.UpdateMenu.Name = "UpdateMenu";
            this.UpdateMenu.Size = new System.Drawing.Size(105, 38);
            this.UpdateMenu.TabIndex = 4;
            this.UpdateMenu.Text = "Update Rate";
            this.UpdateMenu.UseVisualStyleBackColor = true;
            this.UpdateMenu.Click += new System.EventHandler(this.UpdateMenu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.UpdateMenu);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loggedIn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuTable)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MenuTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneHr;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoHr;
        private System.Windows.Forms.DataGridViewTextBoxColumn threeHrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn WholeDay;
        private System.Windows.Forms.Button UpdateMenu;
    }
}