namespace Enum
{
    partial class frmEnum
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
            this.lstWeek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstWeek
            // 
            this.lstWeek.FormattingEnabled = true;
            this.lstWeek.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.lstWeek.Location = new System.Drawing.Point(54, 46);
            this.lstWeek.Name = "lstWeek";
            this.lstWeek.Size = new System.Drawing.Size(135, 108);
            this.lstWeek.TabIndex = 1;
            this.lstWeek.SelectedIndexChanged += new System.EventHandler(this.lstWeek_SelectedIndexChanged);
            // 
            // frmEnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 209);
            this.Controls.Add(this.lstWeek);
            this.Name = "frmEnum";
            this.Text = "Enum";
            this.Load += new System.EventHandler(this.frmEnum_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstWeek;
    }
}

