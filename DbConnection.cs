using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DbConnection
/// </summary>
public class DbConnection
{
    public static string con1 = "Data Source=.;Initial Catalog=lawvia;Integrated Security=True;";
    private static string connectionString = "Data Source=.;Initial Catalog=lawvia;Integrated Security=True;";

    // Method to open and return the SqlConnection object
    public static SqlConnection GetConnection()
    {
        try
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        catch (Exception ex)
        {
            // Log or handle the exception as needed
            Console.WriteLine("Error opening connection: " + ex.Message);
            throw;
        }
    }

    // Method to close the connection
    public static void CloseConnection(SqlConnection conn)
    {
        try
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        catch (Exception ex)
        {
            // Log or handle the exception as needed
            Console.WriteLine("Error closing connection: " + ex.Message);
            throw;
        }
    }
}