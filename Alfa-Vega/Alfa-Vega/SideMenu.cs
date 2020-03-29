using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Alfa_Vega
{
    /// <summary>
    /// Yan menüde kullanılacak butonları ayarlayan ana sınıf.
    /// Bir panel bir butondan oluşur.
    /// Tasarladığımız yapıya göre:
    /// Ana Menü:
    ///     Alt Menü1:
    ///     Alt Menü2:
    ///         Alt Menü 2.1:
    ///         Alt Menü 2.2:
    ///             Alt Menü 2.2.1:
    ///             Alt Menü 2.2.2:
    /// Yapısı ele alınır.
    /// Menüleri açmak ve kapatmak için buton kullanılır.
    /// Menü içeriklerini saklamak içinse paneller kullanılır.
    /// </summary>
    public class SideMenu
    {
        public SideMenu(int _type, string _name, SideMenu _parent)
        {
            ParentMenu = _parent;
            ParentMenu.panel.Controls.Add(AddPanel());
            //ExtendPanel();
            ParentMenu.panel.Controls.Add(AddButton(_type, _name));
            //Main.BaseMenu = this;
        }
        public SideMenu(Point3D _id)
        {
            //ParentMenu.panel.Controls.Add(AddButton(_type, _name));
            ID = _id;
        }
        /// <summary>
        /// Base menü oluşturmak için.
        /// </summary>
        public SideMenu(Panel _panel)
        {
            panel = _panel;
        }

        /// <summary>
        /// Menünün altındaki menüleri içerisinde barınıdırır.
        /// </summary>
        public Panel panel { get; set; }
        /// <summary>
        /// Menüyü açan kapatan buton.
        /// </summary>
        public Button button { get; set; }
        public Padding Padding { get; set; }

        /// <summary>
        /// Birimin bağlı olduğu birim.
        /// </summary>
        public SideMenu ParentMenu { get; set; }

        /// <summary>
        /// Menü elemanın Parent olup olmadığını tutar.
        /// </summary>
        public bool isParent { get; set; }
        /// <summary>
        /// Menünün temsil ettiği ID.
        /// </summary>
        public Point3D ID { get; set; }

        /// <summary>
        /// Belirtilen ayarlarda panel oluşturur.
        /// </summary>
        public Panel AddPanel()
        {
            panel = new Panel();
            panel.Size = new Size(200, 5);
            panel.Dock = DockStyle.Top;
            panel.BackColor = Color.Transparent;
            panel.BorderStyle = BorderStyle.None;
            panel.Enabled = true;
            panel.Visible = true;
            return panel;
        }
        /// <summary>
        /// Paneli istenilen ölçüde uzatır.
        /// </summary>
        public void ExtendPanel(Panel _panel)
        {
            //ParentMenu.panel.Size += new Size(panel.Size.Width, panel.Size.Height + 45);
            _panel.Size += new Size(_panel.Size.Width, _panel.Size.Height + 45);
        }
        /// <summary>
        /// Menü butonu oluşturur.
        /// </summary>
        /// <param name="_type">Buton tipi</param>
        /// <param name="_text">Buton texti</param>
        /// <returns></returns>
        public Button AddButton(int _type, string _text)
        {
            button = new Button();

            button.Size = new Size(200, 45);
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.Text = _text;
            button.ForeColor = Color.White;
            switch (_type)
            {
                //Mains
                case 10: //Fabrika
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.Image = Properties.Resources.icons8_factory;
                    button.Text = "Fabrikalar";
                    break;
                case 11: //Departman
                    button.Padding = new Padding(20, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_module;
                    button.Text = "Departmanlar";
                    break;
                case 12: //Mekan
                    button.Padding = new Padding(60, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_place_marker_32px;
                    button.Text = "Mekanlar";
                    break;
                case 13: //Makine
                    button.Padding = new Padding(60, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_robot_1;
                    button.Text = "Makineler";
                    break;
                case 14: //Çalışan
                    button.Padding = new Padding(60, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_workers;
                    button.Text = "Çalışanlar";
                    break;
                case 15: //VEGA
                    button.Padding = new Padding(60, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_vegas;
                    button.ForeColor = Color.MediumOrchid;
                    button.Text = "VEGA";
                    break;

                //Subs
                case 0: //Fabrika
                    button.Padding = new Padding(0, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_manufacturing;
                    break;
                case 1:
                    //Sub Departman
                    button.Padding = new Padding(40, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_module_11;
                    break;
                case 2: //Mekan
                    button.Padding = new Padding(80, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_place_marker_32px;
                    break;
                case 3: //Makine
                    button.Padding = new Padding(80, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_cnc_machine_1;
                    break;
                case 4: //Çalışan
                    button.Padding = new Padding(80, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_worker;
                    break;
                case 5: //Vega
                    button.Padding = new Padding(80, 0, 0, 0);
                    button.Image = Properties.Resources.icons8_raspberry;
                    button.ForeColor = Color.MediumOrchid;
                    break;

                default:
                    break;
            }

            button.Font = new Font("Century Gothic", 11);
            button.Location = new Point(0, 200);
            button.Dock = DockStyle.Top;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(17, 24, 32);
            button.Enabled = true;
            button.Visible = true;
            return button;
        }

        /// <summary>
        /// Menüyü gizler.
        /// </summary>
        public void Hide()
        {
            panel.Visible = false;
            button.Visible = false;
        }
        /// <summary>
        /// Menüyü açar
        /// </summary>
        public void Show()
        {
            panel.Visible = true;
            button.Visible = true;
        }

    }
}
