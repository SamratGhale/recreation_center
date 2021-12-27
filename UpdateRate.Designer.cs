
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
            this.oneHourText = new System.Windows.Forms.TextBox();
            this.twoHoursText = new System.Windows.Forms.TextBox();
            this.fourHoursText = new System.Windows.Forms.TextBox();
            this.wholeDayText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupDropDown
            // 
            this.groupDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupDropDown.FormattingEnabled = true;
            this.groupDropDown.Location = new System.Drawing.Point(120, 145);
            this.groupDropDown.Name = "groupDropDown";
            this.groupDropDown.Size = new System.Drawing.Size(121, 21);
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
            // oneHourText
            // 
            this.oneHourText.Location = new System.Drawing.Point(250, 228);
            this.oneHourText.Name = "oneHourText";
            this.oneHourText.Size = new System.Drawing.Size(100, 20);
            this.oneHourText.TabIndex = 5;
            // 
            // twoHoursText
            // 
            this.twoHoursText.Location = new System.Drawing.Point(250, 275);
            this.twoHoursText.Name = "twoHoursText";
            this.twoHoursText.Size = new System.Drawing.Size(100, 20);
            this.twoHoursText.TabIndex = 7;
            // 
            // fourHoursText
            // 
            this.fourHoursText.Location = new System.Drawing.Point(250, 336);
            this.fourHoursText.Name = "fourHoursText";
            this.fourHoursText.Size = new System.Drawing.Size(100, 20);
            this.fourHoursText.TabIndex = 8;
            // 
            // wholeDayText
            // 
            this.wholeDayText.Location = new System.Drawing.Point(250, 383);
            this.wholeDayText.Name = "wholeDayText";
            this.wholeDayText.Size = new System.Drawing.Size(100, 20);
            this.wholeDayText.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wholeDayText);
            this.Controls.Add(this.fourHoursText);
            this.Controls.Add(this.twoHoursText);
            this.Controls.Add(this.oneHourText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupDropDown);
            this.Name = "UpdateRate";
            this.Text = "UpdateRate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox groupDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oneHourText;
        private System.Windows.Forms.TextBox twoHoursText;
        private System.Windows.Forms.TextBox fourHoursText;
        private System.Windows.Forms.TextBox wholeDayText;
        private System.Windows.Forms.Button button1;
    }
}