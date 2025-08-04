using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Cafe_PoS.Resources
{
    public class RJTextbox : TextBox
    {
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;

        //this constructor is the style of the textbox
        public RJTextbox()
        {
            this.Size = new Size(180, 90);
            this.MaxLength = 250;
            this.Font = new Font("Noto Sans SC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
    
}
