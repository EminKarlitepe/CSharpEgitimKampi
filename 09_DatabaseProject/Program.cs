using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Listesi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------------");

            SqlConnection connection = new SqlConnection("Data source=KARLITEPE\\MSSQLSERVER79;" +
                "initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from tblCategory", connection);
            //sql adapter c# ve sql arasındaki kodlar için köprü görevi görüyor.
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //data table verilerimizi belleğe (RAM) almamızı sağlayacak.
            DataTable dataTable = new DataTable();
            /* 
             * datatable ramde bize alan sağladı ve bu alanı adapter ile doldurduk, adapter içinde
            command ve command içerisindeki sorguyu RAM bellek üzerinden kullanıcıya
            gösterebilmemizi sağlar
           */
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}
