using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Alfa_Vega
{
    
    class VegaSystem : DB
    {

        /// <summary>
        /// Veri tabanına veri ekler
        /// </summary>
        public void Add(string _table, params object[] _data)
        {
            try
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendFormat("INSERT INTO {0} VALUES({1}, ", _table, GetLastID(_table) + 1);
                for (int i = 0; i < _data.Length; i++)
                {
                    cmd.Append(_data[i].ToString() + ",");
                }
                cmd.Remove(cmd.Length - 1, 1);
                cmd.Append(")");
                //MessageBox.Show(cmd.ToString());
                Write(cmd.ToString());
                MessageBox.Show("Ekleme işlemi başarlı!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Veri tabanından veri çeker
        /// </summary>
        public List<string> Get(string _table, int _ID)
        {
            try
            {
                return Read(_table, _ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Veri tabanındaki bir veriyi düzenler
        /// </summary>
        public void Set(string _table, int _id, params object[] _data)
        {
            try
            {
                Edit(_table, _id, _data);
                MessageBox.Show("Düzenleme işlemi başarlı!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Veri tabanındaki bir veriyi siler
        /// </summary>
        public void Delete(string _table, int _id)
        {
            try
            {
                Remove(_table, _id);
                MessageBox.Show("Silme işlemi başarlı!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

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
    class SideMenu : VegaSystem
    {
        /// <summary>
        /// Menünün altındaki menüleir içerisinde barınıdırır.
        /// </summary>
        public Panel panel { get; set; }
        /// <summary>
        /// Menüyü açan kapatan buton.
        /// </summary>
        public Button button { get; set; }
        public Padding Padding { get; set; }

        /// <summary>
        /// Belirtilen ayarlarda panel oluşturur.
        /// </summary>
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
        /// <summary>
        /// Paneli istenilen ölçüde uzatır.
        /// </summary>
        public void ExtendPanel(int _height)
        {
            panel.Size += new Size(panel.Size.Width, panel.Size.Height + _height);

        }

        /// <summary>
        /// Menü butonu oluşturur.
        /// </summary>
        /// <param name="_type">Buton tipi</param>
        /// <param name="_text">Buton texti</param>
        /// <returns></returns>
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
    /// <summary>
    /// Bir işletme/kuruluş birden fazla fabrikaya/atölyeye sahip olabileceğinden
    /// defalarce kez fabrika oluşturmak için fabrika sınıfı kullanılır.
    /// Bizim mimarimize göre fabrikalar birbirlerinden farklı departmanlardan oluşur.
    /// </summary>
    class Factories : SideMenu
    {
        /// <summary>
        /// Fabrika listesi
        /// </summary>
        public List<Factories> factories { get; set; }
        /// <summary>
        /// Departman listesi
        /// </summary>
        public List<Departments> SubMenu { get; set; }

    }
    /// <summary>
    /// Bir fabrika birden fazla departman/bölümden oluşabilir.
    /// Departmanlar Makinlerden, Çalışanlardan, Mekanlardan ve Vega Kartlarından oluşur.
    /// </summary>
    class Departments : SideMenu
    {
        public List<Departments> departments { get; set; }
        public List<Machines> SubMachines { get; set; }
        public List<Workers> SubWorkes { get; set; }
        public List<Places> SubPlaces { get; set; }
        public List<Vega> SubVegas { get; set; }
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
    /// <summary>
    /// Vegalar her yerde bulunabilir. Vegaların ham verilerini görmek için bu menü kullanılır.
    /// </summary>
    class Vega : SideMenu
    {
        public List<Vega> vegas { get; set; }
    }
}
