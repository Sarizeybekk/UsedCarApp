using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsedVehicleApp.Concretes
{
    class ConnSingleton
    {
        private static ConnSingleton dbInstance;
        private readonly SqlConnection conn = new SqlConnection();
        private ConnSingleton()
        {

        }
        public static ConnSingleton getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new ConnSingleton();
            }
            return dbInstance;
        }
        public SqlConnection GetDBConnection()
        {
            try
            {
                MessageBox.Show("Bağlantı sağlandı");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
            }

            return conn;
        }
    }


}
