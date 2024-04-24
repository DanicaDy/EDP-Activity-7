using System;
using System.IO;
using ClosedXML.Excel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using ClosedXML.Report.Excel;

namespace EDP_Act_4
{
    public partial class Reports : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=3306;Database=act_2_edp;Uid=root;Pwd=danica;";
        private string loggedInUserName; // Class-level variable to store logged-in username

        public Reports(string userName)
        {
            InitializeComponent();
            loggedInUserName = userName;

            // Call methods to load reports
            LoadInventoryReport();
            LoadSalesReport();
            LoadPurchaseReport();
        }

        // Method to load inventory report
        private void LoadInventoryReport()
        {
            string query = "SELECT * FROM products";
            try
            {
                LoadReportToPanel(query, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory report: " + ex.Message);
            }
        }

        // Method to load sales report
        private void LoadSalesReport()
        {
            string query = "SELECT o.id_orders, c.c_name AS customer_name, p.pname AS product_name, oi.quantity, oi.unit_price, o.orderDate " +
                           "FROM orders o " +
                           "JOIN order_items oi ON o.id_orders = oi.id_orders " +
                           "JOIN customers c ON o.id_customers = c.id_customers " +
                           "JOIN products p ON oi.id_product = p.id_product";
            try
            {
                LoadReportToPanel(query, dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales report: " + ex.Message);
            }
        }

        // Method to load purchase report
        private void LoadPurchaseReport()
        {
            string query = "SELECT o.id_orders, p.pname AS product_name, oi.quantity, oi.unit_price, o.orderDate " +
                           "FROM orders o " +
                           "JOIN order_items oi ON o.id_orders = oi.id_orders " +
                           "JOIN products p ON oi.id_product = p.id_product";
            try
            {
                LoadReportToPanel(query, dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading purchase report: " + ex.Message);
            }
        }

        // Method to load report data into DataGridView
        private void LoadReportToPanel(string query, DataGridView dataGridView)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report data: " + ex.Message);
            }
        }

        // Method to export DataGridView data to Excel
        // Method to export DataGridView data to Excel
        private void ExportToExcel(DataGridView dataGridView, string templatePath, string filename, string exportedBy)
        {
            try
            {
                using (var workbook = new XLWorkbook(templatePath))
                {
                    var worksheet = workbook.Worksheet(1);

                    // Write column headers (field names)
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(2, j + 1).Value = dataGridView.Columns[j].HeaderText;
                    }

                    int rowCount = dataGridView.RowCount;
                    int colCount = dataGridView.ColumnCount;

                    // Write data starting from row 3
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < colCount; j++)
                        {
                            worksheet.Cell(i + 3, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Include exported by information
                    worksheet.Cell(rowCount + 3, 1).Value = "Exported By:";
                    worksheet.Cell(rowCount + 3, 2).Value = exportedBy;

                 

                    workbook.SaveAs(filename);

                    MessageBox.Show("Export successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data to Excel: " + ex.Message);
            }
        }



        // Event handler for Inventory Report export button click
        private void intexport_Click(object sender, EventArgs e)
        {
            string templatePath = @"C:\Users\user\Desktop\Danica Files\EDP\Reports.xlsx";
            string folderPath = @"C:\Users\user\Desktop\Danica Files\EDP";

            string exportedBy = loggedInUserName; // Get the logged-in username

            ExportToExcel(dataGridView1, templatePath, Path.Combine(folderPath, "InventoryReport.xlsx"), exportedBy);
        }

        // Event handler for Sales Report export button click
        private void salesexport_Click(object sender, EventArgs e)
        {
            string templatePath = @"C:\Users\user\Desktop\Danica Files\EDP\Reports.xlsx";
            string folderPath = @"C:\Users\user\Desktop\Danica Files\EDP";

            string exportedBy = loggedInUserName; // Get the logged-in username

            ExportToExcel(dataGridView2, templatePath, Path.Combine(folderPath, "SalesReport.xlsx"), exportedBy);
        }

        // Event handler for Purchase Report export button click
        private void purchaseexport_Click(object sender, EventArgs e)
        {
            string templatePath = @"C:\Users\user\Desktop\Danica Files\EDP\Reports.xlsx";
            string folderPath = @"C:\Users\user\Desktop\Danica Files\EDP";

            string exportedBy = loggedInUserName; // Get the logged-in username

            ExportToExcel(dataGridView3, templatePath, Path.Combine(folderPath, "PurchaseReport.xlsx"), exportedBy);
        }

        // Event handler for about button click
        private void aboutbut_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.ShowDialog();
            this.Hide();
        }

        private void homebut_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard f = new Dashboard();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f = new Form6();
            f.ShowDialog();

        }

        private void logoutbut_Click(object sender, EventArgs e)
        {

            this.Close(); // Hide the current Dashboard form
            LogIn loginForm = new LogIn();
            loginForm.Show(); // Show the LogIn form again
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
