using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webTestOperaciones.Inicio
{
    public partial class Saludos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            Funciones.Operaciones op = new Funciones.Operaciones();
            double[] x = new double[] { 2, 3324, 3, 24, 234, 4234, 31 };
            this.lblsaludos.Text = op.saludo(this.Txtnombre.Text);
            this.Txtresultado.Text = op.suma(x).ToString();

        }
    }
}