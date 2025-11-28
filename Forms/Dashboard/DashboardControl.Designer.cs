using System.Drawing;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Dashboard
{
    partial class DashboardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblWelcom = new System.Windows.Forms.Label();
            this.panelLowStocksCount = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLowStocksCount = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlTotalProductsCount = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotalProductsCount = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.chartLowStocks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTotalProducts = new System.Windows.Forms.Panel();
            this.chartProductsByCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlDailySales = new System.Windows.Forms.Panel();
            this.chartDailySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlDailySalesCount = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblpnlDailySalesCount = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnOpenSales = new System.Windows.Forms.Button();
            this.panelLowStocksCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlTotalProductsCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLowStocks)).BeginInit();
            this.pnlTotalProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductsByCategory)).BeginInit();
            this.pnlDailySales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDailySales)).BeginInit();
            this.pnlDailySalesCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcom
            // 
            this.lblWelcom.AutoSize = true;
            this.lblWelcom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcom.ForeColor = System.Drawing.Color.White;
            this.lblWelcom.Location = new System.Drawing.Point(15, 3);
            this.lblWelcom.Name = "lblWelcom";
            this.lblWelcom.Size = new System.Drawing.Size(295, 41);
            this.lblWelcom.TabIndex = 0;
            this.lblWelcom.Text = "Welcome Username";
            // 
            // panelLowStocksCount
            // 
            this.panelLowStocksCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.panelLowStocksCount.Controls.Add(this.label3);
            this.panelLowStocksCount.Controls.Add(this.lblLowStocksCount);
            this.panelLowStocksCount.Controls.Add(this.pictureBox3);
            this.panelLowStocksCount.Location = new System.Drawing.Point(708, 57);
            this.panelLowStocksCount.Name = "panelLowStocksCount";
            this.panelLowStocksCount.Size = new System.Drawing.Size(284, 98);
            this.panelLowStocksCount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(115, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Low Stocks";
            // 
            // lblLowStocksCount
            // 
            this.lblLowStocksCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLowStocksCount.ForeColor = System.Drawing.Color.Red;
            this.lblLowStocksCount.Location = new System.Drawing.Point(113, 11);
            this.lblLowStocksCount.Name = "lblLowStocksCount";
            this.lblLowStocksCount.Size = new System.Drawing.Size(100, 43);
            this.lblLowStocksCount.TabIndex = 1;
            this.lblLowStocksCount.Text = "99";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DSAFinalRequirement.Properties.Resources.Warning__2_;
            this.pictureBox3.Location = new System.Drawing.Point(42, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(18, 568);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(224, 53);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pnlTotalProductsCount
            // 
            this.pnlTotalProductsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.pnlTotalProductsCount.Controls.Add(this.label2);
            this.pnlTotalProductsCount.Controls.Add(this.pictureBox2);
            this.pnlTotalProductsCount.Controls.Add(this.lblTotalProductsCount);
            this.pnlTotalProductsCount.Location = new System.Drawing.Point(365, 57);
            this.pnlTotalProductsCount.Name = "pnlTotalProductsCount";
            this.pnlTotalProductsCount.Size = new System.Drawing.Size(337, 98);
            this.pnlTotalProductsCount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Products";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DSAFinalRequirement.Properties.Resources.TotalProducts;
            this.pictureBox2.Location = new System.Drawing.Point(42, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotalProductsCount
            // 
            this.lblTotalProductsCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductsCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductsCount.Location = new System.Drawing.Point(113, 11);
            this.lblTotalProductsCount.Name = "lblTotalProductsCount";
            this.lblTotalProductsCount.Size = new System.Drawing.Size(100, 43);
            this.lblTotalProductsCount.TabIndex = 1;
            this.lblTotalProductsCount.Text = "99";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.pnlLowStock.Controls.Add(this.chartLowStocks);
            this.pnlLowStock.Location = new System.Drawing.Point(708, 358);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(284, 263);
            this.pnlLowStock.TabIndex = 4;
            // 
            // chartLowStocks
            // 
            chartArea7.Name = "ChartArea1";
            this.chartLowStocks.ChartAreas.Add(chartArea7);
            this.chartLowStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.chartLowStocks.Legends.Add(legend7);
            this.chartLowStocks.Location = new System.Drawing.Point(0, 0);
            this.chartLowStocks.Name = "chartLowStocks";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartLowStocks.Series.Add(series7);
            this.chartLowStocks.Size = new System.Drawing.Size(284, 263);
            this.chartLowStocks.TabIndex = 0;
            this.chartLowStocks.Text = "chart1";
            // 
            // pnlTotalProducts
            // 
            this.pnlTotalProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.pnlTotalProducts.Controls.Add(this.chartProductsByCategory);
            this.pnlTotalProducts.Location = new System.Drawing.Point(708, 175);
            this.pnlTotalProducts.Name = "pnlTotalProducts";
            this.pnlTotalProducts.Size = new System.Drawing.Size(284, 177);
            this.pnlTotalProducts.TabIndex = 5;
            // 
            // chartProductsByCategory
            // 
            chartArea8.Name = "ChartArea1";
            this.chartProductsByCategory.ChartAreas.Add(chartArea8);
            this.chartProductsByCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.chartProductsByCategory.Legends.Add(legend8);
            this.chartProductsByCategory.Location = new System.Drawing.Point(0, 0);
            this.chartProductsByCategory.Name = "chartProductsByCategory";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartProductsByCategory.Series.Add(series8);
            this.chartProductsByCategory.Size = new System.Drawing.Size(284, 177);
            this.chartProductsByCategory.TabIndex = 0;
            this.chartProductsByCategory.Text = "chart1";
            // 
            // pnlDailySales
            // 
            this.pnlDailySales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.pnlDailySales.Controls.Add(this.chartDailySales);
            this.pnlDailySales.Location = new System.Drawing.Point(18, 175);
            this.pnlDailySales.Name = "pnlDailySales";
            this.pnlDailySales.Size = new System.Drawing.Size(684, 387);
            this.pnlDailySales.TabIndex = 6;
            // 
            // chartDailySales
            // 
            chartArea9.Name = "ChartArea1";
            this.chartDailySales.ChartAreas.Add(chartArea9);
            this.chartDailySales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.chartDailySales.Legends.Add(legend9);
            this.chartDailySales.Location = new System.Drawing.Point(0, 0);
            this.chartDailySales.Name = "chartDailySales";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartDailySales.Series.Add(series9);
            this.chartDailySales.Size = new System.Drawing.Size(684, 387);
            this.chartDailySales.TabIndex = 0;
            this.chartDailySales.Text = "chart1";
            // 
            // pnlDailySalesCount
            // 
            this.pnlDailySalesCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.pnlDailySalesCount.Controls.Add(this.label1);
            this.pnlDailySalesCount.Controls.Add(this.pictureBox1);
            this.pnlDailySalesCount.Controls.Add(this.lblpnlDailySalesCount);
            this.pnlDailySalesCount.Location = new System.Drawing.Point(18, 57);
            this.pnlDailySalesCount.Name = "pnlDailySalesCount";
            this.pnlDailySalesCount.Size = new System.Drawing.Size(341, 98);
            this.pnlDailySalesCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Daily sales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DSAFinalRequirement.Properties.Resources.DailySales;
            this.pictureBox1.Location = new System.Drawing.Point(42, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblpnlDailySalesCount
            // 
            this.lblpnlDailySalesCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblpnlDailySalesCount.ForeColor = System.Drawing.Color.White;
            this.lblpnlDailySalesCount.Location = new System.Drawing.Point(113, 11);
            this.lblpnlDailySalesCount.Name = "lblpnlDailySalesCount";
            this.lblpnlDailySalesCount.Size = new System.Drawing.Size(225, 43);
            this.lblpnlDailySalesCount.TabIndex = 1;
            this.lblpnlDailySalesCount.Text = "99";
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Location = new System.Drawing.Point(478, 568);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(224, 53);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Transactions";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnOpenSales
            // 
            this.btnOpenSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnOpenSales.FlatAppearance.BorderSize = 0;
            this.btnOpenSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOpenSales.ForeColor = System.Drawing.Color.Black;
            this.btnOpenSales.Location = new System.Drawing.Point(248, 568);
            this.btnOpenSales.Name = "btnOpenSales";
            this.btnOpenSales.Size = new System.Drawing.Size(224, 53);
            this.btnOpenSales.TabIndex = 8;
            this.btnOpenSales.Text = "New Sale";
            this.btnOpenSales.UseVisualStyleBackColor = false;
            this.btnOpenSales.Click += new System.EventHandler(this.btnOpenSales_Click_1);
            // 
            // DashboardControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.lblWelcom);
            this.Controls.Add(this.pnlDailySalesCount);
            this.Controls.Add(this.pnlTotalProductsCount);
            this.Controls.Add(this.panelLowStocksCount);
            this.Controls.Add(this.pnlLowStock);
            this.Controls.Add(this.pnlTotalProducts);
            this.Controls.Add(this.pnlDailySales);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnOpenSales);
            this.Controls.Add(this.btnReports);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1012, 632);
            this.panelLowStocksCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlTotalProductsCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLowStocks)).EndInit();
            this.pnlTotalProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProductsByCategory)).EndInit();
            this.pnlDailySales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDailySales)).EndInit();
            this.pnlDailySalesCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblWelcom;
        private System.Windows.Forms.Panel panelLowStocksCount;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblLowStocksCount;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel pnlTotalProductsCount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalProductsCount;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlTotalProducts;
        private System.Windows.Forms.Panel pnlDailySales;
        private System.Windows.Forms.Panel pnlDailySalesCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblpnlDailySalesCount;
        private Button btnReports;
        private Button btnOpenSales;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDailySales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductsByCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLowStocks;
    }
}
