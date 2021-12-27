
namespace recreation_center
{
    partial class UpdateRate
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
            this.groupDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.oneHourNum = new System.Windows.Forms.NumericUpDown();
            this.twoHoursNum = new System.Windows.Forms.NumericUpDown();
            this.fourHoursNum = new System.Windows.Forms.NumericUpDown();
            this.wholeDayNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oneHourNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoHoursNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourHoursNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeDayNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDropDown
            // 
            this.groupDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupDropDown.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDropDown.FormattingEnabled = true;
            this.groupDropDown.Location = new System.Drawing.Point(136, 148);
            this.groupDropDown.Name = "groupDropDown";
            this.groupDropDown.Size = new System.Drawing.Size(179, 27);
            this.groupDropDown.TabIndex = 0;
            this.groupDropDown.SelectedIndexChanged += new System.EventHandler(this.groupDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "One hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Whole Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Four hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Two hours";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oneHourNum
            // 
            this.oneHourNum.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneHourNum.Location = new System.Drawing.Point(250, 227);
            this.oneHourNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.oneHourNum.Name = "oneHourNum";
            this.oneHourNum.Size = new System.Drawing.Size(120, 27);
            this.oneHourNum.TabIndex = 11;
            // 
            // twoHoursNum
            // 
            this.twoHoursNum.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoHoursNum.Location = new System.Drawing.Point(250, 275);
            this.twoHoursNum.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.twoHoursNum.Name = "twoHoursNum";
            this.twoHoursNum.Size = new System.Drawing.Size(120, 27);
            this.twoHoursNum.TabIndex = 12;
            // 
            // fourHoursNum
            // 
            this.fourHoursNum.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourHoursNum.Location = new System.Drawing.Point(250, 334);
            this.fourHoursNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.fourHoursNum.Name = "fourHoursNum";
            this.fourHoursNum.Size = new System.Drawing.Size(120, 27);
            this.fourHoursNum.TabIndex = 13;
            // 
            // wholeDayNum
            // 
            this.wholeDayNum.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeDayNum.Location = new System.Drawing.Point(250, 383);
            this.wholeDayNum.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.wholeDayNum.Name = "wholeDayNum";
            this.wholeDayNum.Size = new System.Drawing.Size(120, 27);
            this.wholeDayNum.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select the group you wanna update the rates of";
            // 
            // UpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wholeDayNum);
            this.Controls.Add(this.fourHoursNum);
            this.Controls.Add(this.twoHoursNum);
            this.Controls.Add(this.oneHourNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupDropDown);
            this.Name = "UpdateRate";
            this.Text = "UpdateRate";
            ((System.ComponentModel.ISupportInitialize)(this.oneHourNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoHoursNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourHoursNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeDayNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox groupDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown oneHourNum;
        private System.Windows.Forms.NumericUpDown twoHoursNum;
        private System.Windows.Forms.NumericUpDown fourHoursNum;
        private System.Windows.Forms.NumericUpDown wholeDayNum;
        private System.Windows.Forms.Label label5;
    }
}