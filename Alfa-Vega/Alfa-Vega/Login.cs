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
    public partial class Login : Form
    {
        #region Splash & INIT

        bool done = true;
        public Login()
        {
            Splash s = new Splash();
            s.Show();
            if(done)System.Threading.Thread.Sleep(1000);
            s.Close();
            InitializeComponent();
            ControlExtension.Draggable(this, true);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!done) Hidee();

        }

        private void ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Main m;
        void Hidee()
        {

            m = new Main();
            m.FormClosed += delegate
            {

                this.Close();
            };
            this.Hide();
            m.ShowDialog();

        }

        #endregion

        /// <summary>
        /// Server üzerinden kullanıcı kaydını kontrol eder.
        /// </summary>
        private void btn_login_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            if (dB.CheckUser(textBox1.Text,textBox2.Text))
            {

                Hidee();

            }
            else MessageBox.Show("Yanlış şifre veya kullanıcı adı girdiniz!","HATA!" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       

    }
}
 