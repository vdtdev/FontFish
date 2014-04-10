namespace FontFish.Controls
{
    partial class FontDetailList
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
            this.scroller = new System.Windows.Forms.ScrollableControl();
            this.layoutFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.scroller.SuspendLayout();
            this.SuspendLayout();
            // 
            // scroller
            // 
            this.scroller.Controls.Add(this.layoutFlow);
            this.scroller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scroller.Location = new System.Drawing.Point(0, 0);
            this.scroller.Name = "scroller";
            this.scroller.Size = new System.Drawing.Size(494, 353);
            this.scroller.TabIndex = 0;
            this.scroller.Text = "scrollableControl1";
            // 
            // layoutFlow
            // 
            this.layoutFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutFlow.Location = new System.Drawing.Point(0, 0);
            this.layoutFlow.Name = "layoutFlow";
            this.layoutFlow.Size = new System.Drawing.Size(494, 353);
            this.layoutFlow.TabIndex = 0;
            // 
            // FontDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scroller);
            this.Name = "FontDetail";
            this.Size = new System.Drawing.Size(494, 353);
            this.scroller.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ScrollableControl scroller;
        private System.Windows.Forms.FlowLayoutPanel layoutFlow;
    }
}
