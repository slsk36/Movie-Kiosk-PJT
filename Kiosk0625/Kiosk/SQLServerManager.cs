using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Kiosk
{
    class SQLServerManager
    {
        private static SQLServerManager instance = new SQLServerManager();

        public static SQLServerManager getInstance()
        {
            return instance;
        }

        public static string strconn = "Data Source=munggu.iptime.org,11113;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!";

        public string Strconn
        {
            get { return strconn; }
            set { }

        }

        public DataSet getDataSetBoard()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(Strconn))
            {
                SqlCommand com = new SqlCommand("select * from board", conn);
                SqlDataAdapter sda = new SqlDataAdapter(com);
                sda.Fill(ds);
            }
            return ds;
        }
    }
}
