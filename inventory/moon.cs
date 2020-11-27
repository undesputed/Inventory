using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class moon
    {
        protected internal static void fetchDataT(string query, string data1, string data2, string data3, string SourceX)
        {
            try
            {
                MySqlConnection con2 = new MySqlConnection("");
                MySqlCommand cmd = new MySqlCommand(query, con2);
                MySqlDataReader myreader;
                con2.Open();
                cmd.Parameters.Add(new MySqlParameter("@Data1", data1));
                cmd.Parameters.Add(new MySqlParameter("@Data2", data2));
                cmd.Parameters.Add(new MySqlParameter("@Data3", data3));
                myreader = cmd.ExecuteReader();
                con2.Close();
            }
            catch (Exception lied)
            {
                // MessageBox.Show("Connect to Transaction : " + lied.Message.ToString(), "Server Error");
                Console.WriteLine("Error details:" + lied.Message.ToString() 
                 + " \nPath: fetchDataT \nQuery:" + query);
                
            }
        }
        protected internal static System.Data.DataTable getDataFinalRecordsWSpecial(string xd, string data1, string data2, string data3, string SourceX)
        {
            DataTable table = new DataTable(); ;
            try
            {
                MySqlConnection con2 = new MySqlConnection("");
                MySqlCommand cmd = new MySqlCommand(xd, con2);
                cmd.Parameters.Add(new MySqlParameter("@Data1", data1));
                cmd.Parameters.Add(new MySqlParameter("@Data2", data2));
                cmd.Parameters.Add(new MySqlParameter("@Data3", data3));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
            }
            catch (Exception lied)
            {
                Console.WriteLine("Error details:" + lied.Message.ToString()
                    + " \nPath: getDataERecordsWSpecial \nQuery:" 
                    + xd);
            }
            return table;
        }
    }
}
