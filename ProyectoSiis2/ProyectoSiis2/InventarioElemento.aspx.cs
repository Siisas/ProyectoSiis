using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
    {

    public partial class InventarioElemento : System.Web.UI.Page
    {
        LayerBusiness.LayerBusinessElementos oLB = new LayerBusiness.LayerBusinessElementos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarDatos();
            }

        }

        public void LlenarDatos()
        {
            GridView1.DataSource = oLB.SpMostrarElemento();
            GridView1.DataBind();

            ////En la busqueda debe aparecer los 2 id id
            //DropDownList1.DataSource = oLB.MostrarEmpleados();
            ////DropDownList1.DataTextField = "id";
            ////DropDownList1.DataValueField = "id";
            //DropDownList1.DataTextField = "Apellidos";
            //DropDownList1.DataValueField = "Apellidos";
            ////DropDownList1.DataTextField = "Nombres";
            ////DropDownList1.DataValueField = "Nombres";
            ////DropDownList1.DataTextField = "HorasTrabajadas";
            ////DropDownList1.DataValueField = "HorasTrabajadas";
            ////DropDownList1.DataTextField = "SueldoXHora";
            ////DropDownList1.DataValueField = "SueldoXHora";


            //DropDownList1.DataBind();
            //DropDownList1.Items.Insert(0, new ListItem("--Selecciones empleado", "0"));
        }


    }
}