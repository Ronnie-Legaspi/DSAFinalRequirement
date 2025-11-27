using DSAFinalRequirement.Database.Connections;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Reports
{
    public partial class DeleteTransactionForm : Form
    {
        private int transactionId;

        public DeleteTransactionForm(int transactionId)
        {
            InitializeComponent();
            this.transactionId = transactionId;
            lblMessage.Text = $"Are you sure you want to delete transaction ID: {transactionId}?";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM Transactions WHERE TransactionID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", transactionId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Transaction deleted successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Transaction not found or could not be deleted.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting transaction:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
