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
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LlenarDatos();
            }

        }
        public void LlenarDatos()
        {
            LayerBusiness.LayerBusinessElementos objBS = new LayerBusiness.LayerBusinessElementos();

            GridView1.DataSource = objBS.Prestamo();
            GridView1.DataBind();
        }
    }
}