using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa_Vega
{
    public class SideMenu
    {
        #region ctors
        public SideMenu(Panel _parent,string _id, string _name, string _ownerID, Selected.Units _unit, bool _isParent)
        {
            Parent = _parent;

            ID = _id;
            Name = _name;
            OwnerID = _ownerID;
            Unit = _unit;
            isParent = _isParent;

            AddMenu();
        }

        public SideMenu()
        {

        }
        #endregion



        #region variables
        public string ID { get; set; }
        public string Name { get; set; }
        public string OwnerID { get; set; }
        public Selected.Units Unit { get; set; }
        public bool isParent { get; set; }

        public Button button { get; set; }
        public Panel panel { get; set; }
        public Padding Padding { get; set; }
        public Panel Parent { get; set; }
        #endregion


        #region methods
        public Panel AddPanel()
        {
            panel = new Panel();
            panel.Size = new Size(200, 0);
            panel.Dock = DockStyle.Top;
            panel.BackColor = Color.Transparent;
            panel.BorderStyle = BorderStyle.None;
            panel.Enabled = true;
            panel.Visible = false;
            panel.AutoSize = true;
            Parent.Controls.Add(panel);
            return panel;
        }

        public Button AddParentMenu()
        {
            button = new Button();
            button.Size = new Size(200, 45);
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.Text = Name;
            button.ForeColor = Color.White;
            button.ImageAlign = ContentAlignment.MiddleLeft;

            switch (Unit)
            {
                //Mains
                case Selected.Units.FACTORIES: //Fabrika
                    button.Padding = new Padding(10, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_factory;
                    button.Text = "Fabrikalar";
                    break;
                case Selected.Units.DEPARTMENTS: //Departman
                    button.Padding = new Padding(40, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_module;
                    button.Text = "Departmanlar";
                    break;
                case Selected.Units.PLACES: //Mekan
                    button.Padding = new Padding(80, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_marker;
                    button.Text = "Mekanlar";
                    break;
                case Selected.Units.MACHINES: //Makine
                    button.Padding = new Padding(80, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_robot_1;
                    button.Text = "Makineler";
                    break;
                case Selected.Units.WORKERS: //Çalışan
                    button.Padding = new Padding(80, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_workers;
                    button.Text = "Çalışanlar";
                    break;
                default: break;
            }

            button.Font = new Font("Century Gothic", 11);
            button.Location = new Point(0, 200);
            button.Dock = DockStyle.Top;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(17, 24, 32);
            button.Enabled = true;
            button.Visible = true;
            button.Click += new EventHandler(button_Click);
            Parent.Controls.Add(button);
            return button;
        }
        public Button AddSubMenu()
        {
            button = new Button();
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Size = new Size(200, 45);
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.Text = Name;
            button.ForeColor = Color.White;
            switch (Unit)
            {
                //Subs
                case Selected.Units.FACTORIES: //Fabrika
                    button.Padding = new Padding(20, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_manufacturing;
                    break;
                case Selected.Units.DEPARTMENTS:
                    //Sub Departman
                    button.Padding = new Padding(60, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_module_11;
                    break;
                case Selected.Units.PLACES: //Mekan
                    button.Padding = new Padding(100, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_place_marker_32px;
                    break;
                case Selected.Units.MACHINES: //Makine
                    button.Padding = new Padding(100, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_cnc_machine_1;
                    break;
                case Selected.Units.WORKERS: //Çalışan
                    button.Padding = new Padding(100, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_worker;
                    break;
                case Selected.Units.VEGAS: //Vega
                    button.Padding = new Padding(100, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_raspberry;
                    button.ForeColor = Color.MediumOrchid;
                    break;
                default: break;
            }

            button.Font = new Font("Century Gothic", 11);
            button.Location = new Point(0, 200);
            button.Dock = DockStyle.Top;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(17, 24, 32);
            button.Enabled = true;
            button.Visible = true;
            button.Click += new EventHandler(button_Click);
            Parent.Controls.Add(button);
            //Parent.Controls.SetChildIndex(button, 0);
            return button;
        }
        public void AddMenu()
        {
            if (!isParent)
            {
                AddPanel();
                AddSubMenu();
            }
            else
            {
                AddPanel();
                AddParentMenu();
            }
        }

        public void button_Click(object sender, EventArgs e)
        {
            if (panel.Visible)
            {
                Hide();
            }
            else
            {
                Show();
            }
            if (!isParent)
            {
                OpenForm.OpnForm(new INFO());
            }
        }

        public void Hide()
        {
            panel.Visible = false;
        }
        public void Show()
        {
            panel.Visible = true;
        }


        #endregion
    }
}
