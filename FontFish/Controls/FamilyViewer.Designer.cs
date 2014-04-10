namespace FontFish.Controls
{
    partial class FamilyViewer
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
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblFontName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPreview
            // 
            this.lblPreview.BackColor = System.Drawing.Color.White;
            this.lblPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.Location = new System.Drawing.Point(0, 23);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(558, 75);
            this.lblPreview.TabIndex = 0;
            this.lblPreview.Text = "abcABC123";
            this.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFontName
            // 
            this.lblFontName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFontName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFontName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFontName.Location = new System.Drawing.Point(0, 0);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(558, 23);
            this.lblFontName.TabIndex = 1;
            this.lblFontName.Text = "label1";
            this.lblFontName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FamilyViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblFontName);
            this.Controls.Add(this.lblPreview);
            this.Name = "FamilyViewer";
            this.Size = new System.Drawing.Size(558, 102);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblFontName;
    }
}
