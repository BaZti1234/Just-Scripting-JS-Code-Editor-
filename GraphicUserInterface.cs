using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JS_Code_Editor.Class
{
    public class GraphicUserInterface
    {
        public void exitApplication() 
        {
            Application.Exit();
        }

        public void minimizeForm() 
        {
            foreach (Form frm in Application.OpenForms)
            {
                frm.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
