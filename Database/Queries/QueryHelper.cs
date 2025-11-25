using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Database.Queries
{
    public static class QueryHelper
    {
        // SELECT with DataReader
        public static OleDbDataReader ExecuteReader(string query, params OleDbParameter[] parameters)
        {
            try
            {
                OleDbConnection conn = DatabaseConnection.GetConnection();
                OleDbCommand cmd = new OleDbCommand(query, conn);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // INSERT, UPDATE, DELETE
        public static int ExecuteNonQuery(string query, params OleDbParameter[] parameters)
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // indicate failure
            }
        }

        // Return single value (integer, string, count, etc.)
        public static object ExecuteScalar(string query, params OleDbParameter[] parameters)
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
