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
    public partial class INFO : Form
    {
        public INFO()
        {
            InitializeComponent();

        }
        public INFO(Selected.Units _unit, string _name, bool _isWorking, string _time, string _userName, int[] _production, int[] _params, string[] _paramNames, int[] _graphData)
        {
            InitializeComponent();
            Unit = _unit;
            Name = _name;
            IsWorking = _isWorking;
            Time = _time;
            UserName = _userName;
            Production = _production;
            Params = _params;
            ParamNames = _paramNames;
            GraphData = _graphData;
        }
        private void INFO_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            if (IsWorking)
            {
                labelIsWorking.Text = "Çalışıyor";
                pbIsWorking.Image = Properties.Resources.icons8_checkmark;
                panel1.Enabled = true;

                switch (Unit)
                {
                    case Selected.Units.FACTORIES:
                        pbprofile.Image = Properties.Resources.icons8_factory;
                        buttonUser.Visible = false;
                        break;
                    case Selected.Units.DEPARTMENTS:
                        pbprofile.Image = Properties.Resources.icons8_module_11;
                        buttonUser.Image = Properties.Resources.icons8_factory_100px;
                        break;
                    case Selected.Units.PLACES:
                        pbprofile.Image = Properties.Resources.icons8_place_marker_1;
                        buttonUser.Image = Properties.Resources.icons8_module_60px;
                        pbParam4.Visible = false;
                        pgbParam4.Visible = false;
                        labelParam4.Visible = false;
                        break;
                    case Selected.Units.MACHINES:
                        pbprofile.Image = Properties.Resources.icons8_cnc_machine_1;
                        buttonUser.Image = Properties.Resources.icons8_worker_100px;
                        break;
                    case Selected.Units.WORKERS:
                        pbprofile.Image = Properties.Resources.icons8_worker;
                        buttonUser.Image = Properties.Resources.icons8_cnc_machine_64px;
                        pbParam4.Visible = false;
                        pgbParam4.Visible = false;
                        labelParam4.Visible = false;
                        break;
                    case Selected.Units.VEGAS:
                        pbprofile.Image = Properties.Resources.icons8_raspberry;
                        buttonUser.Image = Properties.Resources.icons8_module_60px;
                        break;
                    default: break;
                }
                pgbTotal.Value = Production[0];
                pgbPass.Value = Production[1];
                pgbBad.Value = Production[2];

                labelProfile.Text = Name;
                buttonUser.LabelText = UserName;

                pgbParam1.Value = Params[0];
                pgbParam2.Value = Params[1];
                pgbParam3.Value = Params[2];
                pgbParam4.Value = Params[3];
                DrawGraph();

            }
            else
            {
                MessageBox.Show("Aygıt Çalışmıyor!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelIsWorking.Text = "Çalışmıyor";
                pbIsWorking.Image = Properties.Resources.icons8_delete;
                panel1.Enabled = false;
            }

        }

        #region Vars
        private Selected.Units Unit;
        private string Name;
        private bool IsWorking;
        private string Time;
        private string UserName;
        private int[] Production = new int[3];
        private int[] Params = new int[4];
        private string[] ParamNames = new string[4];
        private int[] GraphData;
        #endregion

        private void DrawGraph()
        {
            var canvas = new Bunifu.DataViz.WinForms.Canvas();
            var datapoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_area);
            datapoint.addLabely("08:00", GraphData[0]);
            datapoint.addLabely("10:00", GraphData[1]);
            datapoint.addLabely("12:00", GraphData[2]);
            datapoint.addLabely("14:00", GraphData[3]);
            datapoint.addLabely("16:00", GraphData[4]);
            datapoint.addLabely("18:00", GraphData[5]);
            datapoint.addLabely("20:00", GraphData[6]);
            canvas.addData(datapoint);
            graph.Render(canvas);

        }
    }

}
