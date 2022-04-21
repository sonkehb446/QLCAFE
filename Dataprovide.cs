using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;

namespace CAFE
{

        public class Dataprovide

        {
            private static Dataprovide instance;
            public static Dataprovide Instance
            {
                get
                {
                    if (instance == null) instance = new Dataprovide();
                    return Dataprovide.instance;
                }
                private set
                {
                    Dataprovide.instance = value;
                }
            }
            private Dataprovide() { }
        private string ConnectionStr = @"Data Source=.\SQLEXPRESS; AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().ToString() + "\\QLCAFE.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True";
        public DataTable TruyVan(string query, object[] parameter = null)

            {
     
            DataTable Data = new DataTable();
                using (SqlConnection Connection = new SqlConnection(ConnectionStr))
                {
                    Connection.Open();

                    SqlCommand Commad = new SqlCommand(query, Connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            Commad.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adepter = new SqlDataAdapter(Commad);

                adepter.Fill(Data);

                    Connection.Close();
                }
                return Data;
            }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }



}




