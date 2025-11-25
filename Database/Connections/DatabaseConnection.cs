using System;
using System.Data.OleDb;

namespace DSAFinalRequirement.Database.Connections
{
    public static class DatabaseConnection
    {
        // USE THIS WHEN SCHEMA FINALIZED
        //private static readonly string dbPath =
        //    AppDomain.CurrentDomain.BaseDirectory + @"Database\inventory_db.accdb";
        private static readonly string dbPath =
            @"C:\Users\ronni\Documents\inventory_db.accdb";

        private static readonly string connectionString =
            $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            var conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Database connection error:\n\n" + ex.Message,
                    "Connection Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                );
            }

            return conn;
        }
    }
}
