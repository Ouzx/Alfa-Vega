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
        }

        /// <summary>
        /// Test butonu
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {

            SetMenu();
            /*
            GroupBox gp;
            gp = AddGroupBox();
            Button btn;
            btn = AddButton();
            panelFabrics.Controls.Add(AddButton());
            panelFabrics.Controls.Add(AddButton());
            panelFabrics.Controls.Add(gp);
            gp.Controls.Add(btn);
            */
            /*
            Factories factories = new Factories();
            panelBase.Controls.Add(factories.AddButton(0, "Fabrikalar"));
            panelBase.Controls.Add(factories.AddPanel());

            Factories factoriez = new Factories();
            factories.panel.Controls.Add(factoriez.AddButton(1, "Fabrika 1"));
            factories.panel.Controls.Add(factoriez.AddPanel());
            factories.ExtendPanel();

            factoriez.SubMenu = new List<Departments>();
            factoriez.SubMenu.Add(new Departments());
            factoriez.panel.Controls.Add(factoriez.SubMenu[0].AddButton(2, "Departmanlar"));
            factoriez.panel.Controls.Add(factoriez.SubMenu[0].AddPanel());


            factoriez.SubMenu[0].departments = new List<Departments>();
            factoriez.SubMenu[0].departments.Add(new Departments());
            factoriez.SubMenu[0].panel.Controls.Add(factoriez.SubMenu[0].departments[0].AddButton(1, "Departman 1"));
            factoriez.SubMenu[0].panel.Controls.Add(factoriez.SubMenu[0].departments[0].AddPanel());



            factories.SubMenu[0].departments = new List<Departments>();
            factories.SubMenu[0].departments.Add(new Departments());
            factories.SubMenu[0].panel.Controls.Add(factories.SubMenu[0].departments[0].AddPanel());
            factories.SubMenu[0].departments[0].AddButton(3, "Departman 1");

            factories.SubMenu[0].departments[0].SubMachines = new List<Machines>();
            factories.SubMenu[0].departments[0].SubMachines.Add(new Machines());
            factories.SubMenu[0].departments[0].panel.Controls.Add(factories.SubMenu[0].departments[0].SubMachines[0].AddPanel());
            factories.SubMenu[0].departments[0].SubMachines[0].AddButton(4, "Makineler");

            factories.SubMenu[0].departments[0].SubMachines[0].machines = new List<Machines>();
            factories.SubMenu[0].departments[0].SubMachines[0].machines.Add(new Machines());
            factories.SubMenu[0].departments[0].SubMachines[0].panel.Controls.Add(factories.SubMenu[0].departments[0].SubMachines[0].machines[0].AddPanel());
            factories.SubMenu[0].departments[0].SubMachines[0].machines[0].AddButton(5, "Makine 1");
            */
            /*           Factories factories = new Factories();
            panelBase.Controls.Add(factories.AddButton(0, "Fabrikalar"));
            panelBase.Controls.Add(factories.AddPanel());

            factories.SubMenu = new List<Departments>();
            Departments temp = new Departments();
            factories.SubMenu.Add(temp);
            factories.ExtendPanel();
            factories.ExtendPanel();

            factories.panel.Controls.Add(factories.SubMenu[0].AddButton(2, "Departmanlar"));
            factories.panel.Controls.Add(factories.SubMenu[0].AddPanel());
            
            factories.SubMenu[0].SubMachines = new List<Machines>();
            Machines machines = new Machines();
            factories.SubMenu[0].SubMachines.Add(machines);
            factories.SubMenu[0].panel.Controls.Add(factories.SubMenu[0].SubMachines[0].AddButton(3, "Makine 1"));
            factories.SubMenu[0].panel.Controls.Add(factories.SubMenu[0].SubMachines[0].AddPanel());
            factories.SubMenu[0].ExtendPanel();
            
            */


        }
        VegaSystem vegas = new VegaSystem();
        public static SideMenu BaseMenu;
        private bool done = false;
        public void SetMenu()
        {
            if (activeForm != null)
            {
                vegas.ClearMenu();
                Selected.MenuID = new Point3D(0, 0, 0);
            }


            vegas.GetMenu(); //Verileri listelere ekler
            if (!done)
            {
                for (int i = 5; i >= 0; i--)
                {

                    if (Selected.Menu[i].Count > 0)
                    {
                        //Parent
                        Selected.Parents.Add(new SideMenu(i + 10, ((Selected.Units)i).ToString(), BaseMenu));
                        //Selected.Parents[i].panel.Controls.Add()
                        for (int j = Selected.Menu[i].Count-1; j >= 0; j--)
                        {
                            Point3D id = new Point3D(i, j, 0);
                            SideMenu temp = new SideMenu(id);
                            Selected.Parents[5 - i].panel.Controls.Add(temp.AddButton(i, Selected.Menu[i][j][1]));
                            temp.ExtendPanel(Selected.Parents[5 - i].panel);
                        }
                    }
                    else continue;
                }
                done = true;
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
