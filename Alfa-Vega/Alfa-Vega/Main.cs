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
        public static Panel pnl = null;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            pnl = panelMain;
            SetMenu();
        }

        VegaSystem vegas = new VegaSystem();
        
        public void SetMenu()
        {
            vegas.GetMenu();
            //int Total = GetLength();
            SideMenu Factories = new SideMenu(panelBase, "-1", "-1", "-1", Selected.Units.FACTORIES, true);
            SideMenu Departments;
            SideMenu SubDepartments = new SideMenu();

            SideMenu SubMenu;
            SideMenu SubSubMenu;
            for (int i = Selected.Menu[0].Count - 1; i >= 0; i--)
            {
                SideMenu SubFactories = new SideMenu(Factories.panel, Selected.Menu[0][i][0], Selected.Menu[0][i][1], Selected.Menu[0][i][2], Selected.Units.FACTORIES, false);
                if (Selected.Menu[1].Count > 0)
                {
                    Departments = new SideMenu(SubFactories.panel, "-1", "-1", "-1", Selected.Units.DEPARTMENTS, true);
                    for (int j = Selected.Menu[1].Count - 1; j >= 0; j--)
                    {
                        if (Selected.Menu[1][j][2] == SubFactories.ID)
                            SubDepartments = new SideMenu(Departments.panel, Selected.Menu[1][j][0], Selected.Menu[1][j][1], Selected.Menu[1][j][2], Selected.Units.DEPARTMENTS, false);
                        if (SubDepartments.panel != null)
                        {
                            for (int k = 2; k < 5; k++)
                            {
                                if (Selected.Menu[k].Count > 0)
                                {
                                    SubMenu = new SideMenu(SubDepartments.panel, "-1", "-1", "-1", (Selected.Units)k, true);
                                    for (int l = Selected.Menu[k].Count - 1; l >= 0; l--)
                                    {
                                        if (Selected.Menu[k][l][2] == SubDepartments.ID)
                                        {
                                            SubSubMenu = new SideMenu(SubMenu.panel, Selected.Menu[k][j][0], Selected.Menu[k][j][1], Selected.Menu[k][j][2], (Selected.Units)k, false);
                                        }
                                    }
                                    /*
                                    if (SubMenu.panel.Controls.Count == 0)
                                    {
                                        SubDepartments.panel.Controls.Remove(SubMenu.panel);
                                        SubDepartments.panel.Controls.Remove(SubMenu.button);
                                    }
                                    */
                                }
                            }
                        }

                    }
                    /*
                    //Cleaner
                    if (Departments.panel.Controls.Count == 0)
                    {
                        Factories.panel.Controls.Remove(SubFactories.panel);
                    }
                    */
                    
                }
            }
            
        }
        

        /// <summary>
        /// Settings formunu açan buton.
        /// </summary>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings _form = new Settings();
            OpenForm.OpnForm(_form);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            panelBase.Controls.Clear();
            foreach (var v in Selected.Menu) v.Clear();
            SetMenu();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonClock.Text = DateTime.Now.ToString();

        }

        private void ReSize(object sender, EventArgs e)
        {
            OpenForm.ReSize();
        }
    }
}
