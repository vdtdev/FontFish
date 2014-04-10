using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontFish.Controls
{
    /// <summary>
    /// Displays a preview of a font face and shows its name
    /// </summary>
    public partial class FamilyViewer : UserControl
    {
        private Font font;
     
        /// <summary>
        /// Font displayed by the viewer
        /// </summary>
        public Font PreviewFont
        {
            get
            {
                return font;
            }
            set
            {
                font = value;
                lblPreview.Font = value;
                lblFontName.Text = value.Name + value.Style.ToString();
            }
        }

        /// <summary>
        /// The name of the displayed font's family
        /// </summary>
        public String Family
        {
            get { return lblPreview.Font.FontFamily.Name; }
        }

        public FamilyViewer()
        {
            InitializeComponent();
        }
    }
}
