using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{
    public partial class Gestion : System.Web.UI.Page
    {
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
            GvDatos.DataSource = OBj.MostrarElementos();
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
    }
}