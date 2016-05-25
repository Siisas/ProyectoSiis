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
        public string strconn = @"Data Source=ACER;Initial Catalog=Proyecto;Integrated Security=True";

        public LayerDataElementos() { }

        public int InsertarElementos(Int64 IdElemento, Int64 NumeroPlaca, Int64 NumeroSerial, string Marca, string Modelo, string Descripcion)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlCommand OrdenSQL = new SqlCommand("SpInsertarElementos", cnx);
                OrdenSQL.CommandType = CommandType.StoredProcedure;
                try
                {
                    OrdenSQL.Parameters.AddWithValue("@IdElemento", IdElemento);
                    OrdenSQL.Parameters.AddWithValue("@NumeroPlaca", NumeroPlaca);
                    OrdenSQL.Parameters.AddWithValue("@NumeroSerial ", NumeroSerial);
                    OrdenSQL.Parameters.AddWithValue("@Marca", Marca);
                    OrdenSQL.Parameters.AddWithValue("@Modelo", Modelo);
                    OrdenSQL.Parameters.AddWithValue("@Descripcion", Descripcion);
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
        public DataTable MostrarElementos()
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter ObjMostrar = new SqlDataAdapter("SpMostrarElementos", cnx);
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
        public int EditarElementos(Int64 IdElemento, Int64 NumeroPlaca, Int64 NumeroSerial, string Marca, string Modelo, string Descripcion)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();

                SqlCommand OrdenSQL = new SqlCommand("SpEditarElementos", cnx);
                OrdenSQL.CommandType = CommandType.StoredProcedure;

                try
                {
                    OrdenSQL.Parameters.AddWithValue("@IdElemento", IdElemento);
                    OrdenSQL.Parameters.AddWithValue("@NumeroPlaca", NumeroPlaca);
                    OrdenSQL.Parameters.AddWithValue("@NumeroSerial ", NumeroSerial);
                    OrdenSQL.Parameters.AddWithValue("@Marca", Marca);
                    OrdenSQL.Parameters.AddWithValue("@Modelo", Modelo);
                    OrdenSQL.Parameters.AddWithValue("@Descripcion", Descripcion);
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
        public int EliminarElemento(Int64 IdElemento)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();

                SqlCommand OrdenSql = new SqlCommand("SpEliminarElemento", cnx);
                OrdenSql.CommandType = CommandType.StoredProcedure;

                try
                {
                    OrdenSql.Parameters.AddWithValue("@IdElemento", IdElemento);
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


        //LayerData de Reservas
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
    }
}