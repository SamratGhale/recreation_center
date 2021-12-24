
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
            // UpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 504);
            this.Controls.Add(this.groupDropDown);
            this.Name = "UpdateRate";
            this.Text = "UpdateRate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox groupDropDown;
    }
}