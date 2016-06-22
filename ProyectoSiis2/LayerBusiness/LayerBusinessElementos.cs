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
        public int SpInsertarElemento1(Int64 Id_Elemento, string N_placa, string N_Serial, string Marca, string Modelo, string Categoria_Id_Categoria, DateTime Fecha_Ingreso, string Estado_Id_Estado, string Nombre_Elemento)


        {
            try
            {
                return ObjBS.SpInsertarElemento1(Id_Elemento, N_placa, N_Serial, Marca, Modelo, Categoria_Id_Categoria, Fecha_Ingreso, Estado_Id_Estado, Nombre_Elemento);
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
        public int EditarElementos(Int64 Id_Elemento, string N_placa, string N_Serial, string Marca, string Modelo, string Categoria_Id_Categoria, DateTime Fecha_Ingreso, string Estado_Id_Estado, string Nombre_Elemento)

        {
            try
            {
                return ObjBS.SpEditarElemento(Id_Elemento, N_placa, N_Serial, Marca, Modelo, Categoria_Id_Categoria, Fecha_Ingreso, Nombre_Elemento, Estado_Id_Estado);

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
        public int InsertarReserva(string Id_Reserva, string Nombre_Solicitante, Int64 Fk_Id_Elemento, DateTime Fecha_Reserva, string Observaciones, string Fk_Id_Categoria, string Fk_Id_Estado)
        {
            try
            {
                return ObjBS.InsertarReserva(Id_Reserva, Nombre_Solicitante, Fk_Id_Elemento, Fecha_Reserva, Observaciones, Fk_Id_Categoria, Fk_Id_Estado);
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

        public DataTable MostrarReserva()
        {
            try
            {
                return ObjBS.MostrarReserva();
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

       
        public int Prestamo(Int64 Id_Elemento, string N_placa, string N_Serial, string Marca, string Modelo, string Categoria_Id_Categoria, DateTime Fecha_Ingreso, string Estado_Id_Estado, string Nombre_Elemento)
        {
            try
            {
                return ObjBS.SpInsertarElemento1(Id_Elemento, N_placa, N_Serial, Marca, Modelo, Categoria_Id_Categoria, Fecha_Ingreso, Nombre_Elemento, Estado_Id_Estado);

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