using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace TV_advert_WF
{
    internal class DatabaseScaner
    {
        public static OleDbConnection connection;
        private static OleDbCommand command;
        public static OleDbDataAdapter dataAdapter;
        public DataTable bufferTable;

        public DatabaseScaner(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        //Возврат количества рекламы на программу
        public int ScalarAdsQuantity()
        {
            connection.Open();
            command = connection.CreateCommand();
            connection.Close();
            return 3;
        }
    }
}
