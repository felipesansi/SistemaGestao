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
    public partial class TelaCadsEmpresa : Form
    {
        public TelaCadsEmpresa()
        {
            InitializeComponent();
        }

        private void panel_txb_nome_produto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btncancelarempresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_fechartela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
