using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLibrary;
using System.Data.SqlClient; 
using System.Data;

namespace DataAccessLayer
{
    public class DataLayer
    {

        SqlConnection con;
        SqlCommand cmd;

        public DataLayer()
        {
            //Configure Connection String
            con = new SqlConnection();
            con.ConnectionString = @"Data Source = DHAN31\SQLEXPRESS;Initial Catalog = draganddropDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }

        public void SetFavoirtes(string fav,int psid)
        { 
            cmd = new SqlCommand();
            cmd.CommandText = "Insert into TAB_FAVORITES values ("+psid +","+ fav +")";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
          
        }

        public void ConfigureFavorites(string fav, int psid)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "update TAB_FAVORITES set fav_link=" + fav + " where psid = " + psid;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
    }
}
