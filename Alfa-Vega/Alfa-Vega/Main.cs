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
            SideMenu Factories = new SideMenu(panelBase, Selected.Units.FACTORIES);
            for (int i = Selected.Menu[0].Count - 1; i >= 0; i--)//Fabrikalar
            {
                SideMenu SubFactories = new SideMenu(Factories.panel, Selected.Menu[0][i][0], Selected.Menu[0][i][1],
                                                        Selected.Menu[0][i][2], Selected.Units.FACTORIES);
                if (Selected.Menu[1].Count > 0)
                {
                    SideMenu Departments = new SideMenu(SubFactories.panel, Selected.Units.DEPARTMENTS);
                    for (int j = Selected.Menu[1].Count - 1; j >= 0; j--)
                    {
                        SideMenu SubDepartments = new SideMenu();
                        if (Selected.Menu[1][j][2] == SubFactories.ID)
                        {
                            SubDepartments = new SideMenu(Departments.panel, Selected.Menu[1][j][0], Selected.Menu[1][j][1], Selected.Menu[1][j][2], Selected.Units.DEPARTMENTS);
                        }
                        if (SubDepartments.panel != null)
                        {
                            for (int k = 2; k < 5; k++)
                            {
                                if (Selected.Menu[k].Count > 0)
                                {
                                    SideMenu SubMenu = new SideMenu(SubDepartments.panel, (Selected.Units)k);
                                    for (int l = Selected.Menu[k].Count - 1; l >= 0; l--)
                                    {
                                        
                                        if (Selected.Menu[k][l][2] == SubDepartments.ID)
                                        {
                                            SideMenu SubSubMenu = new SideMenu(SubMenu.panel, Selected.Menu[k][j][0], Selected.Menu[k][j][1], Selected.Menu[k][j][2], (Selected.Units)k);
                                            for (int m = Selected.Menu[5].Count - 1; m >= 0; m--)
                                            {
                                                if(Selected.Menu[5][m][2][0].ToString() == k.ToString())
                                                {
                                                    
                                                    int temp = Convert.ToInt32(Selected.Menu[5][m][2].Remove(0,1));
                                                    if(SubSubMenu.OwnerID == temp.ToString())
                                                    {
                                                        SideMenu vega = new SideMenu(SubMenu.panel, Selected.Menu[5][m][0], Selected.Menu[5][m][1], Selected.Menu[5][m][2], Selected.Units.VEGAS);
                                                    }
                                                }
                                            }
                                        }
                                        
                                       
                                    }
                                    
                                    if (SubMenu.panel.Controls.Count == 0)
                                    {
                                        SubDepartments.panel.Controls.Remove(SubMenu.panel);
                                        SubDepartments.panel.Controls.Remove(SubMenu.button);
                                    }
                                    
                                }
                            }
                        }
                    }
                    
                    // Cleaner
                    if (Departments.panel.Controls.Count == 0)
                    {
                        Factories.panel.Controls.Remove(SubFactories.panel);
                    }
                    
                }
                
            }
        }
        

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
