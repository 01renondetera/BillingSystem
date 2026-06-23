using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Billing_System
{
    public partial class frmBillingHistory : Form
    {
        private readonly int _customerId;
        private readonly string _connectionString =
            "server=localhost; uid=root; password=admin; database=billingdb";

        // The customer ID is passed in safely from the Customer List form
        public frmBillingHistory(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        private void frmBillingHistory_Load(object sender, EventArgs e)
        {
            LoadCustomerName();
            LoadBillingRecords();
        }

        // Req 3.4 — name comes from the DB, verified against customers table
        private void LoadCustomerName()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "SELECT FullName FROM customers WHERE CustomerID = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _customerId);
                        object result = cmd.ExecuteScalar();
                        string name = result != null ? result.ToString() : "Unknown Customer";
                        lblCustomerName.Text = "BILLING HISTORY — " + name;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer name: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Req 3.6 — parameterized, only this customer's records
        private void LoadBillingRecords()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            BillingMonth      AS `Billing Month`,
                            PreviousReading   AS `Previous Reading`,
                            PresentReading    AS `Present Reading`,
                            Consumption       AS `Consumption`,
                            RatePerCubic      AS `Rate Per Cubic`,
                            TotalAmount       AS `Total Amount`,
                            Status            AS `Status`
                        FROM billing
                        WHERE CustomerID = @customerId
                        ORDER BY BillingID ASC;";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@customerId", _customerId);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvBilling.DataSource = table;

                        // Req 3.5, Popup 2 — customer exists but has no bills
                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show(
                                "No billing records were found for this customer.",
                                "No Records Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading billing records: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}