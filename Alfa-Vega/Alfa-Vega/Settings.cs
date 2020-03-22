using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa_Vega
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        private void MoveIndicator(Control control)
        {
            indicator.Location = new Point(control.Location.X, indicator.Location.Y);
            indicator.Width = control.Width;
        }
        private void MoveIndicator2(Control control)
        {
            indicator2.Location = new Point(control.Location.X, indicator2.Location.Y);
            indicator2.Width = control.Width;
        }
        private void btnFactory_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);

        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);

        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);

        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MoveIndicator2((Control)sender);

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            MoveIndicator2((Control)sender);

        }
    }
}
