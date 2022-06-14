using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionPractice
{
    class ModelDB
    {
        SqlConnection sqlCon = new SqlConnection("data source=CHETUIWK1026\\SQLEXPRESS;database=ConsoleAdo;Integrated Security=SSPI");
        string sql = "";
        
        public void Insert(string ename,string mob,string address)
        {
            sql = "insert into raj values(@vename,@vemob,@vaddress)";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.Parameters.AddWithValue("@vename", ename);
            cmd.Parameters.AddWithValue("@vemob", mob);
            cmd.Parameters.AddWithValue("@vaddress", address);
            sqlCon.Open();
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            Console.WriteLine("Data Inserted successfully"); 
        }
        public void Update(int id,string ename, string mob, string address)
        {
            sql = "update raj set ename=@vename, mob=@vemob, address=@vaddress  where eno= @veno";
            SqlCommand cmd2 = new SqlCommand(sql, sqlCon);
            cmd2.Parameters.AddWithValue("@veno", id);
            cmd2.Parameters.AddWithValue("@vename", ename);
            cmd2.Parameters.AddWithValue("@vemob", mob);
            cmd2.Parameters.AddWithValue("@vaddress", address);
            sqlCon.Open();
            cmd2.ExecuteNonQuery();
            sqlCon.Close();
            Console.WriteLine("Data Updated successfully");
        }
        public void Delete(int id)
        {
            sql = "delete from raj where eno=" + id + "";
            SqlCommand cmd3 = new SqlCommand(sql, sqlCon);
            sqlCon.Open();
            cmd3.ExecuteNonQuery();
            sqlCon.Close();
            Console.WriteLine("Data Deleted successfully");
        }
        public void ShowAll()
        {
            sql = "select * from raj  ";
            sqlCon.Open();
            SqlCommand cmd4 = new SqlCommand(sql, sqlCon);
            SqlDataReader dr = cmd4.ExecuteReader();


            while (dr.Read() == true)
            {
                Console.WriteLine("No is     :" + dr[0]);
                Console.WriteLine("No is     :" + dr[1]);
                Console.WriteLine("Mobile No :" + dr[2]);
                Console.WriteLine("Address   :" + dr[3]);
                Console.WriteLine("--------------");
            }
            sqlCon.Close();
        }
        public void FindRecord(int id)
        {
            
            sql = "select * from raj where eno=@veno ";
            sqlCon.Open();
            SqlCommand cmd5 = new SqlCommand(sql, sqlCon);
            cmd5.Parameters.AddWithValue("@veno", id);
            SqlDataReader dr5 = cmd5.ExecuteReader();

            if(dr5.Read() == true)
            {
                Console.WriteLine("No is     :" + dr5[0]);
                Console.WriteLine("Name is   :" + dr5[1]);
                Console.WriteLine("Mobile No :" + dr5[2]);
                Console.WriteLine("Address   :" + dr5[3]);
                Console.WriteLine("________________");
            }
            sqlCon.Close();
        }
        
    }
}
