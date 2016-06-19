using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LayerBusiness
{
    public class LayerBusinessElementos
    {
        LayerData.LayerDataElementos ObjBS = new LayerData.LayerDataElementos();
        public int SpInsertarElemento1(string Id_Elemento, string N_placa, string N_Serial, string Marca, string Modelo, DateTime Fecha_Ingreso, string Nombre_Elemento, string Categoria_Id_Categoria, string Estado_Id_Estado)
        {
            try
            {
                return ObjBS.SpInsertarElemento1(Id_Elemento, N_placa, N_Serial, Marca, Modelo, Fecha_Ingreso, Nombre_Elemento, Categoria_Id_Categoria, Estado_Id_Estado);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ObjBS = null;
            }
        }


        public DataTable SpMostrarElemento()
        {
            try
            {
                return ObjBS.SpMostrarElemento();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                ObjBS = null;
            }

        }
        public int EditarElementos(string IdElemento, string NumeroPlaca, string NumeroSerial, string Marca, string Modelo, DateTime FechaIngreso, string NombreElemento)
        {
            try
            {
                return ObjBS.SpEditarElemento(IdElemento, NumeroPlaca, NumeroSerial, Marca, Modelo, FechaIngreso,NombreElemento);
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                ObjBS = null;
            }
        }
        public int EliminarElemento(Int64 IdElemento)
        {
            try
            {
                return ObjBS.SpEliminarElemento(IdElemento);
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                ObjBS = null;
            }

        }



        //Insertar reserva
        public int InsertarReserva(Int64 Id, string NombreSolicitante, string ElementoAPrestar, DateTime FechaPrestao, string Observaciones, DateTime fechadevolucion)
        {
            try
            {
                return ObjBS.InsertarReserva(Id, NombreSolicitante, ElementoAPrestar, FechaPrestao, Observaciones, fechadevolucion);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ObjBS = null;
            }
        }

        //Mostrar Reserva

        public DataTable MostarReserva()
        {
            try
            {
                return ObjBS.MostarReserva();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ObjBS = null;
            }
        }



        //mostrar Prestamo

       
        public int Prestamo(String IdElemento, string NumeroPlaca, string NumeroSerial, string Marca, string Modelo, DateTime FechaIngreso, string NombreElemento, string Categoria_Id_Categoria, string Estado_Id_Estado)
        {
            try
            {
                return ObjBS.SpInsertarElemento1(IdElemento, NumeroPlaca, NumeroSerial, Marca, Modelo, FechaIngreso,NombreElemento,Categoria_Id_Categoria,Estado_Id_Estado);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ObjBS = null;
            }
        }
    }
}