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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            BaseMenu = new SideMenu(panelBase);
            SetMenu();
        }

        /// <summary>
        /// Anasayfa butonu
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
                vegas.ClearMenu();
                Selected.MenuID = new Point3D(0, 0, 0);
            }

        }

        VegaSystem vegas = new VegaSystem();
        public static SideMenu BaseMenu;
        public void SetMenu()
        {
            vegas.GetMenu(); //Verileri listelere ekler

            for (int i = 5; i >= 0; i--)
            {
                if (Selected.Menu[i].Count > 0)
                {
                    //Parent
                    Selected.Parents.Add(new SideMenu(i + 10, ((Selected.Units)i).ToString(), BaseMenu));

                    for (int j = Selected.Menu[i].Count - 1; j >= 0; j--)
                    {
                        Point3D id = new Point3D(i, j, 0);
                        SideMenu temp = new SideMenu(id);
                        temp.AddSub(i, Selected.Menu[i][j][1], Selected.Parents[5 - i].panel);
                        //temp.ExtendPanel(Selected.Parents[5 - i].panel);
                    }
                }
                else continue;

            }
        }

        /// <summary>
        /// Settings formunu açan buton.
        /// </summary>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings _form = new Settings();
            OpenForm(_form);
        }

        /// <summary>
        /// Ana paneli hangi formun kullandığınu tutar.
        /// </summary>
        private Form activeForm = null;
        /// <summary>
        /// Ana panel üzerinde form açmak için kullanılır.
        /// </summary>
        /// <param name="_form">Açılacak form</param>
        private void OpenForm(Form _form)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = _form;
            _form.TopLevel = false;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.StartPosition = FormStartPosition.Manual;
            _form.Dock = DockStyle.None;

            _form.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

            panelMain.Controls.Add(_form);
            panelMain.Tag = _form;
            _form.BringToFront();
            _form.Show();

        }

        
    }
}
