using DBConnectionPractice;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    class Program
    {
        //string name=null;
        //string mob = null;
        //string address = null;

       
        //public static void RepeatCode()
        //{
        //    Console.Write("Enter updated Name : ");
        //     name = Console.ReadLine();
        //    Console.Write("Enter updated Mobile No : ");
        //     mob = Console.ReadLine();
        //    Console.Write("Enter updated Address : ");
        //     address = Console.ReadLine();
            
        //}
        static void Main(string[] args)
        {
            ModelDB modelDB = new ModelDB();
            //SqlConnection sqlCon = new SqlConnection("data source=CHETUIWK1026\\SQLEXPRESS;database=ConsoleAdo;Integrated Security=SSPI");
            //Console.WriteLine("Connect");
            //string sql = "create table raj(eno int,ename varchar(20))";
            //string sql = "insert into raj values(101,'san')";
            //string sql = "insert into raj values(102,'sam')";
            //string sql = "insert into raj values(103,'ram')";
            //string sql = "insert into raj values(104,'den')";

            //string sql = "update raj set ename='SAN' where eno=101";
            //string sql = "delete from raj where eno=104";
            //while (true) 
            //{ 
            while (true)
            {
                Console.WriteLine("Select your choice");
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. ShowAll");
                Console.WriteLine("5. FindRecord");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your Choice :");
                int choice = int.Parse(Console.ReadLine());
                //string sql = "";

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter  Name : ");
                         string  name1 = Console.ReadLine();
                         Console.Write("Enter  Mobile No : ");
                         string  mob1 = Console.ReadLine();
                         Console.Write("Enter  Address : ");
                          string address1 = Console.ReadLine();
                        modelDB.Insert( name1, mob1, address1);        
                        break;
                    case 2:
                        Console.Write("Enter ENo : ");
                        int eno2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter updated Name : ");
                        string name2 = Console.ReadLine();
                        Console.Write("Enter updated Mobile No : ");
                        string mob2 = Console.ReadLine();
                        Console.Write("Enter updated Address : ");
                        string address2 = Console.ReadLine();
                        
                        modelDB.Update(eno2,name2,mob2,address2);
                        break;
                    case 3:
                        Console.Write("Enter ENo : ");
                        int eno3 = int.Parse(Console.ReadLine());
                        modelDB.Delete(eno3);
                        break;
                    case 4:
                        modelDB.ShowAll();
                        break;
                    case 5:
                        Console.Write("Enter ENo ");
                        int eno5 = int.Parse(Console.ReadLine()); 
                        modelDB.FindRecord(eno5);
                        break;
                    case 6:
                        Console.WriteLine("Thank you for using the Program.");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice ");
                        break;

                }
                if (choice == 6)
                    break;
                Console.WriteLine("Enter for Continue ");
                Console.ReadLine();
            }

        }
    }
}
//}
