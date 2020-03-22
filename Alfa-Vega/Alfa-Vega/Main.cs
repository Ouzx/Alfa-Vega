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
        #region Menu

        class SideMenu
        {
            public Panel panel { get; set; }
            public Button button { get; set; }
            public Padding Padding { get; set; }

            public Panel AddPanel()
            {
                panel = new Panel();
                panel.Size = new Size(200, 45);
                panel.Dock = DockStyle.Top;
                panel.BackColor = Color.Transparent;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.Enabled = true;
                panel.Visible = true;
                return panel;
            }
            public void ExtendPanel()
            {
                panel.Size += new Size(panel.Size.Width, panel.Size.Height + 45);

            }

            public Button AddButton(byte _type, string _text)
            {
                button = new Button();

                button.Size = new Size(200, 45);
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.Text = _text;
                switch (_type)
                {
                    //Mains
                    case 0:
                        button.ImageAlign = ContentAlignment.MiddleLeft;
                        button.Image = Properties.Resources.icons8_factory;
                        break;
                    case 1:
                        button.Padding = new Padding(0, 0, 0, 0);
                        button.Image = Properties.Resources.icons8_manufacturing;
                        //Fabrika
                        break;
                    case 2:
                        button.Padding = new Padding(20, 0, 0, 0);
                        button.Image = Properties.Resources.icons8_module;
                        //Departman
                        break;
                    case 3:
                        //Sub Departman
                        button.Padding = new Padding(40, 0, 0, 0);
                        button.Image = Properties.Resources.icons8_module_11;
                        break;
                    case 4:
                        button.Padding = new Padding(60, 0, 0, 0);
                        button.Image = Properties.Resources.icons8_server;
                        //Makine
                        break;
                    case 5:
                        button.Padding = new Padding(60, 0, 0, 0);
                        button.Image = Properties.Resources.icons8_workers;
                        //Çalışan
                        break;
                    case 6:
                        //Mekan
                        button.Padding = new Padding(60, 0, 0, 0);
                        button.Image = Properties.Resources.icons8_place_marker_50px;
                        break;

                    //Subs
                    case 7:
                        //Makine
                        button.Padding = new Padding(80, 0, 0, 0);
                        button.Image = Properties.Resources.icons8_cnc_machine_1;
                        break;
                    case 8:
                        //Çalışan
                        button.Padding = new Padding(80, 0, 0, 0);
                        button.Image = Properties.Resources.icons8_worker;
                        break;
                    case 9:
                        //Mekan
                        button.Padding = new Padding(80, 0, 0, 0);
                        button.Image = Properties.Resources.icons8_place_marker_32px;
                        break;
                }
                button.Font = new Font("Century Gothic", 11);
                button.Location = new Point(0, 200);
                button.Dock = DockStyle.Top;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 2;
                button.BackColor = Color.Transparent;
                button.Enabled = true;
                button.Visible = true;

                return button;
            }

        }
        #region classes
        class Factories : SideMenu
        {
            public List<Factories> factories { get; set; }
            public List<Departments> SubMenu { get; set; }

        }
        class Departments : SideMenu
        {
            public List<Departments> departments { get; set; }
            public List<Machines> SubMachines { get; set; }
            public List<Workers> SubWorkes { get; set; }
            public List<Places> SubPlaces { get; set; }
        }
        class Machines : SideMenu
        {
            public List<Machines> machines { get; set; }
        }
        class Workers : SideMenu
        {
            public List<Workers> workers { get; set; }
        }
        class Places : SideMenu
        {
            public List<Places> places { get; set; }
        }
        #endregion
        #endregion



        private void button1_Click(object sender, EventArgs e)
        {
            INFO _form = new INFO();
            _form.TopLevel = false;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.StartPosition = FormStartPosition.Manual;
            _form.Dock = DockStyle.None;
            panelMain.Controls.Add(_form);
            panelMain.Tag = _form;
            _form.Anchor = AnchorStyles.Right;
            _form.Anchor = AnchorStyles.Left;
            _form.Anchor = AnchorStyles.Top;
            _form.BringToFront();
            _form.Show();
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
        
    }
}
