using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa_Vega
{
    public class OpenForm
    {
        public static Form activeForm = null;
        public static void OpnForm(Form _form)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = _form;
            _form.TopLevel = false;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.StartPosition = FormStartPosition.Manual;
            _form.Dock = DockStyle.None;

            _form.Anchor = AnchorStyles.Top;

            Main.pnl.Controls.Add(_form);
            Main.pnl.Tag = _form;
            _form.BringToFront();
            _form.Show();
        }
        public static void ReSize()
        {
            activeForm.Anchor = AnchorStyles.Top;
        }
    }
}
