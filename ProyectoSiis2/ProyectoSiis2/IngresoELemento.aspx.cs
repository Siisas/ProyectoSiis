using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{
    public partial class IngresoELemento : System.Web.UI.Page
    {
        LayerBusiness.LayerBusinessElementos oLB = new LayerBusiness.LayerBusinessElementos();
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (!Page.IsValid)
            {
                return;
            }
            else
            {
                try
                {
                    oLB.SpInsertarElemento1(TxtIdElemento.Text, TxtNumeroPlaca.Text, TxtNumeroSerial.Text, TxtMarca.Text, TxtModelo.Text,DateTime.Parse(TxtFecha_Ingreso.Text), TxtNombreElemento.Text, TxtCategoria.Text, TxtEstado.Text);
                    mensaje.Text = "Empleado Insertado";
                }
                catch (Exception exc)
                {
                    mensaje.Text = exc.Message.ToString();
                }
                finally
                {
                    oLB = null;
                }



            }
        }

    }
}
