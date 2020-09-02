using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.DataSetSerieTableAdapters;
using System.Data;

namespace BLL1
{
   public class ClassSerie
    {
        #region Atributos

        private SerieTableAdapter serie;

        #endregion



        #region Propiedades 
        private SerieTableAdapter SERIE
        {
            get
            {
                if (serie == null)
                {
                    serie = new SerieTableAdapter();
                }
                return serie;
            }
        }
        #endregion

        #region metodos

        public string InsertarSerie(string _Nombre, string _Inicio, string _Fin)
        {
            string resouesta = "";
            try
            {
                SERIE.sp_AgregaSerie(_Nombre, Convert.ToInt32(_Inicio), Convert.ToInt32(_Fin),  ref resouesta);

            }
            catch (Exception error)
            {
                resouesta = error.Message;
            }
            return resouesta;
        }

        public DataTable Verificar()
        {
            DataTable resusltado = new DataTable();
            try
            {
                resusltado = SERIE.GetDataByVerificarSerie();
            }
            catch (Exception)
            {

                return null; 
            }
            return resusltado;
        }

        #endregion
    }
}
