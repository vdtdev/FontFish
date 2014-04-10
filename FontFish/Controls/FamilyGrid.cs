using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace FontFish.Controls
{
    public partial class FamilyGrid : UserControl
    {
        private Dictionary<String, int> famPositions = new Dictionary<string, int>();
        public FlowLayoutPanel LayoutBox
        {
            get { return layout; }
        }
        public FamilyGrid()
        {
            
            InitializeComponent();
            
        }

        /// <summary>
        /// Add an item to the FamilyGrid
        /// </summary>
        /// <remarks>Also stores the vertical position of the control in famPositions</remarks>
        /// <param name="f">FamilyViewer control to add</param>
        private void AddItem(FamilyViewer f)
        {
            String fn = f.Family;
            Controls.Add(f);
            famPositions.Add(fn,Controls[Controls.IndexOf(f)].Top);
        }

        /// <summary>
        /// The vertical offset of the top of the control displaying a preview
        /// of the provided font family
        /// </summary>
        /// <param name="familyName">Name of the font family to find</param>
        /// <returns>The vertical offset of the preview, or -1 if not found</returns>
        public int FamilyPreviewPosition(String familyName)
        {
            if (famPositions.ContainsKey(familyName))
            {
                return famPositions[familyName];
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Load system fonts and create previews of them
        /// </summary>
        /// <returns>Total number of fonts loaded</returns>
        public int LoadSystemFonts()
        {
            FontCollection fc = new InstalledFontCollection();
            int fontCount = 0;

            foreach (FontFamily f in fc.Families)
            {
                fontCount++;

                try
                {
                    FontStyle fs = FontStyle.Strikeout;
                    foreach (FontStyle fos in Enum.GetValues(typeof(FontStyle)))
                    {

                        if (fs == FontStyle.Strikeout && fos != FontStyle.Strikeout)
                        {
                            if (f.IsStyleAvailable(fos))
                            {
                                fs = fos;
                            }
                        }
                    }
                    Font fo = new Font(f, 38f, fs);
                    FamilyViewer fv = new FamilyViewer();
                    fv.PreviewFont = fo;
                    this.AddItem(fv);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Problem displaying " + f.Name);
                }
            }
            return fontCount;
        }
    }
}
