using BillingSystem.Utils;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GetPasswordError(string pwd)
        {
            if (pwd.Length < 8)
                return "Password must be at least 8 characters long.";
            if (!pwd.Any(char.IsUpper))
                return "Password must contain at least one uppercase letter (A-Z).";
            if (!pwd.Any(char.IsLower))
                return "Password must contain at least one lowercase letter (a-z).";
            if (!pwd.Any(char.IsDigit))
                return "Password must contain at least one number (0-9).";
            if (!pwd.Any(ch => !char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch)))
                return "Password must contain at least one special character (e.g. !@#$%^&*).";
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string current = txtCurrent.Text;
            string newPwd = txtNew.Text;
            string retype = txtRetype.Text;

            // Gate 1: new vs retype match (local)
            if (newPwd != retype)
            {
                MessageBox.Show("New Password and Retype Password do not match.");
                return;
            }

            // Gate 2: complexity (local)
            string error = GetPasswordError(newPwd);
            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            // Gate 3 + Save: verify current password, then update (database)
            string connString = "server=localhost;user=root;password=admin;database=billingdb;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string checkSql = "SELECT Password FROM users WHERE UserID = @id";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", AppSession.CurrentUserID);
                        object result = checkCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Logged-in user could not be found.");
                            return;
                        }
                        if (result.ToString() != current)
                        {
                            MessageBox.Show("Current Password is incorrect.");
                            return;
                        }
                    }

                    string updateSql = "UPDATE users SET Password = @newPwd WHERE UserID = @id";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateSql, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@newPwd", newPwd);
                        updateCmd.Parameters.AddWithValue("@id", AppSession.CurrentUserID);
                        updateCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Password changed successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void chkShowCurrent_CheckedChanged(object sender, EventArgs e)
        {
            txtCurrent.UseSystemPasswordChar = !chkShowCurrent.Checked;
        }

        private void chkShowNew_CheckedChanged(object sender, EventArgs e)
        {
            txtNew.UseSystemPasswordChar = !chkShowNew.Checked;
        }

        private void chkShowRetype_CheckedChanged(object sender, EventArgs e)
        {
            txtRetype.UseSystemPasswordChar = !chkShowRetype.Checked;
        }
    }
}
