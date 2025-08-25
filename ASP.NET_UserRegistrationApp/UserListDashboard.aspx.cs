using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class UserListDashboard : System.Web.UI.Page
    {
        static DataSet dataset = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    getAllRecords();
                    rpUsers.DataSource = dataset.Tables["Users"];
                    rpUsers.DataBind();
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
            }
        }

        private void getAllRecords()
        {
            const string selectQuery = "Select name, email, age from Users";

            string connectionString = ConfigurationManager.ConnectionStrings["connConfig"].ConnectionString;

            using (var adapter = new SqlDataAdapter(selectQuery, connectionString))
            {
                dataset.Tables.Clear();
                adapter.Fill(dataset, "Users");
            }
        }
    }
}