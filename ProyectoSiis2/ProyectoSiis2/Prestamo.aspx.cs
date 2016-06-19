using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{
    public partial class Prestamo : System.Web.UI.Page
    {
        LayerBusiness.LayerBusinessElementos Obk = new LayerBusiness.LayerBusinessElementos();
        protected void Page_Load(object sender, EventArgs e)

        { }



        ////Codigo behind del boton guardar de insertar
        //protected void BtnGuardar_Click(object sender, EventArgs e)
        //{
        //    if (!Page.IsValid)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            Obk.InsertarElementos(Convert.ToInt64(TxtIdElemento.Text), Convert.ToInt64(TxtNumeroPlaca.Text), Convert.ToInt64(TxtNumeroSerial.Text), TxtMarca.Text, TxtModelo.Text, TxtDescripcion.Text);
        //            mensaje.Text = "Elemento Insertado";
        //        }
        //        catch (Exception exc)
        //        {
        //            mensaje.Text = exc.Message.ToString();
        //        }
        //        finally
        //        {
        //            Obk = null;

        //        }
        //    }
        //}
    }
}
    