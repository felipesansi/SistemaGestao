using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestao.Telas
{
    public partial class TelaSplash : Form
    {
        public TelaSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            P_bar.Width  += 3;
            if (P_bar.Width>=800)
            {
                timer1.Stop();
                TelaEntrar telaEntrar = new TelaEntrar();
                this.Hide();

                TelaSplash telaSplash = new TelaSplash();
                telaSplash.Close();
                telaEntrar.Show();
                telaEntrar.Btn_login2.Enabled = false;
                telaEntrar.Btn_login2.BackColor = SystemColors.ActiveCaption;
                telaEntrar.panel_txb_usuarioEntrar.Focus();

            }
        }
    }
}
