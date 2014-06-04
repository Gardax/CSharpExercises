using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Write a program that retrieves from the Northwind sample database in 
             * MS SQL Server the number of  rows in the Categories table.*/

            SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESSGARDAX;Database=Northwind;Integrated Security=SSPI;");
            con.Open();
            SqlCommand commandExecutor = new SqlCommand("SELECT count(*) FROM Categories", con);
            int count = int.Parse(commandExecutor.ExecuteScalar().ToString());
            Console.WriteLine("The count of categories is {0}.", count);

            /* 2. Write a program that retrieves the name and description of all categories in the Northwind DB.*/

            commandExecutor.CommandText = "SELECT CategoryName, Description FROM Categories";
            var reader = commandExecutor.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Category {0} is {1}.", reader["CategoryName"], reader["Description"]);
            }
            reader.Close();

            /* 3. Write a program that retrieves from the Northwind database all product categories and 
             * the names of the products in each category. Can you do this with a single SQL query (with table join)?*/
            commandExecutor.CommandText = "SELECT * FROM Categories c JOIN Products p ON c.CategoryID=p.CategoryID";
            reader = commandExecutor.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Category: {0} - product: {1}", reader["CategoryName"], reader["ProductName"]);
            }
            reader.Close();

            /*4. Write a method that adds a new product in the products table in the Northwind database.
             * Use a parameterized SQL command.*/

            commandExecutor.CommandText=("INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit,"+
                                        "UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)"+
                                        "VALUES(@name, @supplierID, @categoryID, @quantityPerUnit, @unitPrice,"+
                                        "@unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)");

            commandExecutor.Parameters.AddWithValue("@name", "domat");
            commandExecutor.Parameters.AddWithValue("@supplierID", 2);
            commandExecutor.Parameters.AddWithValue("@categoryID", 3);
            commandExecutor.Parameters.AddWithValue("@quantityPerUnit", "2kg box");
            commandExecutor.Parameters.AddWithValue("@unitPrice", 5);
            commandExecutor.Parameters.AddWithValue("@unitsInStock", 40);
            commandExecutor.Parameters.AddWithValue("@unitsOnOrder", 20);
            commandExecutor.Parameters.AddWithValue("@reorderLevel", 5);
            commandExecutor.Parameters.AddWithValue("@discontinued", 0);
            commandExecutor.ExecuteNonQuery();

            /* 5. Write a program that retrieves the images for all categories in the Northwind database
             * and stores them as JPG files in the file system.*/

            commandExecutor.CommandText = "SELECT CategoryName, Picture FROM Categories";
            reader = commandExecutor.ExecuteReader();
            while (reader.Read())
            {
                byte[] rawData = (byte[])reader["Picture"];
                string fileName = reader["CategoryName"].ToString().Replace('/', '_') + ".jpg";
                int len = rawData.Length;
                int header = 78;
                byte[] imgData = new byte[len - header];
                Array.Copy(rawData, 78, imgData, 0, len - header);
                MemoryStream memoryStream = new MemoryStream(imgData);
                System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);
                image.Save(new FileStream(fileName, FileMode.Create), ImageFormat.Jpeg);
            }
            reader.Close();

            /* 6. Create an Excel file with 2 columns: name and score:
             * Write a program that reads your MS Excel file through the OLE DB 
             * data provider and displays the name and score row by row.*/

            var connectionString = string.Format(
            "Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=Excel 12.0;", "scores.xlsx");
            OleDbConnection ExelConnection = new OleDbConnection(connectionString);
            ExelConnection.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", ExelConnection);
            var ExelReader = cmd.ExecuteReader();
            while (ExelReader.Read())
            {
                Console.WriteLine(ExelReader["Name"] + " " + ExelReader["scores"]);
            }
            ExelReader.Close(); 

            /* 7. Implement appending new rows to the Excel file. */

            string name = "Petar Petrov";
            int score = 21;
            cmd.CommandText= "INSERT INTO [Sheet1$] VALUES(@name, @score)";
            cmd.Parameters.Add(new OleDbParameter("@name", name));
            cmd.Parameters.Add(new OleDbParameter("@score", score));
            cmd.ExecuteNonQuery();
            ExelConnection.Close();

            /* 8. Write a program that reads a string from the console and finds all products that contain this string.
             * Ensure you handle correctly characters like ', %, ", \ and _. */

            Console.Write("Enter a string: ");
            string str = Console.ReadLine().Replace("%", "!%").Replace("\"", "!\"")
            .Replace("_", "!_").Replace("\\", "!\\");
            SqlCommand command = new SqlCommand("SELECT * FROM Products " +
            "WHERE ProductName LIKE '%' + @str + '%' ESCAPE '!'", con);
            command.Parameters.Add(new SqlParameter("@str", str));

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("ProductID: {0}", reader["ProductID"]);
                Console.WriteLine("ProductName: {0}", reader["ProductName"]);
                Console.WriteLine("UnitPrice: {0}", reader["UnitPrice"]);
                Console.WriteLine();
            }
            reader.Close();
            con.Close();
        }
    }
}
             