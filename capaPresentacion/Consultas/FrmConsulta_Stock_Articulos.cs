using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaNegocio;

namespace capaPresentacion.Consultas

{
    public partial class FrmConsulta_Stock_Articulos : Form
    {
        public FrmConsulta_Stock_Articulos()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Stock_Articulos_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;

        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NArticulo.Stock_Articulo();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }


    }
}
