using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaPunto
{
    public partial class FrmFarmaceutico : MetroFramework.Forms.MetroForm
    {
        UCFacturacionAdministrador uCFacturacionF = new UCFacturacionAdministrador();
        UCDetallesDeProductos detallesDeProductos = new UCDetallesDeProductos();

        public FrmFarmaceutico()
        {
            InitializeComponent();
            Timer.Enabled = true;
        }

        private void FrmFarmaceutico_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LbelHora.Text = DateTime.Now.ToString();
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            //faraceutico facturas

            CambiarColorF(BtnFacturacion);
            MostrarControlF(uCFacturacionF);
            CambiarColorF(BtnProductos);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            CambiarColorF(BtnProductos);
            MostrarControlF(detallesDeProductos);
            CambiarColorF(BtnFacturacion);
        }
        public void MostrarControlF(UserControl control)
        {
            if (!PnelEjecucion.Controls.Contains(control))
            {
                PnelEjecucion.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
            }
            else
            {
                control.BringToFront();
            }
        }

        public void CambiarColorF(Button button)
        {
            if (button.Focused)
            {
                button.BackColor = Color.DimGray;
            }
            else
            {
                button.BackColor = Color.Crimson;
             
            }
        }

        private void PnelEjecucion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
