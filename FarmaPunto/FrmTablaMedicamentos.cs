using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace FarmaPunto
{
    public partial class FrmTablaMedicamentos : MetroFramework.Forms.MetroForm
    {
        MedicamentosService servicios = new MedicamentosService();
        IReceptor FrmIreceptor;
        public FrmTablaMedicamentos()
        {
            InitializeComponent();
        }
        public FrmTablaMedicamentos(IReceptor frmIreceptor)
        {
            InitializeComponent();
            FrmIreceptor = frmIreceptor;
        }

        private void FrmTablaMedicamentos_Load(object sender, EventArgs e)
        {

        }

        private void DtgListadeProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FrmIreceptor != null)
            {
                Medicamentos medicamento = (Medicamentos)DtgListadeProductos.CurrentRow.DataBoundItem;
                FrmIreceptor.Recibir(medicamento);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            servicios.ConsultarMedicamentos();
        }
    }
}
