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
            Factory,
            Department,
            Place,
            Machine,
            Worker,
            Product,
            VEGA
        }
        public Mode SelectedMode = Mode.Add;
        Unit SelectedUnit = Unit.Factory;
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
            SelectedUnit = Unit.Factory;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            SelectedUnit = Unit.Department;
            MoveIndicator((Control)sender);
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }

        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            SelectedUnit = Unit.Place;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = true;
            }

        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            SelectedUnit = Unit.Machine;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }

        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            SelectedUnit = Unit.Worker;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = true;
                gbPlace.Enabled = false;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }

        }
        private void btnVega_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            SelectedUnit = Unit.VEGA;
            if (SelectedMode != Mode.Delete)
            {
                gbWorker.Enabled = false;
                gbPlace.Enabled = false;
            }
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
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MoveIndicator2((Control)sender);
            SelectedMode = Mode.Delete;
            gbInitial.Enabled = false;
            gbPlace.Enabled = false;
            gbWorker.Enabled = false;
            gbEdit.Enabled = true;

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            gbEdit.Enabled = false;
            gbWorker.Enabled = false;
            gbPlace.Enabled = false;

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
            dialogResult = MessageBox.Show("İşlemi Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                switch (SelectedMode)
                {
                    case Mode.Add:
                        switch (SelectedUnit)
                        {
                            case Unit.Factory:
                                try
                                {
                                    vegas.Add("FACTORIES",cbType.SelectedIndex,tbName.Text,cbOwner.SelectedIndex);
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Department:
                                try
                                {
                                    vegas.Add("DEPARTMENTS", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Place:
                                try
                                {
                                    vegas.Add("PLACES", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex,placeRFID.Text);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Machine:
                                try
                                {
                                    vegas.Add("MACHINES", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Worker:
                                try
                                {
                                    vegas.Add("WORKERS", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex,workerRFID.Text);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Product:
                                try
                                {
                                    vegas.Add("PRODUCTS", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.VEGA:
                                try
                                {
                                    vegas.Add("VEGAS", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                        }
                        break;
                    case Mode.Edit:
                        switch (SelectedUnit)
                        {
                            case Unit.Factory:
                                try
                                {
                                    vegas.Set("FACTORIES", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Department:
                                try
                                {
                                    vegas.Set("DEPARTMENTS", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Place:
                                try
                                {
                                    vegas.Set("PLACES", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex, placeRFID.Text);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Machine:
                                try
                                {
                                    vegas.Set("MACHINES", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Worker:
                                try
                                {
                                    vegas.Set("WORKERS", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex, workerRFID.Text);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.Product:
                                try
                                {
                                    vegas.Set("PRODUCTS", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.VEGA:
                                try
                                {
                                    vegas.Set("VEGAS", cbType.SelectedIndex, tbName.Text, cbOwner.SelectedIndex);
                                }
                                catch
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun!",
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                        }
                        break;
                    case Mode.Delete:
                        switch (SelectedUnit)
                        {
                            case Unit.Factory:
                                vegas.Delete("FACTORIES", cbName.SelectedIndex);
                                break;
                            case Unit.Department:
                                vegas.Delete("DEPARTMENTS", cbName.SelectedIndex);
                                break;
                            case Unit.Place:
                                vegas.Delete("PLACES", cbName.SelectedIndex);
                                break;
                            case Unit.Machine:
                                vegas.Delete("MACHINES", cbName.SelectedIndex);
                                break;
                            case Unit.Worker:
                                vegas.Delete("WORKERS", cbName.SelectedIndex);
                                break;
                            case Unit.Product:
                                vegas.Delete("PRODUCTS", cbName.SelectedIndex);
                                break;
                            case Unit.VEGA:
                                vegas.Delete("VEGAS", cbName.SelectedIndex);
                                break;
                        }
                        break;
                }
            }
        }
    }
}
