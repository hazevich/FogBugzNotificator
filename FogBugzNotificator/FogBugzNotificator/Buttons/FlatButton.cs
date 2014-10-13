using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FogBugzNotificator.Buttons
{
    public class FlatButton : Button
    {
        public FlatButton()
        {
            FlatStyle = FlatStyle.Flat;
            Width = 60;
            Height = 35;
            Font = new Font(new FontFamily("Calibri"), 11.25f, FontStyle.Regular);
        }
    }
}
