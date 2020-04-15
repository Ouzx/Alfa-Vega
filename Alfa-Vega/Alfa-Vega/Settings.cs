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
        #region ENABLE & DISABLE
        public Settings()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            timer.Start();

            
            unit = Unit.FACTORIES;
            mode = Mode.Add;
            Clear();
            GetTyp();
            GetOwner();
        }

        public static Unit unit = Unit.FACTORIES;
        public static Mode mode = Mode.Add;
        public enum Mode
        {
            Add,
            Edit,
            Delete
        }
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
        private void timer_Tick(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Add:
                    gbEdit.Enabled = false;
                    gbInitial.Enabled = true;
                    break;
                case Mode.Edit:
                    gbEdit.Enabled = true;
                    gbInitial.Enabled = true;
                    break;
                case Mode.Delete:
                    gbInitial.Enabled = false;
                    gbEdit.Enabled = true;
                    break;
            }

            if (unit == Unit.WORKERS) { gbWorker.Enabled = true; gbPlace.Enabled = false; }
            else if (unit == Unit.PLACES) { gbPlace.Enabled = true; gbWorker.Enabled = false; }
            else { gbWorker.Enabled = false; gbPlace.Enabled = false; }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = (Control)sender;
            
            int ti = btn.TabIndex;
            if (ti > 2)
            {
                MoveIndicator((Control)sender);
                unit = (Unit)(ti - 3);
            }
            else
            {
                MoveIndicator2((Control)sender);
                mode = (Mode)ti;
            }

            Clear();
            switch (mode)
            {
                case Mode.Add:
                    GetTyp();
                    GetOwner();
                    break;
                case Mode.Edit:
                    GetName();
                    GetTyp();
                    GetOwner();
                    break;
                case Mode.Delete:
                    GetName();
                    break;
            }

        }
        #endregion

        #region ServerSide
         VegaSystem vs = new VegaSystem();

        private void GetName()
        {
            cbName.Items.Clear();
            cbName.Text = "";
            vs.GetParams(unit.ToString(), Selected.Mode.Name);
            if (Selected.NameName.Count > 0)
            {
                cbName.Items.AddRange(Selected.NameName.ToArray());
                cbName.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Geçerli bir birim bulunamadı! \n" +
                            "Önce geçerli bir birim oluşturun.\n" +
                            "Detaylar için sistem yöneticinize başvurun.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }
        private void GetTyp()
        {
            cbType.Items.Clear();
            cbType.Text = "";
            string[] Types = new string[] {"FACTORY_TYPES","DEPARTMENT_TYPES","PLACE_TYPES",
                                            "MACHINE_TYPES","WORKER_TYPES","PRODUCT_TYPES","VEGA_TYPES"};
            vs.GetParams(Types[(int)unit], Selected.Mode.Type);

            if (Selected.TypeName.Count > 0)
            {
                cbType.Items.AddRange(Selected.TypeName.ToArray());
                cbType.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Geçerli bir tip bulunamadı! \n" +
                               "Önce geçerli bir tip oluşturun.\n" +
                               "Detaylar için sistem yöneticinize başvurun.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }
        private void GetOwner()
        {
            Selected.OwnerInt.Clear();
            Selected.OwnerName.Clear();
            cbOwner.Items.Clear();
            cbOwner.Text = "";
            string temp = "";
            switch (unit)
            {
                case Unit.FACTORIES:
                    temp = "USERS";
                    break;
                case Unit.DEPARTMENTS:
                    temp = "FACTORIES";
                    break;
                case Unit.PLACES:
                    temp = "DEPARTMENTS";
                    break;
                case Unit.MACHINES:
                    temp = "DEPARTMENTS";
                    break;
                case Unit.WORKERS:
                    temp = "DEPARTMENTS";
                    break;
                case Unit.PRODUCTS:
                    temp = "USERS";
                    break;
                case Unit.VEGAS:
                    temp = "DEPARTMENTS";
                    break;
            }
            if (unit == Unit.VEGAS) vs.GetVegas();
            else vs.GetParams(temp, Selected.Mode.Owner);

            if (Selected.OwnerName.Count > 0)
            {
                cbOwner.Items.AddRange(Selected.OwnerName.ToArray());
                cbOwner.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Bağlılık Bulunamadı! \n" +
                               "Önce bir bağlılık oluşturun.\n" +
                               "Detaylar için sistem yöneticinize başvurun.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }

        private void Read()
        {
            List<string> data = vs.Get(unit.ToString(), Selected.NameInt[cbName.SelectedIndex]);
            if (data.Count > 0)
            {
                tbName.Text = data[2];
                try
                {
                    cbType.SelectedIndex = Selected.TypeInt.IndexOf(Convert.ToInt32(data[1]));
                    cbOwner.SelectedIndex = Selected.OwnerInt.IndexOf(Convert.ToInt32(data[3]));
                }
                catch { }
                if (unit == Unit.WORKERS) workerRFID.Text = data[4];
                else if (unit == Unit.PLACES) placeRFID.Text = data[4];
            }
        }
        private void Clear()
        {
            cbName.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            tbName.Text = "";
            //cbOwner.SelectedIndex = 0;
            workerRFID.Text = "";
            placeRFID.Text = "";
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbName.Items.Count > 0)
            {
                if (cbName.SelectedIndex == -1) cbName.SelectedIndex = 0;
                else Read();
                
            }
        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Items.Count > 0)
            {
                if (cbType.SelectedIndex == -1) cbType.SelectedIndex = 0;  
            }
        }
        private void cbOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOwner.Items.Count > 0)
            {
                if (cbOwner.SelectedIndex == -1) cbName.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("İşlemi Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                switch (mode)
                {
                    case Mode.Add:
                        if(unit == Unit.WORKERS)
                            vs.Add(unit.ToString(), Selected.TypeInt[cbType.SelectedIndex], "\"" + tbName.Text + "\"",
                             Selected.OwnerInt[cbOwner.SelectedIndex], "\"" + workerRFID.Text + "\"");

                        else if(unit == Unit.PLACES)
                            vs.Add(unit.ToString(), Selected.TypeInt[cbType.SelectedIndex], "\"" + tbName.Text + "\"",
                             Selected.OwnerInt[cbOwner.SelectedIndex], "\"" + placeRFID.Text + "\"");

                        else vs.Add(unit.ToString(), Selected.TypeInt[cbType.SelectedIndex], "\"" + tbName.Text + "\"",
                            Selected.OwnerInt[cbOwner.SelectedIndex]);
                        break;

                    case Mode.Edit:
                        if (unit == Unit.WORKERS)
                            vs.Edit(unit.ToString(), Selected.NameInt[cbName.SelectedIndex], Selected.TypeInt[cbType.SelectedIndex],
                             "\"" + tbName.Text + "\"", Selected.OwnerInt[cbOwner.SelectedIndex], "\"" + workerRFID.Text + "\"");

                        else if (unit == Unit.PLACES)
                            vs.Edit(unit.ToString(), Selected.NameInt[cbName.SelectedIndex], Selected.TypeInt[cbType.SelectedIndex],
                            "\"" + tbName.Text + "\"", Selected.OwnerInt[cbOwner.SelectedIndex], "\"" + placeRFID.Text + "\"");

                        else vs.Edit(unit.ToString(), Selected.NameInt[cbName.SelectedIndex], Selected.TypeInt[cbType.SelectedIndex],
                            "\"" + tbName.Text + "\"", Selected.OwnerInt[cbOwner.SelectedIndex]);
                        break;

                    case Mode.Delete:
                        vs.Delete(unit.ToString(), Selected.NameInt[cbName.SelectedIndex]);
                        break;
                }
                Clear();
                GetName();
                GetTyp();
                GetOwner();
            }
        }
        #endregion
    }
}
