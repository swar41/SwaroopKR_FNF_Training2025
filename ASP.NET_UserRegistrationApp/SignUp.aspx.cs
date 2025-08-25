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
    public partial class SignUp : System.Web.UI.Page
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
        const string addquery = "Insert into Users (name,password,email,age) values (@name,@password,@email,@age)";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connConfig"].ConnectionString);
            var command = new SqlCommand(addquery, connection);
            string hasedPassword = encryptedPassword(txtPassword.Text);
            try
            {
                connection.Open();


                string checkQuery = "select count(*) from Users WHERE email = @email";
                var checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("email", txtEmail.Text);

                int userCount = (int)checkCommand.ExecuteScalar();

                if (userCount > 0)
                {
                    lblError.Text = "Email Already Exists in the System..Please use different email or LogIn";
                    return;
                }

                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@password", hasedPassword);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@age", txtAge.Text);
                command.ExecuteNonQuery();
                connection.Close();
                lblError.Text = "User added Successfully..";
                Response.Redirect("HomePage.aspx");
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