using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FrmReporteFactura : Form
    {

        private int _Idventa;



        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        public int Idventa { get => _Idventa; set => _Idventa = value; }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPrincipal.spreporte_factura' table. You can move, or remove it, as needed.
            this.spreporte_facturaTableAdapter.Fill(this.dsPrincipal.spreporte_factura,Idventa);

            this.reportViewer1.RefreshReport();
        }
    }
}
