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
    public partial class INFO : Form
    {
        #region ctors
        public INFO()
        {
            InitializeComponent();   
        }
        public INFO(Selected.Units _unit)
        {

        }

        #endregion


        private void INFO_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }
    }
}
