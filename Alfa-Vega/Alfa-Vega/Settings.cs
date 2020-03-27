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

        /// <summary>
        /// Yazma modu, Ekleme Modu, Silme Modu
        /// </summary>
        public enum Mode
        {
            Add,
            Edit,
            Delete
        }

        /// <summary>
        /// Birim:Tür Fabrika, Departman, Mekan, Makine, Çalışan, Ürün, VEGA
        /// </summary>
        public enum Unit
        {
            FACTORIES,
            DEPARTMENTS,
            PLACES,
            MACHINES,
            WORKERS,
            PRODUCTS,
            VEGAS
        }

        public Mode SelectedMode = Mode.Add;
        Unit SelectedUnit = Unit.FACTORIES;

        private void MoveIndicator(Control control)
        {
            indicator.Location = new Point(control.Location.X, indicator.Location.Y);
            indicator.Width = control.Width;
            indicator.BringToFront();

        }
        private void MoveIndicator2(Control control)
        {

            indicator2.Location = new Point(control.Location.X, indicator2.Location.Y);
            indicator2.Width = control.Width;
            indicator2.BringToFront();
        }


        private void btnFactory_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            SelectedUnit = Unit.FACTORIES;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }
            GetName(SelectedUnit);
            GetType(SelectedUnit);
            Read();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            SelectedUnit = Unit.DEPARTMENTS;
            MoveIndicator((Control)sender);
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }
            GetName(SelectedUnit);
            GetType(SelectedUnit);
            Read();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            SelectedUnit = Unit.PLACES;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = true;
            }
            GetName(SelectedUnit);
            GetType(SelectedUnit);
            Read();
        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            SelectedUnit = Unit.MACHINES;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }
            GetName(SelectedUnit);
            GetType(SelectedUnit);
            Read();
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            SelectedUnit = Unit.WORKERS;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = true;
                gbPlace.Enabled = false;
            }
            GetName(SelectedUnit);
            GetType(SelectedUnit);
            Read();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }
            GetName(SelectedUnit);
            GetType(SelectedUnit);
            Read();
        }

        private void btnVega_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            SelectedUnit = Unit.VEGAS;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }
            GetName(SelectedUnit);
            GetType(SelectedUnit);
            Read();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MoveIndicator2((Control)sender);
            SelectedMode = Mode.Add;
            gbEdit.Enabled = false;
            gbInitial.Enabled = true;
            gbPlace.Enabled = true;
            gbWorker.Enabled = true;

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            MoveIndicator2((Control)sender);
            SelectedMode = Mode.Edit;
            gbEdit.Enabled = true;
            gbInitial.Enabled = true;
            gbPlace.Enabled = true;
            gbWorker.Enabled = true;
            GetName(SelectedUnit);
            GetType(SelectedUnit);
            Read();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MoveIndicator2((Control)sender);
            SelectedMode = Mode.Delete;
            gbInitial.Enabled = false;
            gbPlace.Enabled = false;
            gbWorker.Enabled = false;
            gbEdit.Enabled = true;
            GetName(SelectedUnit);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            gbEdit.Enabled = false;
            gbWorker.Enabled = false;
            gbPlace.Enabled = false;
            GetType(SelectedUnit);
        }
        VegaSystem vegas = new VegaSystem();

        /// <summary>
        /// Seçili olan modda seçili olan birim için veritabanı işlemi yapar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("İşlemi Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                switch (SelectedMode)
                {
                    case Mode.Add:
                        switch (SelectedUnit)
                        {
                            case Unit.FACTORIES:
                                vegas.Add(Unit.FACTORIES.ToString(),Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;

                            case Unit.DEPARTMENTS:
                                vegas.Add(Unit.DEPARTMENTS.ToString(),Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;

                            case Unit.PLACES:
                                vegas.Add(Unit.PLACES.ToString(),Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID, "\"" + placeRFID.Text + "\"");
                                break;

                            case Unit.MACHINES:
                                vegas.Add(Unit.MACHINES.ToString(),Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;

                            case Unit.WORKERS:
                                vegas.Add(Unit.WORKERS.ToString(),Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID, "\"" + workerRFID.Text + "\"");
                                break;

                            case Unit.PRODUCTS:
                                vegas.Add(Unit.PRODUCTS.ToString(),Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;

                            case Unit.VEGAS:
                                vegas.Add(Unit.VEGAS.ToString(),Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;
                        }
                        break;

                    case Mode.Edit:
                        switch (SelectedUnit)
                        {
                            case Unit.FACTORIES:
                                vegas.Set(Unit.FACTORIES.ToString(), Selected.NameID,Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;

                            case Unit.DEPARTMENTS:
                                vegas.Set(Unit.DEPARTMENTS.ToString(), Selected.NameID,Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;

                            case Unit.PLACES:
                                vegas.Set(Unit.PLACES.ToString(), Selected.NameID,Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID, "\"" + placeRFID.Text + "\"");
                                break;

                            case Unit.MACHINES:
                                vegas.Set(Unit.MACHINES.ToString(), Selected.NameID,Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;

                            case Unit.WORKERS:
                                vegas.Set(Unit.WORKERS.ToString(), Selected.NameID,Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID, "\"" + workerRFID.Text + "\"");
                                break;

                            case Unit.PRODUCTS:
                                vegas.Set(Unit.PRODUCTS.ToString(), Selected.NameID,Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;

                            case Unit.VEGAS:
                                vegas.Set(Unit.VEGAS.ToString(), Selected.NameID,Selected.TypeID, "\"" + tbName.Text + "\"", Selected.OwnerID);
                                break;
                        }
                        break;

                    case Mode.Delete:
                        switch (SelectedUnit)
                        {
                            case Unit.FACTORIES:
                                vegas.Delete(Unit.FACTORIES.ToString(), Selected.NameID);
                                break;

                            case Unit.DEPARTMENTS:
                                vegas.Delete(Unit.DEPARTMENTS.ToString(), Selected.NameID);
                                break;

                            case Unit.PLACES:
                                vegas.Delete(Unit.PLACES.ToString(), Selected.NameID);
                                break;

                            case Unit.MACHINES:
                                vegas.Delete(Unit.MACHINES.ToString(), Selected.NameID);
                                break;

                            case Unit.WORKERS:
                                vegas.Delete(Unit.WORKERS.ToString(), Selected.NameID);
                                break;

                            case Unit.PRODUCTS:
                                vegas.Delete(Unit.PRODUCTS.ToString(), Selected.NameID);
                                break;

                            case Unit.VEGAS:
                                vegas.Delete(Unit.VEGAS.ToString(), Selected.NameID);
                                break;
                        }
                        break;
                }
            }
            Clear();
            GetName(SelectedUnit);
            GetType(SelectedUnit);
            Read();
        }

        private void cbName_SelectedValueChanged(object sender, EventArgs e)
        {
            Read();
        }

        /// <summary>
        /// Formda ilgli alanları serverden okuduğu alana göre doldurur.
        /// </summary>
        private void Read()
        {
            if (cbName.SelectedIndex != -1 && SelectedMode == Mode.Edit)
            {
                List<string> data = vegas.Get(SelectedUnit.ToString(), Selected.NameID);
                
                if (data.Count > 0)
                {
                    cbType.SelectedIndex = Convert.ToInt32(data[1]);
                    tbName.Text = data[2];
                    //cbOwner.SelectedIndex = Convert.ToInt32(data[3]);
                    if(SelectedUnit == Unit.WORKERS )
                    {
                        workerRFID.Text = data[4];
                    }
                    else if(SelectedUnit == Unit.PLACES)
                    {
                        workerRFID.Text = data[4];
                    }
                }
                
                else
                {
                    MessageBox.Show("Veri bulunamdı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }

        }

        /// <summary>
        /// Formu temizler
        /// </summary>
        private void Clear()
        {
            cbName.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            tbName.Text = "";
            cbOwner.SelectedIndex = -1;
            workerRFID.Text = "";
            placeRFID.Text = "";
        }

        
        /// <summary>
        /// İstenilen Type tablosunun verilerini ekler.
        /// </summary>
        private void GetType(Unit _unit)
        {
            if (SelectedMode != Mode.Delete)
            {
                cbType.Items.Clear();
                cbType.Text = "";
                string[] Types = new string[] {"FACTORY_TYPES","DEPARTMENT_TYPES","PLACE_TYPES",
                                           "MACHINE_TYPES","WORKER_TYPES","PRODUCT_TYPES","VEGA_TYPES"};
                vegas.GetParams(Types[(int)_unit], "NAME", Selected.Mode.Type);
                
                if (Selected.TYPES.Count > 0)
                {
                    foreach (List<string> s in Selected.TYPES) 
                    {
                        cbType.Items.Add(s[0]);
                        //Selected.TypeID = Convert.ToInt32(s[0]);
                    }
                    cbType.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// İstenilen bağlılık tablosunun verilerini ekler.
        /// </summary>
        //private void GetOwner(Unit _unit)
        //{
        //    string[] Types = new string[] {"FACTORY_","DEPARTMENT_TYPES","PLACE_TYPES",
        //                                   "MACHINE_TYPES","WORKER_TYPES","PRODUCT_TYPES","VEGA_TYPES"};
        //    List<string> data = vegas.GetParams(Types[(int)_unit], "NAME");
        //    foreach (string s in data) cbType.Items.Add(s);
        //}

        /// <summary>
        /// İstenilen kimlik tablosunun verilerini  ekler.
        /// </summary>
        private void GetName(Unit _unit)
        {
            if (SelectedMode != Mode.Add)
            {
                cbName.Items.Clear();
                cbName.Text = "";
                vegas.GetParams(_unit.ToString(), "NAME", Selected.Mode.Name);
                if (Selected.NAMES.Count > 0)
                {
                    foreach (List<string> s in Selected.NAMES)
                    {
                        cbName.Items.Add(s[1]);
                        //Selected.NameID = Convert.ToInt32(s[0]);
                    }
                    //cbName.SelectedIndex = 0;
                    if (cbName.SelectedItem != null) tbName.Text = cbName.SelectedItem.ToString();
                }
            }
        }

        
        /// <summary>
        /// İstenilen RFID tablosunun verilerini  ekler.
        /// </summary>
        //private void RFID(Unit _unit)
        //{
        //    string[] Types = new string[] {"FACTORY_TYPES","DEPARTMENT_TYPES","PLACE_TYPES",
        //                                   "MACHINE_TYPES","WORKER_TYPES","PRODUCT_TYPES","VEGA_TYPES"};
        //    List<string> data = vegas.GetParams(Types[(int)_unit], "NAME");
        //    foreach (string s in data) cbType.Items.Add(s);
        //}

    }

}
