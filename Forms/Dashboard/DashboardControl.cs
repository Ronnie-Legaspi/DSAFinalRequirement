using DSAFinalRequirement.Classes.Helpers;
using DSAFinalRequirement.Database.Connections;
using DSAFinalRequirement.Forms.Products;
using DSAFinalRequirement.Forms.Reports;
using DSAFinalRequirement.Forms.Sales;
using DSAFinalRequirement.Forms.Shared;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Management.Instrumentation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Dashboard
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            RoleType();

            // Load initial data
            RefreshDashboard();

            btnAddProduct.Click -= btnAddProduct_Click;
            btnAddProduct.Click += btnAddProduct_Click;

            btnOpenSales.Click -= btnOpenSales_Click;
            btnOpenSales.Click += btnOpenSales_Click;
        }
        private void RoleType()
        {
            btnAddProduct.Visible = RoleHelper.IsAdmin();
            btnReports.Visible = RoleHelper.IsAdmin();

            if (RoleHelper.IsStaff())
            {
                btnOpenSales.Location = new Point(18, 568);
                btnOpenSales.Size = new Size(684, 53);
            }
            
        }

        private void LoadUserSession()
        {
            lblWelcom.Text = $"Welcome {Session.Username}!";
        }

        private void LoadDailySales()
        {
            string currency = "₱ ";
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        SELECT SUM([TotalAmount]) AS DailySales
                        FROM [Transactions]
                        WHERE DateValue([DateOfSale]) = DateValue(?)
                    ";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", DateTime.Today);

                        object result = cmd.ExecuteScalar();
                        decimal totalSalesAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                        lblpnlDailySalesCount.Text = currency + totalSalesAmount.ToString("N2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading daily sales: " + ex.Message);
            }
        }

        private void LoadTotalProducts()
        {
            try
            {
                string query = "SELECT COUNT(*) AS TotalProducts FROM [Products]";

                using (OleDbCommand cmd = new OleDbCommand(query, DatabaseConnection.GetConnection()))
                {
                    object result = cmd.ExecuteScalar();
                    int totalProducts = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    lblTotalProductsCount.Text = totalProducts.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total products: " + ex.Message);
            }
        }

        private void LoadLowStockCount()
        {
            try
            {
                string query = "SELECT COUNT(*) AS LowStocksCount FROM [Products] WHERE [StockQuantity] <= 5";

                using (OleDbCommand cmd = new OleDbCommand(query, DatabaseConnection.GetConnection()))
                {
                    object result = cmd.ExecuteScalar();
                    int lowStockCount = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    lblLowStocksCount.Text = lowStockCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading low stocks count: " + ex.Message);
            }
        }

        // ------------------ CHARTS ------------------

        private void SetupDailySalesChart()
        {
            chartDailySales.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Today's Transactions")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String,
                YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double,
                IsValueShownAsLabel = true
            };
            chartDailySales.Series.Add(series);

            chartDailySales.ChartAreas[0].AxisX.Title = "Time";
            chartDailySales.ChartAreas[0].AxisY.Title = "Amount (₱)";
            chartDailySales.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chartDailySales.Titles.Clear();
            chartDailySales.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title
            {
                Text = "Daily Sales",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                Alignment = ContentAlignment.MiddleCenter
            });
        }

        private void LoadTodaysSalesChart()
        {
            var series = chartDailySales.Series["Today's Transactions"];
            series.Points.Clear();

            string query = @"
                SELECT [DateOfSale], [TotalAmount]
                FROM [Transactions]
                WHERE DateValue([DateOfSale]) = DateValue(?)
                ORDER BY [DateOfSale] ASC
            ";

            using (OleDbCommand cmd = new OleDbCommand(query, DatabaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("?", DateTime.Today);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime dateTime = Convert.ToDateTime(reader["DateOfSale"]);
                        decimal amount = reader["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(reader["TotalAmount"]) : 0;
                        series.Points.AddXY(dateTime.ToString("hh:mm tt"), amount);
                    }
                }
            }

            chartDailySales.Invalidate();
        }

        private void SetupProductsByCategoryChart()
        {
            chartProductsByCategory.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Products")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String,
                YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32,
                IsValueShownAsLabel = true
            };
            chartProductsByCategory.Series.Add(series);

            chartProductsByCategory.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            chartProductsByCategory.Legends[0].Alignment = StringAlignment.Center;

            chartProductsByCategory.Titles.Clear();
            chartProductsByCategory.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title
            {
                Text = "Total Products",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                Alignment = ContentAlignment.MiddleCenter
            });
        }

        private void LoadProductsByCategoryChart()
        {
            var series = chartProductsByCategory.Series["Products"];
            series.Points.Clear();

            string query = @"
                SELECT C.[CategoryName], COUNT(P.[CategoryID]) AS ProductCount
                FROM [Products] AS P
                INNER JOIN [Categories] AS C ON P.[CategoryID] = C.[CategoryID]
                GROUP BY C.[CategoryName]
                ORDER BY C.[CategoryName]
            ";

            using (OleDbCommand cmd = new OleDbCommand(query, DatabaseConnection.GetConnection()))
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string categoryName = reader["CategoryName"].ToString();
                        int count = reader["ProductCount"] != DBNull.Value ? Convert.ToInt32(reader["ProductCount"]) : 0;
                        series.Points.AddXY(categoryName, count);
                    }
                }
            }

            chartProductsByCategory.Invalidate();
        }

        private void SetupLowStocksChart()
        {
            chartLowStocks.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Low Stocks")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String,
                YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32,
                IsValueShownAsLabel = true
            };

            series.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series.MarkerSize = 10;
            series.Color = Color.Red;
            series.LabelForeColor = Color.Black;

            chartLowStocks.Series.Add(series);

            chartLowStocks.ChartAreas[0].AxisX.Title = "Product Name";
            chartLowStocks.ChartAreas[0].AxisY.Title = "Stock Quantity";
            chartLowStocks.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chartLowStocks.Titles.Clear();
            chartLowStocks.Titles.Add("Low Stock Products");
        }

        private void LoadLowStocksChart()
        {
            var series = chartLowStocks.Series["Low Stocks"];
            series.Points.Clear();

            string query = @"
                SELECT [ProductName], [StockQuantity]
                FROM [Products]
                WHERE [StockQuantity] <= 5
                ORDER BY [StockQuantity] ASC
            ";

            using (OleDbCommand cmd = new OleDbCommand(query, DatabaseConnection.GetConnection()))
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string productName = reader["ProductName"].ToString();
                        int stockQty = reader["StockQuantity"] != DBNull.Value ? Convert.ToInt32(reader["StockQuantity"]) : 0;

                        int pointIndex = series.Points.AddXY(productName, stockQty);

                        if (stockQty <= 2)
                        {
                            series.Points[pointIndex].MarkerColor = Color.DarkRed;
                            series.Points[pointIndex].MarkerSize = 14;
                        }
                    }
                }
            }

            chartLowStocks.Invalidate();
        }

        // ------------------ ADD PRODUCT ------------------

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           
                AddProductForm addForm = new AddProductForm();
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshDashboard(); // Refresh everything after adding product

                    var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                    if (dash != null)
                        dash.ShowStatus("Product Added Successfully!");
                }
                
            
            


        }

        // ------------------ REFRESH DASHBOARD ------------------



        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            MainDashboardForm main = this.FindForm() as MainDashboardForm;
            if (main == null) return;

            // Trigger the same navigation as clicking the Sales button
            main.TriggerNav(main.btnSales);
        }

        private async void btnReports_Click(object sender, EventArgs e)
        {
            MainDashboardForm main = this.FindForm() as MainDashboardForm;
            if (main == null) return;

            // Trigger the same navigation as clicking the Sales button
            main.TriggerNav(main.btnTransactions);
        }






        public void RefreshDashboard()
        {
            LoadTotalProducts();
            LoadDailySales();
            LoadLowStockCount();
            LoadUserSession();

            SetupDailySalesChart();
            LoadTodaysSalesChart();

            SetupProductsByCategoryChart();
            LoadProductsByCategoryChart();

            SetupLowStocksChart();
            LoadLowStocksChart();
        }

        private void btnOpenSales_Click_1(object sender, EventArgs e)
        {

        }
    }
}
