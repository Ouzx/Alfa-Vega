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

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            gbEdit.Enabled = false;
            gbWorker.Enabled = false;
            gbPlace.Enabled = false;
            cbName.Items.Add("Bill Gaasdtes");

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
                            case Unit.FACTORIES:
                                try
                                {
                                    vegas.Add(Unit.FACTORIES.ToString(),cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.DEPARTMENTS:
                                try
                                {
                                    vegas.Add(Unit.DEPARTMENTS.ToString(), cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.PLACES:
                                try
                                {
                                    vegas.Add(Unit.PLACES.ToString(), cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex,"\"" + placeRFID.Text+"\"");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.MACHINES:
                                try
                                {
                                    vegas.Add(Unit.MACHINES.ToString(), cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.WORKERS:
                                try
                                {
                                    vegas.Add(Unit.WORKERS.ToString(), cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex,"\"" + workerRFID.Text+"\"");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.PRODUCTS:
                                try
                                {
                                    vegas.Add(Unit.PRODUCTS.ToString(), cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.VEGAS:
                                try
                                {
                                    vegas.Add(Unit.VEGAS.ToString(), cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                        }
                        break;
                    case Mode.Edit:
                        switch (SelectedUnit)
                        {
                            case Unit.FACTORIES:
                                try
                                {
                                    vegas.Set(Unit.FACTORIES.ToString(), "\"" + cbName.SelectedItem.ToString()+ "\"", cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.DEPARTMENTS:
                                try
                                {
                                    vegas.Set(Unit.DEPARTMENTS.ToString(), "\"" + cbName.SelectedItem.ToString() + "\"", cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.PLACES:
                                try
                                {
                                    vegas.Set(Unit.PLACES.ToString(), "\"" + cbName.SelectedItem.ToString() + "\"", cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex, "\"" + placeRFID.Text+"\"");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.MACHINES:
                                try
                                {
                                    vegas.Set(Unit.MACHINES.ToString(), "\"" + cbName.SelectedItem.ToString() + "\"", cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.WORKERS:
                                try
                                {
                                    vegas.Set(Unit.WORKERS.ToString(), "\"" + cbName.SelectedItem.ToString() + "\"", cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex, "\"" + workerRFID.Text+"\"");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.PRODUCTS:
                                try
                                {
                                    vegas.Set(Unit.PRODUCTS.ToString(), "\"" + cbName.SelectedItem.ToString() + "\"", cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case Unit.VEGAS:
                                try
                                {
                                    vegas.Set(Unit.VEGAS.ToString(), "\"" + cbName.SelectedItem.ToString() + "\"", cbType.SelectedIndex, "\"" + tbName.Text+"\"", cbOwner.SelectedIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                        }
                        break;
                    case Mode.Delete:
                        switch (SelectedUnit)
                        {
                            case Unit.FACTORIES:
                                vegas.Delete(Unit.FACTORIES.ToString(), cbName.SelectedItem.ToString());
                                break;
                            case Unit.DEPARTMENTS:
                                vegas.Delete(Unit.DEPARTMENTS.ToString(), cbName.SelectedItem.ToString());
                                break;
                            case Unit.PLACES:
                                vegas.Delete(Unit.PLACES.ToString(), cbName.SelectedItem.ToString());
                                break;
                            case Unit.MACHINES:
                                vegas.Delete(Unit.MACHINES.ToString(), cbName.SelectedItem.ToString());
                                break;
                            case Unit.WORKERS:
                                vegas.Delete(Unit.WORKERS.ToString(), cbName.SelectedItem.ToString());
                                break;
                            case Unit.PRODUCTS:
                                vegas.Delete(Unit.PRODUCTS.ToString(), cbName.SelectedItem.ToString());
                                break;
                            case Unit.VEGAS:
                                vegas.Delete(Unit.VEGAS.ToString(), cbName.SelectedItem.ToString());
                                break;
                        }
                        break;
                }
            }
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
                List<string> data = vegas.Read(Unit.FACTORIES.ToString(), cbName.SelectedIndex);
                if (data.Count > 1)
                {
                    cbType.Items.Add(data[1]);
                    cbType.SelectedIndex = cbType.Items.Count - 1;
                    tbName.Text = data[2];
                    cbOwner.Items.Add(data[3]);
                    cbOwner.SelectedIndex = cbOwner.Items.Count - 1;

                    if (SelectedUnit == Unit.WORKERS)
                    {
                        //"\"" + workerRFID.Text+"\"" = data[4];
                    }
                    else if (SelectedUnit == Unit.PLACES)
                    {
                        //"\"" + placeRFID.Text+"\"" = data[4];
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
    }
    
}
