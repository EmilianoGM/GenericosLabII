using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary1
{
    public class BaseSQL
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;
        public BaseSQL()
        {
            this._comando = new SqlCommand();
            //this._conexion = new SqlConnection(Properties.Settings.Default.conexion_bd);
        }

        public bool Metodo<T>(T elemento)
        {
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "INSERT INTO  db () values ()";
            /*
            "UPDATE db SET campo = valor, campo = valor WHERE id = n" 
            "DELETE FROM db WHERE id = n"
             */
            try
            {
                this._conexion.Open();
                if (this._comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if (this._conexion.State.Equals(ConnectionState.Open))
                {
                    this._conexion.Close();
                }

            }
            return false;
        }

        public List<T> Traer<T>()
        {
            List<T> retorno = new List<T>();
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT columna, columna FROM db";
            try
            {
                this._conexion.Open();
                SqlDataReader sqlDataReader = this._comando.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    /*
                     T elemento = new T((int)sqlDataReader["nombre columna"]);
                     retorno.Add(elemento);
                    */
                }
            }
            catch (Exception e)
            {
                return retorno;
            }
            finally
            {
                if (this._conexion.State.Equals(ConnectionState.Open))
                {
                    this._conexion.Close();
                }

            }
            return retorno;
        }

        public DataTable TraerTabla()
        {           
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT columna, columna FROM db";

            DataTable dataTable = new DataTable("Tabla");
            try
            {
                this._conexion.Open();
                SqlDataReader sqlDataReader = this._comando.ExecuteReader();
                dataTable.Load(sqlDataReader);
            }
            catch (Exception e)
            {
                return dataTable;
            }
            finally
            {
                if (this._conexion.State.Equals(ConnectionState.Open))
                {
                    this._conexion.Close();
                }
            }
            return dataTable;
        }

        public T TraerElementoDeTabla<T>()
        {
            DataTable dataTable = this.TraerTabla();
            DataRowCollection rowCollection = dataTable.Rows;
            for (int i = 0; i < rowCollection.Count; i++)
            {
                DataRow dataRow = rowCollection[i];
                //T elemento = new T((int)dataRow["id"], (string)dataRow["nombre"], (string)dataRow["apellido"], (int)dataRow["edad"]);
                Console.WriteLine("elemento");
            }
            return default(T);
        }

        public DataTable TablaXML()
        {
            DataTable dataTable = new DataTable();
            /*GUARDAR*/
            //dataTable.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_esquema.xml");
            //dataTable.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_datos.xml");

            /*LEER*/
            dataTable.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_esquema.xml");
            dataTable.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_datos.xml");

            return dataTable;
        }
    }
}
