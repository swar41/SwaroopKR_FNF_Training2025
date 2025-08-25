using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class Login : System.Web.UI.Page
    {
        public static string encryptedPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var hashedPassword = encryptedPassword(txtPassword.Text);

            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connConfig"].ConnectionString);


            try
            {
                connection.Open();

                string loginQuery = "Select name from Users WHERE email = @email and password = @password";
                var cmd = new SqlCommand(loginQuery, connection);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", hashedPassword);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Response.Redirect("UserListDashboard.aspx");
                }
                else
                {
                    lblError.Text = "Invalid Email and/or Password..Please Try Again";
                }

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}