namespace DesignTest
{
    partial class PlayList_screen
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
            this.TheListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TheListBox
            // 
            this.TheListBox.BackColor = System.Drawing.Color.DarkMagenta;
            this.TheListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TheListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TheListBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheListBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TheListBox.FormattingEnabled = true;
            this.TheListBox.ItemHeight = 23;
            this.TheListBox.Location = new System.Drawing.Point(0, 0);
            this.TheListBox.Name = "TheListBox";
            this.TheListBox.Size = new System.Drawing.Size(640, 443);
            this.TheListBox.TabIndex = 11;
            // 
            // PlayList_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TheListBox);
            this.Name = "PlayList_screen";
            this.Size = new System.Drawing.Size(640, 443);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TheListBox;
    }
}
