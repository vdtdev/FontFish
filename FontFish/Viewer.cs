using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using FontFish.Controls;
namespace FontFish
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
            int fontCount = grid.LoadSystemFonts();
            lblStats.Text = String.Format("{0} font{1}", fontCount, (fontCount == 1) ? "" : "s");
        }
    }
}
