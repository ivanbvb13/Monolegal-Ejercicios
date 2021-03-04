using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo.Src.Class
{
    class ConexionAcces
    {

        private OleDbConnection _conection;

        public ConexionAcces(string path) 
        {
            this._conection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|"+ path);
        }

        public void open() 
        {
            this._conection.Open();
        }

        public void close()
        {
            this._conection.Close();

        }

        public DataSet executeQuery(string sql) 
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, this._conection);

            DataSet d = new DataSet();
            adapter.Fill(d);

            return d;
        }

        public bool exceuteInstruction(string sql) 
        {
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = this._conection;
            cmd.CommandText = @sql;
            return cmd.ExecuteNonQuery() > 0;
        }

    }
}
