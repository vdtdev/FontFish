namespace FontFish
{
    partial class Viewer
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
            this.lblStats = new System.Windows.Forms.Label();
            this.grid = new FontFish.Controls.FamilyGrid();
            this.SuspendLayout();
            // 
            // lblStats
            // 
            this.lblStats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStats.Location = new System.Drawing.Point(0, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(588, 30);
            this.lblStats.TabIndex = 1;
            this.lblStats.Text = "2 Fonts";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStats.UseMnemonic = false;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 30);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(588, 305);
            this.grid.TabIndex = 2;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 335);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lblStats);
            this.Name = "Viewer";
            this.Text = "FontFish";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStats;
        private Controls.FamilyGrid grid;
    }
}

