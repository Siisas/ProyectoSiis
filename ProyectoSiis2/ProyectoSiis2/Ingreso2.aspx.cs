using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{
    public partial class Ingreso : System.Web.UI.Page
    {
        LayerBusiness.LayerBusinessElementos Obk = new LayerBusiness.LayerBusinessElementos();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                LlenarDatos();
            }
        }

        public void LlenarDatos()
        {
            LayerBusiness.LayerBusinessElementos OBj = new LayerBusiness.LayerBusinessElementos();
            GvDatos.DataSource = OBj.SpMostrarElemento();
            GvDatos.DataBind();
        }
        protected void GvDatos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LayerBusiness.LayerBusinessElementos OBj = new LayerBusiness.LayerBusinessElementos();
            Int64 ID = Convert.ToInt64(GvDatos.DataKeys[e.RowIndex].Value.ToString());
            try
            {
                OBj.EliminarElemento(ID);
                mensaje.Text = "Elemento Eliminado";
                LlenarDatos();
            }
            catch (Exception exc)
            {
                mensaje.Text = exc.Message.ToString();
            }
            finally
            {
                OBj = null;
            }
        }



    

    //Codigo behind del boton guardar de insertar
    //protected void BtnGuardar_Click(object sender, EventArgs e)
    //    {
    //        if (!Page.IsValid)
    //        {
    //            return;
    //        }
    //        else
    //        {
    //            try
    //            {
    //                Obk.iN(Convert.ToInt64(TxtIdElemento.Text), Convert.ToInt64(TxtNumeroPlaca.Text), Convert.ToInt64(TxtNumeroSerial.Text), TxtMarca.Text, TxtModelo.Text, TxtDescripcion.Text);
    //                mensaje.Text = "Elemento Insertado";
    //            }
    //            catch (Exception exc)
    //            {
    //                mensaje.Text = exc.Message.ToString();
    //            }
    //            finally
    //            {
    //                Obk = null;

    //            }
    //        }
    //    }
    }
}
    