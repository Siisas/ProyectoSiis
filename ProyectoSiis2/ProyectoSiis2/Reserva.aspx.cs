using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{
    public partial class Reserva : System.Web.UI.Page
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
                    oLB.InsertarReserva(Convert.ToInt64(TxtId.Text), TxtNombreSolicitante.Text, TxtElementoAPrestar.Text, Convert.ToDateTime(TxtFechaPrestao.Text), TxtObservaciones.Text, Convert.ToDateTime(Txtfechadevolucion.Text));
                    LblMsg.Text = "Reserva Generada";
                }
                catch (Exception exc)
                {
                    LblMsg.Text = exc.Message.ToString();
                }
                finally
                {
                    oLB = null;
                }

            }
        }
    }
}