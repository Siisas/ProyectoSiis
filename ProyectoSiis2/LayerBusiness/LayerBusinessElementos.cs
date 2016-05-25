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
        public int InsertarElementos(Int64 IdElemento, Int64 NumeroPlaca, Int64 NumeroSerial, string Marca, string Modelo, string Descripcion)
        {
            try
            {
                return ObjBS.InsertarElementos(IdElemento, NumeroPlaca, NumeroSerial, Marca, Modelo, Descripcion);
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


        public DataTable MostrarElementos()
        {
            try
            {
                return ObjBS.MostrarElementos();
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
        public int EditarElementos(Int64 IdElemento, Int64 NumeroPlaca, Int64 NumeroSerial, string Marca, string Modelo, string Descripcion)
        {
            try
            {
                return ObjBS.EditarElementos(IdElemento, NumeroPlaca, NumeroSerial, Marca, Modelo, Descripcion);
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
                return ObjBS.EliminarElemento(IdElemento);
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
