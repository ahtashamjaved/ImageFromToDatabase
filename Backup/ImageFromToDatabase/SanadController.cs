using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Collections;

namespace ImageFromToDatabase
{
    public class SanadController
    {



      
        [STAThread]
        public List<SanadDataClass> GetDataOledb(string where )
        {

            List<SanadDataClass> list = new List<SanadDataClass>();
            //string query = "select * from " + Connection.tableName + " " + whereClause;
            string query = " SELECT * FROM " + StaticClass.tableName + " Where "+ where;
            OleDbConnection conn = new OleDbConnection(StaticClass.connectionStr);
            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(query, conn);
                OleDbDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    //read all columns from database table 
                    SanadDataClass temp = new SanadDataClass();
                    try
                    {

                        if ((reader["Roll_Number"].GetType().ToString()) != "System.DBNull")
                            temp.Roll_Number = Convert.ToInt32(reader["Roll_Number"]);

                        try
                        {
                            temp.Picture_File = (Byte[])(reader["Picture_File"]);
                     

                      
                        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
                        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................imageToByteArray...................................
                        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

                        Image picture = StaticClass.byteArrayToImage(temp.Picture_File);
                        temp.PictureImage = picture;
                        }
                        catch (Exception ex)
                        { 
                        
                        }
                        
                        
                        list.Add(temp);

                    }
                    catch (Exception ex)
                    {
                        string exp = ex.ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                string exp = ex.ToString();
            }
            finally
            {
                
              
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
           
            if (conn.State.ToString() == "Open")
            conn.Close();
            return list;
        }
    }
}

