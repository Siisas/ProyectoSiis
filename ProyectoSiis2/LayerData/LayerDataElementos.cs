using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LayerData
{
    public class LayerDataElementos
    {
        public string strconn = @"Data Source=GALEX;Initial Catalog=pruebaspro1;Integrated Security=True";
        //Data Source=RICARD-PC;Initial Catalog=ProyectoSiis;Integrated Security=True
        //Server=tcp:proyectosiis.database.windows.net,1433;Database=Proyecto1;User ID = Siis@proyectosiis;Password={123456789Aa];Trusted_Connection=False;Encrypt=True;Connection Timeout = 30;
        public LayerDataElementos() { }
        //prueba
        public int SpInsertarElemento1(string Id_Elemento, string N_placa, string N_Serial, string Marca, string Modelo, DateTime Fecha_Ingreso, string Nombre_Elemento, string Categoria_Id_Categoria, string Estado_Id_Estado)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlCommand OrdenSQL = new SqlCommand("SpInsertarElemento1", cnx);
                OrdenSQL.CommandType = CommandType.StoredProcedure;
                try
                {   
                    OrdenSQL.Parameters.AddWithValue("@Id_Elemento", Id_Elemento);
                    OrdenSQL.Parameters.AddWithValue("@N_Placa", N_placa);
                    OrdenSQL.Parameters.AddWithValue("@N_Serial",N_Serial);
                    OrdenSQL.Parameters.AddWithValue("@Marca", Marca);
                    OrdenSQL.Parameters.AddWithValue("@Modelo", Modelo);
                    OrdenSQL.Parameters.AddWithValue("@Fecha_Ingreso", Fecha_Ingreso);
                    OrdenSQL.Parameters.AddWithValue("@Nombre_Elemento", Nombre_Elemento);
                    OrdenSQL.Parameters.AddWithValue("@Categoria_Id_Categoria", Categoria_Id_Categoria);
                    OrdenSQL.Parameters.AddWithValue("@Estado_Id_Estado",Estado_Id_Estado);
                    return OrdenSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    OrdenSQL.Dispose();
                }
            }
        }
        public DataTable SpMostrarElemento()
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter ObjMostrar = new SqlDataAdapter("SpMostrarElemento", cnx);
                ObjMostrar.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                try
                {
                    ObjMostrar.Fill(ds, "Table");
                    return ds.Tables["Table"];

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {


                    cnx.Close();
                    cnx.Dispose();
                    ObjMostrar.Dispose();
                    ds.Dispose();
                }
            }
        }
        public int SpEditarElemento(string IdElemento, string NumeroPlaca, string NumeroSerial, string Marca, string Modelo, DateTime FechaIngreso, string NombreElemento)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();

                SqlCommand OrdenSQL = new SqlCommand("SpEditarElemento", cnx);
                OrdenSQL.CommandType = CommandType.StoredProcedure;

                try
                {
                    OrdenSQL.Parameters.AddWithValue("@Id_Elemento", IdElemento);
                    OrdenSQL.Parameters.AddWithValue("@N_Placa", NumeroPlaca);
                    OrdenSQL.Parameters.AddWithValue("@N_Serial", NumeroSerial);
                    OrdenSQL.Parameters.AddWithValue("@Marca", Marca);
                    OrdenSQL.Parameters.AddWithValue("@Modelo", Modelo);
                    OrdenSQL.Parameters.AddWithValue("@Fecha_Ingreso", FechaIngreso);
                    OrdenSQL.Parameters.AddWithValue("@Nombre_Elemento", NombreElemento);
                    return OrdenSQL.ExecuteNonQuery();


                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    OrdenSQL.Dispose();
                }
            }
        }
        public int SpEliminarElemento(Int64 IdElemento)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();

                SqlCommand OrdenSql = new SqlCommand("SpEliminarElemento", cnx);
                OrdenSql.CommandType = CommandType.StoredProcedure;

                try
                {
                    OrdenSql.Parameters.AddWithValue("@Id_Elemento", IdElemento);
                    return OrdenSql.ExecuteNonQuery();


                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    OrdenSql.Dispose();
                }
            }
        }


        //LayerData de Reservas Para la Pagina reserva
        public int InsertarReserva(Int64 Id, string NombreSolicitante, string ElementoAPrestar, DateTime FechaPrestao, string Observaciones, DateTime fechadevolucion)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlCommand Ordensql = new SqlCommand("SpInsertarReserva", cnx);
                Ordensql.CommandType = CommandType.StoredProcedure;

                try
                {
                    Ordensql.Parameters.AddWithValue("@IdReserva", Id);
                    Ordensql.Parameters.AddWithValue("@NombreSolicitante", NombreSolicitante);
                    Ordensql.Parameters.AddWithValue("@ElementoAPrestar", ElementoAPrestar);
                    Ordensql.Parameters.AddWithValue("@FechaPrestamo", FechaPrestao);
                    Ordensql.Parameters.AddWithValue("@Observaciones", Observaciones);
                    Ordensql.Parameters.AddWithValue("@fechaDevolucion", fechadevolucion);
                    return Ordensql.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    Ordensql.Dispose();
                }
            }
        }

   //Mostrar Reserva para la pagina Gestion

        public DataTable MostarReserva()
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter dAd = new SqlDataAdapter("SpMostarReserva", cnx);
                dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();

                try
                {
                    dAd.Fill(ds, "Table");
                    return ds.Tables["Table"];
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    dAd.Dispose();
                    ds.Dispose();
                }
            }
        }

        //LayerData Prestamo
        public DataTable Prestamo()
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter ObjMostrar = new SqlDataAdapter("SpInsertarPrestamo", cnx);
                ObjMostrar.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                try
                {
                    ObjMostrar.Fill(ds, "TablePrestamo");
                    return ds.Tables["TablePrestamo"];

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {


                    cnx.Close();
                    cnx.Dispose();
                    ObjMostrar.Dispose();
                    ds.Dispose();
                }
            }
        }
    }
}